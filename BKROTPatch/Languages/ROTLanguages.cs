using BannerKings;
using BannerKings.Managers.Education.Languages;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BKCEKPatch.Languages
{
    public class ROTLanguages : DefaultTypeInitializer<ROTLanguages, Language>
    {
        public Language HighValyrian { get; } = new Language("language_high_valyrian");
        public Language LowValyrian { get; } = new Language("language_low_valyrian");
        public Language Westerosi { get; } = new Language("language_westerosi");
        public Language Ghiscari { get; } = new Language("language_ghiscari");
        public Language Sarnori { get; } = new Language("language_sarnori");
        public Language YiTish { get; } = new Language("language_yitish");
        public Language Dothraki { get; } = new Language("language_dothraki");
        public Language OldTongue { get; } = new Language("language_old_tongue");
        public Language SummerTongue { get; } = new Language("language_summer_tongue");

        public override IEnumerable<Language> All
        {
            get
            {
                yield return this.HighValyrian;
                yield return this.LowValyrian;
                yield return this.Westerosi;
                yield return this.Ghiscari;
                yield return this.Sarnori;
                yield return this.YiTish;
                yield return this.Dothraki;
                yield return this.OldTongue;
            }
        }

        public override void Initialize()
        {
            CultureObject valyrian = MBObjectManager.Instance.GetObject<CultureObject>("valyrian");
            CultureObject freefolk = MBObjectManager.Instance.GetObject<CultureObject>("freefolk");
            CultureObject nightswatch = MBObjectManager.Instance.GetObject<CultureObject>("nightswatch");
            CultureObject vale = MBObjectManager.Instance.GetObject<CultureObject>("vale");
            CultureObject river = MBObjectManager.Instance.GetObject<CultureObject>("river");
            CultureObject dragonstone = MBObjectManager.Instance.GetObject<CultureObject>("dragonstone");
            CultureObject stormlands = MBObjectManager.Instance.GetObject<CultureObject>("stormlands");
            CultureObject reach = MBObjectManager.Instance.GetObject<CultureObject>("reach");
            CultureObject ghiscari = MBObjectManager.Instance.GetObject<CultureObject>("ghiscari");
            CultureObject crownlands = MBObjectManager.Instance.GetObject<CultureObject>("crownlands");
            CultureObject braavosi = MBObjectManager.Instance.GetObject<CultureObject>("empire");
            CultureObject dorne = MBObjectManager.Instance.GetObject<CultureObject>("aserai");
            CultureObject ironIslands = MBObjectManager.Instance.GetObject<CultureObject>("sturgia");
            CultureObject north = MBObjectManager.Instance.GetObject<CultureObject>("battania");
            CultureObject westerlands = MBObjectManager.Instance.GetObject<CultureObject>("vlandia");
            CultureObject dothraki = MBObjectManager.Instance.GetObject<CultureObject>("khuzait");
            CultureObject sarnor = MBObjectManager.Instance.GetObject<CultureObject>("sarnor");
            CultureObject skagos = MBObjectManager.Instance.GetObject<CultureObject>("skagosi");
            CultureObject norvos = MBObjectManager.Instance.GetObject<CultureObject>("norvos");
            CultureObject volantine = MBObjectManager.Instance.GetObject<CultureObject>("volantine");
            CultureObject qohorik = MBObjectManager.Instance.GetObject<CultureObject>("qohorik");
            CultureObject lorathi = MBObjectManager.Instance.GetObject<CultureObject>("lorathi");
            CultureObject pentoshi = MBObjectManager.Instance.GetObject<CultureObject>("pentoshi");
            CultureObject myrish = MBObjectManager.Instance.GetObject<CultureObject>("myrish");
            CultureObject tyroshi = MBObjectManager.Instance.GetObject<CultureObject>("tyroshi");
            CultureObject lyseni = MBObjectManager.Instance.GetObject<CultureObject>("lyseni");
            CultureObject yiti = MBObjectManager.Instance.GetObject<CultureObject>("yiti");
            CultureObject summer = MBObjectManager.Instance.GetObject<CultureObject>("summer");
            
            MBReadOnlyList<CultureObject> cultureList = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();

            this.HighValyrian.Initialize(
                new TextObject("High Valyrian"), 
                new TextObject("High Valyrian is a language originating from Valyria and the Valyrian Freehold.High Valyrian is no longer widely spoken due to the Doom of Valyria,[6] and most Valyrian records were destroyed in the catastrophe. The tongues of the Free Cities have continued to evolve from the original High Valyrian."), 
                new List<CultureObject> { valyrian }, 
                this.GetIntelligibles(this.HighValyrian));

            this.LowValyrian.Initialize(
                new TextObject("Low Valyrian"),
                new TextObject("In the four centuries since Valyria's destruction, everyday use led the language spoken in different former provinces to grow into a dozen bastardized dialects from the Free Cities to Slaver's Bay, known as \"Low Valyrian\". Each Free City's dialect is on its way to be a separate language, but someone who is fluent in High Valyrian can communicate well enough."), 
                new List<CultureObject> { braavosi, norvos, volantine, qohorik, lorathi, pentoshi, myrish, tyroshi, lyseni }, 
                this.GetIntelligibles(this.LowValyrian));

            this.Westerosi.Initialize(
                new TextObject("Westerosi"), 
                new TextObject("The Common Tongue or Common Speech is a language commonly spoken in the Seven Kingdoms of Westeros. There are regional accents, but these do not result in a lack of comprehensibility."), 
                new List<CultureObject> { north, vale, river, dorne, stormlands, nightswatch, dragonstone, reach, ironIslands, westerlands }, 
                this.GetIntelligibles(this.Westerosi));

            this.Ghiscari.Initialize(
                new TextObject("Old Ghiscari"),
                new TextObject("Old Ghiscari is a largely extinct tongue. It was spoken five thousand years ago by the Ghiscari people of the Old Empire of Ghis, which was destroyed by the Valyrian Freehold. A mongrel tongue blending High Valyrian and Old Ghiscari is now the predominant language of Slaver's Bay, though Old Ghiscari is still spoken by some, and engraved Ghiscari glyphs can be found on various old objects."),
                new List<CultureObject> { ghiscari },
                this.GetIntelligibles(this.Ghiscari));

            this.Sarnori.Initialize(
                new TextObject("Sarnori"),
                new TextObject("Whilst an ancient language within Essos, there are hints and some roots of words and sayings that pre-date the Ghiscari Empire, even some Valyrian words would find a place in the Sarnori language. Like the science and religion, the language would evolve over the thousands of years since its birth. At its origin, Sarnori was a harsh and difficult to understand dialect, but as it has evolved, the language has smoothed and become malleable to new scripts."),
                new List<CultureObject> { sarnor },
                this.GetIntelligibles(this.Sarnori));

            this.YiTish.Initialize(
                new TextObject("Old Ghiscari"),
                new TextObject("Almost entirely unheard of in Westeros and the Free Cities, YiTish has been brought further west by exiles from the Golden Empire of Yi Ti. The YiTish language is thought to be a product of the ancient Great Empire of the Dawn."),
                new List<CultureObject> { yiti },
                this.GetIntelligibles(this.YiTish));

            this.Dothraki.Initialize(
                new TextObject("Dothraki"),
                new TextObject("The Dothraki language is the language spoken by the Dothraki, the indigenous nomadic horse people who roam the Dothraki sea in central Essos. It is known to be a rough, harsh language."),
                new List<CultureObject> { dothraki },
                this.GetIntelligibles(this.Dothraki));

            this.OldTongue.Initialize(
                new TextObject("The Old Tongue"),
                new TextObject("The Old Tongue is a language brought to Westeros by the First Men during their migration over twelve thousand years ago. It is a coarse language, harsh and clanging. The language is all but extinct in the Seven Kingdoms, where the Common Tongue has become dominant. In the lands beyond the Wall, however, the Old Tongue is still spoken by giants and most wildlings."),
                new List<CultureObject> { freefolk, skagos },
                this.GetIntelligibles(this.OldTongue));

            this.SummerTongue.Initialize(
                new TextObject("The Summer Tongue"),
                new TextObject("The Summer Tongue is the language used by the peoples of the Summer Islands. A curiousity to the inhabitants of Westeros and the Free Cities, this language lacks pronouns and a peculiar sentence structure."),
                new List<CultureObject> { summer },
                this.GetIntelligibles(this.SummerTongue));

            foreach (Language lang in All)
            {
                DefaultTypeInitializer<DefaultLanguages, Language>.Instance.AddObject(lang);
            }
        }

        private Dictionary<Language, float> GetIntelligibles(Language language)
        {
            string stringId = language.StringId;

            Dictionary<Language, float> intelligibles;
            switch (stringId)
            {
                case "language_high_valyrian":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            LowValyrian,
                            0.7f
                        },
                        {
                            Ghiscari,
                            0.3f
                        }
                    };
                    break;
                case "language_low_valyrian":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            HighValyrian,
                            0.5f
                        }
                    };
                    break;
                case "language_westerosi":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            OldTongue,
                            0.3f
                        }
                    };
                    break;
                case "language_ghiscari":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            HighValyrian,
                            0.15f
                        },
                        {
                            LowValyrian,
                            0.2f
                        }
                    };
                    break;
                case "language_sarnori":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            HighValyrian,
                            0.15f
                        },
                        {
                            LowValyrian,
                            0.2f
                        },
                        {
                            Ghiscari,
                            0.1f
                        }
                    };
                    break;
                case "language_yitish":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            HighValyrian,
                            0.05f
                        },
                        {
                            Dothraki,
                            0.05f
                        }
                    };
                    break;
                case "language_dothraki":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            HighValyrian,
                            0.05f
                        },
                        {
                            Ghiscari,
                            0.1f
                        }
                    };
                    break;
                case "language_old_tongue":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            Westerosi,
                            0.2f
                        }
                    };
                    break;
                case "language_summer_tongue":
                    intelligibles = new Dictionary<Language, float>()
                    {
                        {
                            HighValyrian,
                            0.1f
                        },
                        {
                            LowValyrian,
                            0.2f
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
