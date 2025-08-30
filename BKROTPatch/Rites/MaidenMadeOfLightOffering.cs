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
    internal class MaidenMadeOfLightOffering : Offering
    {
        public MaidenMadeOfLightOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "Papyrus"), 10)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Knowledge laid bare before the shrine is embraced. The Maiden whispers understanding to those who seek wisdom.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of Insight", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 scrolls of papyrus", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer papyrus in the name of the Maiden-Made-of-Light?", null), false);
        }
    }
}
