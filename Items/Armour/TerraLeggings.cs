
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Legs)]
	public class TerraLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Terra Leggings");
			Tooltip.SetDefault("30% increased range critical strike chance, 15% increased ranged damage");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 35);
			item.rare = ItemRarityID.Lime;
			item.defense = 17;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedCrit += 30;
			player.rangedDamage += 0.15f;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoltenGreaves, 1);
			recipe.AddIngredient(ItemID.JunglePants, 1);
			recipe.AddIngredient(ItemID.NecroGreaves, 1);
			recipe.AddIngredient(ItemID.BeeGreaves, 1);
			recipe.AddIngredient(ItemType<RoundTableLeggings>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}