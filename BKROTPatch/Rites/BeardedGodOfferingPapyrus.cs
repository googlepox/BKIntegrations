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
    internal class BeardedGodOfferingPapyrus : CompositeOffering
    {
        public BeardedGodOfferingPapyrus()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("Ink"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("Papyrus"),
                    10
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Secrets are laid bare in silence. The Bearded God blesses discretion, secrecy, and the careful guarding of knowledge.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Votive of Secret Knowledge", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 bottles of ink and 10 scrolls of papyrus", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer papyrus and ink in the name of the Bearded God?", null), false);
        }
    }
}
