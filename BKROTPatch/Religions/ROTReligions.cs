using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BKROTPatch.Faiths;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.ObjectSystem;

namespace BKROTPatch.Religions
{
    internal class ROTReligions : DefaultTypeInitializer<ROTReligions, Religion>
    {
        public Religion Seven { get; } = new Religion("seven");
        public Religion OldGods { get; } = new Religion("old_gods");
        public Religion DrownedGod { get; } = new Religion("drowned_god");
        public Religion Rhllor { get; } = new Religion("rhllor");
        public Religion Vhugyahar { get; } = new Religion("vhugyahar");
        public Religion PearlDivinities { get; } = new Religion("pearl_divinities");
        public Religion HuesOfTrios { get; } = new Religion("hues_of_trios");
        public Religion PrincesMercies { get; } = new Religion("princes_mercies");
        public Religion GoldenGardens { get; } = new Religion("golden_gardens");
        public Religion Heritory { get; } = new Religion("heritory");
        public Religion BeardedGod { get; } = new Religion("bearded_god");
        public Religion ManyFacedGod { get; } = new Religion("many_faced_god");
        public Religion Pattern { get; } = new Religion("pattern");
        public Religion Josimakazma { get; } = new Religion("josimakazma");
        public Religion Boash { get; } = new Religion("boash");
        public Religion BlackGoat { get; } = new Religion("black_goat");
        public Religion FourteenFlames { get; } = new Religion("fourteen_flames");
        public Religion MotherRhoyne { get; } = new Religion("mother_rhoyne");
        public Religion GreatStallion { get; } = new Religion("great_stallion");
        public Religion Harpy { get; } = new Religion("harpy");
        public Religion Summer { get; } = new Religion("summer");
        public Religion YiTi { get; } = new Religion("yiti");

        public override IEnumerable<Religion> All {
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
            
            this.Seven.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Seven, 
                new List<CultureObject> { nightswatch, vale, river, dragonstone, stormlands, reach, crownlands, dorne, westerlands });

            this.OldGods.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.OldGods,
                new List<CultureObject> { freefolk, north, skagos, nightswatch });

            this.DrownedGod.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.DrownedGod,
                new List<CultureObject> { ironIslands });

            this.Rhllor.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Rhllor,
                new List<CultureObject> { dragonstone, volantine });

            this.Vhugyahar.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Vhugyahar,
                new List<CultureObject> { braavosi });

            this.PearlDivinities.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.PearlDivinities,
                new List<CultureObject> { lyseni });

            this.HuesOfTrios.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.HuesOfTrios,
                new List<CultureObject> { tyroshi });

            this.PrincesMercies.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.PrincesMercies,
                new List<CultureObject> { pentoshi });

            this.GoldenGardens.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.GoldenGardens,
                new List<CultureObject> { myrish });

            this.Heritory.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Heritory,
                new List<CultureObject> { volantine });

            this.BeardedGod.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.HuesOfTrios,
                new List<CultureObject> { norvos });

            this.ManyFacedGod.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.ManyFacedGod,
                new List<CultureObject> { braavosi });

            this.Pattern.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Pattern,
                new List<CultureObject> { lorathi });

            this.Josimakazma.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Josimakazma,
                new List<CultureObject> { sarnor });

            this.Boash.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Boash,
                new List<CultureObject> { qohorik });

            this.BlackGoat.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.BlackGoat,
                new List<CultureObject> { qohorik });

            this.FourteenFlames.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.FourteenFlames,
                new List<CultureObject> { valyrian });

            this.MotherRhoyne.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.MotherRhoyne,
                new List<CultureObject> { dorne });

            this.GreatStallion.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.GreatStallion,
                new List<CultureObject> { dothraki });

            this.Harpy.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Harpy,
                new List<CultureObject> { ghiscari });

            this.Summer.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.Summer,
                new List<CultureObject> { summer });

            this.YiTi.Initialize(DefaultTypeInitializer<ROTFaiths, Faith>.Instance.YiTi,
                new List<CultureObject> { yiti });

            foreach (Religion religion in All)
            {
                DefaultTypeInitializer<DefaultReligions, Religion>.Instance.AddObject(religion);
            }
        }
    }
}
