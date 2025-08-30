using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Populations;
using BannerKings.Models.BKModels;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.Settlements;

namespace BKROTPatch.Models
{
    internal class BKROTCultureModel : BKCultureModel
    {
        public override ExplainedNumber CalculateAcceptanceGain(CultureDataClass data)
        {
            ExplainedNumber result = base.CalculateAcceptanceGain(data);
            Settlement settlement = data.Settlement;
            bool flag = settlement != null && settlement.OwnerClan != null;
            if (flag)
            {
                Hero leader = settlement.OwnerClan.Leader;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Trios, null))
                {
                    result.Add(0.04f, ROTDivinities.Instance.Trios.Name, null);
                }
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodsBlood, null))
                {
                    result.Add(0.04f, ROTDivinities.Instance.GodsBlood.Name, null);
                }
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Harpy, null))
                {
                    result.Add(0.08f, ROTDivinities.Instance.Harpy.Name, null);
                }
            }
            return result;
        }

        public override ExplainedNumber CalculateCultureWeight(Settlement settlement, CultureDataClass data, float baseWeight = 0f)
        {
            ExplainedNumber result = base.CalculateCultureWeight(settlement, data, baseWeight);
            bool flag = settlement != null && settlement.OwnerClan != null;
            if (flag)
            {
                Hero leader = settlement.OwnerClan.Leader;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Trios, null))
                {
                    result.Add(25f, ROTDivinities.Instance.Trios.Name, null);
                }
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodsBlood, null))
                {
                    result.Add(25f, ROTDivinities.Instance.GodsBlood.Name, null);
                }
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Harpy, null))
                {
                    result.Add(50f, ROTDivinities.Instance.Harpy.Name, null);
                }
            }
            return result;
        }
    }
}
