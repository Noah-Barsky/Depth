using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace Depth.Projectiles
{
    public class PlasmaSurge : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "PlasmaSurge";
            projectile.magic = true;
            projectile.friendly = true;
            projectile.width = 16;
            projectile.height = 16;
            projectile.timeLeft = 3600;
            projectile.aiStyle = 0;
            projectile.penetrate = -1;
            projectile.light = 1f;

            // make it tincy
            projectile.scale = 0.2f;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (projectile.damage >= 5)
            {
                for (int i = 0; i < 4; i++)
                {

                    float speedX = Main.rand.Next(0, 10) - 5;
                    float speedY = -Main.rand.Next(5, 9);
                    Projectile.NewProjectile(projectile.position.X, projectile.position.Y + speedY, speedX, speedY, mod.ProjectileType("PlasmaSurge"), (int)(projectile.damage * 0.5), 0f, projectile.owner, 0f, 0f);
                }
            }
        }

        public override void AI()
        {
            projectile.velocity.Y = projectile.velocity.Y + 0.4f; // 0.1f for arrow gravity, 0.4f for knife gravity
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }
            Dust.NewDustPerfect(projectile.Center, 21, projectile.velocity).noGravity = true;

        }
    }
}
