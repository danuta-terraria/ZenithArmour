
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Head)]
	public class ZenithHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Zenith Helmet");
			Tooltip.SetDefault("Increases max mana by 120" +
			"\n40% reduced mana usage" +
			"\nIncreases max minions by 12" +
			"\n'You feel like a god'");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Red;
			item.defense = 35;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 120;
			player.manaCost -= 40f;
			player.maxMinions += 12;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnglerHat, 1);
			recipe.AddIngredient(ItemID.CopperHelmet, 1);
			recipe.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe.AddIngredient(ItemID.CobaltHelmet, 1);
			recipe.AddIngredient(ItemID.MythrilHelmet, 1);
			recipe.AddIngredient(ItemID.AdamantiteHelmet, 1);
			recipe.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe.AddIngredient(ItemID.VortexHelmet, 1);
			recipe.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe.AddIngredient(ItemID.StardustHelmet, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.AnglerHat, 1);
			recipe2.AddIngredient(ItemID.CopperHelmet, 1);
			recipe2.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe2.AddIngredient(ItemID.CobaltHelmet, 1);
			recipe2.AddIngredient(ItemID.OrichalcumHelmet, 1);
			recipe2.AddIngredient(ItemID.AdamantiteHelmet, 1);
			recipe2.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe2.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe2.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe2.AddIngredient(ItemID.VortexHelmet, 1);
			recipe2.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe2.AddIngredient(ItemID.StardustHelmet, 1);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();

			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(ItemID.AnglerHat, 1);
			recipe3.AddIngredient(ItemID.CopperHelmet, 1);
			recipe3.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe3.AddIngredient(ItemID.CobaltHelmet, 1);
			recipe3.AddIngredient(ItemID.MythrilHelmet, 1);
			recipe3.AddIngredient(ItemID.TitaniumHelmet, 1);
			recipe3.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe3.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe3.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe3.AddIngredient(ItemID.VortexHelmet, 1);
			recipe3.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe3.AddIngredient(ItemID.StardustHelmet, 1);
			recipe3.AddTile(TileID.Anvils);
			recipe3.SetResult(this);
			recipe3.AddRecipe();

			ModRecipe recipe4 = new ModRecipe(mod);
			recipe4.AddIngredient(ItemID.AnglerHat, 1);
			recipe4.AddIngredient(ItemID.CopperHelmet, 1);
			recipe4.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe4.AddIngredient(ItemID.CobaltHelmet, 1);
			recipe4.AddIngredient(ItemID.OrichalcumHelmet, 1);
			recipe4.AddIngredient(ItemID.TitaniumHelmet, 1);
			recipe4.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe4.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe4.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe4.AddIngredient(ItemID.VortexHelmet, 1);
			recipe4.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe4.AddIngredient(ItemID.StardustHelmet, 1);
			recipe4.AddTile(TileID.Anvils);
			recipe4.SetResult(this);
			recipe4.AddRecipe();

			ModRecipe recipe5 = new ModRecipe(mod);
			recipe5.AddIngredient(ItemID.AnglerHat, 1);
			recipe5.AddIngredient(ItemID.CopperHelmet, 1);
			recipe5.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe5.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe5.AddIngredient(ItemID.MythrilHelmet, 1);
			recipe5.AddIngredient(ItemID.AdamantiteHelmet, 1);
			recipe5.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe5.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe5.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe5.AddIngredient(ItemID.VortexHelmet, 1);
			recipe5.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe5.AddIngredient(ItemID.StardustHelmet, 1);
			recipe5.AddTile(TileID.Anvils);
			recipe5.SetResult(this);
			recipe5.AddRecipe();

			ModRecipe recipe6 = new ModRecipe(mod);
			recipe6.AddIngredient(ItemID.AnglerHat, 1);
			recipe6.AddIngredient(ItemID.CopperHelmet, 1);
			recipe6.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe6.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe6.AddIngredient(ItemID.OrichalcumHelmet, 1);
			recipe6.AddIngredient(ItemID.AdamantiteHelmet, 1);
			recipe6.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe6.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe6.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe6.AddIngredient(ItemID.VortexHelmet, 1);
			recipe6.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe6.AddIngredient(ItemID.StardustHelmet, 1);
			recipe6.AddTile(TileID.Anvils);
			recipe6.SetResult(this);
			recipe6.AddRecipe();

			ModRecipe recipe7 = new ModRecipe(mod);
			recipe7.AddIngredient(ItemID.AnglerHat, 1);
			recipe7.AddIngredient(ItemID.CopperHelmet, 1);
			recipe7.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe7.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe7.AddIngredient(ItemID.MythrilHelmet, 1);
			recipe7.AddIngredient(ItemID.TitaniumHelmet, 1);
			recipe7.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe7.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe7.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe7.AddIngredient(ItemID.VortexHelmet, 1);
			recipe7.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe7.AddIngredient(ItemID.StardustHelmet, 1);
			recipe7.AddTile(TileID.Anvils);
			recipe7.SetResult(this);
			recipe7.AddRecipe();

			ModRecipe recipe8 = new ModRecipe(mod);
			recipe8.AddIngredient(ItemID.AnglerHat, 1);
			recipe8.AddIngredient(ItemID.CopperHelmet, 1);
			recipe8.AddIngredient(ItemID.MeteorHelmet, 1);
			recipe8.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe8.AddIngredient(ItemID.OrichalcumHelmet, 1);
			recipe8.AddIngredient(ItemID.TitaniumHelmet, 1);
			recipe8.AddIngredient(ItemID.ChlorophyteMask, 1);
			recipe8.AddIngredient(ItemType<TerraHelmet>(), 1);
			recipe8.AddIngredient(ItemID.SolarFlareHelmet, 1);
			recipe8.AddIngredient(ItemID.VortexHelmet, 1);
			recipe8.AddIngredient(ItemID.NebulaHelmet, 1);
			recipe8.AddIngredient(ItemID.StardustHelmet, 1);
			recipe8.AddTile(TileID.Anvils);
			recipe8.SetResult(this);
			recipe8.AddRecipe();

		}
	}
}