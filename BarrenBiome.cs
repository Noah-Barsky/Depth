using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Depth.Tiles.BarrenBiome;
using Depth.BaseMod;
using static Terraria.ModLoader.ModContent;

namespace Depth.BarrenBiome
{
    public class BarrenBiome 
    {
        
        public static void Generate(int x, int y)
        {
            
            GenTiles(x, y);
        
        }
        private static void GenTiles(int x, int y)  
        {
            Dictionary<Color, int> colorToTile = new Dictionary<Color, int>   
            {
                //color to tile, these are all the color coded tiles, you can replace these with your own custom tiles of course
                [new Color(166, 215, 222)] = ModContent.TileType<BarrenDirtTile>(),   
                [new Color(91, 124, 143)] = ModContent.TileType<BarrenStoneTile>(),
                [new Color(255, 255, 255)] = -1, //leaving something white will not be affected during gen
                [Color.Black] = -2 //turn into air
            };

            Dictionary<Color, int> colorToWall = new Dictionary<Color, int> 
            {
                //color to wall, same thing as above but for walls, and change these to what you want
               // [new Color(47, 0, 93)] = ModContent.WallType<BarrenWall>(),
                [Color.Black] = -2, //turn into air
            };		
            
            TexGen gen = BaseWorldGenTex.GetTexGenerator(GetTexture("Depth/BarrenBiome/BarrenBiome"), colorToTile, GetTexture("Depth/BarrenBiome/BarrenBiomeWalls"), colorToWall);
            gen.Generate(x - (gen.width / 2), y - (gen.height / 2), true, true);
        
            //WorldGen.PlaceChest(x - 2, y + 202, (ushort)ModContent.TileType<Backpack>()); ///this code places a chest at a certain coordinate in the shadow biome, just ignore this lmao
            
        }
    }
}