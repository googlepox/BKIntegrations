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
    public class DefaultLanguageTypesAddOn : DefaultTypeInitializer<DefaultLanguageTypesAddOn, Language>
    {
        public Language Vagiric
        {
            get; private set;
        }
        public Language Lyrion
        {
            get; private set;
        }
        public Language Nordic
        {
            get; private set;
        }
        public Language Apolssalian
        {
            get; private set;
        }
        public Language Palaic
        {
            get; private set;
        }

        public override IEnumerable<Language> All
        {
            get
            {
                yield return this.Vagiric;
                yield return this.Lyrion;
                yield return this.Nordic;
                yield return this.Apolssalian;
                yield return this.Palaic;
            }
        }

        public override void Initialize()
        {
            CultureObject vagir = MBObjectManager.Instance.GetObject<CultureObject>("vagir");
            CultureObject lyrion = MBObjectManager.Instance.GetObject<CultureObject>("lyrion");
            CultureObject nordling = MBObjectManager.Instance.GetObject<CultureObject>("nordling");
            CultureObject apolssalian = MBObjectManager.Instance.GetObject<CultureObject>("apolssalian");
            CultureObject paleician = MBObjectManager.Instance.GetObject<CultureObject>("paleician");
            MBReadOnlyList<CultureObject> objectTypeList = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            this.Vagiric = new Language("language_vagiric");
            this.Lyrion = new Language("language_lyrion");
            this.Nordic = new Language("language_nordic");
            this.Apolssalian = new Language("language_apolssalian");
            this.Palaic = new Language("language_palaic");
            this.Vagiric.Initialize(new TextObject("Vagiric"), new TextObject("Vagiric is a relatively new language in Calradia, a rich and diverse mixture of Sturgian syntax and Battanian vocabulary. The ancient Sturgian language remains relatively strong in the form of Vagiric, although outside influences can clearly be seen in Battanian, Calradic, and Palaic influences."), new List<CultureObject> { vagir }, this.GetIntelligibles(this.Vagiric));
            this.Lyrion.Initialize(new TextObject("Lyrion"), new TextObject("Although few Calradians speak Lyrion and even fewer still have been to Lyria, the recent influx of Lyrion soldiers and outposts have led to a rise in linguistic trade and many merchants to southern lands now need to speak it. It is described as \'totally foreign\', and bears little to no similarities with Aseran. "), new List<CultureObject> { lyrion }, this.GetIntelligibles(this.Lyrion));
            this.Nordic.Initialize(new TextObject("Nordic"), new TextObject("Hailing from the lands of Jumne to the far north, the Nords carried their ancient language with them to the south. The Nordic language has seen derivatives in the form of Sturgian and even further Vagiric, and some scholars have been puzzled by ancient Palaic words bearing Nordic origins, suggesting the Nords had frequent contact with Calradia for longer than initially thought."), new List<CultureObject> { nordling }, this.GetIntelligibles(this.Nordic));
            this.Apolssalian.Initialize(new TextObject("Apolssalian"), new TextObject("Apolssaly is said to be a beautiful trading kingdom situated along an inland bay to the southwest of Calradia, and its language is equally rich and beautiful. Apolssalian bears influences from countless other languages, including Asera, Calradic, and even hints of the Balic language far to the west."), new List<CultureObject> { apolssalian }, this.GetIntelligibles(this.Apolssalian));
            this.Palaic.Initialize(new TextObject("Palaic"), new TextObject("Though thought to be nearly extinct due to centuries of Imperial Oppression, the recent uprising by the Palaic people has seen a renaissance of the indigenous language. Although there once were countless dialects of Palaic due to the tribal nature of Palaic society, there now remains only one; a bastardized version of the ancient language intermingled with Calradic syntax and vocubulary. This only gives the Palaic people more reason to fight the Empire, and they hope to one day be free to speak their natural language once more."), new List<CultureObject> { paleician }, this.GetIntelligibles(this.Palaic));
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
                case "language_vagiric":
                    intelligibles = new Dictionary<Language, float>()
                {
                    {
                        DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Sturgian,
                        0.3f
                    },
                    {
                        DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Battanian,
                        0.3f
                    }
                };
                    break;
                case "language_lyrion":
                    intelligibles = new Dictionary<Language, float>()
                {
                    {
                        DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Aseran,
                        0.05f
                    }
                };
                    break;
                case "language_nordic":
                    intelligibles = new Dictionary<Language, float>()
                {
                    {
                        DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Sturgian,
                        0.5f
                    },
                    {
                        this.Vagiric,
                        0.3f
                    }
                };
                    break;
                case "language_apolssalian":
                    intelligibles = new Dictionary<Language, float>()
                {
                {
                    DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Aseran,
                    0.15f
                },
                {
                    DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Calradian,
                    0.1f
                }
                };
                    break;
                case "language_palaic":
                    intelligibles = new Dictionary<Language, float>()
                {
                {
                    DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Battanian,
                    0.15f
                },
                {
                    DefaultTypeInitializer<DefaultLanguages, Language>.Instance.Calradian,
                    0.2f
                },
                {
                    this.Vagiric,
                    0.1f
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
