using BannerKings;
using BKEducationPatch.Behaviors;
using BKEducationPatch.Books;
using HarmonyLib;
using LT_Education;
using TaleWorlds.CampaignSystem;
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
            base.OnCampaignStart(game, gameStarterObject);
            CampaignGameStarter campaignGameStarter = (CampaignGameStarter)gameStarterObject;
            campaignGameStarter.AddBehavior(new EducationCampaignBehaviorAddon());
            BannerKingsConfig.Instance.AddInitializer(DefaultBookTypesAddOn.Instance);
        }
    }
}
