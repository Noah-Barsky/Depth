using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Depth.Projectiles
{
    public class ThornstoneYoYoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 5.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 190f; // 130f = Wood, 400f = Terrarian
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 12f; // 7f = wood 17 = Terrarian
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }

        public override void PostAI()
        {
            if (Main.rand.NextBool())
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 180);
                dust.noGravity = true;
                dust.scale = 1.8f;
            }
        }
    }
}