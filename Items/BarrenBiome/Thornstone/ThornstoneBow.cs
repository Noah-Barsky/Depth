using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Depth.Items.BarrenBiome.Thornstone
{
    public class ThornstoneBow : ModItem {
                
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Necropolis");
            Tooltip.SetDefault("Shoots 2 arrows at the cost of one");
        }
        public override void SetDefaults() {
            item.damage = 21;
            item.noMelee = true;
            item.ranged = true;
            item.scale = 0.8f;
            item.width = 20;
            item.height = 34;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.value = 1000;
            item.rare = 3;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 25f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
            float numberProjectiles = 2;
            float rotation = MathHelper.ToRadians(6);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 0.7f;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}