using System.Collections.Generic;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Library;

namespace Biggerlord.Patches
{
    internal class BKCECreationContentPatch
    {
        public static void BKCECreationContentPostfix(CharacterCreation characterCreation, ref Dictionary<string, Vec2> ____startingPoints)
        {
            ____startingPoints = new Dictionary<string, Vec2>
            {
                {
                "empire",
                new Vec2(1929.95f, 1551.08f)
                },
                {
                "sturgia",
                new Vec2(1628.75f, 1823.52f)
                },
                {
                "aserai",
                new Vec2(1572.78f, 1531.99f)
                },
                {
                "battania",
                new Vec2(1565.64f, 1718.39f)
                },
                {
                "khuzait",
                new Vec2(1952.73f, 1752.8f)
                },
                {
                "vlandia",
                new Vec2(1479.04f, 1661.04f)
                },
                {
                "siri",
                new Vec2(1657.5405f, 1325.993f)
                },
                {
                "darshi",
                new Vec2(2037.1729f, 1422.5149f)
                },
                {
                "geroia",
                new Vec2(1750.6044f, 1489.9456f)
                },
                {
                "nord",
                new Vec2(1442.9158f, 1859.5662f)
                },
                {
                "massa",
                new Vec2(1463.1839f, 1453.5139f)
                },
                {
                "vakken",
                new Vec2(1914.2234f, 1896.5721f)
                },
                {
                "kannic",
                new Vec2(1534.9534f, 1535.2021f)
                },
                {
                "balion",
                new Vec2(1333.83505f, 1606.9693f)
                },
                {
                "bragantia",
                new Vec2(1333.83505f, 1606.9693f)
                },
                {
                "lokti",
                new Vec2(2072.6518f, 1989.6616f)
                },
                {
                "iltanlar",
                new Vec2(2002.2615f, 1808.8068f)
                },
                {
                "zendar",
                new Vec2(1591.775f, 1793.8525f)
                },
                {
                "rhodok",
                new Vec2(1479.04f, 1661.04f)
                },
                {
                "swadia",
                new Vec2(1479.04f, 1661.04f)
                },
            };
        }
    }
}
