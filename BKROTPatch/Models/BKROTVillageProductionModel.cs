using BannerKings;
using BannerKings.CampaignContent;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Items;
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
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTVillageProductionModel : BKVillageProductionModel
    {
        public override float CalculateDailyProductionAmount(Village village, ItemObject item)
        {
            float result = base.CalculateDailyProductionAmount(village, item);
            Hero owner = village.Settlement.OwnerClan.Leader;
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(owner);
            ItemCategory category = item.ItemCategory;
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.TheSmith, rel))
            {
                result *= 1.25f;
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.GodsSummer, rel))
            {
                result *= 1.25f;
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.OldGodsForest, rel) &&
                village.VillageType == DefaultVillageTypes.Lumberjack)
            {
                result *= 1.50f;
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(owner, ROTDivinities.Instance.MerlingKing, rel) &&
                village.VillageType == DefaultVillageTypes.Fisherman)
            {
                result *= 1.50f;
            }
            return result;
        }
    }
}
