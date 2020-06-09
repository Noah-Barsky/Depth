using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Depth.Buffs {
    public class SoulBuff : ModBuff {
        public override void SetDefaults() {
            DisplayName.SetDefault("Darkmancer Souls");
            Description.SetDefault("\"Conjured souls to protect you.\"");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex) {
            bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<Projectiles.PlasmaBall>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
                Main.LocalPlayer.GetModPlayer<DepthPlayer>().soulProjectile = Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ProjectileType<Projectiles.PlasmaBall>(), 5, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}