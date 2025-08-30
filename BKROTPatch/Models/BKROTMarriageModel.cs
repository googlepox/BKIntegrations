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
    internal class BKROTMarriageModel : BKMarriageModel
    {
        public override ExplainedNumber GetSpouseScore(Hero hero, bool explanations = false)
        {
            ExplainedNumber result = base.GetSpouseScore(hero, explanations);
            Religion religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
            bool flag = BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.YndrosOfTheTwilight, religion);
            if (flag)
            {
                result.AddFactor(0.2f, ROTDivinities.Instance.YndrosOfTheTwilight.Name);
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.Gelenei, religion))
            {
                result.AddFactor(0.2f, ROTDivinities.Instance.Gelenei.Name);
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.GodsLove, religion))
            {
                result.AddFactor(0.2f, ROTDivinities.Instance.GodsLove.Name);
            }
            return result;
        }
    }
}
