using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Rites
{
    internal class FatherSacrifice : Sacrifice
    {
        public override TextObject GetDescription()
        {
            return new TextObject("Execute a criminal in the name of The Father, so that all may know that none are above the law.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Trial by The Father", null);
        }

        public override bool CanHeroBeSacrificed(Hero executor, Hero hero)
        {
            Religion religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(executor);
            Religion religion2 = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
            return religion != religion2 && (hero.Culture.StringId == "looters" 
                || hero.Culture.StringId == "sea_raiders"
                || hero.Culture.StringId == "mountain_bandits"
                || hero.Culture.StringId == "forest_bandits"
                || hero.Culture.StringId == "desert_bandits"
                || hero.Culture.StringId == "steppe_bandits"
                || hero.Culture.StringId == "wildlings"
                || hero.Culture.StringId == "hilltribesmen"
                || hero.Culture.StringId == "robber_knights"
                || hero.Culture.StringId == "yiti_bandits");
        }

        public override int CalculateSacrificeReward(Hero sacrifice)
        {
            int result = base.CalculateSacrificeReward(sacrifice);
            result += (int)((float)sacrifice.GetSkillValue(DefaultSkills.OneHanded) / 2f);
            result += (int)((float)sacrifice.GetSkillValue(DefaultSkills.TwoHanded) / 2f);
            result += (int)((float)sacrifice.GetSkillValue(DefaultSkills.Polearm) / 2f);
            result += (int)((float)sacrifice.GetSkillValue(DefaultSkills.Bow) / 3f);
            result += (int)((float)sacrifice.GetSkillValue(DefaultSkills.Crossbow) / 3f);
            return result + (int)((float)sacrifice.GetSkillValue(DefaultSkills.Throwing) / 3f);
        }
    }
}
