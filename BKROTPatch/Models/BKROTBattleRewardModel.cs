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
using TaleWorlds.CampaignSystem.Party;

namespace BKROTPatch.Models
{
    internal class BKROTBattleRewardModel : BKBattleRewardModel
    {
        public override ExplainedNumber CalculateRenownGain(PartyBase party, float renownValueOfBattle, float contributionShare)
        {
            ExplainedNumber result = base.CalculateRenownGain(party, renownValueOfBattle, contributionShare);
            Hero leader = party.LeaderHero;
            if (leader != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheWarrior, rel))
                {
                    result.AddFactor(0.6f, ROTDivinities.Instance.TheWarrior.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Bakkalon, rel))
                {
                    result.AddFactor(0.6f, ROTDivinities.Instance.Bakkalon.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.BeardedGod, rel))
                {
                    result.AddFactor(0.6f, ROTDivinities.Instance.BeardedGod.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.ManyFacedGod, rel))
                {
                    result.AddFactor(0.6f, ROTDivinities.Instance.ManyFacedGod.Name);
                }
            }
            return result;
        }

        public override ExplainedNumber CalculateInfluenceGain(PartyBase party, float influenceValueOfBattle, float contributionShare)
        {
            ExplainedNumber result = base.CalculateInfluenceGain(party, influenceValueOfBattle, contributionShare);
            Hero leader = party.LeaderHero;
            if (leader != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheWarrior, rel))
                {
                    result.AddFactor(0.3f, ROTDivinities.Instance.TheWarrior.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Bakkalon, rel))
                {
                    result.AddFactor(0.3f, ROTDivinities.Instance.Bakkalon.Name);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Josimakazma, rel))
                {
                    result.AddFactor(0.3f, ROTDivinities.Instance.Josimakazma.Name);
                }
            }
            return result;
        }
    }
}
