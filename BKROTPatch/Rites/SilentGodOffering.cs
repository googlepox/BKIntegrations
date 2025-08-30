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
    internal class SilentGodOffering : Offering
    {
        public SilentGodOffering()
            : base(MBObjectManager.Instance.GetObject<ItemObject>((ItemObject x) => x.StringId == "jewelry"), 5)
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The shrine hums with stillness. The Silent God watches those who listen, granting insight through quiet contemplation.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Silent Vigil", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 items of jewelry", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer jewelry in the name of the Silent God?", null), false);
        }
    }
}
