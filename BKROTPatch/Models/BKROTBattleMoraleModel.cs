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
using TaleWorlds.MountAndBlade;

namespace BKROTPatch.Models
{
    internal class BKROTBattleMoraleModel : BKBattleMoraleModel
    {
        public override float GetEffectiveInitialMorale(Agent agent, float baseMorale)
        {
            float morale = base.GetEffectiveInitialMorale(agent, baseMorale);
            bool flag = agent.IsHuman && Mission.Current != null && agent.Team != null && agent.Team.IsAttacker;
            bool flag2 = agent.IsHuman && Mission.Current != null && agent.Team != null && agent.Team.IsDefender;
            IAgentOriginBase origin = agent.Origin;
            PartyBase partyBase = (PartyBase)(origin?.BattleCombatant);
            Hero hero = ((partyBase != null) ? partyBase.LeaderHero : null);
            if (flag && hero != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.DrownedGod, rel))
                {
                    morale *= 1.3f;
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.Rhllor, rel))
                {
                    morale *= 1.3f;
                }
            }
            if (flag2 && hero != null)
            {
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.MaidenMadeOfLight, rel))
                {
                    morale *= 1.3f;
                }
            }
            if (agent.ImmediateEnemy != null && agent.ImmediateEnemy.Team != null)
            {
                IAgentOriginBase enemyOrigin = agent.ImmediateEnemy.Origin;
                PartyBase enemyPartyBase = (PartyBase)(enemyOrigin?.BattleCombatant);
                Hero enemyHero = ((enemyPartyBase != null) ? enemyPartyBase.LeaderHero : null);
                if (enemyHero != null)
                {
                    Religion enemyRel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(enemyHero);
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(enemyHero, ROTDivinities.Instance.LionOfNight, enemyRel))
                    {
                        morale *= 0.8f;
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(enemyHero, ROTDivinities.Instance.Bakkalon, enemyRel))
                    {
                        morale *= 0.8f;
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(enemyHero, ROTDivinities.Instance.BlackGoat, enemyRel))
                    {
                        morale *= 0.6f;
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(enemyHero, ROTDivinities.Instance.GodsFire, enemyRel))
                    {
                        morale *= 0.8f;
                    }
                }
            }
            return morale;
        }
    }
}
