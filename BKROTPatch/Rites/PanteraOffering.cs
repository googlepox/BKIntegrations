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
    internal class PanteraOffering : Offering
    {
        public PanteraOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "fish"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("You leave the bounty for Pantera, and her soft purrs echo in the air. Fertility blooms, and life stirs quietly in hidden places.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Purring Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 barrels of fish", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer fish in the name of Pantera?", null), false);
        }
    }
}
