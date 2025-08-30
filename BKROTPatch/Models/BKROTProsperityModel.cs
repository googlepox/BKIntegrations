using BannerKings;
using BannerKings.Extensions;
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

namespace BKROTPatch.Models
{
    internal class BKROTProsperityModel : BKProsperityModel
    {
        public override ExplainedNumber CalculateHearthChange(Village village, bool includeDescriptions = false)
        {
            ExplainedNumber baseResult = base.CalculateHearthChange(village, includeDescriptions);
            Hero owner = village.GetActualOwner();
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(owner);
            if (rel != null)
            {
                bool flag5 = BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.Pantera, rel);
                if (flag5)
                {
                    baseResult.Add(0.12f, ROTDivinities.Instance.Pantera.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.BeardedGod, rel))
                {
                    baseResult.Add(0.12f, ROTDivinities.Instance.BeardedGod.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.Josimakazma, rel))
                {
                    baseResult.Add(0.12f, ROTDivinities.Instance.Josimakazma.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.MotherRhoyne, rel))
                {
                    baseResult.Add(0.12f, ROTDivinities.Instance.MotherRhoyne.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.GodsSummer, rel))
                {
                    baseResult.Add(0.12f, ROTDivinities.Instance.GodsSummer.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.GodOnEarth, rel))
                {
                    baseResult.Add(0.12f, ROTDivinities.Instance.GodOnEarth.Name, null);
                }

            }
            return baseResult;
        }

        public override ExplainedNumber CalculateProsperityChange(Town fortification, bool includeDescriptions = false)
        {
            ExplainedNumber baseResult = base.CalculateProsperityChange(fortification, includeDescriptions);
            Hero owner = fortification.OwnerClan.Leader;
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(owner);
            if (rel != null)
            {
                bool flag5 = BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.Pantera, rel);
                if (flag5)
                {
                    baseResult.Add(0.5f, ROTDivinities.Instance.Pantera.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.BeardedGod, rel))
                {
                    baseResult.Add(0.5f, ROTDivinities.Instance.BeardedGod.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.Josimakazma, rel))
                {
                    baseResult.Add(0.5f, ROTDivinities.Instance.Josimakazma.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.GodsSummer, rel))
                {
                    baseResult.Add(0.5f, ROTDivinities.Instance.GodsSummer.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.GodOnEarth, rel))
                {
                    baseResult.Add(0.5f, ROTDivinities.Instance.GodOnEarth.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.FatherOfWaters, rel))
                {
                    if (ROTShippingLanes.Instance.Narrow.Ports.Contains(fortification.Settlement) ||
                        ROTShippingLanes.Instance.SunsetSouth.Ports.Contains(fortification.Settlement) ||
                        ROTShippingLanes.Instance.SunsetNorth.Ports.Contains(fortification.Settlement) ||
                        ROTShippingLanes.Instance.Northern.Ports.Contains(fortification.Settlement) ||
                        ROTShippingLanes.Instance.SlaversBay.Ports.Contains(fortification.Settlement))
                    {
                        baseResult.Add(0.5f, ROTDivinities.Instance.FatherOfWaters.Name, null);
                    }
                }
            }
            return baseResult;
        }
    }
}
