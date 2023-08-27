using BannerKings;
using BKWarlordPatch.Books;
using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BKWarlordPatch
{
    public class BKWarlordPatch : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("BKWarlordPatch");

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            harmony.PatchAll();
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            BannerKingsConfig.Instance.AddInitializer(DefaultBookTypesWarlord.Instance);
        }
    }
}
