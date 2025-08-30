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
    internal class GreatStallionOfferingBeer : Offering
    {
        public GreatStallionOfferingBeer()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "beer"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The faithful gather under the open sky. The Great Stallion fills hearts with vigor, stamina, and camaraderie among kin.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Feast of the Nomads", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 barrels of beer", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer beer in the name of the Great Stallion?", null), false);
        }
    }
}
