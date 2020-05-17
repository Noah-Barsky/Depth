using Depth.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Depth.Items
{
    public class PlasmicTome : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forgotten Book of Plasma");
            Tooltip.SetDefault("The book enslaves plasma into protecting you r mom.");
        }

        public override void SetDefaults()
        {
            item.magic = true;
            item.damage = 20;
            item.width = 28;
            item.height = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 2);
            item.rare = 6;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("PlasmaBolt");
            item.shootSpeed = 15f;
            item.prefix = 0;
            item.mana = 2;
            item.noMelee = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile proj = Projectile.NewProjectileDirect(position, new Vector2(speedX, speedY), type, damage, knockBack, player.whoAmI);
            proj.GetGlobalProjectile<DepthGlobalProjectile>().shotFrom = item;
            return false;
        }
    }
}