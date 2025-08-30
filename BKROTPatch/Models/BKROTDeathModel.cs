using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;

namespace BKROTPatch.Models
{
    internal class BKROTDeathModel : DefaultHeroDeathProbabilityCalculationModel
    {
        public override float CalculateHeroDeathProbability(Hero hero)
        {
            float chance = base.CalculateHeroDeathProbability(hero);
            bool flag = !CampaignOptions.IsLifeDeathCycleDisabled;
            if (flag)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.TheMaiden, rel))
                {
                    chance *= 0.1f;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.TheStranger, rel))
                {
                    chance *= 0.05f;
                }
            }
            return chance;
        }
    }
}
