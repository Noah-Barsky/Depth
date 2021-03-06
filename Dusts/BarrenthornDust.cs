using Terraria;
using Terraria.ModLoader;
using System;

namespace Depth.Dusts {
    public class BarrenthornDust : ModDust {
        public override void OnSpawn(Dust dust) {
            dust.velocity *= 0.4f;
            dust.velocity.Y = Math.Abs(dust.velocity.Y); // makes all dust go up
            dust.noGravity = true;
            dust.noLight = true;
            // dust.scale *= 0.5f;
        }

        public override bool Update(Dust dust) {
            dust.position -= dust.velocity;
            dust.rotation += dust.velocity.X * 0.25f;
            dust.scale *= 0.99f;
            float light = 0.35f * dust.scale;
            Lighting.AddLight(dust.position, light, light, light);
            if (dust.scale < 0.5f) {
                dust.active = false;
            }
            return false;
        }
    }
}