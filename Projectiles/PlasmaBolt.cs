using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace Depth.Projectiles
{
    public class PlasmaBolt : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "PlasmaBolt";
            projectile.magic = true;
            projectile.friendly = true;
            projectile.width = 16;
            projectile.height = 16;
            projectile.timeLeft = 3600;
            projectile.aiStyle = 0;
            projectile.light = 1f;

            // make it smaller
            projectile.scale = 0.5f;
        }

        public override void AI()
        {
            Dust.NewDustPerfect(projectile.Center, 21, projectile.velocity).noGravity = true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for (int i = 0; i < 4; i++)
            {

                float speedX = Main.rand.Next(0, 10) - 5;
                float speedY = -Main.rand.Next(5, 9);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y + speedY, speedX, speedY, mod.ProjectileType("PlasmaSurge"), (int)(projectile.damage * 0.5), 0f, projectile.owner, 0f, 0f);
            }
        }
    }
}
