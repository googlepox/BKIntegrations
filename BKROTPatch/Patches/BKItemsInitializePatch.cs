using BannerKings.Managers.Items;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(BKItems), "InitializeTradeGood")]
    internal class BKItemsInitializePatch
    {
        public static bool Prefix(ref BKItems __instance, ItemObject item, ref TextObject name, string meshName, ItemCategory category,
            ref int value, float weight, ItemObject.ItemTypeEnum itemType, bool isFood)
        {
            if (item.StringId == "book_medicine")
            {
                name = new TextObject("Valyrian Papyrus{@Plural}collection of Valyrian Papyrus{\\@}");
            }
            else if (item.StringId == "book_throwing")
            {
                name = new TextObject("The Forty-Two Casts of Strength{@Plural}collection of The Forty-Two Casts of Strength{\\@}");
            }
            else if (item.StringId == "book_polearm")
            {
                name = new TextObject("The Volantene Debate{@Plural}collection of The Volantene Debate{\\@}");
            }
            else if (item.StringId == "book_bow")
            {
                name = new TextObject("The History of Westerosi Archery{@Plural}collection of The History of Westerosi Archery{\\@}");
            }
            else if (item.StringId == "book_twoHanded")
            {
                name = new TextObject("Sarnoreid{@Plural}collection of Sarnoreid{\\@}");
            }
            else if (item.StringId == "book_oneHanded")
            {
                name = new TextObject("Water Dancing Ms. I.33{@Plural}collection of Water Dancing Ms. I.33{\\@}");
            }
            else if (item.StringId == "book_dictionary")
            {
                name = new TextObject("Dictionarium Valyrium{@Plural}collection of Dictionarium Valyrium{\\@}");
            }
            else if (item.StringId == "book_leadership")
            {
                name = new TextObject("The Harpy's Will{@Plural}collection of The Harpy's Will{\\@}");
            }
            else if (item.StringId == "book_irk_bitig")
            {
                name = new TextObject("Book of Visions{@Plural}collection of Book of Visions{\\@}");
            }
            else if (item.StringId == "book_skulls_eleftheroi")
            {
                name = new TextObject("Skulls of the Naathi{@Plural}collection of Skulls of the Naathi{\\@}");
            }
            else if (item.StringId == "book_west_gemynt")
            {
                name = new TextObject("North{@Plural}collection of North{\\@}");
            }
            else if (item.StringId == "book_fabulae_aquilae")
            {
                name = new TextObject("Fabulae Draconae{@Plural}collection of Fabulae Draconae{\\@}");
            }
            value = value / 100;
            return true;
        }
    }
}
