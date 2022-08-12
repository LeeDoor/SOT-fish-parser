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
.BuildFish(
"Ruby Splashtail",
"images\fishes\Ruby_Splashtail.png",
new Location(),
new Price(75, 190, 115, 285)

.BuildFish(
"Sunny Splashtail",
"images\fishes\Sunny_Splashtail.png",
new Location(),
new Price(150, 375, 225, 565)

.BuildFish(
"Indigo Splashtail",
"images\fishes\Indigo_Splashtail.png",
new Location(),
new Price(255, 565, 340, 850)

.BuildFish(
"Umber Splashtail",
"images\fishes\Umber_Splashtail.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Seafoam Splashtail",
"images\fishes\Seafoam_Splashtail.png",
new Location(),
new Price(150, 375, 225, 565)

.BuildFish(
"Charcoal Pondie",
"images\fishes\Charcoal_Pondie.png",
new Location(),
new Price(75, 190, 115, 285)

.BuildFish(
"Orchid Pondie",
"images\fishes\Orchid_Pondie.png",
new Location(),
new Price(150, 375, 225, 565)

.BuildFish(
"Bronze Pondie",
"images\fishes\Bronze_Pondie.png",
new Location(),
new Price(255, 565, 340, 850)

.BuildFish(
"Bright Pondie",
"images\fishes\Bright_Pondie.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Moonsky Pondie",
"images\fishes\Moonsky_Pondie.png",
new Location(),
new Price(150, 375, 225, 565)

.BuildFish(
"Almond Ancientscale",
"images\fishes\Almond_Ancientscale.png",
new Location(),
new Price(225, 565, 340, 850)

.BuildFish(
"Sapphire Ancientscale",
"images\fishes\Sapphire_Ancientscale.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Smoke Ancientscale",
"images\fishes\Smoke_Ancientscale.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Bone Ancientscale",
"images\fishes\Bone_Ancientscale.png",
new Location(),
new Price(3000, 7500, 4500, 11250)

.BuildFish(
"Starshine Ancientscale",
"images\fishes\Starshine_Ancientscale.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Olive Plentifin",
"images\fishes\Olive_Plentifin.png",
new Location(),
new Price(225, 565, 340, 850)

.BuildFish(
"Amber Plentifin",
"images\fishes\Amber_Plentifin.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Cloudy Plentifin",
"images\fishes\Cloudy_Plentifin.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Bonedust Plentifin",
"images\fishes\Bonedust_Plentifin.png",
new Location(),
new Price(3000, 7500, 4500, 11250)

.BuildFish(
"Watery Plentifin",
"images\fishes\Watery_Plentifin.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Russet Wildsplash",
"images\fishes\Russet_Wildsplash.png",
new Location(),
new Price(225, 565, 340, 850)

.BuildFish(
"Sandy Wildsplash",
"images\fishes\Sandy_Wildsplash.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Ocean Wildsplash",
"images\fishes\Ocean_Wildsplash.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Muddy Wildsplash",
"images\fishes\Muddy_Wildsplash.png",
new Location(),
new Price(3000, 7500, 4500, 11250)

.BuildFish(
"Coral Wildsplash",
"images\fishes\Coral_Wildsplash.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Ashen Devilfish",
"images\fishes\Ashen_Devilfish.png",
new Location(),
new Price(225, 565, 340, 850)

.BuildFish(
"Seashell Devilfish",
"images\fishes\Seashell_Devilfish.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Lava Devilfish",
"images\fishes\Lava_Devilfish.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Forsaken Devilfish",
"images\fishes\Forsaken_Devilfish.png",
new Location(),
new Price(3000, 7500, 4500, 11250)

.BuildFish(
"Firelight Devilfish",
"images\fishes\Firelight_Devilfish.png",
new Location(),
new Price(300, 750, 450, 1125)

.BuildFish(
"Jade Battlegill",
"images\fishes\Jade_Battlegill.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Sky Battlegill",
"images\fishes\Sky_Battlegill.png",
new Location(),
new Price(450, 1125, 675, 1690)

.BuildFish(
"Rum Battlegill",
"images\fishes\Rum_Battlegill.png",
new Location(),
new Price(525, 1315, 790, 1975)

.BuildFish(
"Sand Battlegill",
"images\fishes\Sand_Battlegill.png",
new Location(),
new Price(3750, 9375, 5625, 14065)

.BuildFish(
"Bittersweet Battlegill",
"images\fishes\Bittersweet_Battlegill.png",
new Location(),
new Price(450, 1125, 675, 1690)

.BuildFish(
"Rose Wrecker",
"images\fishes\Rose_Wrecker.png",
new Location(),
new Price(375, 940, 565, 1410)

.BuildFish(
"Sun Wrecker",
"images\fishes\Sun_Wrecker.png",
new Location(),
new Price(450, 1125, 675, 1690)

.BuildFish(
"Blackcloud Wrecker",
"images\fishes\Blackcloud_Wrecker.png",
new Location(),
new Price(525, 1315, 790, 1975)

.BuildFish(
"Snow Wrecker",
"images\fishes\Snow_Wrecker.png",
new Location(),
new Price(3750, 9375, 5625, 14065)

.BuildFish(
"Moon Wrecker",
"images\fishes\Moon_Wrecker.png",
new Location(),
new Price(450, 1125, 675, 1690)
 */