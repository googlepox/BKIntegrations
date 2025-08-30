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
    internal class BKROTArmyModel : BKArmyManagementModel
    {
        public override ExplainedNumber CalculateDailyCohesionChange(Army army, bool includeDescriptions = false)
        {
            ExplainedNumber result = base.CalculateDailyCohesionChange(army, includeDescriptions);
            Hero leader = army.LeaderParty.LeaderHero;
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
            bool flag = rel != null;
            if (flag)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader,ROTDivinities.Instance.TheWarrior, rel))
                {
                    result.Add(0.2f, ROTDivinities.Instance.TheWarrior.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheCrone, rel))
                {
                    result.Add(0.2f, ROTDivinities.Instance.TheCrone.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Pattern, rel))
                {
                    result.Add(0.2f, ROTDivinities.Instance.Pattern.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.SilentGod, rel))
                {
                    result.Add(0.2f, ROTDivinities.Instance.SilentGod.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Boash, rel))
                {
                    result.Add(0.2f, ROTDivinities.Instance.Boash.Name, null);
                }
            }
            return result;
        }
        public override int CalculatePartyInfluenceCost(MobileParty armyLeaderParty, MobileParty party)
        {
            int result = base.CalculatePartyInfluenceCost(armyLeaderParty, party);
            Hero leader = armyLeaderParty.LeaderHero;
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
            if (rel != null)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheWarrior, rel))
                {
                    result = (int)((float)result * 0.75f);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Pattern, rel))
                {
                    result = (int)((float)result * 0.75f);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Boash, rel))
                {
                    result = (int)((float)result * 0.75f);
                }
            }
            return result;
        }

        public override int GetCohesionBoostInfluenceCost(Army army, int percentageToBoost = 100)
        {
            int result = base.GetCohesionBoostInfluenceCost(army, percentageToBoost);
            Hero leader = army.LeaderParty.LeaderHero;
            
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
            if (rel != null)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheWarrior))
                {
                    result = (int)((float)result * 0.75f);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Pattern))
                {
                    result = (int)((float)result * 0.75f);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Boash))
                {
                    result = (int)((float)result * 0.75f);
                }
            }
            return result;
        }
    }
}
