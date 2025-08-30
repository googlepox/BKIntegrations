using BannerKings;
using BannerKings.Managers.Education;
using BannerKings.Managers.Institutions.Religions;
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
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTMapVisibilityModel : BKMapVisibilityModel
    {
        public override ExplainedNumber GetPartySpottingRange(MobileParty party, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.GetPartySpottingRange(party, includeDescriptions);
            if (party.LeaderHero != null)
            {
                Hero leader = party.LeaderHero;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Pattern))
                {
                    result.AddFactor(0.5f, ROTDivinities.Instance.Pattern.Name);
                }
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.HoodedWayfarer))
                {
                    result.AddFactor(0.5f, ROTDivinities.Instance.HoodedWayfarer.Name);
                }
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.MaidenMadeOfLight))
                {
                    result.AddFactor(0.5f, ROTDivinities.Instance.MaidenMadeOfLight.Name);
                }
            }
            return result;
        }

        public override float GetPartySpottingDifficulty(MobileParty spottingParty, MobileParty party)
        {
            float result = base.GetPartySpottingDifficulty(spottingParty, party);
            if (party != null && party.LeaderHero != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(party.LeaderHero);
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(party.LeaderHero, ROTDivinities.Instance.HoodedWayfarer))
                {
                    result *= 1.5f;
                }
            }
            return result;
        }
    }
}
