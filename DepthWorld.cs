using Depth.Items;
using Depth.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace Depth
{
    public class DepthWorld : ModWorld
    {
        //Tile stuff
        public static bool spawnOre = false;
        public static int BarrenDirtTile;

        private void GenBarren(GenerationProgress progress)
        {
            progress.Message = "The bowels of souls are screeching..";
        IL_19:
            int startPositionX = WorldGen.genRand.Next(0, Main.maxTilesX - 2);
            int startPositionY = (int)Main.worldSurface;
            int size = 0;

            if (Main.maxTilesX == 4200 && Main.maxTilesY == 1200)
            {
                size = 190;
            }
            if (Main.maxTilesX == 6400 && Main.maxTilesY == 1800)
            {
                size = 240;
            }
            if (Main.maxTilesX == 8400 && Main.maxTilesY == 2400)
            {
                size = 300;
            }
            if (Main.tile[startPositionX, startPositionY].type == TileID.Ebonstone || Main.tile[startPositionX, startPositionY].type == TileID.Crimstone)

            {
                var startX = startPositionX;
                var startY = startPositionY;
                startX = startX - 100;
                startY = startY - 100;
                startY++;
                for (int x = startX - size; x <= startX + size; x++)
                {
                    for (int y = startY - size; y <= startY + size; y++)
                    {
                        if (Vector2.Distance(new Vector2(startX, startY), new Vector2(x, y)) <= size)
                        {


                            //if (Main.tile[x, y].wall == WallID.JungleUnsafe || Main.tile[x, y].wall == WallID.Jungle || Main.tile[x, y].wall == WallID.DirtUnsafe || Main.tile[x, y].wall == WallID.MudUnsafe || Main.tile[x, y].wall == WallID.Dirt || Main.tile[x, y].wall == WallID.GrassUnsafe || Main.tile[x, y].wall == WallID.Grass || Main.tile[x, y].wall == WallID.FlowerUnsafe || Main.tile[x, y].wall == WallID.CorruptGrassUnsafe || Main.tile[x, y].wall == WallID.CrimsonGrassUnsafe)
                            //{
                            //    Main.tile[x, y].wall = (ushort)mod.WallType("BarrenStoneTile");
                            // }


                            //   if (Main.tile[x, y].wall == WallID.CrimstoneUnsafe || Main.tile[x, y].wall == WallID.EbonstoneUnsafe || Main.tile[x, y].wall == WallID.SnowWallUnsafe || Main.tile[x, y].wall == WallID.Stone)
                            //  {
                            //      Main.tile[x, y].wall = (ushort)mod.WallType("BarrenStoneTile");
                            //  }


                            if (Main.tile[x, y].type == TileID.JungleGrass || Main.tile[x, y].type == TileID.Mud || Main.tile[x, y].type == TileID.SnowBlock || Main.tile[x, y].type == TileID.Sand || Main.tile[x, y].type == TileID.Ebonsand || Main.tile[x, y].type == TileID.Crimsand || Main.tile[x, y].type == TileID.FleshGrass || Main.tile[x, y].type == TileID.Mud || Main.tile[x, y].type == TileID.CorruptGrass || Main.tile[x, y].type == TileID.Dirt || Main.tile[x, y].type == TileID.Grass)
                            {
                                Main.tile[x, y].type = (ushort)mod.TileType("BarrenDirtTile");
                            }


                            //  if (Main.tile[x, y].type == 6 || Main.tile[x, y].type == 7 || Main.tile[x, y].type == 8 || Main.tile[x, y].type == 9 || Main.tile[x, y].type == 221 || Main.tile[x, y].type == 222 || Main.tile[x, y].type == 223 || Main.tile[x, y].type == 204 || Main.tile[x, y].type == 166 || Main.tile[x, y].type == 167 || Main.tile[x, y].type == 168 || Main.tile[x, y].type == 169 || Main.tile[x, y].type == 221 || Main.tile[x, y].type == 107 || Main.tile[x, y].type == 108 || Main.tile[x, y].type == 22 || Main.tile[x, y].type == 111 || Main.tile[x, y].type == 123 || Main.tile[x, y].type == 224 || Main.tile[x, y].type == 40 || Main.tile[x, y].type == 59)
                            //  {
                            //  Main.tile[x, y].type = (ushort)mod.TileType("ShadowOreTile");
                            //  }


                            if (Main.tile[x, y].type == TileID.Stone || Main.tile[x, y].type == TileID.Ebonstone || Main.tile[x, y].type == TileID.Crimstone || Main.tile[x, y].type == TileID.CorruptIce || Main.tile[x, y].type == TileID.FleshIce || Main.tile[x, y].type == TileID.IceBlock)
                            {
                                Main.tile[x, y].type = (ushort)mod.TileType("BarrenDirtTile");
                            }

                            if (Main.tile[x, y].liquid == 3)
                            {
                                WorldGen.PlaceTile(x, y, 162);
                            }

                        }
                    }
                }

                for (int k = 0; k < 1000; k++)
                {
                    int positionX = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int positionY = WorldGen.genRand.Next(0, Main.maxTilesY);
                    if (Main.tile[positionX, positionY].type == mod.TileType("BarrenDirtTile"))
                    {
                        WorldGen.TileRunner(positionX, positionY, WorldGen.genRand.Next(10, 10), WorldGen.genRand.Next(8, 12), (ushort)mod.TileType("BarrenDirtTile"), false, 0f, 0f, false, true);
                    }
                }
                for (int k = 0; k < Main.maxTilesX; k++)
                {
                    for (int i = 0; i < Main.maxTilesY; i++)
                    {
                        if (Main.tile[k, i].type == mod.TileType("BarrenDirtTile"))
                        {
                            if (Main.tile[k + 1, i].active() && Main.tile[k, i - 1].active() && Main.tile[k - 1, i].active() && Main.tile[k, i + 1].active())
                            {
                            }
                            else
                            {
                                Main.tile[k, i].type = (ushort)mod.TileType("BarrenDirtTile");
                            }
                        }
                    }
                }
            }
            else
                goto IL_19;

        }

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Slush"));
            if (shiniesIndex == -1)
            {
                return;
            }
            tasks.Insert(shiniesIndex + 8, new PassLegacy("Mod Biomes", GenBarren));


        }
    }
}















