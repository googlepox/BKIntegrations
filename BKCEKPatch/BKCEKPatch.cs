using BannerKings;
using BKCEKPatch.Languages;
using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BKCEKPatch
{
    public class BKCEKPatch : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("BKCEKPatch");

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            harmony.PatchAll();
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            BannerKingsConfig.Instance.AddInitializer(DefaultLanguageTypesAddOn.Instance);
        }
    }
}
