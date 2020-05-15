using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Depth.Projectiles
{
    public class DepthGlobalProjectile : GlobalProjectile
    {
        public override bool InstancePerEntity
        {
            get { return true; }
        }

        public Item shotFrom = null;
    }

}