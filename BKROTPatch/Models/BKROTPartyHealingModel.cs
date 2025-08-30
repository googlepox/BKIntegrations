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
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTPartyHealingModel : BKPartyHealingModel
    {
        public override ExplainedNumber GetDailyHealingForRegulars(MobileParty party, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.GetDailyHealingForRegulars(party, includeDescriptions);
            Hero leader = party.LeaderHero;
            if (leader != null)
            {
                Religion religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheMother, religion))
                {
                    result.Add(0.8f, ROTDivinities.Instance.TheMother.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheMaiden, religion))
                {
                    result.Add(0.8f, ROTDivinities.Instance.TheMaiden.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.OldGodsStream, religion))
                {
                    result.Add(0.8f, ROTDivinities.Instance.OldGodsStream.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.WeepingLady, religion))
                {
                    result.Add(0.8f, ROTDivinities.Instance.WeepingLady.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Saagael, religion))
                {
                    result.Add(0.8f, ROTDivinities.Instance.Saagael.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.AquanTheRedBull, religion))
                {
                    result.Add(0.8f, ROTDivinities.Instance.AquanTheRedBull.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Josimakazma, religion))
                {
                    result.Add(0.8f, ROTDivinities.Instance.AquanTheRedBull.Name, null);
                }
            }
            return result;
        }

        public override float GetSurvivalChance(PartyBase party, CharacterObject character, DamageTypes damageType, bool canDamageKillEvenIfBlunt, PartyBase enemyParty = null)
        {
            float result = base.GetSurvivalChance(party, character, damageType, canDamageKillEvenIfBlunt, enemyParty);
            if (party != null && party.MobileParty != null)
            {
                Hero leader = party.MobileParty.LeaderHero;
                Religion religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheMaiden, religion))
                {
                    result += 0.03f;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.WeepingLady, religion))
                {
                    result += 0.03f;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Josimakazma, religion))
                {
                    result += 0.03f;
                }
            }
            return result;
        }
    }
}
