
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Head)]
	public class TerraHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Terra Helmet");
			Tooltip.SetDefault("Increases max mana by 40" +
			"\n30% reduced mana usage, 15% increased magic damage");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 35);
			item.rare = ItemRarityID.Lime;
			item.defense = 25;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 40;
			player.manaCost -= 0.30f;
			player.magicDamage += 0.15f;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoltenHelmet, 1);
			recipe.AddIngredient(ItemID.JungleHat, 1);
			recipe.AddIngredient(ItemID.NecroHelmet, 1);
			recipe.AddIngredient(ItemID.BeeHeadgear, 1);
			recipe.AddIngredient(ItemType<RoundTableHelmet>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}