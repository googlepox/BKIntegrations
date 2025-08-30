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
using TaleWorlds.CampaignSystem.Settlements;

namespace BKROTPatch.Models
{
    internal class BKROTConstructionModel : BKConstructionModel
    {
        public override int CalculateDailyConstructionPowerWithoutBoost(Town town)
        {
            int result = base.CalculateDailyConstructionPowerWithoutBoost(town);
            Hero owner = town.OwnerClan.Leader;
            if (owner != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(owner);
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.Boash))
                {
                    result *= (int)(1.15f);
                }
            }
            return result;
        }
    }
}
