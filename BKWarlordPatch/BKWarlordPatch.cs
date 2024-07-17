using BannerKings;
using BKWarlordPatch.Behaviors;
using BKWarlordPatch.Books;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
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
            base.OnCampaignStart(game, gameStarterObject);
            CampaignGameStarter campaignGameStarter = (CampaignGameStarter)gameStarterObject;
            campaignGameStarter.AddBehavior(new WarlordCampaignBehaviorAddon());
            BannerKingsConfig.Instance.AddInitializer(DefaultBookTypesWarlord.Instance);
        }
    }
}
