using BannerKings;
using BKEducationPatch.Books;
using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BKEducationPatch
{
    public class BKEducationPatch : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("BKEducationPatch");

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            harmony.PatchAll();
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            BannerKingsConfig.Instance.AddInitializer(DefaultBookTypesAddOn.Instance);
        }
    }
}
