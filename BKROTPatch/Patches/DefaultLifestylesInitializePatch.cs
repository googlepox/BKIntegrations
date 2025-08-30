using BannerKings;
using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Lifestyles;
using BannerKings.Managers.Skills;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(DefaultLifestyles), "Initialize")]
    internal class DefaultLifestylesInitializePatch
    {
        public static bool Prefix(DefaultLifestyles __instance)
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

            MBReadOnlyList<CultureObject> cultures = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();

            __instance.Commander.Initialize(new TextObject("Commander", null), new TextObject("", null), DefaultSkills.Leadership, DefaultSkills.Tactics, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CommanderLogistician,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CommanderInspirer,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CommanderWarband
            }, new TextObject("{=Z87jdO67}Party supplies build up at a {EFFECT1}% slower rate.\nInfluence gain reduced by {EFFECT2}%, other than battle reward", null), 25f, 15f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Fian").SetValue(__instance, new Lifestyle("lifestyle_fian"));
            Lifestyle fian = __instance.Fian;
            TextObject textObject = new TextObject("Greenwood Fian", null);
            TextObject textObject2 = new TextObject("In the North, there are those called the Greenwood Fians, warriors whose forebears learned that the trees themselves were their greatest allies. From the shelter of the forests, a longbow loosed unseen could cut down knight and peasant alike, and when arrows failed, a greatsword finished the work. For generations, the longbow and the blade have been their hallmarks, a grim legacy of ambush and endurance. Unlike the lords of the South, they scorn the horse as a vanity, holding fast to the ways of the footsoldier — silent, deadly, and bound to the woods.", null);
            SkillObject bow = DefaultSkills.Bow;
            SkillObject twoHanded = DefaultSkills.TwoHanded;
            List<PerkObject> list = new List<PerkObject>();
            list.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.FianHighlander);
            list.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.FianRanger);
            list.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.FianFennid);
            fian.Initialize(textObject, textObject2, bow, twoHanded, list, new TextObject("{=tRp08jyH}Northern settlements have +{EFFECT1} militia\nReduced damage by {EFFECT2}% when mounted", null), 1.5f, 25f, null, north);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Cataphract").SetValue(__instance, new Lifestyle("lifestyle_cataphract"));
            Lifestyle cataphract = __instance.Cataphract;
            TextObject textObject3 = new TextObject("{=RWrMBAbv}Cataphract", null);
            TextObject textObject4 = new TextObject("Born from the martial legacy of Old Valyria, the cataphract traditions of the Free Cities remain among the most feared in Essos. Armored rider and barded steed move as one, a wall of steel thundering across the field. These warriors are trained not only to crush infantry beneath their lances, but to withstand the charges of foreign horse from the grasslands and the deserts alike. Yet their Valyrian discipline sets them apart: they practice swift redeployments, feigned retreats, and skirmishing maneuvers, adapting to battle’s flow without ever surrendering the awe of their glittering mail and unyielding strength.", null);
            SkillObject polearm = DefaultSkills.Polearm;
            SkillObject riding = DefaultSkills.Riding;
            List<PerkObject> list2 = new List<PerkObject>();
            list2.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CataphractEquites);
            list2.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CataphractAdaptiveTactics);
            list2.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CataphractKlibanophoros);
            cataphract.Initialize(textObject3, textObject4, polearm, riding, list2, new TextObject("{=y2zNEeT5}Increased renown from victories by {EFFECT1}%\nNon-cavalry units need {EFFECT2}% more experience to upgrade", null), 12f, 25f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Diplomat").SetValue(__instance, new Lifestyle("lifestyle_diplomat"));
            __instance.Diplomat.Initialize(new TextObject("{=uc7xjTQv}Diplomat", null), new TextObject("The Diplomat is a master of tongues and tempers, one who bends quarrels into compromise and forges peace where steel would otherwise decide the matter. In a world of feuding kings and grasping lords, such a figure weaves alliances with words as deftly as any knight wields a sword. Though often dismissed as soft by the warlike, the Diplomat’s victories endure in parchments and oaths, binding realms together long after the battlefield has been forgotten.", null), DefaultSkills.Charm, BKSkills.Instance.Lordship, new List<PerkObject>(), new TextObject("{=!}", null), 0f, 0f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "August").SetValue(__instance, new Lifestyle("lifestyle_august"));
            __instance.August.Initialize(new TextObject("August", null), new TextObject("Among the Free Cities, the title of August is bestowed upon a lord whose stature eclipses his peers. Such rulers are not only cunning stewards of their domains, but also men and women of the sword, leading their hosts in person against all who would threaten their rule. To be named August is to be remembered—not merely as a lord, but as a figure of history, whose governance and valor stand as the measure of what true lordship should be.", null), DefaultSkills.Leadership, BKSkills.Instance.Lordship, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.AugustCommander,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.AugustDeFacto,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.AugustDeJure,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.AugustKingOfKings
            }, new TextObject("{=H1igmZMn}1 knight less is counted towards vassal limit\nTrade penalty increased by {EFFECT2}%", null), 1f, 20f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "SiegeEngineer").SetValue(__instance, new Lifestyle("lifestyle_siegeEngineer"));
            __instance.SiegeEngineer.Initialize(new TextObject("{=brd9F4gY}Siege Engineer", null), new TextObject("Masters of stone, timber, and fire, Siege Engineers are the silent architects of conquest. Where others see walls as impenetrable, they see weaknesses to be pried apart with rams, towers, and engines of war. More than mere builders, they are tacticians of destruction, directing the thunder of catapults and the slow grind of siegeworks until proud fortresses fall. To the people, they are dreaded harbingers—proof that no gate is unbreakable, and no lord’s walls eternal.", null), DefaultSkills.Engineering, DefaultSkills.Tactics, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.SiegeEngineer,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.SiegePlanner,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.SiegeOverseer
            }, new TextObject("{=oNcfLnCB}Party expenses are {EFFECT1}% cheaper during sieges\nSettlements of different culture have {EFFECT2}% more autonomy", null), 30f, 10f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "CivilAdministrator").SetValue(__instance, new Lifestyle("lifestyle_civilAdministrator"));
            __instance.CivilAdministrator.Initialize(new TextObject("{=EJEkuBZ4}Civil Administrator", null), new TextObject("Civil Administrators are the architects of order, their craft measured not in sword-strokes but in stone set, roads paved, and accounts balanced. They oversee the digging of canals, the raising of walls, and the keeping of ledgers, ensuring that the lifeblood of the realm—its harvests, coin, and people—flows without waste. Where others see only chaos, they see design; where others squander, they preserve. Lords may win realms with steel, but it is the administrator’s hand that keeps them standing, their works enduring long after banners have fallen.", null), DefaultSkills.Engineering, DefaultSkills.Steward, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CivilEngineer,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CivilCultivator,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CivilManufacturer,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CivilOverseer
            }, new TextObject("{=v0bOk0Y9}Reduced demesne weight of towns by {EFFECT1}%\nParty size reduced by {EFFECT2}%", null), 20f, 15f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Caravaneer").SetValue(__instance, new Lifestyle("lifestyle_caravaneer"));
            __instance.Caravaneer.Initialize(new TextObject("{=F5aAvvhD}Caravaneer", null), new TextObject("Caravaneers are the lifeblood of long roads and distant horizons, masters of coin and survival alike. They bind cities, castles, and villages together with strings of laden wagons and pack beasts, carrying spices, silks, and steel where few dare tread. More than mere merchants, they are logisticians, scouts, and envoys, skilled in bargaining at the counting tables and warding off bandits on the open road. A caravaneer thrives where danger and opportunity meet, for they know that fortune favors those bold enough to carry it across deserts, mountains, and war-torn lands.", null), DefaultSkills.Trade, DefaultSkills.Scouting, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CaravaneerStrider,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CaravaneerDealer,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.CaravaneerOutsideConnections
            }, new TextObject("{=1UEN6xUV}Reduced trade penalty by {EFFECT1}%\nReduced speed during nighttime by {EFFECT2}%", null), 10f, 8f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Artisan").SetValue(__instance, new Lifestyle("lifestyle_artisan"));
            __instance.Artisan.Initialize(new TextObject("{=RUtaPqBv}Artisan", null), new TextObject("{=VOV4Shbm}Essential to the economy, artisans produce manufactured goods in high demand, such as high quality textiles, tools, beer, and much more. As one inclined to the artisan world, you have keen insight into crafting and managing your workshops.", null), DefaultSkills.Crafting, DefaultSkills.Trade, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.ArtisanSmith,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.ArtisanCraftsman,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.ArtisanEntrepeneur
            }, new TextObject("{=mV7M6SgW}Chance of botching items when smithing reduced by {EFFECT1}%\nRecruiting troops is {EFFECT2}% more expensive", null), 10f, 15f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Outlaw").SetValue(__instance, new Lifestyle("lifestyle_outlaw"));
            __instance.Outlaw.Initialize(new TextObject("{=GTYYnH9E}Outlaw", null), new TextObject("{=WRbLY55G}Universally shamed, yet universally present, no realm can fully rid itself of outlaws. More 'professional' outlaws will specialize in efficient plundering, speed and furtiveness to avoid law enforcement. Known outlaws often become notorious for kidnapping nobles and demanding unfair ransoms.", null), DefaultSkills.Roguery, DefaultSkills.Scouting, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.OutlawKidnapper,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.OutlawPlunderer,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.OutlawNightPredator
            }, new TextObject("{=gkaq9L2T}Bandit troops are {EFFECT1}% faster on map\nRandomly lose relations with heroes that disapprove criminality when leaving dialogue", null), 10f, 8f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Mercenary").SetValue(__instance, new Lifestyle("lifestyle_mercenary"));
            __instance.Mercenary.Initialize(new TextObject("{=kLHXZnLY}Mercenary", null), new TextObject("Mercenaries are soldiers for coin, their loyalty bound not to kings or lords, but to the weight of a purse and the promise of survival. They march across realms and battlefields alike, trading steel for gold, skill for pay. Some fight with honor, some with cunning, but all know the hazards of war, the hunger of winter, and the fickle favor of those who hire them. Though looked upon with suspicion by nobles, mercenaries carry the strength of entire armies, and their blades often decide the fate of lands far from home.", null), DefaultSkills.Leadership, DefaultSkills.Roguery, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.MercenaryLocalConnections,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.MercenaryRansacker,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.MercenaryFamousSellswords
            }, new TextObject("{=mAta6M84}Influence is {EFFECT1}% more profitable as mercenary\nSettlement stability reduced by {EFFECT2}%", null), 20f, 10f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Kheshig").SetValue(__instance, new Lifestyle("lifestyle_kheshig"));
            Lifestyle kheshig = __instance.Kheshig;
            TextObject textObject5 = new TextObject("{=sccoC5ta}Kheshig", null);
            TextObject textObject6 = new TextObject("{=TbzJaXUV}Kheshig is the way of life adopted by the eastern nomads, the Dothraki and Jogos Nhai, as an adaptation to the harsh steppe life. Kheshig travel in large groups of mounted warriors, often with many spare horses and cattle heads. These feed the horde with dairy and meat. They are known for expert mounted archery skirmishing, and merciless raiding. Yet, Kheshig have a profound sense of respect to those born in the steppes, and find honor in serving a strong leader.", null);
            SkillObject riding2 = DefaultSkills.Riding;
            SkillObject bow2 = DefaultSkills.Bow;
            List<PerkObject> list3 = new List<PerkObject>();
            list3.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.KheshigRaider);
            list3.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.KheshigOutrider);
            list3.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.KheshigHonorGuard);
            kheshig.Initialize(textObject5, textObject6, riding2, bow2, list3, new TextObject("{=BWoMogUy}Party size increased by {EFFECT1}%\nNon-Khuzait troops negatively affect morale by {EFFECT2}%", null), 15f, 0.5f, null, cultures.First((CultureObject x) => x.StringId == "khuzait"));
            
            AccessTools.Property(typeof(DefaultLifestyles), "Varyag").SetValue(__instance, new Lifestyle("lifestyle_varyag"));
            Lifestyle varyag = __instance.Varyag;
            TextObject textObject7 = new TextObject("Sea-Reaver", null);
            TextObject textObject8 = new TextObject("Among the Ironborn, Sea-Reavers are men and women of daring, renown, and skill upon both ship and shore. They prove themselves in boarding actions, coastal raids, and the fierce clash of axes on the decks of longships. Adventure and plunder call to them, and many serve as mercenaries or strike against foes far from their home isles—though never against kin. Yet courage and honor define them: a Sea-Reaver who shirks danger or breaks his word is no true warrior. Those who uphold the unwritten code are revered as Salt-Born, the paragon of Ironborn valor and sea-bound glory.", null);
            SkillObject athletics = DefaultSkills.Athletics;
            SkillObject oneHanded = DefaultSkills.OneHanded;
            List<PerkObject> list4 = new List<PerkObject>();
            list4.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.VaryagShieldBrother);
            list4.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.VaryagRecognizedMercenary);
            list4.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.VaryagDrengr);
            varyag.Initialize(textObject7, textObject8, athletics, oneHanded, list4, new TextObject("{=0HiZjcrv}Infantry troops are {EFFECT1}% faster on the map\nYou and your formation deal {EFFECT2}% less damage when mounted", null), 8f, 20f, null, cultures.First((CultureObject x) => x.StringId == "sturgia"));
            
            AccessTools.Property(typeof(DefaultLifestyles), "Gladiator").SetValue(__instance, new Lifestyle("lifestyle_gladiator"));
            __instance.Gladiator.Initialize(new TextObject("{=wTyw0yfR}Gladiator", null), new TextObject("Among the Free Cities, gladiatorial combat has become a celebrated form of both sport and spectacle. Born from earlier dueling traditions of Old Ghis, it was refined into grand contests within arenas, where skill and bravery are tested before the eyes of the city. Even a warrior of little renown may prove his worth upon the sands, drawing the gaze of lords, merchants, and patrons alike. Success in the arena can turn a nameless fighter into a figure of fame, whose deeds earn coin, prestige, and the notice of those who hold power.", null), DefaultSkills.Athletics, DefaultSkills.Riding, new List<PerkObject>
            {
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.GladiatorPromisingAthlete,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.GladiatorTourDeCalradia,
                DefaultTypeInitializer<BKPerks, PerkObject>.Instance.GladiatorCrowdsFavorite
            }, new TextObject("{=ycDyfToX}Combat experience in tournaments increased by {EFFECT1}%\nTrade penalty increased by {EFFECT2}%", null), 200f, 20f, null, null);
            
            AccessTools.Property(typeof(DefaultLifestyles), "Ritter").SetValue(__instance, new Lifestyle("lifestyle_ritter"));
            Lifestyle ritter = __instance.Ritter;
            TextObject textObject9 = new TextObject("{=axhJNG0M}Ritter", null);
            TextObject textObject10 = new TextObject("Among the Reachmen, the title of Ritter is given to lords who distinguish themselves both on the battlefield and in their halls. These men ride at the head of their banners, lances and swords ready, striking with the disciplined fury that makes Reach cavalry feared across the realm. In times of peace, they tend their demesnes and steward their villages, ensuring harvests and the loyalty of their people. To those beyond the Reach, they are best known for the earth-shaking thunder of their mounted charges, the discipline of their knights, and the honor they carry into every field of battle.", null);
            SkillObject lordship = BKSkills.Instance.Lordship;
            SkillObject riding3 = DefaultSkills.Riding;
            List<PerkObject> list5 = new List<PerkObject>();
            list5.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.RitterIronHorses);
            list5.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.RitterOathbound);
            list5.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.RitterPettySuzerain);
            ritter.Initialize(textObject9, textObject10, lordship, riding3, list5, new TextObject("{=2Gdz90YP}You and melee cavalry in your formation deals {EFFECT1}% more melee damage.{EFFECT1}%\nYou and your formation deal {EFFECT2}% less ranged damaged, mounted or otherwise.", null), 5f, 15f, null, cultures.First((CultureObject x) => x.StringId == "reach"));
            
            AccessTools.Property(typeof(DefaultLifestyles), "Jawwal").SetValue(__instance, new Lifestyle("lifestyle_jawwal"));
            Lifestyle jawwal = __instance.Jawwal;
            TextObject textObject11 = new TextObject("Sandborn", null);
            TextObject textObject12 = new TextObject("{=2KnmOUbx}The Sandborn represent a traditional and conservative way of living in the southern deserts of Dorne. Relying on their camels for mobility, carrying goods and even food, they have mastered survival on the sandy dunes, and are known for raiding and harassing tactics, specially with mounted skirmishing.", null);
            SkillObject throwing = DefaultSkills.Throwing;
            SkillObject riding4 = DefaultSkills.Riding;
            List<PerkObject> list6 = new List<PerkObject>();
            list6.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.JawwalGhazw);
            list6.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.JawwalCamelMaster);
            list6.Add(DefaultTypeInitializer<BKPerks, PerkObject>.Instance.JawwalDuneRider);
            jawwal.Initialize(textObject11, textObject12, throwing, riding4, list6, new TextObject("{=09Uwsivs}Party consumes {EFFECT1}% less food while on deserts\nDemesne limit reduced by {EFFECT2}%", null), 30f, 15f, null, cultures.First((CultureObject x) => x.StringId == "aserai"));
            return false;
        }
    }
}
