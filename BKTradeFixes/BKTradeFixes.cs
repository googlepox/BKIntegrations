using BKTradeFixes.Fixes;
using HarmonyLib;
using System.Reflection;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BKTradeFixes
{
    public class BKTradeFixes : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("BKCEKPatch");

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            harmony.PatchAll();
            MethodBase tradeFixes = AccessTools.Method(AccessTools.TypeByName("BKTradeGoodsFixesBehavior"), "OnProfitMade");
            harmony.Patch(tradeFixes, prefix: new HarmonyMethod(AccessTools.Method(typeof(BKTradeGoodFixesPatch), "TradeGoodFixesPrefix")));
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {

        }
    }
}