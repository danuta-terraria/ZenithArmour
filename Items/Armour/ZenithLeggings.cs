
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Legs)]
	public class ZenithLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Zenith Leggings");
			Tooltip.SetDefault("30% increased movement speed" +
			"\n20% increased melee speed and knockback" +
			"\n'You feel like a god'");
		}
	

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(platinum: 1, gold: 50);
			item.rare = ItemRarityID.Red;
			item.defense = 25;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.3f;
			player.meleeSpeed += 0.2f;
			player.kbGlove = true;
			player.meleeCrit += 40;
			player.magicCrit += 40;
			player.fishingSkill += 30;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnglerPants, 1);
			recipe.AddIngredient(ItemID.CopperGreaves, 1);
			recipe.AddIngredient(ItemID.MeteorLeggings, 1);
			recipe.AddIngredient(ItemID.CobaltLeggings, 1);
			recipe.AddIngredient(ItemID.MythrilGreaves, 1);
			recipe.AddIngredient(ItemID.AdamantiteLeggings, 1);
			recipe.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe.AddIngredient(ItemID.VortexLeggings, 1);
			recipe.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe.AddIngredient(ItemID.StardustLeggings, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.AnglerPants, 1);
			recipe2.AddIngredient(ItemID.CopperGreaves, 1);
			recipe2.AddIngredient(ItemID.MeteorLeggings, 1);;
			recipe2.AddIngredient(ItemID.CobaltLeggings, 1);
			recipe2.AddIngredient(ItemID.OrichalcumLeggings, 1);
			recipe2.AddIngredient(ItemID.AdamantiteLeggings, 1);
			recipe2.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe2.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe2.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe2.AddIngredient(ItemID.VortexLeggings, 1);
			recipe2.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe2.AddIngredient(ItemID.StardustLeggings, 1);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();

			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(ItemID.AnglerPants, 1);
			recipe3.AddIngredient(ItemID.CopperGreaves, 1);
			recipe3.AddIngredient(ItemID.MeteorLeggings, 1);
			recipe3.AddIngredient(ItemID.CobaltLeggings, 1);
			recipe3.AddIngredient(ItemID.MythrilGreaves, 1);
			recipe3.AddIngredient(ItemID.TitaniumLeggings, 1);
			recipe3.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe3.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe3.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe3.AddIngredient(ItemID.VortexLeggings, 1);
			recipe3.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe3.AddIngredient(ItemID.StardustLeggings, 1);
			recipe3.AddTile(TileID.Anvils);
			recipe3.SetResult(this);
			recipe3.AddRecipe();

			ModRecipe recipe4 = new ModRecipe(mod);
			recipe4.AddIngredient(ItemID.AnglerPants, 1);
			recipe4.AddIngredient(ItemID.CopperGreaves, 1);
			recipe4.AddIngredient(ItemID.MeteorLeggings, 1);
			recipe4.AddIngredient(ItemID.CobaltLeggings, 1);
			recipe4.AddIngredient(ItemID.OrichalcumLeggings, 1);
			recipe4.AddIngredient(ItemID.TitaniumLeggings, 1);
			recipe4.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe4.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe4.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe4.AddIngredient(ItemID.VortexLeggings, 1);
			recipe4.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe4.AddIngredient(ItemID.StardustLeggings, 1);
			recipe4.AddTile(TileID.Anvils);
			recipe4.SetResult(this);
			recipe4.AddRecipe();

			ModRecipe recipe5 = new ModRecipe(mod);
			recipe5.AddIngredient(ItemID.AnglerPants, 1);
			recipe5.AddIngredient(ItemID.CopperGreaves, 1);
			recipe5.AddIngredient(ItemID.MeteorLeggings, 1);
			recipe5.AddIngredient(ItemID.PalladiumLeggings, 1);
			recipe5.AddIngredient(ItemID.MythrilGreaves, 1);
			recipe5.AddIngredient(ItemID.AdamantiteLeggings, 1);
			recipe5.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe5.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe5.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe5.AddIngredient(ItemID.VortexLeggings, 1);
			recipe5.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe5.AddIngredient(ItemID.StardustLeggings, 1);
			recipe5.AddTile(TileID.Anvils);
			recipe5.SetResult(this);
			recipe5.AddRecipe();

			ModRecipe recipe6 = new ModRecipe(mod);
			recipe6.AddIngredient(ItemID.AnglerPants, 1);
			recipe6.AddIngredient(ItemID.CopperGreaves, 1);
			recipe6.AddIngredient(ItemID.MeteorLeggings, 1);
			recipe6.AddIngredient(ItemID.PalladiumLeggings, 1);
			recipe6.AddIngredient(ItemID.OrichalcumLeggings, 1);
			recipe6.AddIngredient(ItemID.AdamantiteLeggings, 1);
			recipe6.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe6.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe6.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe6.AddIngredient(ItemID.VortexLeggings, 1);
			recipe6.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe6.AddIngredient(ItemID.StardustLeggings, 1);
			recipe6.AddTile(TileID.Anvils);
			recipe6.SetResult(this);
			recipe6.AddRecipe();

			ModRecipe recipe7 = new ModRecipe(mod);
			recipe7.AddIngredient(ItemID.AnglerPants, 1);
			recipe7.AddIngredient(ItemID.CopperGreaves, 1);
			recipe7.AddIngredient(ItemID.MeteorLeggings, 1);
			recipe7.AddIngredient(ItemID.PalladiumLeggings, 1);
			recipe7.AddIngredient(ItemID.MythrilGreaves, 1);
			recipe7.AddIngredient(ItemID.TitaniumLeggings, 1);
			recipe7.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe7.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe7.AddIngredient(ItemID.VortexLeggings, 1);
			recipe7.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe7.AddIngredient(ItemID.StardustLeggings, 1);
			recipe7.AddTile(TileID.Anvils);
			recipe7.SetResult(this);
			recipe7.AddRecipe();

			ModRecipe recipe8 = new ModRecipe(mod);
			recipe8.AddIngredient(ItemID.AnglerPants, 1);
			recipe8.AddIngredient(ItemID.CopperGreaves, 1);
			recipe8.AddIngredient(ItemID.MeteorLeggings, 1);
			recipe8.AddIngredient(ItemID.PalladiumLeggings, 1);
			recipe8.AddIngredient(ItemID.OrichalcumLeggings, 1);
			recipe8.AddIngredient(ItemID.TitaniumLeggings, 1);
			recipe8.AddIngredient(ItemID.ChlorophyteGreaves, 1);
			recipe8.AddIngredient(ItemType<TerraLeggings>(), 1);
			recipe8.AddIngredient(ItemID.SolarFlareLeggings, 1);
			recipe8.AddIngredient(ItemID.VortexLeggings, 1);
			recipe8.AddIngredient(ItemID.NebulaLeggings, 1);
			recipe8.AddIngredient(ItemID.StardustLeggings, 1);
			recipe8.AddTile(TileID.Anvils);
			recipe8.SetResult(this);
			recipe8.AddRecipe();
		}
	}
}