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
    internal class GreatStallionSacrifice : Sacrifice
    {
        public override TextObject GetDescription()
        {
            return new TextObject("The blade of the fallen rests upon the altar. The Great Stallion empowers courage, prowess, and unbroken spirit in battle.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Blood of the Warrior", null);
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
