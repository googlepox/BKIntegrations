using BannerKings;
using BannerKings.Managers.Education.Languages;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BKMergedMapPatch.Languages
{
    public class DefaultLanguagesMMAddon : DefaultTypeInitializer<DefaultLanguagesMMAddon, Language>
    {
        public Language Huaxian
        {
            get; private set;
        }
        public Language Tetso
        {
            get; private set;
        }

        public override IEnumerable<Language> All
        {
            get
            {
                yield return this.Huaxian;
                yield return this.Tetso;
            }
        }

        public override void Initialize()
        {
            CultureObject huaxia = MBObjectManager.Instance.GetObject<CultureObject>("huaxia");
            CultureObject tetsojin = MBObjectManager.Instance.GetObject<CultureObject>("tetsojin");
            MBReadOnlyList<CultureObject> objectTypeList = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            this.Huaxian = new Language("language_huaxian");
            this.Tetso = new Language("language_tetso");
            this.Huaxian.Initialize(new TextObject("Huaxian"), new TextObject("Hailing from the beyond the eastern borders of the map, the Huaxian Empire has been said to have lasted 10,000 years and the Palace of their emperors are said to be more splendid than any the Calradians have ever built. Huaxian has no similarities to any of the other languages seen in Calradia, and remains a mystical language to most."), new List<CultureObject> { huaxia }, this.GetIntelligibles(this.Huaxian));
            this.Tetso.Initialize(new TextObject("Tetso"), new TextObject("At first glance the Tetso language may seem a linguistic cousin to Huaxian, however years of war between their civilizations in the far east has made this seem all but impossible. The warriors of Tetsojin speak of their native land with great dignity and pride and of Huaxia with disdain and mockery, although scholars believe their languages may once have intermingled long ago."), new List<CultureObject> { tetsojin }, this.GetIntelligibles(this.Tetso));
            foreach (Language lang in All)
            {
                DefaultTypeInitializer<DefaultLanguages, Language>.Instance.AddObject(lang);
            }
        }

        private Dictionary<Language, float> GetIntelligibles(Language language)
        {
            string stringId = language.StringId;
            if (true)
            {
                ;
            }

            Dictionary<Language, float> intelligibles;
            switch (stringId)
            {
                case "language_huaxia":
                    intelligibles = new Dictionary<Language, float>()
                {
                    {
                        this.Tetso,
                        0.05f
                    }
                };
                    break;
                case "language_tetso":
                    intelligibles = new Dictionary<Language, float>()
                {
                    {
                       this.Huaxian,
                        0.05f
                    }
                };
                    break;
                default:
                    intelligibles = new Dictionary<Language, float>();
                    break;
            }

            return intelligibles;
        }
    }
}
