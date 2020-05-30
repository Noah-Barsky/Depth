using Depth.Items;
using Depth.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;
using Depth.BaseMod;
using Depth.BarrenBiome;

namespace Depth 
{
    public class DepthWorld : ModWorld
    {
        //Tile stuff
        public static bool spawnOre = false;
        public static int BarrenDirtTile;

        private void GenBarren(GenerationProgress progress)
        {
            progress.Message = "Malificus souls crafting a wasteland..";

            int startPositionX = ((int)(Main.maxTilesX * 0.53f));
            int startPositionY = ((int)(Main.maxTilesY * 0.23f));

            BarrenBiome.BarrenBiome.Generate(startPositionX, startPositionY);
        }
      
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight) {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Slush"));
            if (shiniesIndex == -1) {
                return;
            }
            tasks.Insert(shiniesIndex + 8, new PassLegacy("Mod Biomes", GenBarren));


        }
    }
}















