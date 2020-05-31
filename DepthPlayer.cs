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
using Depth;


namespace Depth
{
    public class DepthPlayer : ModPlayer
    {
        public bool GenBarren;

        public bool ZoneBarren;

        public override void UpdateBiomes()
        {
            ZoneBarren = DepthWorld.BarrenDirtTile > 150;
        }

        public override void CopyCustomBiomesTo(Player other)
        {
            DepthPlayer modOther = other.GetModPlayer<DepthPlayer>();
            modOther.ZoneBarren = ZoneBarren;
        }

        public override void SendCustomBiomes(BinaryWriter writer)
        {

            BitsByte flags = new BitsByte();
            flags[0] = ZoneBarren;
            writer.Write(flags);
        }
		
        public override void ReceiveCustomBiomes(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            ZoneBarren = flags[0];

        }

    }
}