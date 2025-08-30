using BannerKings;
using BannerKings.Behaviours;
using BannerKings.CampaignContent.Traits;
using BannerKings.Managers;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Doctrines;
using BannerKings.Managers.Titles;
using BKROTPatch.Divinities;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.Encounters;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace BKROTPatch.Behaviors
{
    internal class BKROTBehavior : BannerKingsBehavior
    {
        public override void RegisterEvents()
        {
            CampaignEvents.RaidCompletedEvent.AddNonSerializedListener(this, new Action<BattleSideEnum, RaidEventComponent>(this.OnRaidCompleted));
            CampaignEvents.HeroCreated.AddNonSerializedListener(this, new Action<Hero, bool>(this.OnHeroCreated));
            CampaignEvents.OnNewGameCreatedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnNewGameCreated));
            CampaignEvents.OnGameEarlyLoadedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnGameEarlyLoaded));
        }

        public override void SyncData(IDataStore dataStore)
        {
            
        }

        private void OnGameEarlyLoaded(CampaignGameStarter starter)
        {
            bool isNewVersion = false;
            foreach (Settlement settlement in Settlement.All)
            {
                if (settlement.StringId == "ROT_town31")
                {
                    isNewVersion = true;
                }
            }
            if (isNewVersion)
            {
                BannerKingsConfig.Instance.TitlesGeneratorPath = BasePath.Name + "Modules/BKROTPatch/ModuleData/titles_6_3.xml";
            }
            else
            {
                BannerKingsConfig.Instance.TitlesGeneratorPath = BasePath.Name + "Modules/BKROTPatch/ModuleData/titles_6_2.xml";
            }
            MethodBase methodBase = AccessTools.Method(typeof(TitleManager), "InitializeTitles");
            methodBase.Invoke(BannerKingsConfig.Instance.TitleManager, new object[] { });
        }

        private void OnNewGameCreated(CampaignGameStarter starter)
        {
            bool isNewVersion = false;
            foreach (Settlement settlement in Settlement.All)
            {
                if (settlement.StringId == "ROT_town31")
                {
                    isNewVersion = true;
                }
            }
            if (isNewVersion)
            {
                BannerKingsConfig.Instance.TitlesGeneratorPath = BasePath.Name + "Modules/BKROTPatch/ModuleData/titles_6_3.xml";
            }
            else
            {
                BannerKingsConfig.Instance.TitlesGeneratorPath = BasePath.Name + "Modules/BKROTPatch/ModuleData/titles_6_2.xml";
            }
            MethodBase methodBase = AccessTools.Method(typeof(TitleManager), "InitializeTitles");
            methodBase.Invoke(BannerKingsConfig.Instance.TitleManager, new object[] { });
        }

        private void OnRaidCompleted(BattleSideEnum winnerSide, RaidEventComponent mapEvent)
        {
            foreach (MapEventParty mapEventParty in mapEvent.AttackerSide.Parties)
            {
                bool isActive = mapEventParty.Party.IsActive;
                if (isActive)
                {
                    MobileParty mobileParty = mapEventParty.Party.MobileParty;
                    bool flag = mobileParty != null && mobileParty.LeaderHero != null;
                    if (flag)
                    {
                        Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(mobileParty.LeaderHero);
                        bool flag2 = rel == null;
                        if (!flag2)
                        {
                            CultureObject settlementCulture = mapEvent.MapEventSettlement.Culture;
                            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(mobileParty.LeaderHero, ROTDivinities.Instance.DrownedGod, rel) && 
                                !rel.FavoredCultures.Contains(settlementCulture))
                            {
                                GainRenownAction.Apply(mobileParty.LeaderHero, 10f, false);
                            }
                            if (rel.MainCulture != settlementCulture && rel.HasDoctrine(DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Reavers))
                            {
                                BannerKingsConfig.Instance.ReligionsManager.AddPiety(rel, mobileParty.LeaderHero, mapEvent.MapEventSettlement.Village.Hearth, true);
                            }
                            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(mobileParty.LeaderHero, ROTDivinities.Instance.Bakkalon, rel))
                            {
                                BannerKingsConfig.Instance.ReligionsManager.AddPiety(rel, mobileParty.LeaderHero, mapEvent.MapEventSettlement.Village.Hearth, true);
                            }
                            if (rel.MainCulture != settlementCulture && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(mobileParty.LeaderHero, ROTDivinities.Instance.GreatStallion, rel))
                            {
                                BannerKingsConfig.Instance.ReligionsManager.AddPiety(rel, mobileParty.LeaderHero, mapEvent.MapEventSettlement.Village.Hearth, true);
                            }
                        }
                    }
                }
            }
        }

        private void OnHeroCreated(Hero hero, bool bornNaturally)
        {
            if (hero != null && bornNaturally)
            {
                if (hero.Father != null)
                {
                    bool hasBlessing = BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero.Father, DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.MotherRhoyne, null) ||
                        BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero.Father, DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheMother, null) ||
                        BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero.Father, DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Pantera, null);
                    if (hasBlessing)
                    {
                        BannerKingsConfig.Instance.ReligionsManager.AddPiety(hero.Father, 150f, true);
                    }
                }
                if (hero.Mother != null)
                {
                    bool hasBlessing = BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero.Mother, DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.MotherRhoyne, null) ||
                        BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero.Mother, DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheMother, null) ||
                        BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero.Mother, DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Pantera, null);
                    if (hasBlessing)
                    {
                        BannerKingsConfig.Instance.ReligionsManager.AddPiety(hero.Mother, 150f, true);
                    }
                }
            }
        }
    }
}
