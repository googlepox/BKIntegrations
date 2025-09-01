using BannerKings.Managers.Cultures;
using BannerKings.Managers.Titles;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(DefaultTitleNames), "GetTitleName")]
    internal class DefaultTitleNamesPatch
    {
        public static bool Prefix(DefaultTitleNames __instance, CultureObject culture, TitleType titleType)
        {
            if (culture != null)
            {
                return true;
            }
            return false;
        }
    }
}
