using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Populations.Villages;
using BannerKings.Managers.Skills;
using BannerKings.Models.Vanilla;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTRaidModel : BKRaidModel
    {
        public override float CalculateHitDamage(MapEventSide attackerSide, float settlementHitPoints)
        {
            float result = base.CalculateHitDamage(attackerSide, settlementHitPoints);
            PartyBase attacker = attackerSide.LeaderParty;
            if (attacker != null && attacker.LeaderHero != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(attacker.LeaderHero);
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(attacker.LeaderHero, ROTDivinities.Instance.GodsFire))
                {
                    result *= 1.15f;
                }
            }
            return result;
        }
    }
}
