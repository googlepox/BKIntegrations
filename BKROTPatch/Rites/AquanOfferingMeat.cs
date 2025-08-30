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
    internal class BlackGoatOfferingLinen : Offering
    {
        public BlackGoatOfferingLinen()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "linen"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("A cloak of darkness drapes the shrine. The Black Goat shrouds the faithful in his protection and grants influence among those who fear him.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Dark Mantle", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 rolls of linen", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer linen in the name of the Black Goat?", null), false);
        }
    }
}
