using BannerKings.Managers.Innovations;
using BannerKings.Managers.Innovations.Eras;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(DefaultInnovations), "GetCultureDefaultInnovations")]
    internal class GetCultureDefaultInnovationsPatch
    {
        public static void Postfix(ref DefaultEras __instance, ref List<Innovation> __result, CultureObject culture)
        {
            if (Helpers.CultureHelpers.IsCultureWesterosi(culture))
            {
                __result = new List<Innovation> { DefaultInnovations.Instance.Burgage, DefaultInnovations.Instance.HeavyPlough, DefaultInnovations.Instance.HorseCollar, DefaultInnovations.Instance.Crossbows, DefaultInnovations.Instance.Mills };
            }
            else if (Helpers.CultureHelpers.IsCultureNorthmen(culture))
            {
                __result = new List<Innovation> { DefaultInnovations.Instance.HeavyPlough, DefaultInnovations.Instance.Wheelbarrow, DefaultInnovations.Instance.ThreeFieldsSystem };
            }
            else if (Helpers.CultureHelpers.IsCultureEssosi(culture))
            {
                __result = new List<Innovation> { DefaultInnovations.Instance.HeavyPlough, DefaultInnovations.Instance.HorseCollar, DefaultInnovations.Instance.Guilds, DefaultInnovations.Instance.Manorialism, DefaultInnovations.Instance.Crossbows, DefaultInnovations.Instance.Stirrups, DefaultInnovations.Instance.Mills, DefaultInnovations.Instance.Theater, DefaultInnovations.Instance.Forum, DefaultInnovations.Instance.Aqueducts };
            }
            else
            {
                __result = new List<Innovation>();
            }
        }
    }
}
