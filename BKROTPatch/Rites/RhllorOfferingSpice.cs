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
    internal class RhllorOfferingSpice : CompositeOffering
    {
        public RhllorOfferingSpice()
            : base(new Dictionary<ItemObject, int>
            {
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("pouchofgems"),
                    5
                },
                {
                    MBObjectManager.Instance.GetObject<ItemObject>("spice"),
                    5
                }
            })
        {
        }

        public override TextObject GetDescription()
        {
            return new TextObject("The smoke twists, the fire dances strangely — faces form in the flame, and the future shimmers before your eyes.", null);
        }

        public override TextObject GetName()
        {
            return new TextObject("Vision in the Flames", null);
        }

        public override float GetPietyReward()
        {
            return 100f;
        }

        public override TextObject GetRequirementsText(Hero hero)
        {
            return new TextObject("May be performed every {YEARS} years\nRequires 5 pouches of gems and 5 sacks of spice", null).SetTextVariable("YEARS", this.GetTimeInterval(hero));
        }

        public override void SetDialogue()
        {
            MBTextManager.SetTextVariable("CLERGYMAN_RITE_CONFIRM", new TextObject("{=!}Will you make an offering of spice and gems in the name of R'hllor?", null), false);
        }
    }
}
