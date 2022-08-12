﻿using System.Text.RegularExpressions;
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
new Price(75, 190, 100, 255, 115, 285, 15, 45)

.BuildFish(
"Sunny Splashtail",
"images\fishes\Sunny_Splashtail.png",
new Location(),
new Price(150, 375, 205, 505, 225, 565, 35, 85)

.BuildFish(
"Indigo Splashtail",
"images\fishes\Indigo_Splashtail.png",
new Location(),
new Price(255, 565, 305, 765, 340, 850, 50, 130)

.BuildFish(
"Umber Splashtail",
"images\fishes\Umber_Splashtail.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Seafoam Splashtail",
"images\fishes\Seafoam_Splashtail.png",
new Location(),
new Price(150, 375, 205, 505, 225, 565, 35, 80)

.BuildFish(
"Charcoal Pondie",
"images\fishes\Charcoal_Pondie.png",
new Location(),
new Price(75, 190, 100, 255, 115, 285, 15, 45)

.BuildFish(
"Orchid Pondie",
"images\fishes\Orchid_Pondie.png",
new Location(),
new Price(150, 375, 205, 505, 225, 565, 35, 85)

.BuildFish(
"Bronze Pondie",
"images\fishes\Bronze_Pondie.png",
new Location(),
new Price(255, 565, 305, 765, 340, 850, 50, 130)

.BuildFish(
"Bright Pondie",
"images\fishes\Bright_Pondie.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Moonsky Pondie",
"images\fishes\Moonsky_Pondie.png",
new Location(),
new Price(150, 375, 205, 505, 225, 565, 35, 85)

.BuildFish(
"Almond Ancientscale",
"images\fishes\Almond_Ancientscale.png",
new Location(),
new Price(225, 565, 305, 765, 340, 850, 50, 130)

.BuildFish(
"Sapphire Ancientscale",
"images\fishes\Sapphire_Ancientscale.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Smoke Ancientscale",
"images\fishes\Smoke_Ancientscale.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Bone Ancientscale",
"images\fishes\Bone_Ancientscale.png",
new Location(),
new Price(3000, 7500, 4050, 10125, 4500, 11250, 675, 1690)

.BuildFish(
"Starshine Ancientscale",
"images\fishes\Starshine_Ancientscale.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Olive Plentifin",
"images\fishes\Olive_Plentifin.png",
new Location(),
new Price(225, 565, 305, 765, 340, 850, 50, 130)

.BuildFish(
"Amber Plentifin",
"images\fishes\Amber_Plentifin.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Cloudy Plentifin",
"images\fishes\Cloudy_Plentifin.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Bonedust Plentifin",
"images\fishes\Bonedust_Plentifin.png",
new Location(),
new Price(3000, 7500, 4050, 10125, 4500, 11250, 675, 1690)

.BuildFish(
"Watery Plentifin",
"images\fishes\Watery_Plentifin.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Russet Wildsplash",
"images\fishes\Russet_Wildsplash.png",
new Location(),
new Price(225, 565, 305, 765, 340, 850, 50, 130)

.BuildFish(
"Sandy Wildsplash",
"images\fishes\Sandy_Wildsplash.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Ocean Wildsplash",
"images\fishes\Ocean_Wildsplash.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Muddy Wildsplash",
"images\fishes\Muddy_Wildsplash.png",
new Location(),
new Price(3000, 7500, 4050, 10125, 4500, 11250, 675, 1690)

.BuildFish(
"Coral Wildsplash",
"images\fishes\Coral_Wildsplash.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Ashen Devilfish",
"images\fishes\Ashen_Devilfish.png",
new Location(),
new Price(225, 565, 305, 765, 340, 850, 50, 130)

.BuildFish(
"Seashell Devilfish",
"images\fishes\Seashell_Devilfish.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Lava Devilfish",
"images\fishes\Lava_Devilfish.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Forsaken Devilfish",
"images\fishes\Forsaken_Devilfish.png",
new Location(),
new Price(3000, 7500, 4050, 10125, 4500, 11250, 675, 1690)

.BuildFish(
"Firelight Devilfish",
"images\fishes\Firelight_Devilfish.png",
new Location(),
new Price(300, 750, 405, 1015, 450, 1125, 70, 170)

.BuildFish(
"Jade Battlegill",
"images\fishes\Jade_Battlegill.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Sky Battlegill",
"images\fishes\Sky_Battlegill.png",
new Location(),
new Price(450, 1125, 610, 1520, 675, 1690, 100, 225)

.BuildFish(
"Rum Battlegill",
"images\fishes\Rum_Battlegill.png",
new Location(),
new Price(525, 1315, 710, 1775, 790, 1975, 120, 295)

.BuildFish(
"Sand Battlegill",
"images\fishes\Sand_Battlegill.png",
new Location(),
new Price(3750, 9375, 5065, 12655, 5625, 14065, 845, 2110)

.BuildFish(
"Bittersweet Battlegill",
"images\fishes\Bittersweet_Battlegill.png",
new Location(),
new Price(450, 1125, 610, 1520, 675, 1690, 100, 225)

.BuildFish(
"Rose Wrecker",
"images\fishes\Rose_Wrecker.png",
new Location(),
new Price(375, 940, 505, 1270, 565, 1410, 85, 210)

.BuildFish(
"Sun Wrecker",
"images\fishes\Sun_Wrecker.png",
new Location(),
new Price(450, 1125, 610, 1520, 675, 1690, 100, 225)

.BuildFish(
"Blackcloud Wrecker",
"images\fishes\Blackcloud_Wrecker.png",
new Location(),
new Price(525, 1315, 710, 1775, 790, 1975, 120, 295)

.BuildFish(
"Snow Wrecker",
"images\fishes\Snow_Wrecker.png",
new Location(),
new Price(3750, 9375, 5065, 12655, 5625, 14065, 845, 2110)

.BuildFish(
"Moon Wrecker",
"images\fishes\Moon_Wrecker.png",
new Location(),
new Price(450, 1125, 610, 1520, 675, 1690, 100, 225)
 */