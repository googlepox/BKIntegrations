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
    internal class WeepingLadyOfferingWine : Offering
    {
        public WeepingLadyOfferingWine()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "wine"), 10)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("You pour your sorrow into the fountain. The Lady’s eyes glisten in return, lifting a weight from your heart and those of others.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Tears in the Fountain", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 amphorae of wine", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wine in the name of the Weeping Lady?", null), false);
        }
    }
}
