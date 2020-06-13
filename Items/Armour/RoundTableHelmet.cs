
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenithArmour.Items.Ingredients;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Head)]
	public class RoundTableHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Knight of the Round Table Helmet");
			Tooltip.SetDefault("16% increased critical strike chance");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 6);
			item.rare = ItemRarityID.Pink;
			item.defense = 22;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeCrit += 16;
			player.magicCrit += 16;
			player.thrownCrit += 16;
			player.rangedCrit += 16;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedMask, 1);
			recipe.AddIngredient(ItemType<BrokenHeroArmourPiece>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.HallowedHeadgear, 1);
			recipe2.AddIngredient(ItemType<BrokenHeroArmourPiece>(), 1);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();

			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(ItemID.HallowedHelmet, 1);
			recipe3.AddIngredient(ItemType<BrokenHeroArmourPiece>(), 1);
			recipe3.AddTile(TileID.Anvils);
			recipe3.SetResult(this);
			recipe3.AddRecipe();


		}
	}
}