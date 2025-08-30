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
    internal class MotherRhoyneOfferingPottery : Offering
    {
        public MotherRhoyneOfferingPottery()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "pottery"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The waters flow over the altar, carrying your devotion. Mother Rhoyne smiles, blessing fertility and abundance upon the land.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Offering of The River", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 20 crates of pottery", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer pottery in the name of the Mother Rhoyne?", null), false);
        }
    }
}
