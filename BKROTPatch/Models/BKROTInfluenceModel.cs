using BannerKings;
using BannerKings.Managers.Court;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Titles;
using BannerKings.Managers.Titles.Governments;
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
    internal class BKROTInfluenceModel : BKInfluenceModel
    {
        public override ExplainedNumber CalculateInfluenceCap(Clan clan, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateInfluenceCap(clan, includeDescriptions);
            Hero leader = clan.Leader;
            if (leader != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.PrincelyArbiter))
                {
                    result.AddFactor(0.15f, ROTDivinities.Instance.PrincelyArbiter.Name);
                }
            }
            return result;
        }

        public override ExplainedNumber CalculateInfluenceChange(Clan clan, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateInfluenceChange(clan, includeDescriptions);
            Hero leader = clan.Leader;
            if (leader != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
                if (rel != null)
                {
                    bool flag3 = BannerKingsConfig.Instance.ReligionsManager.HasBlessing(clan.Leader, ROTDivinities.Instance.PrincelyArbiter, rel);
                    if (flag3)
                    {
                        result.AddFactor((result.BaseNumber > 0f) ? 0.3f : (-0.3f), ROTDivinities.Instance.PrincelyArbiter.Name);
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(clan.Leader, ROTDivinities.Instance.SilentGod, rel))
                    {
                        result.AddFactor((result.BaseNumber > 0f) ? 0.3f : (-0.3f), ROTDivinities.Instance.SilentGod.Name);
                    }
                }
            }
            return result;
        }
    }
}
