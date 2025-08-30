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
    internal class PatternOfferingPapyrus : Offering
    {
        public PatternOfferingPapyrus()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "Papyrus"), 10)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Smoke rises in winding trails. In the haze, the Patternmaker whispers lessons hidden to the impatient and heedless.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Revelation Gift", null);
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
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer papyrus in the name of the Patternmaker?", null), false);
        }
    }
}
