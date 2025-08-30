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
using TaleWorlds.ObjectSystem;

namespace BKROTPatch.Rites
{
    internal class BeardedGodSacrifice : Sacrifice
    {
        public override TextObject GetDescription()
        {
            return new TextObject("Locks are placed at the shrine. The Bearded God sees the sacrifice and strengthens those who submit fully to his will.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Infidel's Hair", null);
        }

        public override bool CanHeroBeSacrificed(Hero executor, Hero hero)
        {
            Religion religion = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(executor);
            Religion religion2 = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
            return religion != religion2;
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
