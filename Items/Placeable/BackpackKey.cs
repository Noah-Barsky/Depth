using Terraria.ID;
using Terraria.ModLoader;

namespace Depth.Items.Placeable
{
    class BackpackKey : ModItem
    {
        public override void SetDefaults()
        {
            //item.CloneDefaults(ItemID.GoldenKey);
            item.width = 14;
            item.height = 20;
            item.maxStack = 99;
        }
    }
}