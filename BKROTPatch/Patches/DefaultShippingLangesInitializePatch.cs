using BannerKings.Managers.Innovations.Eras;
using BannerKings.Managers.Shipping;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BKROTPatch.Patches
{
    [HarmonyPatch(typeof(DefaultShippingLanes), nameof(DefaultShippingLanes.Initialize))]
    internal class DefaultShippingLangesInitializePatch
    {
        public static bool Prefix(DefaultShippingLanes __instance)
        {
            __instance.Laconis.Initialize(new TextObject("{=ZJBYtrAB}Laconian Shipping Network"),
                new TextObject(),
                new List<Settlement>()
                {
                    
                });

            __instance.Western.Initialize(new TextObject("{=tySxydya}Western Sea Network"),
                new TextObject(),
                new List<Settlement>()
                {

                });

            __instance.Junme.Initialize(new TextObject("{=FGXR8tdb}Junme Trade Network"),
                new TextObject(),
                new List<Settlement>()
                {
                    
                });

            __instance.Perassic.Initialize(new TextObject("{=TFoGRBnG}Perassic Trade Network"),
                new TextObject(),
                new List<Settlement>()
                {
                    
                });
            return false;
        }
    }
}
