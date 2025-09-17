using BannerKings;
using BannerKings.Managers.Court;
using BannerKings.Managers.Court.Members;
using BannerKings.Managers.Populations;
using BannerKings.Managers.Skills;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Settlements.Locations;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(CouncilData), "Update")]
    internal class CouncilDataUpdatePatch
    {
        public static bool Prefix(CouncilData __instance, PopulationData data)
        {
            var courtiers = __instance.GetCourtMembers();
            foreach (var pos in DefaultCouncilPositions.Instance.All)
            {
                if (pos.IsAdequate(__instance))
                {
                    if (!__instance.Positions.Any(x => x.StringId == pos.StringId))
                    {
                        __instance.Positions.Add(pos.GetCopy(__instance.Clan));
                    }
                }
                else if (__instance.Positions.Contains(pos))
                {
                    __instance.Positions.Remove(pos);
                }
            }

            if (__instance.Location != null && __instance.Location.OwnerClan != __instance.Clan)
            {
                __instance.SetCourtLocation(null, false);
            }

            if (__instance.Location != null && MBRandom.RandomFloat < 0.02f)
            {
                var template = __instance.Clan.Culture.NotableAndWandererTemplates.GetRandomElementWithPredicate(x => x.Occupation == Occupation.Wanderer);
                if (template != null && !template.Id.ToString().Contains("ROT_"))
                {
                    Hero guest = HeroCreator.CreateSpecialHero(template,
                    __instance.Location.Settlement,
                    null,
                    null,
                    TaleWorlds.CampaignSystem.Campaign.Current.Models.AgeModel.HeroComesOfAge + 5 + MBRandom.RandomInt(27));
                    EnterSettlementAction.ApplyForCharacterOnly(guest, __instance.Location.Settlement);
                    __instance.AddGuest(guest);
                }
            }

            List<Hero> toRemove = new List<Hero>();
            foreach (Hero guest in __instance.Guests)
            {
                if (guest.IsDead || guest.CurrentSettlement == null || guest.CurrentSettlement != __instance.Location?.Settlement)
                {
                    toRemove.Add(guest);
                }
                else if (MBRandom.RandomFloat < 0.14f && MBRandom.RandomFloat < 0.1f)
                {
                    toRemove.Add(guest);
                }
                else if (__instance.Guests.Count > 5)
                {
                    toRemove.Add(guest);
                }
            }

            foreach (Hero guest in toRemove)
            {
                __instance.RemoveGuest(guest);
            }

            foreach (var position in __instance.Positions)
            {
                position.SetIsRoyal(__instance.IsRoyal);
                position.Tick(courtiers);
            }

            if (MBRandom.RandomFloat <= 0.02f)
            {
                var education = BannerKingsConfig.Instance.EducationManager.GetHeroEducation(__instance.Owner);
                if (education.HasPerk(BKPerks.Instance.AugustDeFacto))
                {
                    var positions = __instance.GetOccupiedPositions();
                    if (positions.Count > 0)
                    {
                        var random = positions.GetRandomElement().Member;
                        ChangeRelationAction.ApplyRelationChangeBetweenHeroes(__instance.Owner, random, 1, false);
                        if (__instance.Owner == Hero.MainHero)
                        {
                            InformationManager.DisplayMessage(new InformationMessage(
                                new TextObject("{=rLgCZZDO}You improved relations with {HERO} due to {PERK} lifestyle perk.")
                                    .SetTextVariable("HERO", random.Name)
                                    .SetTextVariable("PERK", BKPerks.Instance.AugustDeFacto.Name)
                                    .ToString()));
                        }
                    }
                }
            }
            return false;
        }
    }
}
