using BannerKings;
using BannerKings.Managers.Court;
using BannerKings.Managers.Court.Members;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Localization;

namespace BKROTPatch.FaithGroups
{
    internal class ROTFaithGroups : DefaultTypeInitializer<ROTFaithGroups, FaithGroup>
    {
        public FaithGroup FreeCitiesGroup { get; } = new DisorganizedGroup("FreeCitiesGroup");
        public FaithGroup DothrakiGroup { get; } = new DisorganizedGroup("DothrakiGroup");
        public FaithGroup OldGodsGroup { get; } = new DisorganizedGroup("OldGodsGroup");
        public FaithGroup SevenGroup { get; } = new LandedPreacherGroup("SevenGroup");
        public FaithGroup RhllorGroup { get; } = new LandedPreacherGroup("RhllorGroup");
        public FaithGroup YiTiGroup { get; } = new AppointedGroup(DefaultTypeInitializer<DefaultCouncilPositions, CouncilMember>.Instance.Spiritual, "YiTiGroup");
        public FaithGroup ValyrianGroup { get; } = new AppointedGroup(DefaultTypeInitializer<DefaultCouncilPositions, CouncilMember>.Instance.Spiritual, "ValyrianGroup");
        public FaithGroup IronBornGroup { get; } = new LandedPreacherGroup("IronbornGroup");
        public FaithGroup MotherRhoyneGroup { get; } = new LandedPreacherGroup("MotherRhoyneGroup");
        public FaithGroup GhisGroup { get; } = new LandedPreacherGroup("GhisGroup");
        public FaithGroup SummerGroup { get; } = new DisorganizedGroup("SummerGroup");

        public override IEnumerable<FaithGroup> All
        {
            get
            {
                yield return this.FreeCitiesGroup;
                yield return this.DothrakiGroup;
                yield return this.OldGodsGroup;
                yield return this.SevenGroup;
                yield return this.RhllorGroup;
                yield return this.YiTiGroup;
                yield return this.ValyrianGroup;
                yield return this.IronBornGroup;
                yield return this.MotherRhoyneGroup;
                yield return this.GhisGroup;
                yield return this.SummerGroup;
                yield break;
            }
        }

        public override void Initialize()
        {
            FreeCitiesGroup.Initialize(new TextObject("Free Cities Faiths"),
                new TextObject("The numerous gods worshiped by the cults of the Free Cities in Essos are as varied as the people there. Each of the cities has its core gods, and yet most welcome all others."));

            DothrakiGroup.Initialize(new TextObject("Dothraki Faiths"),
                new TextObject("The Dothraki have long believed in multitudes of gods, including the Sun and his goddess wife, the Moon. Yet, it was the Witch Doshi who would unite the Dothraki in faith, just as her son united them in Khalasar."));

            OldGodsGroup.Initialize(new TextObject("Old Gods Faiths"),
                new TextObject("The Pact of the Isle of Faces is the treaty that ended the conflict between the First Men and the Children of the Forest. It is what brought peace to Westeros and introduced the worship of the Old Gods to men. The Pact has held to this day and will endure as long as the blood of the First Men flows in the veins of humanity."));

            SevenGroup.Initialize(new TextObject("Faiths of the Andals"),
                new TextObject("The Faith of the Andals is a collection of beliefs centered around the conviction that there is one god, one divine being, who has revealed themselves to the chosen people, the Andals, in seven distinct aspects to guide them to greatness."));

            RhllorGroup.Initialize(new TextObject("The Heart of Fire"),
                new TextObject("Originating from Further East of Essos, the worship of R'hllor, the Heart of Fire, has spread across the known world. Followers view it as their duty to spread the word and prepare the world for the confrontation between R'hllor and the Great Other."));

            YiTiGroup.Initialize(new TextObject("The Courts of Dawn"),
                new TextObject("Yi Ti is a land of a thousand gods and hundreds of princes, and the divine realm is organized much like the middle realm. While all gods are acknowledged and believed in, the various Courts are the specific gods to whom a group or individual will devote themselves."));

            ValyrianGroup.Initialize(new TextObject("The Flames of Valyria"),
                new TextObject("The Lands of the Long Summer were home to Gods of Flame and Wing, often taking the form of dragons for the lower peoples of the region."));

            IronBornGroup.Initialize(new TextObject("The Ways of Sea and Storm"),
                new TextObject("The Ways of Sea and Storm have long been in Westeros, and while many believe they are remnants of some First Gods cult, the practices and beliefs of the Ways are far closer to the Shanties and Churches of the darker Gods of the South and East. There is evidence that the Ways predate the coming of man to Westeros entirely, and the dark implications of that inspire dread and terror."));

            MotherRhoyneGroup.Initialize(new TextObject("The Children of the Mother"),
                new TextObject("The Children of the Mother are many and now spread across many lands. They are all connected in the belief that they are children of Mother Rhoyne, the goddess who birthed not only them but all of creation."));
            
            GhisGroup.Initialize(new TextObject("The Graces of Ghis"),
                new TextObject("Long before the rise of Valyria and its Freehold, it was Ghis and its Gods who forged an empire through discipline and blood. Even after the fall of the Empire and the loss of their tongue, the Ghiscari Gods have persisted and even seen the end of their hated enemies."));

            SummerGroup.Initialize(new TextObject("The Temples of the Summer Gods"),
                new TextObject("The peoples of the Summer Islands worship a myriad of gods and goddesses, who, for the most part, reflect their tropical homes. The Summer Gods are deities of warmth and love, and their people are deeply devoted to them."));

            foreach (FaithGroup faithGroup in All)
            {
                DefaultTypeInitializer<DefaultFaithGroups, FaithGroup>.Instance.AddObject(faithGroup);
            }
        }
    }
}
