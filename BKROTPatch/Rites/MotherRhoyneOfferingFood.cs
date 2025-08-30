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
    internal class MotherRhoyneOfferingFood : CompositeOffering
    {
        public MotherRhoyneOfferingFood()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("grain"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("apple"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("olives"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The harvest is set at her feet. The river goddess ensures plenty for the faithful and their communities.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Bounty of the Banks", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 sacks of grain, 5 baskets of apples, and 5 barrels of olives", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("Will you offer grain, apples, and olives in the name of the Mother Rhoyne?", null), false);
        }
    }
}
