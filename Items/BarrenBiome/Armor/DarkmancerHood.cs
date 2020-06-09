using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Depth.Items.BarrenBiome.Armor {
    [AutoloadEquip(EquipType.Head)]
    public class DarkmancerHood : ModItem {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Increases player health by 15");
        }

        public override void SetDefaults() {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = 2;
            item.defense = 5;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs) {
            return body.type == ItemType<DarkmancerBreastplate>() && legs.type == ItemType<DarkmancerLeggings>();
        }

        public override void UpdateEquip(Player player) {
            player.statLifeMax2 += 15;
        }

        public override void UpdateArmorSet(Player player) {
            player.setBonus = "Increases player damage by 5%.";
            player.allDamage += 0.05f;
            player.AddBuff(BuffType<Buffs.SoulBuff>(), 2);

        }
    }
}
