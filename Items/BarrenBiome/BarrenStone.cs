using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Depth.Items.BarrenBiome
{
    public class BarrenStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Barren Chunk");
            Tooltip.SetDefault(".");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("BarrenStoneTile");
        }
    }
}
