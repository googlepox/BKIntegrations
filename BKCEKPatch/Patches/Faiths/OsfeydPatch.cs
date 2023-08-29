using BannerKings.Managers.Institutions.Religions.Faiths.Vlandia;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths {
    [HarmonyPatch(typeof(Osfeyd), "IsCultureNaturalFaith")]
    internal class OsfeydPatch {
        public static void Postfix(ref bool __result, CultureObject culture) {
            if (culture.StringId == "rhodok" || culture.StringId == "vlandia") {
                __result = true;
            } else {
                __result = false;
            }
        }
    }
}
