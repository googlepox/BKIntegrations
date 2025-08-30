using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.Vanilla;
using BKROTPatch.Divinities;
using BKROTPatch.Religions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Models
{
    internal class BKROTPartyMoraleModel : BKPartyMoraleModel
    {
        public override ExplainedNumber GetEffectivePartyMorale(MobileParty mobileParty, bool includeDescription = false)
        {
            ExplainedNumber result = base.GetEffectivePartyMorale(mobileParty, includeDescription);

            if (mobileParty.LeaderHero != null)
            {
                Hero leader = mobileParty.LeaderHero;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheFather, rel))
                {
                    result.Add(8f, ROTDivinities.Instance.TheFather.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheWarrior, rel))
                {
                    result.Add(15f, ROTDivinities.Instance.TheWarrior.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.AquanTheRedBull, rel))
                {
                    result.Add(15f, ROTDivinities.Instance.AquanTheRedBull.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodsPassion, rel))
                {
                    result.Add(15f, ROTDivinities.Instance.GodsPassion.Name);
                }
                if (mobileParty.IsEngaging && (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheStranger, rel) && (mobileParty.MemberRoster.Count < mobileParty.TargetParty.MemberRoster.Count)))
                {
                    result.Add(15f, ROTDivinities.Instance.TheStranger.Name);
                }
                if (mobileParty.IsEngaging && (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.DrunkenGod, rel) && (mobileParty.MemberRoster.Count < mobileParty.TargetParty.MemberRoster.Count)))
                {
                    result.Add(15f, ROTDivinities.Instance.DrunkenGod.Name);
                }
                if (mobileParty.IsEngaging && (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodsFire, rel)))
                {
                    result.Add(30f, ROTDivinities.Instance.GodsFire.Name);
                }
                if (mobileParty.IsEngaging && (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.DrunkenGod, rel)))
                {
                    ItemRoster itemRoster = mobileParty.ItemRoster;
                    for (int index = 0; index < itemRoster.Count; index++)
                    {
                        if (itemRoster.GetItemAtIndex(index).ItemCategory.StringId == "bf_mead" ||
                            itemRoster.GetItemAtIndex(index).ItemCategory.StringId == "mead" ||
                            itemRoster.GetItemAtIndex(index).ItemCategory.StringId == "beer" ||
                            itemRoster.GetItemAtIndex(index).ItemCategory.StringId == "wine")
                        {
                            result.Add(3f * itemRoster.GetElementNumber(index), ROTDivinities.Instance.DrunkenGod.Name);
                        }

                    }
                    
                }
                if (mobileParty.IsEngaging && mobileParty.TargetParty != null && mobileParty.TargetParty.LeaderHero != null && 
                    (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Rhllor, rel) && 
                    !BannerKingsConfig.Instance.ReligionsManager.IsReligionMember(mobileParty.TargetParty.LeaderHero, 
                    ROTReligions.Instance.Rhllor)))
                {
                    result.Add(15f, ROTDivinities.Instance.Rhllor.Name);
                }
                TerrainType terrain = Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace);
                if (terrain == TerrainType.Swamp && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.MerlingKing, rel))
                {
                    result.Add(10f, ROTDivinities.Instance.MerlingKing.Name, null);
                }
                if (terrain == TerrainType.Forest && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.OldGodsForest, rel))
                {
                    result.Add(10f, ROTDivinities.Instance.OldGodsForest.Name, null);
                }
                if ((terrain == TerrainType.Swamp || terrain == TerrainType.River || terrain == TerrainType.Water) && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.MoonPaleMaiden, rel))
                {
                    result.Add(10f, ROTDivinities.Instance.MoonPaleMaiden.Name, null);
                }
                if ((terrain == TerrainType.Swamp || terrain == TerrainType.River || terrain == TerrainType.Water) && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.MerlingKing, rel))
                {
                    result.Add(10f, ROTDivinities.Instance.MerlingKing.Name, null);
                }
            }

            return result;
        }

        public override int GetDailyStarvationMoralePenalty(PartyBase party)
        {
            int basePenalty = base.GetDailyStarvationMoralePenalty(party);
            if (party.LeaderHero != null)
            {
                Hero leader = party.LeaderHero;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null)
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Saagael, rel))
                    {
                        basePenalty += 2;
                    }
                }
            }
            return basePenalty;
        }
    }
}
