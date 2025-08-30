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
    internal class BlackGoatOfferingAnimals : CompositeOffering
    {
        public BlackGoatOfferingAnimals()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("cow"),
                    5
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
            return new TextObject("The feast is soaked in ritual. The Black Goat smiles upon the faithful who combine indulgence with reverence.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("The Crimson Feast", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 cows and 5 amphorae of wine", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you offer blood and wine in the name of the Black Goat?", null), false);
        }
    }
}
