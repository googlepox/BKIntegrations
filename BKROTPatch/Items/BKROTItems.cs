using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Items
{
    internal class BKROTItems : DefaultTypeInitializer<BKROTItems, ItemObject>
    {
        public ItemObject BookSevenPointedStar { get; private set; }

        public override IEnumerable<ItemObject> All
        {
            get
            {
                yield return this.BookSevenPointedStar;
                yield break;
            }
        }

        public override void Initialize()
        {
            BookSevenPointedStar = Game.Current.ObjectManager.RegisterPresumedObject(new ItemObject("book_seven_pointed_star"));
            InitializeTradeGood(BookSevenPointedStar,
                new TextObject("{=c0sJc9o9}The Seven Pointed Star{@Plural}collection of The Seven Pointed Star books{\\@}"),
                "lib_book_closed_b",
                BKItemCategories.Instance.Book,
                1000,
                1.5f,
                ItemObject.ItemTypeEnum.Goods);
            
            foreach (ItemObject item in All)
                {
                    DefaultTypeInitializer<BKItems, ItemObject>.Instance.AddObject(item);
                }
        }

        private static void InitializeTradeGood(ItemObject item, TextObject name, string meshName, ItemCategory category,
            int value, float weight, ItemObject.ItemTypeEnum itemType, bool isFood = false)
        {
            ItemObject.InitializeTradeGood(item, name, meshName, category, value, weight, itemType, isFood);
        }
    }
}
