using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Depth.Items.BarrenBiome.Thornstone {

    public class ThornstoneYoYo : ModItem { 

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Necrophagous");
            Tooltip.SetDefault("This yoyo shoots a chaotic second yoyo!");
        }

        public override void SetDefaults() {
            item.useStyle = 5;
            item.damage = 15;
            item.width = 22;
            item.height = 30;
            item.shoot = mod.ProjectileType("ThornstoneYoYoProjectile");
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 5;
            item.value = Item.sellPrice(silver: 1);
            item.rare = 2;
            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
            float numberProjectiles = 2;
            float rotation = MathHelper.ToRadians(6);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 15f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 0.7f;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}