using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Depth.Items.BarrenBiome.Armor {

    [AutoloadEquip(EquipType.Body)]
    public class DarkmancerBreastplate : ModItem {

        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Darkmancer Cloak");
            Tooltip.SetDefault("Increases health by 20");
        }

        public override void SetDefaults() {
            item.width = 30;
            item.height = 22;
            item.value = 10000;
            item.rare = 2;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player) {
           player.statLifeMax2 += 20;
        }
    }
}