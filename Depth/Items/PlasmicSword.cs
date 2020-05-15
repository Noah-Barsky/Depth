using Terraria.ID;
using Terraria.ModLoader;

namespace Depth.Items
{
	public class PlasmicSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 40;
			item.melee = true;
			item.width = 58;
			item.height = 62;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PlasmicChunk", 10);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}