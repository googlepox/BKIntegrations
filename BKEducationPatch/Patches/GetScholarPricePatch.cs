using HarmonyLib;
using LT_Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKEducationPatch.Patches
{
    [HarmonyPatch(typeof(LT_EducationBehaviour), "GetScholarPrice")]
    internal class GetScholarPricePatch
    {
        public static void Postfix(LT_EducationBehaviour __instance, int __result)
        {
            __result = __result * 10;
        }
    }
}
