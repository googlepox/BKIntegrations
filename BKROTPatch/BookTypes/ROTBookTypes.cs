using BannerKings;
using BannerKings.CampaignContent.Traits;
using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Items;
using BannerKings.Managers.Skills;
using BKCEKPatch.Languages;
using BKROTPatch.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using static TaleWorlds.CampaignSystem.CampaignBehaviors.LordConversationsCampaignBehavior;

namespace BKROTPatch.BookTypes
{
    internal class ROTBookTypes : DefaultTypeInitializer<ROTBookTypes, BookType>
    {
        public BookType SevenPointedStar = new BookType("book_seven_pointed_star");
        public override IEnumerable<BookType> All
        {
            get
            {
                yield return SevenPointedStar;
                yield break;
            }
        }

        public override void Initialize()
        {
            this.SevenPointedStar.Initialize(DefaultTypeInitializer<BKROTItems, ItemObject>.Instance.BookSevenPointedStar, new TextObject("The Seven-Pointed Star is the holiest text of the Faith of the Seven, said to have been written by Septon Barth the First and inspired by the words of the Seven themselves. Within its pages are sermons, parables, and laws meant to guide the faithful in all walks of life. Each of the Seven speaks through it—the Father on justice, the Mother on mercy, the Warrior on strength, the Maiden on innocence, the Smith on labor, the Crone on wisdom, and the Stranger on death. No other book is so often read aloud in septs across Westeros, nor sworn upon in oaths of crown and commoner alike.", null), ROTLanguages.Instance.Westerosi, BookUse.Skillbook, BKSkills.Instance.Theology, DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble);
            
            foreach (BookType book in All)
            {
                DefaultTypeInitializer<DefaultBookTypes, BookType>.Instance.AddObject(book);
            }
        }
    }
}
