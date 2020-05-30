using Terraria.ModLoader;
using Terraria;
using System.IO;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;
using Terraria.Localization;
using Terraria.DataStructures;
using Terraria.UI;
using ReLogic.Graphics;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;
using Terraria.Graphics.Effects;
using Depth.Projectiles;
using Depth.Items;
using Depth;

namespace Depth
{
	public class Depth : Mod
	{
		public static Mod BaseMod;

		public Depth()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
            };
		}

        public override void Unload()
        {
            BaseMod = null;
        }

        public override void PostSetupContent()
        {
            BaseMod = ModLoader.GetMod("BaseMod");
        }

        public static NPC NearestNPC(Vector2 pos, float distance = -1f, bool lightning = false, bool lineOfSight = true)
        {
            float shortestDistanceSq = -1;
            NPC closestNPC = null;
            for (int i = 0; i < 200; i++)
            {
                NPC npc = Main.npc[i];
                Vector2 toNPC = npc.Center - pos;
                if (npc.active && !npc.immortal && !npc.dontTakeDamage
                    && npc.type != NPCID.TargetDummy
                    && !npc.friendly && npc.type != NPCID.TargetDummy
                    && (shortestDistanceSq == -1 || shortestDistanceSq > toNPC.LengthSquared())
                    && (toNPC.LengthSquared() < distance * distance || distance == -1f)
                    && (!lineOfSight || Collision.CanHit(pos, 1, 1, npc.Center, 1, 1)))
                {
                    closestNPC = npc;
                    shortestDistanceSq = toNPC.LengthSquared();
                }
            }
            return closestNPC;
        }
	}
}
