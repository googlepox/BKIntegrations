using BannerKings;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Institutions.Religions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BKROTPatch.Divinities
{
    internal class ROTDivinities : DefaultTypeInitializer<ROTDivinities, Divinity>
    {
        // The Seven
        public Divinity TheFather { get; } = new Divinity("TheFather");
        public Divinity TheMother { get; } = new Divinity("TheMother");
        public Divinity TheMaiden { get; } = new Divinity("TheMaiden");
        public Divinity TheWarrior { get; } = new Divinity("TheWarrior");
        public Divinity TheSmith { get; } = new Divinity("TheSmith");
        public Divinity TheCrone { get; } = new Divinity("TheCrone");
        public Divinity TheStranger { get; } = new Divinity("TheStranger");

        // The Old Gods
        public Divinity OldGodsStream { get; } = new Divinity("OldGodsStream");
        public Divinity OldGodsForest { get; } = new Divinity("OldGodsForest");
        public Divinity OldGodsStone { get; } = new Divinity("OldGodsStone");

        // Drowned God
        public Divinity DrownedGod { get; } = new Divinity("DrownedGod");

        // Rhllor
        public Divinity Rhllor { get; } = new Divinity("Rhllor");
        public Divinity GreatOther { get; } = new Divinity("GreatOther");

        // Free Cities Gods
        public Divinity MoonPaleMaiden { get; } = new Divinity("MoonPaleMaiden");
        public Divinity LionOfNight { get; } = new Divinity("LionOfNight");
        public Divinity FatherOfWaters { get; } = new Divinity("FatherOfWaters");
        public Divinity MerlingKing { get; } = new Divinity("MerlingKing");
        public Divinity WeepingLady { get; } = new Divinity("WeepingLady");
        public Divinity Pantera { get; } = new Divinity("Pantera");
        public Divinity YndrosOfTheTwilight { get; } = new Divinity("YndrosOfTheTwilight");
        public Divinity Bakkalon { get; } = new Divinity("Bakkalon");
        public Divinity Saagael { get; } = new Divinity("Saagael");
        public Divinity Trios { get; } = new Divinity("Trios");
        public Divinity Semosh { get; } = new Divinity("Semosh");
        public Divinity Selloso { get; } = new Divinity("Selloso");
        public Divinity DrunkenGod { get; } = new Divinity("DrunkenGod");
        public Divinity Pattern { get; } = new Divinity("Pattern");
        public Divinity PrincelyArbiter { get; } = new Divinity("PrincelyArbiter");
        public Divinity AquanTheRedBull { get; } = new Divinity("AquanTheRedBull");
        public Divinity HoodedWayfarer { get; } = new Divinity("HoodedWayfarer");
        public Divinity SilentGod { get; } = new Divinity("SilentGod");
        public Divinity Gelenei { get; } = new Divinity("Gelenei");
        public Divinity BeardedGod { get; } = new Divinity("BeardedGod");
        public Divinity ManyFacedGod { get; } = new Divinity("ManyFacedGod");
        public Divinity Josimakazma { get; } = new Divinity("Josimakazma");
        public Divinity Boash { get; } = new Divinity("Boash");
        public Divinity BlackGoat { get; } = new Divinity("BlackGoat");

        // Valyrian Gods
        public Divinity GodsFire { get; } = new Divinity("GodsFire");
        public Divinity GodsBlood { get; } = new Divinity("GodsBlood");
        
        // Mother Rhoyne
        public Divinity MotherRhoyne { get; } = new Divinity("MotherRhoyne");

        // Dothraki Gods
        public Divinity GreatStallion { get; } = new Divinity("GreatStallion");

        // Summer Gods
        public Divinity GodsSummer { get; } = new Divinity("GodsSummer");
        public Divinity GodsPassion { get; } = new Divinity("GodsPassion");
        public Divinity GodsLove { get; } = new Divinity("GodsLove");

        // Ghis Gods
        public Divinity Harpy { get; } = new Divinity("Harpy");

        // Yi Ti Gods
        public Divinity GodOnEarth { get; } = new Divinity("GodOnEarth");
        public Divinity MaidenMadeOfLight { get; } = new Divinity("MaidenMadeOfLight");

        public override IEnumerable<Divinity> All
        {
            get
            {
                yield return this.TheFather;
                yield return this.TheMother;
                yield return this.TheMaiden;
                yield return this.TheWarrior;
                yield return this.TheSmith;
                yield return this.TheCrone;
                yield return this.TheStranger;
                yield return this.OldGodsForest;
                yield return this.OldGodsStone;
                yield return this.OldGodsStream;
                yield return this.DrownedGod;
                yield return this.Rhllor;
                yield return this.GreatOther;
                yield return this.MoonPaleMaiden;
                yield return this.LionOfNight;
                yield return this.FatherOfWaters;
                yield return this.MerlingKing;
                yield return this.WeepingLady;
                yield return this.Pantera;
                yield return this.YndrosOfTheTwilight;
                yield return this.Bakkalon;
                yield return this.Saagael;
                yield return this.Trios;
                yield return this.Semosh;
                yield return this.Selloso;
                yield return this.DrunkenGod;
                yield return this.Pattern;
                yield return this.PrincelyArbiter;
                yield return this.AquanTheRedBull;
                yield return this.HoodedWayfarer;
                yield return this.SilentGod;
                yield return this.Gelenei;
                yield return this.BeardedGod;
                yield return this.ManyFacedGod;
                yield return this.Josimakazma;
                yield return this.Boash;
                yield return this.BlackGoat;
                yield return this.GodsFire;
                yield return this.GodsBlood;
                yield return this.MotherRhoyne;
                yield return this.GreatStallion;
                yield return this.GodsSummer;
                yield return this.GodsPassion;
                yield return this.GodsLove;
                yield return this.Harpy;
                yield return this.GodOnEarth;
                yield return this.MaidenMadeOfLight;
                yield break;
            }
        }

        public override void Initialize()
        {
            this.TheFather.Initialize(
                new TextObject("The Father", null), 
                new TextObject("The Father represents judgement. He is depicted as a bearded man who carries scales. He is prayed to for justice.", null), 
                new TextObject("Increased settlement loyalty{newline}Increased troop morale{newline}Increased legitimacy", null), 
                new TextObject("", null), 
                200, 
                new TextObject("The Father represents judgement. He is depicted as a bearded man who carries scales. He is prayed to for justice.", null), 
                new TextObject("Justice, authority, protection, and governance are the domains of The Father.", null), 
                Settlement.All.First((Settlement x) => x.StringId == "town_EW4"), null);
            this.TheMother.Initialize(
                new TextObject("The Mother", null),
                new TextObject("The Mother represents motherhood and nurturing. She is prayed to for fertility or compassion, and is depicted as smiling with love, embodying the concept of mercy.", null),
                new TextObject("Piety gain for every child born{newline}Increased recovery of wounded troops{newline}Increased fertility", null),
                new TextObject("", null),
                200,
                new TextObject("The Mother represents motherhood and nurturing. She is prayed to for fertility or compassion, and is depicted as smiling with love, embodying the concept of mercy.", null),
                new TextObject("Nurturing, fertility, mercy, and protection of the vulnerable are the domains of The Mother.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_V2"), null);
            this.TheWarrior.Initialize(
                new TextObject("The Warrior", null),
                new TextObject("The Warrior represents strength in battle. He is prayed to for courage and victory. He carries a sword.", null),
                new TextObject("Increased troop morale{newline}Decreased army influence costs & cohesion loss{newline}Increased influence and renown from battles", null),
                new TextObject("", null),
                200,
                new TextObject("The Warrior represents strength in battle. He is prayed to for courage and victory. He carries a sword.", null),
                new TextObject("Valor, courage, military leadership, and protection of the innocent are the domains of The Warrior.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_V9"), null);
            this.TheSmith.Initialize(
                new TextObject("The Smith", null),
                new TextObject("The Smith represents crafts and labour, and portrayed with a hammer. He is usually prayed to when work needs to be done, for strength.", null),
                new TextObject("Improved trade penalties{newline}Increased workshop production quality{newline}Increased village production", null),
                new TextObject("", null),
                200,
                new TextObject("The Smith represents crafts and labour, and portrayed with a hammer. He is usually prayed to when work needs to be done, for strength.", null),
                new TextObject("Craftsmanship, industry, tools, and weaponry are the domains of The Smith.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_V5"), null);
            this.TheMaiden.Initialize(
                new TextObject("The Maiden", null),
                new TextObject("The Maiden represents innocence and chastity. She is usually prayed to protect a maiden's virtue.", null),
                new TextObject("Increased recovery of wounded troops{newline}Increased lifespan (reduced old age death chance){newline}Decreased chance of troops dying in battle", null),
                new TextObject("", null),
                200,
                new TextObject("The Maiden represents innocence and chastity. She is usually prayed to protect a maiden's virtue.", null),
                new TextObject("Compassion, protection, healing, and guidance of youth and families are the domains of The Maiden.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_EW3"), null);
            this.TheCrone.Initialize(
                new TextObject("The Crone", null),
                new TextObject("The Crone represents wisdom and is prayed to for guidance. Her statues often show her with a lamp in one hand.", null),
                new TextObject("Decreased army cohesion loss{newline}Increased party movement speed{newline}Improved relations with notables over 50", null),
                new TextObject("", null),
                200,
                new TextObject("The Crone represents wisdom and is prayed to for guidance. Her statues often show her with a lamp in one hand.", null),
                new TextObject("Wisdom, foresight, guidance, and preparation for the end are the domains of The Crone.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_EN1"), null);
            this.TheStranger.Initialize(
                new TextObject("The Stranger", null),
                new TextObject("The Stranger represents death and the unknown, and he leads the dead to the other world. Whilst referred to as male, he is neither male nor female.", null),
                new TextObject("Increased party morale when outnumbered{newline}Increased lifespan (reduced old age death chance){newline}Stronger claim to captured fiefs", null),
                new TextObject("", null),
                200,
                new TextObject("The Stranger represents death and the unknown, and he leads the dead to the other world. Whilst referred to as male, he is neither male nor female.", null),
                new TextObject("Death, fate, mystery, and the unknown are the domains of The Stranger.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_V6"), null);
            this.OldGodsForest.Initialize(
                new TextObject("Old Gods of the Forest", null),
                new TextObject("The old gods are nameless deities of stream, forest, and stone worshiped in the Seven Kingdoms of Westeros and beyond the Wall.", null),
                new TextObject("Increased party movement speed in forested regions{newline}Increased lumber village productivity{newline}Increased troop morale in forested terrain", null),
                new TextObject("", null),
                200,
                new TextObject("The old gods are nameless deities of stream, forest, and stone worshiped in the Seven Kingdoms of Westeros and beyond the Wall.", null),
                new TextObject("Wilderness, growth, stealth, and resilience are the domains of the Old Gods of the Forest.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_B2"), null);
            this.OldGodsStream.Initialize(
                new TextObject("Old Gods of the Stream", null),
                new TextObject("The old gods are nameless deities of stream, forest, and stone worshiped in the Seven Kingdoms of Westeros and beyond the Wall.", null),
                new TextObject("Increased party movement speed along rivers{newline}Increased recovery of wounded troops{newline}Increased caravan income", null),
                new TextObject("", null),
                200,
                new TextObject("The old gods are nameless deities of stream, forest, and stone worshiped in the Seven Kingdoms of Westeros and beyond the Wall.", null),
                new TextObject("Rivers, fertility, prosperity, and water are the domains of the Old Gods of the Stream.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_B3"), null);
            this.OldGodsStone.Initialize(
                new TextObject("Old Gods of Stone", null),
                new TextObject("The old gods are nameless deities of stream, forest, and stone worshiped in the Seven Kingdoms of Westeros and beyond the Wall.", null),
                new TextObject("Increased party movement speed in mountainous terrain{newline}Increased fief stability{newline}Increased settlement loyalty", null),
                new TextObject("", null),
                200,
                new TextObject("The old gods are nameless deities of stream, forest, and stone worshiped in the Seven Kingdoms of Westeros and beyond the Wall.", null),
                new TextObject("Fortitude, endurance, fortifications, and resilience are the domains of the Old Gods of Stone.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_S7"), null);
            this.DrownedGod.Initialize(
                new TextObject("The Drowned God", null),
                new TextObject("The Drowned God, also known as He Who Dwells Beneath the Waves, is a sea deity worshipped by the ironborn of the Iron Islands in Westeros. The religion of the Drowned God is old, dating back to before the coming of the Andals, and the attempts of the Andal invaders to supplant it with the Seven all failed. The Drowned God religion supports the ironmen's naval, pirate culture.", null),
                new TextObject("Renown gain for every successful raid{newline}Increased party movement speed when sailing{newline}Increased troop morale when leading offensive battles", null),
                new TextObject("", null),
                200,
                new TextObject("The Drowned God, also known as He Who Dwells Beneath the Waves, is a sea deity worshipped by the ironborn of the Iron Islands in Westeros. The religion of the Drowned God is old, dating back to before the coming of the Andals, and the attempts of the Andal invaders to supplant it with the Seven all failed. The Drowned God religion supports the ironmen's naval, pirate culture.", null),
                new TextObject("Sea, strength through hardship, raiding, and naval dominance are the domains of the Drowned God.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_S3"), null);
            this.Rhllor.Initialize(
                new TextObject("R'hllor", null),
                new TextObject("R'hllor, also known as the Lord of Light, the Heart of Fire, the God of Flame and Shadow, is a prominent god in Essos, but has only a few followers in Westeros, where he is more commonly known as the red god. The symbol of R'hllor the Red is a fiery heart. Red priests lead prayers to R'hllor at red temples and at nightfires.", null),
                new TextObject("Increased troop morale when fighting non-believers{newline}Increased relations with other believers{newline}Increased troop morale when leading offensive battles", null),
                new TextObject("", null),
                200,
                new TextObject("R'hllor, also known as the Lord of Light, the Heart of Fire, the God of Flame and Shadow, is a prominent god in Essos, but has only a few followers in Westeros, where he is more commonly known as the red god. The symbol of R'hllor the Red is a fiery heart. Red priests lead prayers to R'hllor at red temples and at nightfires.", null),
                new TextObject("Fire, zeal, combat, and holy war are the domains of R'hllor.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_EW1"), null);
            this.GreatOther.Initialize(
                new TextObject("The Great Other", null),
                new TextObject("The Great Other, also known as the Other, the Lord of Darkness, the Soul of Ice, and the God of Night and Terror, is a god considered the enemy of R'hllor, the Lord of Light. His true name is never spoken.", null),
                new TextObject("Increased party movement speed in mountainous or snowy terrain{newline}Decreased morale for enemy troops{newline}Increased troop morale when leading offensive battles", null),
                new TextObject("", null),
                200,
                new TextObject("The Great Other, also known as the Other, the Lord of Darkness, the Soul of Ice, and the God of Night and Terror, is a god considered the enemy of R'hllor, the Lord of Light. His true name is never spoken.", null),
                new TextObject("Cold, death, fear, and winter are the domains of the Great Other.", null),
                null, null);
            this.MoonPaleMaiden.Initialize(
                new TextObject("The Moon-Pale Maiden", null),
                new TextObject("Goddess of the seas and tides, the Moon-Pale Maiden guides sailors through storms and darkness, watching over voyages and offering protection to those who honor her. Her followers trust her light to lead them safely home and her favor to calm the wrathful waters.", null),
                new TextObject("Increased party movement speed when sailing{newline}Increased caravan income{newline}Increased troop morale in watery terrain", null),
                new TextObject("", null),
                200,
                new TextObject("Goddess of the seas and tides, the Moon-Pale Maiden guides sailors through storms and darkness, watching over voyages and offering protection to those who honor her. Her followers trust her light to lead them safely home and her favor to calm the wrathful waters.", null),
                new TextObject("Sea, navigation, protection, and guidance are the domains of the Moon-Pale Maiden.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town14"), null);
            this.LionOfNight.Initialize(
                new TextObject("The Lion of Night", null),
                new TextObject("The Lion of Night is the shadowed enforcer of the God-on-Earth, dispensing justice and executing the will of the divine court. Feared and revered, this deity embodies vigilance, judgment, and the inevitability of punishment for those who defy the celestial order.", null),
                new TextObject("Decreased morale for enemy troops{newline}Increased legitimacy{newline}Increased settlement loyalty", null),
                new TextObject("", null),
                200,
                new TextObject("The Lion of Night is the shadowed enforcer of the God-on-Earth, dispensing justice and executing the will of the divine court. Feared and revered, this deity embodies vigilance, judgment, and the inevitability of punishment for those who defy the celestial order.", null),
                new TextObject("Justice, enforcement, intimidation, and control are the domains of the Lion of Night.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town17"), null);
            this.FatherOfWaters.Initialize(
                new TextObject("Father of Waters", null),
                new TextObject("The Father of Waters is the supreme deity of rivers and seas, guardian of their currents and the life they sustain. Revered for granting prosperity, guiding trade, and controlling floods, he demands respect and tribute to ensure his blessings flow to his people.", null),
                new TextObject("Increased port town prosperity{newline}Increased port town stability{newline}Increased legitimacy", null),
                new TextObject("", null),
                200,
                new TextObject("The Father of Waters is the supreme deity of rivers and seas, guardian of their currents and the life they sustain. Revered for granting prosperity, guiding trade, and controlling floods, he demands respect and tribute to ensure his blessings flow to his people.", null),
                new TextObject("Rivers, prosperity, trade, and protection from floods are the domains of the Father of Waters.", null),
                null, null);
            this.MerlingKing.Initialize(
                new TextObject("Merling King", null),
                new TextObject("The Merling King rules the depths alongside the Moon-Pale Maiden, commanding the waves and safeguarding those who sail upon them. Feared for his wrath in storms and revered for guiding fleets, he rewards the devoted with safe passage and bountiful waters.", null),
                new TextObject("Increased fishing villages productivity{newline}Increased port settlement loyalty{newline}Increased troop morale in watery terrain", null),
                new TextObject("", null),
                200,
                new TextObject("The Merling King rules the depths alongside the Moon-Pale Maiden, commanding the waves and safeguarding those who sail upon them. Feared for his wrath in storms and revered for guiding fleets, he rewards the devoted with safe passage and bountiful waters.", null),
                new TextObject("Sea mastery, protection of sailors, and maritime prosperity are the domains of the Merling King.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town13"), null);
            this.WeepingLady.Initialize(
                new TextObject("The Weeping Lady", null),
                new TextObject("The Weeping Lady mourns for all who are lost — to the sea, to war, to time. Her tears fall for the widows and the orphans, for the slain and the forgotten. Worship of the Lady brings compassion and remembrance, but her grief is heavy, and her followers risk being dragged down by her sorrow.", null),
                new TextObject("Increased relations with village notables{newline}Troops are less likely to die in battle{newline}Increased recovery of wounded troops", null),
                new TextObject("Mourning, sacrifice, compassion, shared grief", null),
                200,
                new TextObject("The Weeping Lady mourns for all who are lost — to the sea, to war, to time. Her tears fall for the widows and the orphans, for the slain and the forgotten. Worship of the Lady brings compassion and remembrance, but her grief is heavy, and her followers risk being dragged down by her sorrow.", null),
                new TextObject("Mourning, sacrifice, compassion, shared grief are the domains of the Weeping Lady.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town11"), null);
            this.Pantera.Initialize(
                new TextObject("Pantera", null),
                new TextObject("Pantera, the Cat-Goddess, is a deity of fertility, passion, and the pleasures of life. Her priests speak of her as a playful huntress, who blesses the fields, the womb, and the bedchamber alike. Worship of Pantera is joyous and sensual, but her followers risk indulgence, for her favor can vanish as quickly as affection itself.", null),
                new TextObject("Increased fertility{newline}Piety gain for every child born{newline}Increased fief prosperity", null),
                new TextObject("", null),
                200,
                new TextObject("Pantera, the Cat-Goddess, is a deity of fertility, passion, and the pleasures of life. Her priests speak of her as a playful huntress, who blesses the fields, the womb, and the bedchamber alike. Worship of Pantera is joyous and sensual, but her followers risk indulgence, for her favor can vanish as quickly as affection itself.", null),
                new TextObject("Fertility, passion, vitality, charm are the domains of Pantera.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_A4"), null);
            this.YndrosOfTheTwilight.Initialize(
                new TextObject("Yndros of The Twilight", null),
                new TextObject("Yndros of the Twilight is the ever-changing deity of Lys, male by day and female by night. In twilight’s shifting veil, Yndros embodies duality — passion and restraint, strength and grace, the power to be many selves in one. Their acolytes claim the god grants the gift of transformation, that in love’s embrace one may become what the other most desires. Worship of Yndros is sensual, fluid, and mysterious, and is said to grant its followers the gift of adaptability in both bedchamber and battlefield.", null),
                new TextObject("Increased persuasion succes chance{newline}Increased spouse score{newline}Disguise attempts are more likely to succeed", null),
                new TextObject("", null),
                200,
                new TextObject("Yndros of the Twilight is the ever-changing deity of Lys, male by day and female by night. In twilight’s shifting veil, Yndros embodies duality — passion and restraint, strength and grace, the power to be many selves in one. Their acolytes claim the god grants the gift of transformation, that in love’s embrace one may become what the other most desires. Worship of Yndros is sensual, fluid, and mysterious, and is said to grant its followers the gift of adaptability in both bedchamber and battlefield.", null),
                new TextObject("Transformation, duality, adaptability, persuasion are the domains of Yndros of the Twilight.", null),
                null, null);
            this.Bakkalon.Initialize(
                new TextObject("Bakkalon", null),
                new TextObject("Bakkalon, the Pale Child, is worshiped as both god and weapon — a cruel child with a blade in hand, pale as death. Called ‘Bakkalon of the Sword,’ she embodies the mercilessness of war and the innocence of destruction, where death comes not as wisdom or vengeance, but as play. Her cults are found in Asshai, Braavos, and Lys, whispered in shadowed halls and blood-stained altars. Those who pray to Bakkalon seek victory in battle and the cold certainty of death given without pity.", null),
                new TextObject("Decreased enemy troop morale{newline}Increased renown and influence gain from battles{newline}Receive piety from raiding", null),
                new TextObject("Death, merciless war, cruelty, and suffering", null),
                200,
                new TextObject("Bakkalon, the Pale Child, is worshiped as both god and weapon — a cruel child with a blade in hand, pale as death. Called ‘Bakkalon of the Sword,’ she embodies the mercilessness of war and the innocence of destruction, where death comes not as wisdom or vengeance, but as play. Her cults are found in Asshai, Braavos, and Lys, whispered in shadowed halls and blood-stained altars. Those who pray to Bakkalon seek victory in battle and the cold certainty of death given without pity.", null),
                new TextObject("Death, merciless war, cruelty, and suffering are the domains of Bakkalon.", null),
                null, null);
            this.Saagael.Initialize(
                new TextObject("Saagael", null),
                new TextObject("Saagael, the Giver of Pain, the Faceless One, is venerated in Lys among shadowed temples where suffering is exalted. To her followers, pain is not a curse, but a gift — proof of life, resilience, and devotion. She wears many faces, appearing as maiden, mother, crone, or masked tormentor, and her worshipers believe pain strips away falsehood, leaving only truth. Saagael is prayed to by torturers, ascetics, and those who seek hidden strength in agony.", null),
                new TextObject("Disguise attempts are more likely to succeed{newline}Increased recovery of wounded troops{newline}Increased party morale when low on food", null),
                new TextObject("", null),
                200,
                new TextObject("Saagael, the Giver of Pain, the Faceless One, is venerated in Lys among shadowed temples where suffering is exalted. To her followers, pain is not a curse, but a gift — proof of life, resilience, and devotion. She wears many faces, appearing as maiden, mother, crone, or masked tormentor, and her worshipers believe pain strips away falsehood, leaving only truth. Saagael is prayed to by torturers, ascetics, and those who seek hidden strength in agony.", null),
                new TextObject("Pain, endurance, disguise, and faceless truth are the domains of Saagael.", null),
                null, null);
            this.Trios.Initialize(
                new TextObject("Trios", null),
                new TextObject("Trios, the Three-Headed God, is chief among the Tyroshi pantheon, revered as the Dominar of the Gods. He is depicted with three faces: one male, one female, and one androgynous, symbolizing authority over all aspects of life and the balance of opposites. In Tyrosh, Trios represents unity through multiplicity, dominion through paradox, and the divine right of Tyroshi culture to thrive amidst rivals. As Dominar, Trios rules not through brute strength alone but by commanding the respect of gods and mortals alike, standing as the patron of Tyrosh’s identity and its proud, flamboyant traditions.", null),
                new TextObject("Increased legitimacy{newline}Increased fief loyalty{newline}Signicantly increased cultural presence and acceptance gain", null),
                new TextObject("", null),
                200,
                new TextObject("Trios, the Three-Headed God, is chief among the Tyroshi pantheon, revered as the Dominar of the Gods. He is depicted with three faces: one male, one female, and one androgynous, symbolizing authority over all aspects of life and the balance of opposites. In Tyrosh, Trios represents unity through multiplicity, dominion through paradox, and the divine right of Tyroshi culture to thrive amidst rivals. As Dominar, Trios rules not through brute strength alone but by commanding the respect of gods and mortals alike, standing as the patron of Tyrosh’s identity and its proud, flamboyant traditions.", null),
                new TextObject("Dominion, authority, pride, and multiplicity are the domains of Trios.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_A5"), null);
            this.Semosh.Initialize(
                new TextObject("Semosh", null),
                new TextObject("Where Trios is the Dominar, the sovereign of the gods, Semosh is his favored broker — the Hue of Wealth, Cunning, and Prosperity. He is depicted as a masked merchant draped in silks, with one hand offering gold and the other hiding a dagger. Tyroshi sailors and merchants alike pour out offerings to Semosh, seeking his blessing for profitable ventures, the ruin of their rivals, and safe passage across the sea. Though loved by traders, he is also whispered to be the god of bribes, smuggling, and betrayals done in the name of profit.", null),
                new TextObject("Increased caravan income{newline}Improved trade penalties{newline}Persuasion is easier", null),
                new TextObject("", null),
                200,
                new TextObject("Where Trios is the Dominar, the sovereign of the gods, Semosh is his favored broker — the Hue of Wealth, Cunning, and Prosperity. He is depicted as a masked merchant draped in silks, with one hand offering gold and the other hiding a dagger. Tyroshi sailors and merchants alike pour out offerings to Semosh, seeking his blessing for profitable ventures, the ruin of their rivals, and safe passage across the sea. Though loved by traders, he is also whispered to be the god of bribes, smuggling, and betrayals done in the name of profit.", null),
                new TextObject("Wealth, trade, duality, and the razor’s edge between prosperity and deceit are the domains of Semosh.", null),
                null, null);
            this.Selloso.Initialize(
                new TextObject("Selloso", null),
                new TextObject("Twin to Semosh, yet his opposite in temperament, Selloso is the Hue of Passion, Revelry, and Excess. He is depicted as a beautiful youth painted in bright dyes, with one hand holding a goblet and the other a lover’s hand. To Tyroshi, Selloso embodies the lust for life: wine, song, art, and the pleasures of the flesh. His temples are draped in silks and filled with laughter, music, and painted masks. Yet his smile is dangerous — for indulgence leads to ruin as easily as it does joy. Where Semosh’s mask hides a dagger, Selloso’s hides desire.", null),
                new TextObject("Increased settlement loyalty{newline}Double piety from feasts{newline}Persuasion is easier", null),
                new TextObject("", null),
                200,
                new TextObject("Twin to Semosh, yet his opposite in temperament, Selloso is the Hue of Passion, Revelry, and Excess. He is depicted as a beautiful youth painted in bright dyes, with one hand holding a goblet and the other a lover’s hand. To Tyroshi, Selloso embodies the lust for life: wine, song, art, and the pleasures of the flesh. His temples are draped in silks and filled with laughter, music, and painted masks. Yet his smile is dangerous — for indulgence leads to ruin as easily as it does joy. Where Semosh’s mask hides a dagger, Selloso’s hides desire.", null),
                new TextObject("Pleasure, charm, indulgence, and risk are the domains of Selloso.", null),
                null, null);
            this.DrunkenGod.Initialize(
                new TextObject("The Drunken God", null),
                new TextObject("The Drunken God is the spirit of riotous abandon, the deity who laughs in the face of restraint. To worship him is to embrace excess: wine, song, and the heady thrill of unpredictability. He is depicted staggering on painted legs, a goblet in one hand and a flask in the other, surrounded by laughing followers. Though his followers gain inspiration and courage, those who overindulge risk disaster. In Tyrosh, his temples are taverns and back alleys, and no festival is complete without his presence.", null),
                new TextObject("Increased party morale bonus from alcohol{newline}Double piety from feasts{newline}Increased troop morale when outnumbered", null),
                new TextObject("", null),
                200,
                new TextObject("The Drunken God is the spirit of riotous abandon, the deity who laughs in the face of restraint. To worship him is to embrace excess: wine, song, and the heady thrill of unpredictability. He is depicted staggering on painted legs, a goblet in one hand and a flask in the other, surrounded by laughing followers. Though his followers gain inspiration and courage, those who overindulge risk disaster. In Tyrosh, his temples are taverns and back alleys, and no festival is complete without his presence.", null),
                new TextObject("Chaos, unpredictability, courage, and intoxication are the domains of the Drunken God.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town10"), null);
            this.Pattern.Initialize(
                new TextObject("The Patternmaker", null),
                new TextObject("The Patternmaker is the god of truth, contradiction, and the labyrinthine paths of life. All choices, all twists, all unforeseen consequences are threads in the Patternmaker’s great tapestry. Those who follow the Pattern seek wisdom not in brute force or wealth, but in patience, observation, and the courage to navigate uncertainty. Followers of the Patternmaker learn to see connections invisible to others, and to act with foresight and subtlety in both politics and war.", null),
                new TextObject("Increased party movement speed{newline}Decreased army influence costs & cohesion loss{newline}Increased party view distance", null),
                new TextObject("", null),
                200,
                new TextObject("The Patternmaker is the god of truth, contradiction, and the labyrinthine paths of life. All choices, all twists, all unforeseen consequences are threads in the Patternmaker’s great tapestry. Those who follow the Pattern seek wisdom not in brute force or wealth, but in patience, observation, and the courage to navigate uncertainty. Followers of the Patternmaker learn to see connections invisible to others, and to act with foresight and subtlety in both politics and war.", null),
                new TextObject("Strategy, foresight, adaptability, and insight are the domains of the Patternmaker.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_EN6"), null);
            this.PrincelyArbiter.Initialize(
                new TextObject("The Great Prince", null),
                new TextObject("The Great Prince, or Princely Arbiter, is the benevolent lord of prosperity, guidance, and foresight, a god who gives blessings to his people through a chosen vessel. His mercy ensures bountiful harvests, wealth, and protection, but his gifts are not without cost: when his blessings are spent, the Mercies may demand the vessel’s life in tribute. The Great Prince embodies balance — prosperity tempered by duty, abundance shadowed by the inevitability of sacrifice. His worshipers seek both his favor and the wisdom to use it well.", null),
                new TextObject("Increased influence cap and legitimacy{newline}Increased influence gain{newline}Decreased party wages", null),
                new TextObject("", null),
                200,
                new TextObject("The Great Prince, or Princely Arbiter, is the benevolent lord of prosperity, guidance, and foresight, a god who gives blessings to his people through a chosen vessel. His mercy ensures bountiful harvests, wealth, and protection, but his gifts are not without cost: when his blessings are spent, the Mercies may demand the vessel’s life in tribute. The Great Prince embodies balance — prosperity tempered by duty, abundance shadowed by the inevitability of sacrifice. His worshipers seek both his favor and the wisdom to use it well.", null),
                new TextObject("Prosperity, guidance, long-term strategy, and cyclical sacrifice are the domains of the Great Prince.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_EN4"), null);
            this.AquanTheRedBull.Initialize(
                new TextObject("Aquan, the Red Bull", null),
                new TextObject("Aquan, the Red Bull, embodies strength, vitality, and untamed power beneath the serene surface of the Golden Gardens. Revered in secretive rites, his followers believe that true beauty and greatness are inseparable from raw, disciplined force. Aquan is often depicted as a massive crimson bull, its eyes gleaming with hidden intelligence, sometimes surrounded by the ethereal glow of the gardens. His worshipers strive to emulate his strength while maintaining the perfection and grace demanded by the conclave of Gelenei.", null),
                new TextObject("Increased troop damage{newline}Increased troop morale{newline}Increased recovery of wounded troops", null),
                new TextObject("", null),
                200,
                new TextObject("Aquan, the Red Bull, embodies strength, vitality, and untamed power beneath the serene surface of the Golden Gardens. Revered in secretive rites, his followers believe that true beauty and greatness are inseparable from raw, disciplined force. Aquan is often depicted as a massive crimson bull, its eyes gleaming with hidden intelligence, sometimes surrounded by the ethereal glow of the gardens. His worshipers strive to emulate his strength while maintaining the perfection and grace demanded by the conclave of Gelenei.", null),
                new TextObject("Strength, vitality, discipline, and power are the domains of Aquan, the Red Bull.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_A8"), null);
            this.HoodedWayfarer.Initialize(
                new TextObject("The Hooded Wayfarer", null),
                new TextObject("The Hooded Wayfarer is the silent guide through shadowed paths and hidden truths. Cloaked and anonymous, he wanders between gardens and cities alike, observing and teaching those who seek knowledge in secrecy. His followers, often acolytes or scholars, practice discretion and subtlety, believing that wisdom and safety come from knowing when to walk unseen. The Wayfarer’s blessing is the art of moving unnoticed and discovering what others cannot.", null),
                new TextObject("Increased party view distance{newline}Increased party tracking skill{newline}Disguise attempts are more likely to succeed", null),
                new TextObject("", null),
                200,
                new TextObject("The Hooded Wayfarer is the silent guide through shadowed paths and hidden truths. Cloaked and anonymous, he wanders between gardens and cities alike, observing and teaching those who seek knowledge in secrecy. His followers, often acolytes or scholars, practice discretion and subtlety, believing that wisdom and safety come from knowing when to walk unseen. The Wayfarer’s blessing is the art of moving unnoticed and discovering what others cannot.", null),
                new TextObject("Stealth, reconnaissance, subtlety, and insight are the domains of the Hooded Wayfarer.", null),
                null, null);
            this.SilentGod.Initialize(
                new TextObject("The Silent God", null),
                new TextObject("The Silent God watches without speaking, commanding without gesture. His power lies in patience, stillness, and the mastery of inner and outer discipline. Worshipers of the Silent God learn to act when necessary, to restrain excess, and to maintain control over themselves and their surroundings. The Silent God’s blessing is subtle but profound: strength and success without drawing notice, achieving mastery in a world of chaos through calm and patience.", null),
                new TextObject("Increased settlement loyalty{newline}Decreased army cohesion loss{newline}Increased influence cap", null),
                new TextObject("", null),
                200,
                new TextObject("The Silent God watches without speaking, commanding without gesture. His power lies in patience, stillness, and the mastery of inner and outer discipline. Worshipers of the Silent God learn to act when necessary, to restrain excess, and to maintain control over themselves and their surroundings. The Silent God’s blessing is subtle but profound: strength and success without drawing notice, achieving mastery in a world of chaos through calm and patience.", null),
                new TextObject("Discipline, patience, stealth, and control are the domains of the Silent God.", null),
                null, null);
            this.Gelenei.Initialize(
                new TextObject("Gelenei", null),
                new TextObject("Gelenei is the radiant yet enigmatic goddess of beauty, perfection, and the hidden power of the Golden Gardens. She is both patron and protector of the conclave, her followers maintaining her mysteries through arcane rituals and whispered scripture. To see her fully is forbidden; her visage exists only in glimpses, in visions, and in the hearts of the devoted. Gelenei teaches that true power lies in discretion, refinement, and the careful preservation of beauty and knowledge.", null),
                new TextObject("Improved spouse score{newline}Reduced time to learn languages{newline}Reduced time to read books", null),
                new TextObject("", null),
                200,
                new TextObject("Gelenei is the radiant yet enigmatic goddess of beauty, perfection, and the hidden power of the Golden Gardens. She is both patron and protector of the conclave, her followers maintaining her mysteries through arcane rituals and whispered scripture. To see her fully is forbidden; her visage exists only in glimpses, in visions, and in the hearts of the devoted. Gelenei teaches that true power lies in discretion, refinement, and the careful preservation of beauty and knowledge.", null),
                new TextObject("Beauty, secrecy, sorcery, and arcane influence are the domains of Gelenei.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town12"), null);
            this.BeardedGod.Initialize(
                new TextObject("The Bearded God", null),
                new TextObject("The Bearded God is the one true deity of his faith, his name known only to the highest priests. He embodies authority, sacred knowledge, and the secret power of the beard itself — a symbol of divine favor and spiritual insight. Only priests may grow beards, and those who wish to serve the god must follow strict codes of hair and appearance. His followers believe that through obedience, secrecy, and devotion, they can draw upon the hidden wisdom of the Bearded God, attaining protection, guidance, and spiritual elevation.", null),
                new TextObject("Improved relations with fellow believers{newline}Increased fief prosperity and loyalty{newline}Increased renown gain from battles", null),
                new TextObject("", null),
                200,
                new TextObject("The Bearded God is the one true deity of his faith, his name known only to the highest priests. He embodies authority, sacred knowledge, and the secret power of the beard itself — a symbol of divine favor and spiritual insight. Only priests may grow beards, and those who wish to serve the god must follow strict codes of hair and appearance. His followers believe that through obedience, secrecy, and devotion, they can draw upon the hidden wisdom of the Bearded God, attaining protection, guidance, and spiritual elevation.", null),
                new TextObject("Authority, secrecy, hierarchy, and obedience are the domains of the Bearded God.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_ES1"), null);
            this.ManyFacedGod.Initialize(
                new TextObject("The Many-Faced God", null),
                new TextObject("The Many-Faced God is the god of all death, for all other death deities are merely his faces. To live is to suffer, and to die in his grace is to be released from pain. Worshipers of the Many-Faced God practice mercy and precision, believing that ending life at the right moment honors both the living and the dead. His temples are silent sanctuaries, his priests cloaked in anonymity, offering their skills to guide souls to their final rest.", null),
                new TextObject("Disguise attempts almost always succeed{newline}Greatly increased influence gain from battles{newline}Increased troop damage", null),
                new TextObject("", null),
                200,
                new TextObject("The Many-Faced God is the god of all death, for all other death deities are merely his faces. To live is to suffer, and to die in his grace is to be released from pain. Worshipers of the Many-Faced God practice mercy and precision, believing that ending life at the right moment honors both the living and the dead. His temples are silent sanctuaries, his priests cloaked in anonymity, offering their skills to guide souls to their final rest.", null),
                new TextObject("Death, stealth, precision, and mercy are the domains of the Many-Faced God.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_EN5"), null);
            this.Josimakazma.Initialize(
                new TextObject("Josimakazma", null),
                new TextObject("Josimakazma is the Great One Who Rises Again and Again, the Sun God and source of all life. From his brilliance, all warmth, growth, and vitality flow. His followers worship him in the hills of the Great Desolation, far from the corruption of others, seeing in his light purity, renewal, and the strength to persevere. To honor Josimakazma is to respect life itself, to nurture growth, and to bring hope where darkness and desolation prevail.", null),
                new TextObject("Increased settlement prosperity{newline}Increased influence gain from battles{newline}Friendly troops are less likely to die in battle", null),
                new TextObject("", null),
                200,
                new TextObject("Josimakazma is the Great One Who Rises Again and Again, the Sun God and source of all life. From his brilliance, all warmth, growth, and vitality flow. His followers worship him in the hills of the Great Desolation, far from the corruption of others, seeing in his light purity, renewal, and the strength to persevere. To honor Josimakazma is to respect life itself, to nurture growth, and to bring hope where darkness and desolation prevail.", null),
                new TextObject("Vitality, renewal, persistence, and resilience are the domains of Josimakazma.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_K6"), null);
            this.Boash.Initialize(
                new TextObject("Boash", null),
                new TextObject("Boash, the Blind God, has guided followers for thousands of years. His eyes are closed, for true vision lies not in sight but in insight. Flesh and wine are forbidden, and only by opening the Third Eye — after the other two have seen only darkness — can his devotees perceive higher planes of existence. Strict and unyielding, Boash demands discipline, patience, and devotion, rewarding those who endure hardship with wisdom and clarity.", null),
                new TextObject("Increased settlement loyalty{newline}Reduced army influence costs and cohesion loss{newline}Decreased construction time", null),
                new TextObject("", null),
                200,
                new TextObject("Boash, the Blind God, has guided followers for thousands of years. His eyes are closed, for true vision lies not in sight but in insight. Flesh and wine are forbidden, and only by opening the Third Eye — after the other two have seen only darkness — can his devotees perceive higher planes of existence. Strict and unyielding, Boash demands discipline, patience, and devotion, rewarding those who endure hardship with wisdom and clarity.", null),
                new TextObject("Discipline, perception, endurance, and spiritual insight are the domains of Boash.", null),
                null, null);
            this.BlackGoat.Initialize(
                new TextObject("The Black Goat", null),
                new TextObject("The Black Goat is a demon-god of Qohor, feared and revered for the daily sacrifices he demands. His followers believe that life and blood are the currency of divine favor, and that without proper offerings, his wrath is swift and terrible. The Black Goat teaches that power is earned through devotion, discipline, and the willingness to spill blood in his name. Those who honor him gain strength and protection, but failure invites calamity.", null),
                new TextObject("Greatly decreased enemy troop morale{newline}Increased damage for all troop types{newline}Persuasion is easier", null),
                new TextObject("", null),
                200,
                new TextObject("The Black Goat is a demon-god of Qohor, feared and revered for the daily sacrifices he demands. His followers believe that life and blood are the currency of divine favor, and that without proper offerings, his wrath is swift and terrible. The Black Goat teaches that power is earned through devotion, discipline, and the willingness to spill blood in his name. Those who honor him gain strength and protection, but failure invites calamity.", null),
                new TextObject("Sacrifice, power, intimidation, and terror are the domains of the Black Goat.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_ES6"), null);
            this.GodsFire.Initialize(
                new TextObject("Gods of Fire", null),
                new TextObject("The Gods of Fire are the embodiment of flame, heat, and the primal energy that forged the Valyrian Freehold. They symbolize power, transformation, and the destructive and creative forces of the world. Worshipers of these gods honor fire in its many forms — volcanic, draconic, and ritual — believing that through flame, one may purify, conquer, and create anew.", null),
                new TextObject("Reduced village raiding time{newline}Greatly increased troop morale{newline}Decreased enemy troop morale", null),
                new TextObject("", null),
                200,
                new TextObject("The Gods of Fire are the embodiment of flame, heat, and the primal energy that forged the Valyrian Freehold. They symbolize power, transformation, and the destructive and creative forces of the world. Worshipers of these gods honor fire in its many forms — volcanic, draconic, and ritual — believing that through flame, one may purify, conquer, and create anew.", null),
                new TextObject("Fire, destruction, magic, and transformative power are the domains of the Gods of Fire.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town20"), null);
            this.GodsBlood.Initialize(
                new TextObject("Gods of Blood", null),
                new TextObject("The Gods of Blood represent loyalty, sacrifice, and the unyielding bonds between master, vassal, and kin. They watch over the people of the Freehold, demanding devotion and the shedding of blood when necessary to maintain order and authority. Through blood, strength is transferred, oaths are honored, and the Freehold is sustained. Worshipers of these gods are taught that true power requires sacrifice and unity, and that blood is the price of dominion.", null),
                new TextObject("Increased legitimacy{newline}Improved settlement loyalty{newline}Increased cultural presence and acceptance", null),
                new TextObject("", null),
                200,
                new TextObject("The Gods of Blood represent loyalty, sacrifice, and the unyielding bonds between master, vassal, and kin. They watch over the people of the Freehold, demanding devotion and the shedding of blood when necessary to maintain order and authority. Through blood, strength is transferred, oaths are honored, and the Freehold is sustained. Worshipers of these gods are taught that true power requires sacrifice and unity, and that blood is the price of dominion.", null),
                new TextObject("Loyalty, sacrifice, endurance, and conquest are the domains of the Gods of Blood.", null),
                null, null);
            this.MotherRhoyne.Initialize(
                new TextObject("Mother Rhoyne", null),
                new TextObject("Mother Rhoyne is the goddess of the great river, the source of all life and the progenitor of all peoples and gods. She nourishes her followers as the river nourishes the lands, providing water, fertility, and sustenance. To honor her is to respect the flow of life, nurture growth, and protect what sustains communities. Her blessings bring prosperity, unity, and the quiet power of steady, flowing influence.", null),
                new TextObject("Reduced trade penalties{newline}Piety gain for every child born{newline}Increased village hearth growth", null),
                new TextObject("", null),
                200,
                new TextObject("Mother Rhoyne is the goddess of the great river, the source of all life and the progenitor of all peoples and gods. She nourishes her followers as the river nourishes the lands, providing water, fertility, and sustenance. To honor her is to respect the flow of life, nurture growth, and protect what sustains communities. Her blessings bring prosperity, unity, and the quiet power of steady, flowing influence.", null),
                new TextObject("Prosperity, fertility, life, and sustenance are the domains of Mother Rhoyne.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_A1"), null);
            this.GreatStallion.Initialize(
                new TextObject("The Great Stallion", null),
                new TextObject("The Great Stallion is the eternal god of the Dothraki, the embodiment of freedom, speed, and the bond between rider and horse. All life is fleeting, but glory in movement, conquest, and battle is eternal. He watches over the people of the great plains, guiding their raids, their herds, and their victories. To honor him is to ride fast, strike hard, and live free, for no man can tame the Great Stallion, nor his favor.", null),
                new TextObject("Increased party movement speed{newline}Increased troop damage{newline}Renown gain for every successful raid on foreign villages", null),
                new TextObject("", null),
                200,
                new TextObject("The Great Stallion is the eternal god of the Dothraki, the embodiment of freedom, speed, and the bond between rider and horse. All life is fleeting, but glory in movement, conquest, and battle is eternal. He watches over the people of the great plains, guiding their raids, their herds, and their victories. To honor him is to ride fast, strike hard, and live free, for no man can tame the Great Stallion, nor his favor.", null),
                new TextObject("Mounted combat, mobility, raiding, and freedom are the domains of the Great Stallion.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_K3"), null);
            this.GodsSummer.Initialize(
                new TextObject("The Gods of Summer", null),
                new TextObject("The Gods of Summer embody the sun, warmth, fertility, and abundance. They watch over crops, seas, and people alike, ensuring that life is vibrant and thriving. Worshiping these gods brings prosperity, good health, and growth to settlements and communities.", null),
                new TextObject("Increased village hearth growth{newline}Increased village production{newline}Increased settlement prosperity", null),
                new TextObject("", null),
                200,
                new TextObject("The Gods of Summer embody the sun, warmth, fertility, and abundance. They watch over crops, seas, and people alike, ensuring that life is vibrant and thriving. Worshiping these gods brings prosperity, good health, and growth to settlements and communities.", null),
                new TextObject("Prosperity, fertility, vitality, and warmth are the domains of the Gods of Summer.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town25"), null);
            this.GodsPassion.Initialize(
                new TextObject("The Gods of Passion", null),
                new TextObject("The Gods of Passion embody courage, bravery, and the fire of life. They inspire warriors to fight with vigor, and lovers to pursue their desires boldly. Their blessing makes hearts bold and actions decisive.", null),
                new TextObject("Increased troop morale{newline}Increased troop damage{newline}Persuasion is easier", null),
                new TextObject("", null),
                200,
                new TextObject("The Gods of Passion embody courage, bravery, and the fire of life. They inspire warriors to fight with vigor, and lovers to pursue their desires boldly. Their blessing makes hearts bold and actions decisive.", null),
                new TextObject("Combat, courage, valor, and decisive action are the domains of the Gods of Passion.", null),
                null, null);
            this.GodsLove.Initialize(
                new TextObject("The Gods of Love", null),
                new TextObject("The Gods of Love embody devotion, loyalty, and affection. They guide hearts and marriages, ensuring bonds remain strong and trust prevails. Their blessings nurture diplomacy, alliances, and companion loyalty.", null),
                new TextObject("Increased relations with fief notables{newline}Increased spouse score{newline}Increased fertility", null),
                new TextObject("", null),
                200,
                new TextObject("The Gods of Love embody devotion, loyalty, and affection. They guide hearts and marriages, ensuring bonds remain strong and trust prevails. Their blessings nurture diplomacy, alliances, and companion loyalty.", null),
                new TextObject("Diplomacy, loyalty, love, and relations are the domains of the Gods of Love.", null),
                null, null);
            this.Harpy.Initialize(
                new TextObject("The Harpy", null),
                new TextObject("The Harpy is the guardian and ruler of the Ghiscari, watching over the Empire and its people. Even after the fall of Ghis, her eyes remain upon the descendants of the Empire, ensuring order, prosperity, and justice. Her followers maintain her legacy through governance, law, and the enforcement of authority. The Harpy’s favor brings stability, loyalty, and the strength to maintain dominion over lands and subjects.", null),
                new TextObject("Increased legitimacy{newline}Increased fief loyalty{newline}Signicantly increased cultural presence and acceptance gain", null),
                new TextObject("", null),
                200,
                new TextObject("The Harpy is the guardian and ruler of the Ghiscari, watching over the Empire and its people. Even after the fall of Ghis, her eyes remain upon the descendants of the Empire, ensuring order, prosperity, and justice. Her followers maintain her legacy through governance, law, and the enforcement of authority. The Harpy’s favor brings stability, loyalty, and the strength to maintain dominion over lands and subjects.", null),
                new TextObject("Authority, governance, lawful rule, and stability are the domains of the Harpy.", null),
                Settlement.All.First((Settlement x) => x.StringId == "town_K1"), null);
            this.GodOnEarth.Initialize(
                new TextObject("God-On-Earth", null),
                new TextObject("All under Heaven is born to Heaven’s Will, and the God-On-Earth rules as the earthly manifestation of this divine order. Sitting at the head of a vast celestial bureaucracy, he governs through law, wisdom, and divine authority. Those who serve him honor hierarchy, loyalty, and order, ensuring that the Celestial Court and the realm remain stable, prosperous, and just.", null),
                new TextObject("Increased legitimacy{newline}Increased fief loyalty{newline}Increased fief prosperity", null),
                new TextObject("", null),
                200,
                new TextObject("All under Heaven is born to Heaven’s Will, and the God-On-Earth rules as the earthly manifestation of this divine order. Sitting at the head of a vast celestial bureaucracy, he governs through law, wisdom, and divine authority. Those who serve him honor hierarchy, loyalty, and order, ensuring that the Celestial Court and the realm remain stable, prosperous, and just.", null),
                new TextObject("Order, governance, righteous rule, and loyalty are the domains of God-On-Earth.", null),
                Settlement.All.First((Settlement x) => x.StringId == "ROT_town26"), null);
            this.MaidenMadeOfLight.Initialize(
                new TextObject("The Maiden-Made-of-Light", null),
                new TextObject("The Maiden-Made-of-Light is the radiant advisor to the God-on-Earth, illuminating the path of righteousness and foresight. She watches over the Celestial Court and its subjects, guiding leaders toward wise decisions, justice, and the protection of those under their care. Her blessing nurtures loyalty, foresight, and the vigilance necessary to maintain order and prosperity.", null),
                new TextObject("Increased party view distance{newline}Increased party morale in defensive battles{newline}Increased legitimacy", null),
                new TextObject("", null),
                200,
                new TextObject("The Maiden-Made-of-Light is the radiant advisor to the God-on-Earth, illuminating the path of righteousness and foresight. She watches over the Celestial Court and its subjects, guiding leaders toward wise decisions, justice, and the protection of those under their care. Her blessing nurtures loyalty, foresight, and the vigilance necessary to maintain order and prosperity.", null),
                new TextObject("Wisdom, foresight, justice, and protection are the domains of the Maiden-Made-of-Light.", null),
                null, null);

            foreach (Divinity divinity in All)
            {
                DefaultTypeInitializer<DefaultDivinities, Divinity>.Instance.AddObject(divinity);
            }
        }
    }
}
