using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using Depth.Tiles.BarrenBiome.Tree;

namespace Depth.Tiles.BarrenBiome.Tree
{
    public class BarrenthornTree : ModTree
    {
        private static Mod mod
        {
            get
            {
                return ModLoader.GetMod("Depth");
            }
        }

        public override int CreateDust()
        {
            return mod.DustType("Sparkle");
        }

        public override int GrowthFXGore()
        {
            return mod.GetGoreSlot("Gores/BarrenthornTreeFX");
        }

        public override int DropWood()
        {
            return mod.ItemType("HardenGel");
        }

        public override Texture2D GetTexture()
        {
            return mod.GetTexture("Tiles/BarrenBiome/Tree/BarrenthornTree");
        }

        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
        {
            return mod.GetTexture("Tiles/BarrenBiome/Tree/BarrenthornTree_Tops");
        }

        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
        {
            return mod.GetTexture("Tiles/BarrenBiome/Tree/BarrenthornTree_Branches");
        }
    }
}