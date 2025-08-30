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
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Models
{
    internal class BKROTPartyWageModel : BKPartyWageModel
    {
        public override ExplainedNumber GetTotalWage(MobileParty mobileParty, bool includeDescriptions = false)
        {
            ExplainedNumber wage = base.GetTotalWage(mobileParty, includeDescriptions);
            if (mobileParty.LeaderHero != null)
            {
                Hero leader = mobileParty.LeaderHero;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null)
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.PrincelyArbiter))
                    {
                        wage.AddFactor(-0.15f * mobileParty.MemberRoster.Count, ROTDivinities.Instance.PrincelyArbiter.Name);
                    }
                }
            }
            return wage;
        }
    }
}
