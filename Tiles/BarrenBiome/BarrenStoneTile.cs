using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Depth.Tiles.BarrenBiome
{
    public class BarrenStoneTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileBlockLight[Type] = false;
            Main.tileLighted[Type] = false;
            drop = mod.ItemType("BarrenStone");
            AddMapEntry(new Color(15, 61, 61));
        }
    }
}