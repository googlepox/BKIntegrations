using BannerKings.Behaviours;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(BKClanBehavior), "GetAdequateTemplate")]
    internal class GetAdequateTemplatePatch
    {
        public static bool Prefix(BKClanBehavior __instance, ref CharacterObject  __result, List<SkillObject> traits, CultureObject culture)
        {
            CharacterObject template = null;
            foreach (var skill in traits)
            {
                if (template != null) break;
                template = (from x in culture.NotableAndWandererTemplates
                            where x.Occupation == Occupation.Wanderer && x.GetSkillValue(skill) >= 50
                            select x).GetRandomElementInefficiently();
            }

            if (template != null && template.StringId.Contains("ROT_"))
            {
                __result = null;
            }
            else
            {
                __result = template;
            }

            return false;
        }
    }
}
