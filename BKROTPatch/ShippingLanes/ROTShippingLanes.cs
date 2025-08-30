using BannerKings;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Shipping;
using BKCEKPatch.Languages;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BKROTPatch.ShippingLanes
{
    internal class ROTShippingLanes : DefaultTypeInitializer<ROTShippingLanes, ShippingLane>
    {
        public ShippingLane SunsetNorth = new ShippingLane("SunsetSeaNorth");
        public ShippingLane SunsetSouth = new ShippingLane("SunsetSeaSouth");
        public ShippingLane Narrow = new ShippingLane("NarrowSea");
        public ShippingLane SlaversBay = new ShippingLane("SlaversBay");
        public ShippingLane Northern = new ShippingLane("NorthernSea");
        public override IEnumerable<ShippingLane> All
        {
            get
            {
                yield return SunsetNorth;
                yield return SunsetSouth;
                yield return Narrow;
                yield return SlaversBay;
                yield return Northern;
            }
        }

        public override void Initialize()
        {
            ShippingLane sunset = SunsetNorth;
            TextObject textObject = new TextObject("North Sunset Sea Shipping Network", null);
            TextObject textObject2 = new TextObject("", null);
            List<Settlement> list = new List<Settlement>();
            list.Add(Settlement.All.First((x) => x.StringId == "ROT_town2"));
            list.Add(Settlement.All.First((x) => x.StringId == "ROT_town7"));
            list.Add(Settlement.All.First((x) => x.StringId == "ROT_town22"));
            list.Add(Settlement.All.First((x) => x.StringId == "town_S2"));
            list.Add(Settlement.All.First((x) => x.StringId == "town_S3"));
            list.Add(Settlement.All.First((x) => x.StringId == "town_V8"));
            sunset.Initialize(textObject, textObject2, list, false, null);
            ShippingLane narrow = Narrow;
            TextObject textObject3 = new TextObject("Narrow Sea Network", null);
            TextObject textObject4 = new TextObject("", null);
            List<Settlement> list2 = new List<Settlement>();
            list2.Add(Settlement.All.First((x) => x.StringId == "town_A1"));
            list2.Add(Settlement.All.First((x) => x.StringId == "ROT_town25"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_A4"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EW2"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_A5"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_A8"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EW3"));
            list2.Add(Settlement.All.First((x) => x.StringId == "ROT_town8"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EN4"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EW5"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_S5"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EW4"));
            list2.Add(Settlement.All.First((x) => x.StringId == "ROT_town5"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EW1"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EN2"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EW6"));
            list2.Add(Settlement.All.First((x) => x.StringId == "ROT_town14"));
            list2.Add(Settlement.All.First((x) => x.StringId == "town_EN5"));
            narrow.Initialize(textObject3, textObject4, list2, false, null);
            ShippingLane north = Northern;
            TextObject textObject5 = new TextObject("Northern Trade Network", null);
            TextObject textObject6 = new TextObject("", null);
            List<Settlement> list3 = new List<Settlement>();
            list3.Add(Settlement.All.First((x) => x.StringId == "town_EN5"));
            list3.Add(Settlement.All.First((x) => x.StringId == "town_EN2"));
            list3.Add(Settlement.All.First((x) => x.StringId == "town_S1"));
            list3.Add(Settlement.All.First((x) => x.StringId == "town_B3"));
            list3.Add(Settlement.All.First((x) => x.StringId == "town_S7"));
            list3.Add(Settlement.All.First((x) => x.StringId == "town_EN6"));
            list3.Add(Settlement.All.First((x) => x.StringId == "town_K6"));
            north.Initialize(textObject5, textObject6, list3, false, null);
            ShippingLane slaver = SlaversBay;
            TextObject textObject7 = new TextObject("Slaver's Bay Trade Network", null);
            TextObject textObject8 = new TextObject("", null);
            List<Settlement> list4 = new List<Settlement>();
            list4.Add(Settlement.All.First((x) => x.StringId == "town_A4"));
            list4.Add(Settlement.All.First((x) => x.StringId == "ROT_town25"));
            list4.Add(Settlement.All.First((x) => x.StringId == "ROT_town20"));
            list4.Add(Settlement.All.First((x) => x.StringId == "town_ES2"));
            list4.Add(Settlement.All.First((x) => x.StringId == "town_K1"));
            list4.Add(Settlement.All.First((x) => x.StringId == "town_A2"));
            list4.Add(Settlement.All.First((x) => x.StringId == "town_A3"));
            list4.Add(Settlement.All.First((x) => x.StringId == "town_A5"));
            slaver.Initialize(textObject7, textObject8, list4, false, null);
            ShippingLane sunsetSouth = SunsetSouth;
            TextObject textObject9 = new TextObject("South Sunset Sea Shipping Network", null);
            TextObject textObject10 = new TextObject("", null);
            List<Settlement> list5 = new List<Settlement>();
            list5.Add(Settlement.All.First((x) => x.StringId == "town_V8"));
            list5.Add(Settlement.All.First((x) => x.StringId == "town_V9"));
            list5.Add(Settlement.All.First((x) => x.StringId == "town_V6"));
            list5.Add(Settlement.All.First((x) => x.StringId == "town_V7"));
            list5.Add(Settlement.All.First((x) => x.StringId == "town_A1"));
            sunsetSouth.Initialize(textObject9, textObject10, list5, false, null);

            foreach (ShippingLane shippingLane in All)
            {
                DefaultTypeInitializer<DefaultShippingLanes, ShippingLane>.Instance.AddObject(shippingLane);
            }
        }
    }
}
