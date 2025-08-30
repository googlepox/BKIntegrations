using BannerKings;
using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Languages;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;
using TaleWorlds.SaveSystem;

namespace BKEducationPatch.Books
{
    internal class DefaultBookTypesAddOn : DefaultTypeInitializer<DefaultBookTypesAddOn, BookType>
    {
        [SaveableField(1)]
        internal static Dictionary<BookType, Language> bookTypeLanguages;
        public BookType LTBook1 { get; private set; } = new BookType("education_book_onehanded1");
        public BookType LTBook2 { get; private set; } = new BookType("education_book_twohanded1");
        public BookType LTBook3 { get; private set; } = new BookType("education_book_polearm1");
        public BookType LTBook4 { get; private set; } = new BookType("education_book_bow1");
        public BookType LTBook5 { get; private set; } = new BookType("education_book_crossbow1");
        public BookType LTBook6 { get; private set; } = new BookType("education_book_throwing1");
        public BookType LTBook7 { get; private set; } = new BookType("education_book_riding1");
        public BookType LTBook8 { get; private set; } = new BookType("education_book_ahthletics1");
        public BookType LTBook9 { get; private set; } = new BookType("education_book_smithing1");
        public BookType LTBook10 { get; private set; } = new BookType("education_book_scouting1");
        public BookType LTBook11 { get; private set; } = new BookType("education_book_tactics1");
        public BookType LTBook12 { get; private set; } = new BookType("education_book_roguery1");
        public BookType LTBook13 { get; private set; } = new BookType("education_book_charm1");
        public BookType LTBook14 { get; private set; } = new BookType("education_book_leadership1");
        public BookType LTBook15 { get; private set; } = new BookType("education_book_trade1");
        public BookType LTBook16 { get; private set; } = new BookType("education_book_steward1");
        public BookType LTBook17 { get; private set; } = new BookType("education_book_medicine1");
        public BookType LTBook18 { get; private set; } = new BookType("education_book_engineering1");
        public BookType LTBook19 { get; private set; } = new BookType("education_book_onehanded2");
        public BookType LTBook20 { get; private set; } = new BookType("education_book_twohanded2");
        public BookType LTBook21 { get; private set; } = new BookType("education_book_polearm2");
        public BookType LTBook22 { get; private set; } = new BookType("education_book_bow2");
        public BookType LTBook23 { get; private set; } = new BookType("education_book_crossbow2");
        public BookType LTBook24 { get; private set; } = new BookType("education_book_throwing2");
        public BookType LTBook25 { get; private set; } = new BookType("education_book_riding2");
        public BookType LTBook26 { get; private set; } = new BookType("education_book_ahthletics2");
        public BookType LTBook27 { get; private set; } = new BookType("education_book_smithing2");
        public BookType LTBook28 { get; private set; } = new BookType("education_book_scouting2");
        public BookType LTBook29 { get; private set; } = new BookType("education_book_tactics2");
        public BookType LTBook30 { get; private set; } = new BookType("education_book_roguery2");
        public BookType LTBook31 { get; private set; } = new BookType("education_book_charm2");
        public BookType LTBook32 { get; private set; } = new BookType("education_book_leadership2");
        public BookType LTBook33 { get; private set; } = new BookType("education_book_trade2");
        public BookType LTBook34 { get; private set; } = new BookType("education_book_steward2");
        public BookType LTBook35 { get; private set; } = new BookType("education_book_medicine2");
        public BookType LTBook36 { get; private set; } = new BookType("education_book_engineering2");


        public override IEnumerable<BookType> All
        {
            get
            {
                yield return LTBook1;
                yield return LTBook2;
                yield return LTBook3;
                yield return LTBook4;
                yield return LTBook5;
                yield return LTBook6;
                yield return LTBook7;
                yield return LTBook8;
                yield return LTBook9;
                yield return LTBook10;
                yield return LTBook11;
                yield return LTBook12;
                yield return LTBook13;
                yield return LTBook14;
                yield return LTBook15;
                yield return LTBook16;
                yield return LTBook17;
                yield return LTBook18;
                yield return LTBook19;
                yield return LTBook20;
                yield return LTBook21;
                yield return LTBook22;
                yield return LTBook23;
                yield return LTBook24;
                yield return LTBook25;
                yield return LTBook26;
                yield return LTBook27;
                yield return LTBook28;
                yield return LTBook29;
                yield return LTBook30;
                yield return LTBook31;
                yield return LTBook32;
                yield return LTBook33;
                yield return LTBook34;
                yield return LTBook35;
                yield return LTBook36;
            }
        }

        public Language GetRandLanguage()
        {
            int randInt = MBRandom.RandomInt(0, DefaultTypeInitializer<DefaultLanguages, Language>.Instance.All.Count());
            return DefaultTypeInitializer<DefaultLanguages, Language>.Instance.All.ElementAt(randInt);
        }

        public SkillObject GetSkillObject(string bookId)
        {
            if (bookId.Contains("onehanded"))
            {
                return DefaultSkills.OneHanded;
            }
            else if (bookId.Contains("twohanded"))
            {
                return DefaultSkills.TwoHanded;
            }
            else if (bookId.Contains("book_bow"))
            {
                return DefaultSkills.Bow;
            }
            else if (bookId.Contains("crossbow"))
            {
                return DefaultSkills.Crossbow;
            }
            else if (bookId.Contains("polearm"))
            {
                return DefaultSkills.Polearm;
            }
            else if (bookId.Contains("throwing"))
            {
                return DefaultSkills.Throwing;
            }
            else if (bookId.Contains("riding"))
            {
                return DefaultSkills.Riding;
            }
            else if (bookId.Contains("ahthletics"))
            {
                return DefaultSkills.Athletics;
            }
            else if (bookId.Contains("smithing"))
            {
                return DefaultSkills.Crafting;
            }
            else if (bookId.Contains("scouting"))
            {
                return DefaultSkills.Scouting;
            }
            else if (bookId.Contains("tactics"))
            {
                return DefaultSkills.Tactics;
            }
            else if (bookId.Contains("roguery"))
            {
                return DefaultSkills.Roguery;
            }
            else if (bookId.Contains("charm"))
            {
                return DefaultSkills.Charm;
            }
            else if (bookId.Contains("leadership"))
            {
                return DefaultSkills.Leadership;
            }
            else if (bookId.Contains("trade"))
            {
                return DefaultSkills.Trade;
            }
            else if (bookId.Contains("medicine"))
            {
                return DefaultSkills.Medicine;
            }
            else if (bookId.Contains("engineering"))
            {
                return DefaultSkills.Engineering;
            }
            else if (bookId.Contains("steward"))
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
                if (bookTypeLanguages?.Count > 0 && bookTypeLanguages.ContainsKey(book))
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
