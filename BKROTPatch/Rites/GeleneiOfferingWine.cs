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
    internal class GeleneiOfferingWine : Offering
    {
        public GeleneiOfferingWine()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "wine"), 20)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("A libation poured upon the altar sweetens the soil. Gelenei’s laughter fills the vines and orchards with promise.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Cup of Plenty", null);
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
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer wine in the name of Gelenei?", null), false);
        }
    }
}
