using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Depth.Items.Placeable
{
    public class Backpack : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A backpack");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 500;
            item.createTile = TileType<Tiles.Chests.BackpackTile>();
        }
    }
}