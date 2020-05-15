using System;
using Terraria;
using Terraria.ModLoader;

namespace Depth.Items
{
    public class PlasmicChunk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plasmic Chunk");
            Tooltip.SetDefault("A malleable form of Plasma. ");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = Item.sellPrice(silver: 25);
            item.rare = 3;
            item.maxStack = 999;
        }
    }
}
