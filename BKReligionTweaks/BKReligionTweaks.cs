using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BKReligionTweaks
{
    public class BKReligionTweaks : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("BKCEKPatch");

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            harmony.PatchAll();
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {

        }
    }
}