using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.Vanilla;
using BannerKings.Settings;
using BKROTPatch.Divinities;
using Helpers;
using MCM.Abstractions.Base.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.ComponentInterfaces;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Models
{
    internal class BKROTPartySpeedModel : BKPartySpeedModel
    {
        public override ExplainedNumber CalculateFinalSpeed(MobileParty mobileParty, ExplainedNumber finalSpeed)
        {
            ExplainedNumber explainedNumber;
            ExplainedNumber speed = base.CalculateFinalSpeed(mobileParty, finalSpeed);
            Hero leader = mobileParty.LeaderHero;
            if (leader != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheCrone, rel))
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.TheCrone.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Pattern, rel))
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.Pattern.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GreatStallion, rel))
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.GreatStallion.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.OldGodsForest, rel) && 
                    Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Forest)
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.OldGodsForest.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.OldGodsStream, rel) &&
                    Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.River)
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.OldGodsStream.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.OldGodsStone, rel) &&
                    Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Mountain)
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.OldGodsStone.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.DrownedGod, rel) &&
                    Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Swamp)
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.DrownedGod.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.MoonPaleMaiden, rel) &&
                    Campaign.Current.MapSceneWrapper.GetFaceTerrainType(mobileParty.CurrentNavigationFace) == TerrainType.Swamp)
                {
                    speed.AddFactor(0.15f, ROTDivinities.Instance.MoonPaleMaiden.Name);
                }
            }
            explainedNumber = speed;
            return explainedNumber;
        }
    }
}
