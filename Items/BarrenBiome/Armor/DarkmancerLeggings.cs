using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace Depth.Items.BarrenBiome.Armor {

    [AutoloadEquip(EquipType.Legs)]
    public class DarkmancerLeggings : ModItem {

        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Increases player movement speed by 5%"
                + "\nIncreases player health by 15");
        }

        public override void SetDefaults() {
            item.width = 22;
            item.height = 16;
            item.value = 10000;
            item.rare = 2;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player) {
            player.moveSpeed += 0.05f;
            player.statLifeMax2 += 15;
        }
    }
}