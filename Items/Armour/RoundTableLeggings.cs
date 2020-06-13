
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenithArmour.Items.Ingredients;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Legs)]
	public class RoundTableLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Knight of the Round Table Leggings");
			Tooltip.SetDefault("16% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 4);
			item.rare = ItemRarityID.Pink;
			item.defense = 14;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.16f;

		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedGreaves, 1);
			recipe.AddIngredient(ItemType<BrokenHeroArmourPiece>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}