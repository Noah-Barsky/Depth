using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Depth.Dusts;
using static Terraria.ModLoader.ModContent;


namespace Depth {
    public class DepthPlayer : ModPlayer {
        public bool GenBarren;

        public bool ZoneBarren = false;
        private float ZoneBarrenIntensity = 1;

        private void DrawHaze() {
            for (int k = (int)Math.Floor(player.position.X / 16) - 55; k < (int)Math.Floor(player.position.X / 16) + 55; k++) {
                for (int i = (int)Math.Floor(player.position.Y / 16) - 30; i < (int)Math.Floor(player.position.Y / 16) + 30; i++) {
                    if (!Main.tile[k, i - 1].active() && !Main.tile[k, i - 2].active() && Main.tile[k, i].active() && Main.tile[k, i].type != TileID.Trees) {
                        if (Main.rand.Next(0, 40) == 2) {
                            Dust.NewDust(new Vector2((k - 2) * 16, (i - 1) * 16), 5, 5, DustType<HazeDust>());
                        }
                    }
                }
            }
        }

        public override void UpdateBiomeVisuals() {
            if (Main.netMode != NetmodeID.Server) {
                if (ZoneBarren) {
                    if (ZoneBarrenIntensity > 0.35) ZoneBarrenIntensity -= 0.004f;
                    Filters.Scene.Activate("BarrenSky");
                    Filters.Scene["BarrenSky"].GetShader().UseIntensity(ZoneBarrenIntensity);

                    DrawHaze();
                } else {
                    if (ZoneBarrenIntensity < 1) {
                        ZoneBarrenIntensity += 0.004f;
                        if (ZoneBarrenIntensity > 1) ZoneBarrenIntensity = 1;
                        Filters.Scene["BarrenSky"].GetShader().UseIntensity(ZoneBarrenIntensity);
                    } else {
                        Filters.Scene["BarrenSky"].Deactivate();
                    }
                }
            }
        }

        public override void UpdateBiomes() {
            ZoneBarren = DepthWorld.BarrenDirtTile > 150;
            if (ZoneBarren) {
                if (player.velocity.X != 0 && player.velocity.Y == 0) {
                    Dust.NewDust(new Vector2(player.position.X, player.position.Y + player.Size.Y), 5, 5, DustType<BarrenthornDust>());
                }
            }
        }

        public override void CopyCustomBiomesTo(Player other) {
            DepthPlayer modOther = other.GetModPlayer<DepthPlayer>();
            modOther.ZoneBarren = ZoneBarren;
        }

        public override void SendCustomBiomes(BinaryWriter writer) {

            BitsByte flags = new BitsByte();
            flags[0] = ZoneBarren;
            writer.Write(flags);
        }

        public override void ReceiveCustomBiomes(BinaryReader reader) {
            BitsByte flags = reader.ReadByte();
            ZoneBarren = flags[0];

        }

    }
}