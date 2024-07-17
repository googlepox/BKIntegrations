using BannerKings;
using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Languages;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;
using TaleWorlds.SaveSystem;

namespace BKWarlordPatch.Books
{
    internal class DefaultBookTypesWarlord : DefaultTypeInitializer<DefaultBookTypesWarlord, BookType>
    {
        [SaveableField(1)]
        internal static Dictionary<BookType, Language> bookTypeLanguages;
        public BookType WarlordBook1 { get; private set; } = new BookType("scroll_1.Tactics.200");
        public BookType WarlordBook2 { get; private set; } = new BookType("scroll_2.Leadership.1300");
        public BookType WarlordBook3 { get; private set; } = new BookType("scroll_3.Medicine.700");
        public BookType WarlordBook4 { get; private set; } = new BookType("scroll_4.Leadership.800");
        public BookType WarlordBook5 { get; private set; } = new BookType("scroll_5.Scouting.200");
        public BookType WarlordBook6 { get; private set; } = new BookType("scroll_6.Riding.600");
        public BookType WarlordBook7 { get; private set; } = new BookType("scroll_7.Tactics.900");
        public BookType WarlordBook8 { get; private set; } = new BookType("scroll_8.Engineering.900");
        public BookType WarlordBook9 { get; private set; } = new BookType("scroll_9.Roguery.300");
        public BookType WarlordBook10 { get; private set; } = new BookType("scroll_10.Crafting.200");
        public BookType WarlordBook11 { get; private set; } = new BookType("scroll_11.OneHanded.1100");
        public BookType WarlordBook12 { get; private set; } = new BookType("scroll_12.Medicine.1000");
        public BookType WarlordBook13 { get; private set; } = new BookType("scroll_13.Scouting.700");
        public BookType WarlordBook14 { get; private set; } = new BookType("scroll_14.TwoHanded.1100");
        public BookType WarlordBook15 { get; private set; } = new BookType("scroll_15.Crafting.900");
        public BookType WarlordBook16 { get; private set; } = new BookType("scroll_16.Roguery.500");
        public BookType WarlordBook17 { get; private set; } = new BookType("scroll_17.Leadership.500");
        public BookType WarlordBook18 { get; private set; } = new BookType("scroll_18.Engineering.800");
        public BookType WarlordBook19 { get; private set; } = new BookType("scroll_19.Tactics.450");
        public BookType WarlordBook20 { get; private set; } = new BookType("scroll_20.Crafting.1200");
        public BookType WarlordBook21 { get; private set; } = new BookType("scroll_21.Tactics.1900");
        public BookType WarlordBook22 { get; private set; } = new BookType("scroll_22.Leadership.1900");
        public BookType WarlordBook23 { get; private set; } = new BookType("scroll_23.Scouting.200");
        public BookType WarlordBook24 { get; private set; } = new BookType("scroll_24.Scouting.800");
        public BookType WarlordBook25 { get; private set; } = new BookType("scroll_25.Medicine.1100");
        public BookType WarlordBook26 { get; private set; } = new BookType("scroll_26.Medicine.200");
        public BookType WarlordBook27 { get; private set; } = new BookType("scroll_27.Trade.1400");
        public BookType WarlordBook28 { get; private set; } = new BookType("scroll_28.Trade.200");
        public BookType WarlordBook29 { get; private set; } = new BookType("scroll_29.Trade.100");
        public BookType WarlordBook30 { get; private set; } = new BookType("scroll_30.Charm.100");
        public BookType WarlordBook31 { get; private set; } = new BookType("scroll_31.Athletics.500");
        public BookType WarlordBook32 { get; private set; } = new BookType("scroll_32.Charm.500");


        public override IEnumerable<BookType> All
        {
            get
            {
                yield return WarlordBook1;
                yield return WarlordBook2;
                yield return WarlordBook3;
                yield return WarlordBook4;
                yield return WarlordBook5;
                yield return WarlordBook6;
                yield return WarlordBook7;
                yield return WarlordBook8;
                yield return WarlordBook9;
                yield return WarlordBook10;
                yield return WarlordBook11;
                yield return WarlordBook12;
                yield return WarlordBook13;
                yield return WarlordBook14;
                yield return WarlordBook15;
                yield return WarlordBook16;
                yield return WarlordBook17;
                yield return WarlordBook18;
                yield return WarlordBook19;
                yield return WarlordBook20;
                yield return WarlordBook21;
                yield return WarlordBook22;
                yield return WarlordBook23;
                yield return WarlordBook24;
                yield return WarlordBook25;
                yield return WarlordBook26;
                yield return WarlordBook27;
                yield return WarlordBook28;
                yield return WarlordBook29;
                yield return WarlordBook30;
                yield return WarlordBook31;
                yield return WarlordBook32;
            }
        }

        public Language GetRandLanguage()
        {
            int randInt = MBRandom.RandomInt(0, DefaultTypeInitializer<DefaultLanguages, Language>.Instance.All.Count());
            return DefaultTypeInitializer<DefaultLanguages, Language>.Instance.All.ElementAt(randInt);
        }

        public SkillObject GetSkillObject(string bookId)
        {
            if (bookId.Contains(".OneHanded"))
            {
                return DefaultSkills.OneHanded;
            }
            else if (bookId.Contains(".TwoHanded"))
            {
                return DefaultSkills.TwoHanded;
            }
            else if (bookId.Contains(".Bow"))
            {
                return DefaultSkills.Bow;
            }
            else if (bookId.Contains(".Crossbow"))
            {
                return DefaultSkills.Crossbow;
            }
            else if (bookId.Contains(".Polearm"))
            {
                return DefaultSkills.Polearm;
            }
            else if (bookId.Contains(".Throwing"))
            {
                return DefaultSkills.Throwing;
            }
            else if (bookId.Contains(".Riding"))
            {
                return DefaultSkills.Riding;
            }
            else if (bookId.Contains(".Athletics"))
            {
                return DefaultSkills.Athletics;
            }
            else if (bookId.Contains(".Crafting"))
            {
                return DefaultSkills.Crafting;
            }
            else if (bookId.Contains(".Scouting"))
            {
                return DefaultSkills.Scouting;
            }
            else if (bookId.Contains(".Tactics"))
            {
                return DefaultSkills.Tactics;
            }
            else if (bookId.Contains(".Roguery"))
            {
                return DefaultSkills.Roguery;
            }
            else if (bookId.Contains(".Charm"))
            {
                return DefaultSkills.Charm;
            }
            else if (bookId.Contains(".Leadership"))
            {
                return DefaultSkills.Leadership;
            }
            else if (bookId.Contains(".Trade"))
            {
                return DefaultSkills.Trade;
            }
            else if (bookId.Contains(".Medicine"))
            {
                return DefaultSkills.Medicine;
            }
            else if (bookId.Contains(".Engineering"))
            {
                return DefaultSkills.Engineering;
            }
            else if (bookId.Contains(".Steward"))
            {
                return DefaultSkills.Steward;
            }
            else
            {
                return DefaultSkills.Charm;
            }
        }

        public override void Initialize()
        {
            foreach (BookType book in All)
            {
                Language bookLanguage;
                if (bookTypeLanguages != null && bookTypeLanguages.Count > 0 && bookTypeLanguages.ContainsKey(book))
                {
                    bookLanguage = bookTypeLanguages[book];
                    bookTypeLanguages[book] = bookLanguage;
                }
                else
                {
                    bookTypeLanguages = new Dictionary<BookType, Language>();
                    bookLanguage = GetRandLanguage();
                    bookTypeLanguages.Add(book, bookLanguage);
                }
                ItemObject bookToAdd = MBObjectManager.Instance.GetObject<ItemObject>(book.StringId);
                book.Initialize(bookToAdd, bookToAdd.Name, bookLanguage, BookUse.Skillbook, GetSkillObject(bookToAdd.StringId));
                DefaultBookTypes.Instance.AddObject(book);
            }
        }
    }
}
