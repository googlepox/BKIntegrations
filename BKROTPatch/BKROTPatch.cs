using BannerKings;
using BannerKings.Models.Vanilla;
using BKCEKPatch.Languages;
using BKROTPatch.Behaviors;
using BKROTPatch.Divinities;
using BKROTPatch.Eras;
using BKROTPatch.FaithGroups;
using BKROTPatch.Faiths;
using BKROTPatch.Models;
using BKROTPatch.Patches;
using BKROTPatch.Religions;
using BKROTPatch.ShippingLanes;
using BKROTPatch.Titles;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.ComponentInterfaces;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace BKROTPatch
{
    public class BKROTPatch : MBSubModuleBase
    {
        public static readonly Harmony harmony = new Harmony("BKROTPatch");

        public static readonly string path = BasePath.Name + "Modules/BKROTPatch/";
        public static readonly string fileName = "log.txt";

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            harmony.PatchAll();
            Type classType = AccessTools.TypeByName("ROTEnlistmentBehavior");
            harmony.Patch(classType.Method("OnSessionLaunched"), finalizer: new HarmonyMethod(typeof(OnSessionLaunchedPatch).GetMethod("Finalizer")));

            classType = AccessTools.TypeByName("ROTPartyWageModel");
            //harmony.Patch(classType.Method("GetCharacterWage"), prefix: new HarmonyMethod(typeof(GetCharacterWagePatch).GetMethod("Prefix")));
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            CampaignGameStarter campaignStarter = gameStarterObject as CampaignGameStarter;
            BannerKingsConfig.Instance.AddInitializer(ROTLanguages.Instance);
            BannerKingsConfig.Instance.AddInitializer(ROTDivinities.Instance);
            BannerKingsConfig.Instance.AddInitializer(ROTFaithGroups.Instance);
            BannerKingsConfig.Instance.AddInitializer(ROTFaiths.Instance);
            BannerKingsConfig.Instance.AddInitializer(ROTReligions.Instance);
            BannerKingsConfig.Instance.AddInitializer(ROTEras.Instance);
            BannerKingsConfig.Instance.AddInitializer(ROTShippingLanes.Instance);
            BannerKingsConfig.Instance.AddInitializer(ROTTitleNames.Instance);
            BannerKingsConfig.Instance.CultureModel = new BKROTCultureModel();
            BannerKingsConfig.Instance.ArmyManagementModel = new BKROTArmyModel();
            BannerKingsConfig.Instance.MarriageModel = new BKROTMarriageModel();
            BannerKingsConfig.Instance.DiplomacyModel = new BKROTDiplomacyModel();
            BannerKingsConfig.Instance.WorkshopModel = new BKROTWorkshopModel();
            BannerKingsConfig.Instance.InfluenceModel = new BKROTInfluenceModel();
            BannerKingsConfig.Instance.LegitimacyModel = new BKROTLegitimacyModel();
            BannerKingsConfig.Instance.ProsperityModel = new BKROTProsperityModel();
            BannerKingsConfig.Instance.RelationsModel = new BKROTRelationsModel();
            BannerKingsConfig.Instance.StabilityModel = new BKROTStabilityModel();
            BannerKingsConfig.Instance.VillageProductionModel = new BKROTVillageProductionModel();
            BannerKingsConfig.Instance.ClanFinanceModel = new BKROTClanFinanceModel();
            BannerKingsConfig.Instance.ConstructionModel = new BKROTConstructionModel();
            campaignStarter.AddModel(new BKROTAgentDamageModel());
            campaignStarter.AddModel(new BKROTBattleMoraleModel());
            campaignStarter.AddModel(new BKROTBattleRewardModel());
            campaignStarter.AddModel(new BKROTDeathModel());
            campaignStarter.AddModel(new BKROTDisguiseDetectionModel());
            campaignStarter.AddModel(new BKROTMapVisibilityModel());
            campaignStarter.AddModel(new BKROTPartyHealingModel());
            campaignStarter.AddModel(new BKROTPartyMoraleModel());
            campaignStarter.AddModel(new BKROTPartySpeedModel());
            campaignStarter.AddModel(new BKROTPartyWageModel());
            campaignStarter.AddModel(new BKROTPersuasionModel());
            campaignStarter.AddModel(new BKROTPregnancyModel());
            campaignStarter.AddModel(new BKROTPriceModel());
            campaignStarter.AddModel(new BKROTRaidModel());
            campaignStarter.AddBehavior(new BKROTBehavior());
        }
    }
}
