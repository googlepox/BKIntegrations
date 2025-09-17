using BannerKings;
using BannerKings.Behaviours;
using BannerKings.Managers.Titles.Governments;
using BannerKings.Settings;
using HarmonyLib;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(BKClanBehavior), "EvaluateRecruitKnight")]
    internal class EvaluateRecruitKnightPatch
    {
        public static bool Prefix(BKClanBehavior __instance, Clan clan, bool ignoreCosts)
        {
            if (!BannerKingsSettings.Instance.AIKnights)
            {
                return false;
            }

            if (clan.WarPartyComponents.Count >= clan.CommanderLimit || clan.Settlements.Count(x => x.IsVillage) <= 1)
            {
                return false;
            }

            if (!ignoreCosts && (clan.Influence < BannerKingsConfig.Instance.TitleModel.GetGrantKnighthoodCost(clan.Leader).ResultNumber))
            {
                return false;
            }

            var village = clan.Settlements.FirstOrDefault(x => x.IsVillage);
            if (village == null)
            {
                return false;
            }

            if (!ignoreCosts)
            {
                var council = BannerKingsConfig.Instance.CourtManager.GetCouncil(clan);
                if (council == null || council.Peerage == null || !council.Peerage.CanGrantKnighthood)
                {
                    return false;
                }
            }

            var clanTitles = BannerKingsConfig.Instance.TitleManager.GetAllDeJure(clan);
            var title = BannerKingsConfig.Instance.TitleManager.GetTitle(village);
            if (clanTitles.Count == 0 || title == null || !clanTitles.Contains(title) || title.deJure != clan.Leader)
            {
                return false;
            }

            CharacterObject template;
            var genderLaw = title.Contract.GenderLaw;
            if (genderLaw == DefaultGenderLaws.Instance.Agnatic)
            {
                template = (from e in clan.Culture.NotableAndWandererTemplates
                            where e.Occupation == Occupation.Wanderer && !e.IsFemale
                            select e).GetRandomElementInefficiently();
            }
            else if (genderLaw == DefaultGenderLaws.Instance.Enatic)
            {
                template = (from e in clan.Culture.NotableAndWandererTemplates
                            where e.Occupation == Occupation.Wanderer && e.IsFemale
                            select e).GetRandomElementInefficiently();
            }
            else
            {
                template = (from e in clan.Culture.NotableAndWandererTemplates
                            where e.Occupation == Occupation.Wanderer
                            select e).GetRandomElementInefficiently();
            }

            if (template == null || template.StringId.Contains("ROT_"))
            {
                return false;
            }

            var settlement = clan.Settlements.FirstOrDefault() ?? Town.AllTowns.FirstOrDefault(x => x.Culture == clan.Culture).Settlement;
            var source = from e in MBObjectManager.Instance.GetObjectTypeList<MBEquipmentRoster>() where e.EquipmentCulture == clan.Culture select e;
            if (source == null)
            {
                return false;
            }

            var roster = (from e in source
                          where e.HasEquipmentFlags(EquipmentFlags.IsMediumTemplate)
                          select e
                into x
                          orderby MBRandom.RandomInt()
                          select x).FirstOrDefault();
            if (roster == null)
            {
                return false;
            }
            MethodInfo getPrice = AccessTools.Method(typeof(BKClanBehavior), "GetPrice");

            float price = (float) getPrice.Invoke(__instance, new object[] { village.Village.Bound, roster });
            if (!ignoreCosts && clan.Leader.Gold < price * 2f)
            {
                return false;
            }

            var hero = HeroCreator.CreateSpecialHero(template, settlement, clan, null, TaleWorlds.CampaignSystem.Campaign.Current.Models.AgeModel.HeroComesOfAge + 5 + MBRandom.RandomInt(27));
            BannerKingsConfig.Instance.TitleManager.GrantKnighthood(title, hero, title.deJure, ignoreCosts);
            EquipmentHelper.AssignHeroEquipmentFromEquipment(hero, roster.AllEquipments.GetRandomElement());
            var mainParty = hero.PartyBelongedTo == MobileParty.MainParty;
            MobilePartyHelper.CreateNewClanMobileParty(hero, clan, out mainParty);
            var component = clan.WarPartyComponents.FirstOrDefault(x => x.Leader == hero);
            if (component != null)
            {
                EnterSettlementAction.ApplyForParty(component.MobileParty, settlement);
            }

            if (!ignoreCosts)
            {
                clan.Leader.ChangeHeroGold((int)-price);
            }

            return false;
        }
    }
}
