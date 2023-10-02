using BannerKings;
using BannerKings.Managers.Shipping;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BKMergedMapPatch
{
    internal class MMShippingLanesAddOn : DefaultTypeInitializer<MMShippingLanesAddOn, ShippingLane>
    {
        public ShippingLane SouthEasternRivers { get; } = new ShippingLane(nameof(SouthEasternRivers));

        public override IEnumerable<ShippingLane> All
        {
            get
            {
                yield return this.SouthEasternRivers;
            }
        }

        public override void Initialize()
        {
            this.SouthEasternRivers.Initialize(new TextObject("{=!}South-Eastern Shipping Network"), new TextObject(), new List<Settlement>()
            {
                Settlement.All.First<Settlement>((x => x.StringId == "town_HX2")),
                Settlement.All.First<Settlement>((x => x.StringId == "village_HX3_b")),
                Settlement.All.First<Settlement>((x => x.StringId == "village_HX2_c")),
                Settlement.All.First<Settlement>((x => x.StringId == "town_HX3")),
                Settlement.All.First<Settlement>((x => x.StringId == "village_HX1_c")),
                Settlement.All.First<Settlement>((x => x.StringId == "town_T7")),
                Settlement.All.First<Settlement>((x => x.StringId == "town_HX1")),
                Settlement.All.First<Settlement>((x => x.StringId == "castle_village_HX1_a")),
                Settlement.All.First<Settlement>((x => x.StringId == "town_T4")),
                Settlement.All.First<Settlement>((x => x.StringId == "town_ES1")),
                Settlement.All.First<Settlement>((x => x.StringId == "town_A2")),
                });
            foreach (ShippingLane lane in All)
            {
                DefaultShippingLanes.Instance.AddObject(lane);
            }
        }
    }
}
