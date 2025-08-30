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
    internal class ManyFacedGodSacrifice : Sacrifice
    {
        public override TextObject GetDescription()
        {
            return new TextObject("A burden is laid bare. The Many-Faced God listens and brings relief, easing the hearts of those who endure.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("End of Suffering", null);
        }

        public override bool CanHeroBeSacrificed(Hero executor, Hero hero)
        {
            return true;
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
