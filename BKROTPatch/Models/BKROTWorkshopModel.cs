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
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.Settlements.Workshops;
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTWorkshopModel : BKWorkshopModel
    {
        public override ExplainedNumber GetProductionQuality(Workshop workshop, bool explanations = false)
        {
            ExplainedNumber result = base.GetProductionQuality(workshop, explanations);
            Hero owner = workshop.Owner;
            if (owner != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(owner);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.TheSmith, rel))
                {
                    result.Add(2f, ROTDivinities.Instance.TheSmith.Name, null);
                }
            }
            return result;
        }
    }
}
