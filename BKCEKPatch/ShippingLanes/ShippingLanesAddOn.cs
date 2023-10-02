using BannerKings;
using BannerKings.Managers.Shipping;
using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BKCEKPatch.ShippingLanes
{
    internal class ShippingLanesAddOn : DefaultTypeInitializer<ShippingLanesAddOn, ShippingLane>
    {
        public ShippingLane EasternRivers { get; } = new ShippingLane(nameof(EasternRivers));

        public override IEnumerable<ShippingLane> All
        {
            get
            {
                yield return this.EasternRivers;
            }
        }

        public override void Initialize()
        {
            this.EasternRivers.Initialize(new TextObject("{=!}Eastern Shipping Network"), new TextObject(), new List<Settlement>()
            {
            Settlement.All.First<Settlement>((x => x.StringId == "town_S9")),
            Settlement.All.First<Settlement>((x => x.StringId == "castle_village_EN8_2")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_K3")),
            Settlement.All.First<Settlement>((x => x.StringId == "village_K3_3")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_K5")),
            Settlement.All.First<Settlement>((x => x.StringId == "village_ES7_2")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_ES7")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_K2")),
            Settlement.All.First<Settlement>((x => x.StringId == "castle_village_K8_2")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_ES1")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_EN6")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_A2")),
            Settlement.All.First<Settlement>((x => x.StringId == "town_ES1")),
            });
            foreach (ShippingLane lane in All)
            {
                DefaultShippingLanes.Instance.AddObject(lane);
            }
        }
    }
}
