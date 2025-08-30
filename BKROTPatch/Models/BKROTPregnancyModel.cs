using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.Vanilla;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Models
{
    internal class BKROTPregnancyModel : BKPregnancyModel
    {
        public override float GetDailyChanceOfPregnancyForHero(Hero hero)
        {
            float result = base.GetDailyChanceOfPregnancyForHero(hero);
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.TheMother, rel))
            {
                result *= 1.25f;
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.Pantera, rel))
            {
                result *= 1.25f;
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.GodsLove, rel))
            {
                result *= 1.25f;
            }
            return result;
        }
    }
}
