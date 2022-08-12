using System.Text.RegularExpressions;
namespace Fishes_SOT_parser
{
    public static class Program
    {
        public static void Main()
        {
            Parser.Start("https://seaofthieves.fandom.com/wiki/Fish");
        }
    }
}
/*
-----------------output----------------------


 .BuildFish("Ruby Splashtail",
 "Base variant",
new Price( 75,  190,  100,  255,  115,  285,  15,  45,  )
.BuildFish("Sunny Splashtail",
 "Common variant",
new Price( 150,  375,  205,  505,  225,  565,  35,  85,  )
.BuildFish("Indigo Splashtail",
 "Uncommon variant",
new Price( 255,  565,  305,  765,  340,  850,  50,  130,  )
.BuildFish("Umber Splashtail",
 "Rare variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Seafoam Splashtail",
 "Night variant",
new Price( 150,  375,  205,  505,  225,  565,  35,  80,
)
.BuildFish("Charcoal Pondie",
 "Base variant",
new Price( 75,  190,  100,  255,  115,  285,  15,  45,  )
.BuildFish("Orchid Pondie",
 "Common variant",
new Price( 150,  375,  205,  505,  225,  565,  35,  85,  )
.BuildFish("Bronze Pondie",
 "Uncommon variant",
new Price( 255,  565,  305,  765,  340,  850,  50,  130,  )
.BuildFish("Bright Pondie",
 "Rare variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Moonsky Pondie",
 "Night variant",
new Price( 150,  375,  205,  505,  225,  565,  35,  85,
)
.BuildFish("Stone Islehopper",
 105,  265,  140,  360,  160,  400,  25,  60,  )
.BuildFish("Moss Islehopper",
 105,  265,  140,  360,  160,  400,  25,  60,  )
.BuildFish("Honey Islehopper",
 105,  265,  140,  360,  160,  400,  25,  60,  )
.BuildFish("Raven Islehopper",
 1_050,  2_625,  1_420,  3_545,  1_575,  3_940,  235,  590,  )
.BuildFish("Amethyst Islehopper",
 105,  265,  140,  360,  160,  400,  25,  60,
)
.BuildFish("Almond Ancientscale",
 "Base variant",
new Price( 225,  565,  305,  765,  340,  850,  50,  130,  )
.BuildFish("Sapphire Ancientscale",
 "Common variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,  )
.BuildFish("Smoke Ancientscale",
 "Uncommon variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Bone Ancientscale",
 "Rare variant",
new Price( 3_000,  7_500,  4_050,  10_125,  4_500,  11_250,  675,  1_690,  )
.BuildFish("Starshine Ancientscale",
 "Night variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,
)
.BuildFish("Olive Plentifin",
 "Base variant",
new Price( 225,  565,  305,  765,  340,  850,  50,  130,  )
.BuildFish("Amber Plentifin",
 "Common variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,  )
.BuildFish("Cloudy Plentifin",
 "Uncommon variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Bonedust Plentifin",
 "Rare variant",
new Price( 3_000,  7_500,  4_050,  10_125,  4_500,  11_250,  675,  1_690,  )
.BuildFish("Watery Plentifin",
 "Night variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,
)
.BuildFish("Russet Wildsplash",
 "Base variant",
new Price( 225,  565,  305,  765,  340,  850,  50,  130,  )
.BuildFish("Sandy Wildsplash",
 "Common variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,  )
.BuildFish("Ocean Wildsplash",
 "Uncommon variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Muddy Wildsplash",
 "Rare variant",
new Price( 3_000,  7_500,  4_050,  10_125,  4_500,  11_250,  675,  1_690,  )
.BuildFish("Coral Wildsplash",
 "Night variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,
)
.BuildFish("Ashen Devilfish",
 "Base variant",
new Price( 225,  565,  305,  765,  340,  850,  50,  130,  )
.BuildFish("Seashell Devilfish",
 "Common variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,  )
.BuildFish("Lava Devilfish",
 "Uncommon variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Forsaken Devilfish",
 "Rare variant",
new Price( 3_000,  7_500,  4_050,  10_125,  4_500,  11_250,  675,  1_690,  )
.BuildFish("Firelight Devilfish",
 "Night variant",
new Price( 300,  750,  405,  1_015,  450,  1_125,  70,  170,
)
.BuildFish("Jade Battlegill",
 "Base variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Sky Battlegill",
 "Common variant",
new Price( 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,  )
.BuildFish("Rum Battlegill",
 "Uncommon variant",
new Price( 525,  1_315,  710,  1_775,  790,  1_975,  120,  295,  )
.BuildFish("Sand Battlegill",
 "Rare variant",
new Price( 3_750,  9_375,  5_065,  12_655,  5_625,  14_065,  845,  2_110,  )
.BuildFish("Bittersweet Battlegill",
 "Night variant",
new Price( 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,
)
.BuildFish("Rose Wrecker",
 "Base variant",
new Price( 375,  940,  505,  1_270,  565,  1_410,  85,  210,  )
.BuildFish("Sun Wrecker",
 "Common variant",
new Price( 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,  )
.BuildFish("Blackcloud Wrecker",
 "Storm variant",
new Price( 525,  1_315,  710,  1_775,  790,  1_975,  120,  295,  )
.BuildFish("Snow Wrecker",
 "Rare variant",
new Price( 3_750,  9_375,  5_065,  12_655,  5_625,  14_065,  845,  2_110,  )
.BuildFish("Moon Wrecker",
 "Night variant",
new Price( 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,
)
.BuildFish("Ancient Stormfish",
 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,  )
.BuildFish("Shores Stormfish",
 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,  )
.BuildFish("Wild Stormfish",
 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,  )
.BuildFish("Shadow Stormfish",
 "Rare variant",
new Price( 4_500,  11_250,  6_075,  15_190,  6_750,  16_875,  1_015,  1_400,  )
.BuildFish("Twilight Stormfish",
 "Night variant",
new Price( 450,  1_125,  610,  1_520,  675,  1_690,  100,  225,
 */