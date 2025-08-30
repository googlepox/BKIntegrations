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
    internal class SaagaelOffering : CompositeOffering
    {
        public SaagaelOffering()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("hog"),
                    1
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("wine"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The scarlet drips upon the altar. Saagael takes it in silence, strengthening those who endure and bending them to her will.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Crimson Offering", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 amphorae of wine and a hog", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer a hog and wine in the name of Saagael?", null), false);
        }
    }
}
