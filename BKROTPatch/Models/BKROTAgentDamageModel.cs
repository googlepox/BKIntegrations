using BannerKings;
using BannerKings.Managers.Education.Lifestyles;
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
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BKROTPatch.Models
{
    internal class BKROTAgentDamageModel : BKAgentDamageModel
    {
        public override float CalculateDamage(in AttackInformation attackInformation, in AttackCollisionData collisionData, in MissionWeapon weapon, float baseDamage)
        {
            var baseResult = base.CalculateDamage(in attackInformation, in collisionData, in weapon, baseDamage);
            var aggressorCaptain = attackInformation.AttackerCaptainCharacter as CharacterObject;

            if (attackInformation.AttackerAgentCharacter is CharacterObject aggressor)
            {
                if (aggressorCaptain != null && aggressorCaptain.IsHero && aggressorCaptain.HeroObject != null)
                {
                    Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(aggressorCaptain.HeroObject);
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(aggressorCaptain.HeroObject, ROTDivinities.Instance.AquanTheRedBull))
                    {
                        return baseResult *= 1.1f;
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(aggressorCaptain.HeroObject, ROTDivinities.Instance.ManyFacedGod))
                    {
                        return baseResult *= 1.1f;
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(aggressorCaptain.HeroObject, ROTDivinities.Instance.BlackGoat))
                    {
                        return baseResult *= 1.2f;
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(aggressorCaptain.HeroObject, ROTDivinities.Instance.GreatStallion))
                    {
                        return baseResult *= 1.1f;
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(aggressorCaptain.HeroObject, ROTDivinities.Instance.GodsPassion))
                    {
                        return baseResult *= 1.1f;
                    }
                }
            }

            return baseResult;
        }
    }
}
