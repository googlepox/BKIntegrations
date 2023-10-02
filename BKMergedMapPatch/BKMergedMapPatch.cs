using BannerKings;
using BKMergedMapPatch.Languages;
using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BKMergedMapPatch
{
    public class BKMergedMapPatch : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("BKMergedMapPatch");

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            harmony.PatchAll();
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            BannerKingsConfig.Instance.AddInitializer(DefaultLanguagesMMAddon.Instance);
        }
    }
}
