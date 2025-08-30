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
            this.SevenPointedStar.Initialize(DefaultTypeInitializer<BKROTItems, ItemObject>.Instance.BookSevenPointedStar, new TextObject("A sad story that reminds many of their powerlesness towards the ways of the world. The shepherd boy Kais and the nobleman's daughter Layala love each other, but they can never marry. The poem is Kais's lament as he wanders alone, unwilling to forget his true love, driving himself mad with longing. “The wind that blows the dry steppe dust...”", null), ROTLanguages.Instance.Westerosi, BookUse.Skillbook, BKSkills.Instance.Theology, DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble);
            
            foreach (BookType book in All)
            {
                DefaultTypeInitializer<DefaultBookTypes, BookType>.Instance.AddObject(book);
            }
        }
    }
}
