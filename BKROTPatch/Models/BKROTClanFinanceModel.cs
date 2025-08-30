using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.Vanilla;
using BannerKings.Settings;
using BKROTPatch.Divinities;
using MCM.Abstractions.Base.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Library;

namespace BKROTPatch.Models
{
    internal class BKROTClanFinanceModel : BKClanFinanceModel
    {
        public override int CalculateOwnerIncomeFromCaravan(MobileParty caravan)
        {
            int income = base.CalculateOwnerIncomeFromCaravan(caravan);
            if (caravan.Owner != null)
            {
                Religion religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(caravan.Owner);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(caravan.Owner, ROTDivinities.Instance.OldGodsStream, religion))
                {
                    return (int)(income * 1.2);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(caravan.Owner, ROTDivinities.Instance.MoonPaleMaiden, religion))
                {
                    return (int)(income * 1.2);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(caravan.Owner, ROTDivinities.Instance.Semosh, religion))
                {
                    return (int)(income * 1.2);
                }
            }
            return income;
        }
    }
}
