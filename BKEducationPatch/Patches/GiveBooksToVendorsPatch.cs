using BannerKings;
using BannerKings.Behaviours;
using HarmonyLib;
using LT_Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace BKEducationPatch.Patches
{
    [HarmonyPatch(typeof(LT_EducationBehaviour), "GiveBooksToVendors")]
    internal class GiveBooksToVendorsPatch
    {
        public static void Postfix(LT_EducationBehaviour __instance)
        {
            MethodInfo startingBooksMethod = AccessTools.Method(typeof(BKEducationBehavior), "GetStartingBooks");
            List<Hero> vendorList = (List<Hero>) AccessTools.Field(typeof(LT_EducationBehaviour), "_vendorList").GetValue(__instance);
            foreach (Hero vendor in vendorList)
            {
                if (vendor != null)
                {
                    List<ItemObject> vendorBooks = LT_EducationBehaviour.GetVendorBooks(vendor).ToList<ItemObject>();
                    ItemRoster startingBooks = (ItemRoster) startingBooksMethod.Invoke(BKEducationBehavior.GetCampaignBehavior<BKEducationBehavior>(), new object[] { vendor.Culture });
                    foreach (ItemRosterElement item in startingBooks)
                    {
                        vendorBooks.Add(item.EquipmentElement.Item);
                    }
                }

            }
        }
    }
}
