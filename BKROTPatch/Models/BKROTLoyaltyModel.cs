using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.Vanilla;
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
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTLoyaltyModel : BKLoyaltyModel
    {
        public override ExplainedNumber CalculateLoyaltyChange(Town town, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateLoyaltyChange(town, includeDescriptions);
            bool flag = town.OwnerClan != null;
            if (flag)
            {
                Hero leader = town.OwnerClan.Leader;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel == null)
                {
                    return result;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheFather, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.TheFather.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.OldGodsStone, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.OldGodsStone.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.LionOfNight, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.LionOfNight.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Trios, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.Trios.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Selloso, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.Selloso.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.SilentGod, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.SilentGod.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Boash, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.Boash.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodsBlood, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.GodsBlood.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Harpy, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.Harpy.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodOnEarth, rel))
                {
                    result.Add(0.5f, ROTDivinities.Instance.GodOnEarth.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.MerlingKing, rel) &&
                            ROTShippingLanes.Instance.Narrow.Ports.Contains(town.Settlement) ||
                            ROTShippingLanes.Instance.SunsetSouth.Ports.Contains(town.Settlement) ||
                            ROTShippingLanes.Instance.SunsetNorth.Ports.Contains(town.Settlement) ||
                            ROTShippingLanes.Instance.Northern.Ports.Contains(town.Settlement) ||
                            ROTShippingLanes.Instance.SlaversBay.Ports.Contains(town.Settlement))
                {
                    result.Add(0.5f, ROTDivinities.Instance.MerlingKing.Name, null);
                }
            }
            return result;
        }
    }
}
