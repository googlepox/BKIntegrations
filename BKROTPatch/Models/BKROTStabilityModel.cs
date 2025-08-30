using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.BKModels;
using BKROTPatch.Divinities;
using BKROTPatch.ShippingLanes;
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
    internal class BKROTStabilityModel : BKStabilityModel
    {
        public override ExplainedNumber CalculateStabilityTarget(Settlement settlement, bool descriptions = false)
        {
            ExplainedNumber result = base.CalculateStabilityTarget(settlement, descriptions);
            bool flag = settlement.OwnerClan != null;
            if (flag)
            {
                Hero leader = settlement.OwnerClan.Leader;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null && leader != null)
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.OldGodsStone, rel))
                    {
                        result.Add(0.1f, ROTDivinities.Instance.OldGodsStone.Name, null);
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.FatherOfWaters, rel) &&
                            ROTShippingLanes.Instance.Narrow.Ports.Contains(settlement) ||
                            ROTShippingLanes.Instance.SunsetSouth.Ports.Contains(settlement) ||
                            ROTShippingLanes.Instance.SunsetNorth.Ports.Contains(settlement) ||
                            ROTShippingLanes.Instance.Northern.Ports.Contains(settlement) ||
                            ROTShippingLanes.Instance.SlaversBay.Ports.Contains(settlement))
                    {
                        result.Add(0.1f, ROTDivinities.Instance.FatherOfWaters.Name, null);
                    }
                }
            }
            return result;
        }
    }
}
