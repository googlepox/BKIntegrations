using Biggerlord.Patches;
using HarmonyLib;
using System.Reflection;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace Biggerlord
{
    public class Biggerlord : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("Biggerlord");

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            MethodBase ccPatch = AccessTools.Method(AccessTools.TypeByName("BKCECreationContent"), "OnInitialized");
            harmony.Patch(ccPatch, postfix: new HarmonyMethod(AccessTools.Method(typeof(BKCECreationContentPatch), "BKCECreationContentPostfix")));
            MethodBase weatherPatch = AccessTools.Method(typeof(DefaultMapWeatherModel), "GetWeatherEventInPosition");
            harmony.Patch(weatherPatch, prefix: new HarmonyMethod(AccessTools.Method(typeof(GetWeatherEventInPositionPatch), "GetWeatherEventInPositionPrefix")));
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {

        }
    }
}
