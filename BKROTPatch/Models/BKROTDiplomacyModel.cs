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
using TaleWorlds.CampaignSystem.Settlements;

namespace BKROTPatch.Models
{
    internal class BKROTDiplomacyModel : BKDiplomacyModel
    {
        public override ExplainedNumber CalculateHeroFiefScore(Settlement settlement, Hero annexing, bool explanations = false)
        {
            ExplainedNumber result = base.CalculateHeroFiefScore(settlement, annexing, explanations);
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(annexing);
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(annexing, ROTDivinities.Instance.TheStranger, rel))
            {
                result.AddFactor(0.2f, ROTDivinities.Instance.TheStranger.Name);
            }
            return result;
        }
    }
}
