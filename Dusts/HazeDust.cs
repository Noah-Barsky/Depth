using Terraria;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace Depth.Dusts {
    public class HazeDust : ModDust {
        private int timer = 0;
        public override void OnSpawn(Dust dust) {
            dust.velocity *= 0.05f;
            dust.velocity.Y *= 0.5f;
            dust.noGravity = true;
            dust.noLight = true;
            dust.scale *= 0.2f;
            dust.frame = new Rectangle((Main.rand.Next(0, 1) == 0) ? 0 : 250, 0, 250, 115);
            dust.alpha = 200;
        }

        public override bool Update(Dust dust) {
            if (Main.rand.Next(0, 10) == 1) dust.alpha++;
            dust.position -= dust.velocity;
            float light = 0.35f * dust.scale;
            Lighting.AddLight(dust.position, light, light, light);
            if (dust.alpha > 255) {
                dust.active = false;
            }
            return false;
        }
    }
}