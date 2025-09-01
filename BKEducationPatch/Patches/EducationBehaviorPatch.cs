using HarmonyLib;
using LT_Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKEducationPatch.Patches
{
    [HarmonyPatch(typeof(LT_EducationBehaviour), "OnSessionLaunched")]
    internal class EducationBehaviorPatch
    {
        public static void Postfix(LT_EducationBehaviour __instance)
        {
            AccessTools.Field(typeof(LT_EducationBehaviour), "_readPrice").SetValue(__instance, 1000);
        }
    }
}
