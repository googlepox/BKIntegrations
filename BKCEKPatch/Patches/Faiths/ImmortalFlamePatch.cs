using TaleWorlds.CampaignSystem;

namespace BKCEKPatch.Patches.Faiths
{
    //[HarmonyPatch(typeof(ImmortalFlame), "IsCultureNaturalFaith")]
    internal class ImmortalFlamePatch
    {
        public static void Postfix(ref bool __result, CultureObject culture)
        {
            if (culture.StringId == "ariorum" || culture.StringId == "republic" || culture.StringId == "empire")
            {
                __result = true;
            }
            else
            {
                __result = false;
            }
        }
    }
}
