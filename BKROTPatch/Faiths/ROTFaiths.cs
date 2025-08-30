using BannerKings;
using BannerKings.Behaviours.Feasts;
using BannerKings.CampaignContent.Traits;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Doctrines;
using BannerKings.Managers.Institutions.Religions.Doctrines.Marriage;
using BannerKings.Managers.Institutions.Religions.Doctrines.War;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using BannerKings.Managers.Institutions.Religions.Faiths.Societies;
using BKROTPatch.Divinities;
using BKROTPatch.FaithGroups;
using BKROTPatch.Faiths.BKROTPatch.Faiths;
using BKROTPatch.Rites;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BKROTPatch.Faiths
{
    internal class ROTFaiths : DefaultTypeInitializer<ROTFaiths, Faith>
    {
        public PolytheisticFaith Seven = new SevenFaith();
        public PolytheisticFaith OldGods = new OldGodsFaith();
        public MonotheisticFaith DrownedGod = new DrownedGodFaith();
        public MonotheisticFaith Rhllor = new RhllorFaith();
        public PolytheisticFaith Vhugyahar = new VhugyaharFaith();
        public PolytheisticFaith PearlDivinities = new PearlDivinitiesFaith();
        public PolytheisticFaith HuesOfTrios = new HuesOfTriosFaith();
        public PolytheisticFaith PrincesMercies = new PrincesMerciesFaith();
        public PolytheisticFaith GoldenGardens = new GoldenGardensFaith();
        public PolytheisticFaith Heritory = new HeritoryFaith();
        public MonotheisticFaith BeardedGod = new BeardedGodFaith();
        public MonotheisticFaith ManyFacedGod = new ManyFacedGodFaith();
        public MonotheisticFaith Pattern = new PatternFaith();
        public MonotheisticFaith Josimakazma = new JosimakazmaFaith();
        public MonotheisticFaith Boash = new BoashFaith();
        public MonotheisticFaith BlackGoat = new BlackGoatFaith();
        public PolytheisticFaith FourteenFlames = new FourteenFlamesFaith();
        public MonotheisticFaith MotherRhoyne = new MotherRhoyneFaith();
        public MonotheisticFaith GreatStallion = new GreatStallionFaith();
        public MonotheisticFaith Harpy = new HarpyFaith();
        public PolytheisticFaith Summer = new SummerFaith();
        public PolytheisticFaith YiTi = new YiTiFaith();


        public override IEnumerable<Faith> All
        {
            get
            {
                yield return this.Seven;
                yield return this.OldGods;
                yield return this.DrownedGod;
                yield return this.Rhllor;
                yield return this.Vhugyahar;
                yield return this.PearlDivinities;
                yield return this.HuesOfTrios;
                yield return this.PrincesMercies;
                yield return this.GoldenGardens;
                yield return this.Heritory;
                yield return this.BeardedGod;
                yield return this.ManyFacedGod;
                yield return this.Pattern;
                yield return this.Josimakazma;
                yield return this.Boash;
                yield return this.BlackGoat;
                yield return this.FourteenFlames;
                yield return this.MotherRhoyne;
                yield return this.GreatStallion;
                yield return this.Harpy;
                yield return this.Summer;
                yield return this.YiTi;
                yield break;
            }
        }

        public override void Initialize()
        {
            this.Seven.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheFather, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheMother,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheMaiden,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheWarrior,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheSmith,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheCrone,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.TheStranger,
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Generosity,
                    true
                },
                {
                    DefaultTraits.Mercy,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.SevenGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new FatherSacrifice(),
                new MotherOffering(),
                new MaidenOffering(),
                new SmithOffering()
            }, new List<Society>(), Feast.FeastType.Normal);

            this.OldGods.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.OldGodsForest, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.OldGodsStream,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.OldGodsStone,
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Mercy,
                    true
                },
                {
                    DefaultTraits.Valor,
                    true
                },
                {
                    DefaultTraits.Honor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.OldGodsGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Druidism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.AncestorWorship,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Animism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new OldGodsForestOfferingFruit(),
                new OldGodsForestOfferingWood(),
                new OldGodsStoneOfferingMarble(),
                new OldGodsStoneOfferingIronOre(),
                new OldGodsStreamSacrifice(),
            }, new List<Society>(), Feast.FeastType.Normal);
            
            this.DrownedGod.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.DrownedGod, new List<Divinity>()
            , new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Generosity,
                    false
                },
                {
                    DefaultTraits.Mercy,
                    false
                },
                {
                    DefaultTraits.Valor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.IronBornGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Reavers,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new DrownedGodOfferingGrain(),
                new DrownedGodOfferingSalt(),
                new DrownedGodSacrifice()
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Rhllor.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Rhllor, new List<Divinity>
            {
                
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTraits.Mercy,
                    false
                },
                {
                    DefaultTraits.Valor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.RhllorGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Shamanism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new RhllorOfferingOil(),
                new RhllorOfferingSpice(),
                new RhllorSacrifice()
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Vhugyahar.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.MerlingKing, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.MoonPaleMaiden,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.LionOfNight,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.FatherOfWaters
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Diligent,
                    true
                },
                {
                    DefaultTraits.Honor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pacifism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new MerlingKingOffering(),
                new LionOfNightOfferingMeat(),
                new LionOfNightSacrifice(),
                new MoonPaleMaidenOffering(),
                new FatherOfWatersOffering(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.PearlDivinities.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.WeepingLady, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Pantera,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.YndrosOfTheTwilight,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Bakkalon,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Saagael,
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Mercy,
                    true
                },
                {
                    DefaultTraits.Generosity,
                    true
                },
                {
                    DefaultTraits.Honor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.AncestorWorship,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Childbirth,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare, new List<Rite>
            {
                new WeepingLadyOfferingWine(),
                new PanteraOffering(),
                new YndrosOfTheTwilightOffering(),
                new BakkalonSacrifice(),
                new SaagaelOffering(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.HuesOfTrios.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Trios, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Semosh,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Selloso,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.DrunkenGod,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Pattern,
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Mercy,
                    true
                },
                {
                    DefaultTraits.Valor,
                    true
                },
                {
                    DefaultTraits.Honor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Defensive,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Polygamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new TriosOffering(),
                new SemoshOffering(),
                new SellosoOffering(),
                new DrunkenGodOffering(),
                new PatternOfferingPapyrus(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.PrincesMercies.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.PrincelyArbiter, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.WeepingLady,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Pantera,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.FatherOfWaters,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.MaidenMadeOfLight,
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Mercy,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just,
                    true
                },
                {
                    DefaultTraits.Honor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Defensive,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Sacrifice
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new PrincelyArbiterOfferingFood(),
                new PrincelyArbiterOfferingGrain(),
                new WeepingLadyOfferingWine(),
                new PanteraOffering(),
                new FatherOfWatersOffering(),
                new MaidenMadeOfLightOffering(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.GoldenGardens.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Gelenei, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.AquanTheRedBull,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.HoodedWayfarer,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.SilentGod
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Mercy,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Diligent,
                    true
                },
                {
                    DefaultTraits.Generosity,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare, new List<Rite>
            {
                new GeleneiOfferingGrain(),
                new GeleneiOfferingWine(),
                new AquanOfferingMeat(),
                new AquanSacrifice(),
                new HoodedWayfarerOffering(),
                new SilentGodOffering(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Heritory.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.AquanTheRedBull, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.LionOfNight,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Semosh,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Selloso,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Pantera
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Generosity,
                    false
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTraits.Valor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new AquanOfferingMeat(),
                new AquanSacrifice(),
                new LionOfNightOfferingMeat(),
                new LionOfNightSacrifice(),
                new PanteraOffering(),
                new SemoshOffering(),
                new SellosoOffering(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.BeardedGod.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.BeardedGod, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Generosity,
                    false
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTraits.Valor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new BeardedGodSacrifice(),
                new BeardedGodOfferingTools(),
                new BeardedGodOfferingPapyrus(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.ManyFacedGod.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.ManyFacedGod, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Generosity,
                    false
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just,
                    true
                },
                {
                    DefaultTraits.Mercy,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Shamanism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Sacrifice,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new ManyFacedGodOfferingFood(),
                new ManyFacedGodOfferingTools(),
                new ManyFacedGodSacrifice(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Pattern.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Pattern, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Calculating,
                    true
                },
                {
                    DefaultTraits.Generosity,
                    false
                },
                {
                    DefaultTraits.Mercy,
                    false
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new PatternOfferingPapyrus(),
                new PatternOfferingWine(),
                new PatternOfferingJewelry()
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Josimakazma.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Josimakazma, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Valor,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTraits.Mercy,
                    false
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new JosimakazmaOfferingAnimals(),
                new JosimakazmaOfferingFood(),
                new JosimakazmaOfferingOil(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Boash.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Boash, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Valor,
                    false
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble,
                    true
                },
                {
                    DefaultTraits.Mercy,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pacifism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare, new List<Rite>()
            {
                new BoashOfferingGrain(),
                new BoashOfferingJewelry(),
                new BoashOfferingPapyrus(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.BlackGoat.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.BlackGoat, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Generosity,
                    false
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTraits.Mercy,
                    false
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.FreeCitiesGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Sacrifice,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new BlackGoatOfferingAnimals(),
                new BlackGoatOfferingLinen(),
                new BlackGoatSacrifice()
            }, new List<Society>(), Feast.FeastType.Normal);

            this.FourteenFlames.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.GodsFire, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.GodsBlood
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Valor,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.ValyrianGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Polygamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new GodsBloodOfferingFood(),
                new GodsBloodSacrifice(),
                new GodsFireOfferingMetal(),
                new GodsFireOfferingWood()
            }, new List<Society>(), Feast.FeastType.Normal);

            this.MotherRhoyne.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.MotherRhoyne, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Valor,
                    false
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    false
                },
                {
                    DefaultTraits.Mercy,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.MotherRhoyneGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pacifism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Childbirth,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Shamanism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare, new List<Rite>
            {
                new MotherRhoyneOfferingFood(),
                new MotherRhoyneOfferingJewelry(),
                new MotherRhoyneOfferingPottery(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.GreatStallion.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.GreatStallion, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Valor,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTraits.Mercy,
                    false
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.DothrakiGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Reavers,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.AncestorWorship,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Shamanism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Polygamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new GreatStallionOfferingAnimals(),
                new GreatStallionOfferingHorse(),
                new GreatStallionSacrifice(),
                new GreatStallionOfferingBeer(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Harpy.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.Harpy, new List<Divinity>
            {
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Valor,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.GhisGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.AncestorWorship,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Druidism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare, new List<Rite>
            {
                new HarpyOfferingBeer(),
                new HarpyOfferingTools(),
                new HarpySacrifice(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.Summer.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.GodsSummer, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.GodsPassion,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.GodsLove,
            }, new Dictionary<TraitObject, bool>
            {
                {
                    DefaultTraits.Mercy,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble,
                    true
                },
                {
                    DefaultTraits.Generosity,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.SummerGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pacifism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pastoralism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Animism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Polygamy, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare, new List<Rite>
            {
                new GodsSummerOffering(),
                new GodsPassionOffering(),
                new GodsLoveOffering(),
            }, new List<Society>(), Feast.FeastType.Normal);

            this.YiTi.Initialize(DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.GodOnEarth, new List<Divinity>
            {
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.MaidenMadeOfLight,
                DefaultTypeInitializer<ROTDivinities, Divinity>.Instance.LionOfNight,
            }, new Dictionary<TraitObject, bool>
            {
                {
                   DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just,
                    true
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    true
                },
                {
                    DefaultTraits.Honor,
                    true
                }
            }, DefaultTypeInitializer<ROTFaithGroups, FaithGroup>.Instance.YiTiGroup, new List<Doctrine>
            {
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Druidism,
                DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism
            }, DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage, DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation, new List<Rite>
            {
                new LionOfNightOfferingMeat(),
                new LionOfNightSacrifice(),
                new MaidenMadeOfLightOffering(),
                new GodOnEarthOfferingMetal(),
                new GodOnEarthOfferingInk(),
            }, new List<Society>(), Feast.FeastType.Normal);

            foreach (Faith faith in All)
            {
                DefaultTypeInitializer<DefaultFaiths, Faith>.Instance.AddObject(faith);
            }

        }
    }
}
