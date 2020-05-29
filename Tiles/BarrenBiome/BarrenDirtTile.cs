using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Depth.Tiles.BarrenBiome {
    public class BarrenDirtTile : ModTile {
        public override void SetDefaults() {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileBlockLight[Type] = false;
            Main.tileLighted[Type] = false;
            // Main.tileMerge[Type][mod.TileType("AuroraStoneTile")] = true;
            drop = mod.ItemType("BarrenDirt");
            AddMapEntry(new Color(15, 61, 61));
            SetModTree(new Tree.BarrenthornTree());
        }

        public override int SaplingGrowthType(ref int style) {
            style = 0;
            return mod.TileType("BarrenthornSapling");

        }
    }
}