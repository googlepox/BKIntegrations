using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BKROTPatch.Helpers
{
    internal class CultureHelpers
    {

        public static bool IsCultureWesterosi(CultureObject culture)
        {
            return culture.StringId == "nightswatch"
                || culture.StringId == "vale"
                || culture.StringId == "river"
                || culture.StringId == "dragonstone"
                || culture.StringId == "stormlands"
                || culture.StringId == "reach"
                || culture.StringId == "aserai"
                || culture.StringId == "vlandia"
                || culture.StringId == "crownlands";
        }

        public static bool IsCultureNorthmen(CultureObject culture)
        {
            return culture.StringId == "battania"
                || culture.StringId == "freefolk"
                || culture.StringId == "skagosi";
        }

        public static bool IsCultureEssosi(CultureObject culture)
        {
            return culture.StringId == "ghiscari"
                || culture.StringId == "empire"
                || culture.StringId == "khuzait"
                || culture.StringId == "sarnor"
                || culture.StringId == "norvos"
                || culture.StringId == "valyrian"
                || culture.StringId == "volantine"
                || culture.StringId == "qohorik"
                || culture.StringId == "lorathi"
                || culture.StringId == "pentoshi"
                || culture.StringId == "myrish"
                || culture.StringId == "tyroshi"
                || culture.StringId == "lyseni"
                || culture.StringId == "yiti"
                || culture.StringId == "summer";
        }

    }
}
