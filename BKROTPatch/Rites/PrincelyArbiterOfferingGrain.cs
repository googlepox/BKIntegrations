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
    internal class PrincelyArbiterOfferingGrain : CompositeOffering
    {
        public PrincelyArbiterOfferingGrain()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("grain"),
                    10
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("cow"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("Your offering nourishes the land and those who dwell upon it. The Prince smiles, and blessings spread where care has been shown.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Sacrifice for the People", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 10 sacks of grain and 5 cows", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("Will you offer grain and cows in the name of the Great Prince?", null), false);
        }
    }
}
