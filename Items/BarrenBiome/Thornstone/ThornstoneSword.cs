using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Depth.Items.BarrenBiome.Thornstone {

    public class ThornstoneSword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Everlasting Demise");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults() {
            item.damage = 18;
            item.melee = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}
