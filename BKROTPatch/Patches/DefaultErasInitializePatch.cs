using BannerKings.Managers.Innovations.Eras;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Localization;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(DefaultEras), "Initialize")]
    internal class DefaultErasInitializePatch
    {
        public static bool Prefix(DefaultEras __instance)
        {
            __instance.FirstEra.Initialize(new TextObject("Bronze Age", null), new TextObject("The Bronze Age", null), null);
            __instance.SecondEra.Initialize(new TextObject("Iron Age", null), new TextObject("The Iron Age", null), __instance.FirstEra);
            __instance.ThirdEra.Initialize(new TextObject("Steel Age", null), new TextObject("The Steel Age", null), __instance.SecondEra);
            return false;
        }
    }
}
