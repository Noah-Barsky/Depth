using System;
using Terraria;
using Terraria.ModLoader;

namespace Depth.Items.BarrenBiome
{
    public class HardenGel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Harden Gel");
            Tooltip.SetDefault("Almost useless gel.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = Item.sellPrice(copper: 25);
            item.rare = 3;
            item.maxStack = 999;
        }
    }
}
