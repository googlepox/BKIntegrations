using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace BKROTPatch.Models
{
    internal class BKROTDisguiseDetectionModel : DefaultDisguiseDetectionModel
    {
        public override float CalculateDisguiseDetectionProbability(Settlement settlement)
        {
            float baseChance = base.CalculateDisguiseDetectionProbability(settlement);
            Religion religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(Hero.MainHero);
            if (religion != null)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.YndrosOfTheTwilight, religion))
                {
                    baseChance -= 0.25f;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.Saagael, religion))
                {
                    baseChance -= 0.25f;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.HoodedWayfarer, religion))
                {
                    baseChance -= 0.25f;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.ManyFacedGod, religion))
                {
                    baseChance *= 0.1f;
                }
            }
            return baseChance;
        }
    }
}
