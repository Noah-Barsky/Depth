using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.ModLoader;
using BaseMod;

namespace Depth.BaseMod
{
    public class BaseTile
    {
        //------------------------------------------------------//
        //-------------------BASE TILE CLASS--------------------//
        //------------------------------------------------------//
        // Contains methods dealing with tiles, except          //
        // generation. (for that, see BaseWorldGen/BaseGoreGen) //
        //------------------------------------------------------//
        //  Author(s): Grox the Great                           //
        //------------------------------------------------------//

        public static Vector2 FindTopLeft(int x, int y)
        {
            Tile tile = Main.tile[x, y]; if (tile == null) return new Vector2(x, y);
            TileObjectData data = TileObjectData.GetTileData(tile.type, 0);
            x -= (tile.frameX / 18) % data.Width;
            y -= (tile.frameY / 18) % data.Height;
            return new Vector2(x, y);
        }
    }
}