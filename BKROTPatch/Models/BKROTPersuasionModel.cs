using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Conversation.Persuasion;
using TaleWorlds.CampaignSystem.GameComponents;

namespace BKROTPatch.Models
{
    internal class BKROTPersuasionModel : DefaultPersuasionModel
    {
        public override float GetDifficulty(PersuasionDifficulty difficulty)
        {
            float baseDiff = base.GetDifficulty(difficulty);
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(Hero.MainHero);
            if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.YndrosOfTheTwilight, rel))
            {
                return baseDiff += 0.1f;
            }
            if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.Semosh, rel))
            {
                return baseDiff += 0.1f;
            }
            if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.Selloso, rel))
            {
                return baseDiff += 0.1f;
            }
            if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.BlackGoat, rel))
            {
                return baseDiff += 0.1f;
            }
            if (rel != null && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(Hero.MainHero, ROTDivinities.Instance.GodsPassion, rel))
            {
                return baseDiff += 0.1f;
            }
            return baseDiff;
        }
    }
}
