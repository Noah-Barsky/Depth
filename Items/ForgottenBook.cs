using Depth.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Depth.Items
{
    public class ForgottenBook : ModItem
    {

        private float rotation;
        private bool purple;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forgotten Book of Plasma");
            Tooltip.SetDefault("The book enslaves plasma into protecting you.");
        }

        public override void SetDefaults()
        {
            item.magic = true;
            item.damage = 31;
            item.width = 28;
            item.height = 30;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 2);
            item.rare = 6;
            item.noMelee = true;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("PlasmaBall");
            item.shootSpeed = 0f;
            item.prefix = 0;
        }

         public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile proj = Projectile.NewProjectileDirect(position, new Vector2(speedX, speedY), type, damage, knockBack, player.whoAmI);
            proj.GetGlobalProjectile<DepthGlobalProjectile>().shotFrom = item;
            return false;
        }
    }
}