using BannerKings.Managers.Shipping;
using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BKCEKPatch.Patches.ShippingLanes
{
    [HarmonyPatch(typeof(ShippingLane), nameof(ShippingLane.Initialize))]
    internal class ShippingLanePatch
    {
        public static void Postfix(ShippingLane __instance,
          TextObject name,
          TextObject description,
          List<Settlement> ports,
          bool isRiver = false,
          CultureObject culture = null)
        {
            List<Settlement> newSettlements;
            if (__instance == DefaultShippingLanes.Instance.Laconis)
            {
                newSettlements = new List<Settlement>()
                {
                    Settlement.All.First<Settlement>((x => x.StringId == "town_S4")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_EN2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_EN4_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_S3_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_EN4")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_EN2_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_S3_3")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_EN2_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_S7_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_S9")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_EN6"))
                };
            }
            else if (__instance == DefaultShippingLanes.Instance.Western)
            {
                newSettlements = new List<Settlement>()
                {
                    Settlement.All.First<Settlement>((x => x.StringId == "town_V7")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_V8")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_V11")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_V6_6")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_V5_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_V7_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_V1_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A10")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_A10_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_A1_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_V4"))
                };
            }
            else if (__instance == DefaultShippingLanes.Instance.Junme)
            {
                newSettlements = new List<Settlement>()
                {
                    Settlement.All.First<Settlement>((x => x.StringId == "town_S2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_V8")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_V4")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_V4_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_B6")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_S3_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_S7_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_S3_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_S1_3")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_S9")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_S7")),
                };
            }
            else if (__instance == DefaultShippingLanes.Instance.Perassic)
            {
                newSettlements = new List<Settlement>()
                {
                    Settlement.All.First<Settlement>((x => x.StringId == "town_ES2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A4")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A8")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_EW2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_B6")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_EW4")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A6")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A10")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_A1_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_A6_3")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A7")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_A11")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_A8_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_A3_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_A4_4")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_A12_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_ES4_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_TT1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_TT1_1")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_TT1_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_TT1_3")),
                    Settlement.All.First<Settlement>((x => x.StringId == "castle_village_EW3_2")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_EW4_3")),
                    Settlement.All.First<Settlement>((x => x.StringId == "village_TT1_3")),
                    Settlement.All.First<Settlement>((x => x.StringId == "town_ES1")),
                };
            }
            else
            {
                newSettlements = new List<Settlement>();
            }
            AccessTools.Property(typeof(ShippingLane), "Ports").SetValue(__instance, newSettlements);
        }
    }
}
