
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Body)]
	public class ZenithBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Zenith Breastplate");
			Tooltip.SetDefault("40% increased critical stike chance" +
			"\nFishing power increased by 30" +
			"\n'You feel like a god'");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(platinum: 2);
			item.rare = ItemRarityID.Red;
			item.defense = 40;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedCrit += 40;
			player.thrownCrit += 40;
			player.meleeCrit += 40;
			player.magicCrit += 40;
			player.fishingSkill += 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ItemType<ZenithHelmet>() && legs.type == ItemType<ZenithLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "40% increased damage";
			player.meleeDamage += 0.4f;
			player.thrownDamage += 0.4f; 
			player.rangedDamage += 0.4f;
			player.magicDamage += 0.4f;
			player.minionDamage += 0.4f;

		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnglerVest, 1);
			recipe.AddIngredient(ItemID.CopperChainmail, 1);
			recipe.AddIngredient(ItemID.MeteorSuit, 1);
			recipe.AddIngredient(ItemID.CobaltBreastplate, 1);
			recipe.AddIngredient(ItemID.MythrilChainmail, 1);
			recipe.AddIngredient(ItemID.AdamantiteBreastplate, 1);
			recipe.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.AnglerVest, 1);
			recipe2.AddIngredient(ItemID.CopperChainmail, 1);
			recipe2.AddIngredient(ItemID.MeteorSuit, 1);
			recipe2.AddIngredient(ItemID.CobaltBreastplate, 1);
			recipe2.AddIngredient(ItemID.OrichalcumBreastplate, 1);
			recipe2.AddIngredient(ItemID.AdamantiteBreastplate, 1);
			recipe2.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe2.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe2.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe2.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe2.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe2.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();

			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(ItemID.AnglerVest, 1);
			recipe3.AddIngredient(ItemID.CopperChainmail, 1);
			recipe3.AddIngredient(ItemID.MeteorSuit, 1);
			recipe3.AddIngredient(ItemID.CobaltBreastplate, 1);
			recipe3.AddIngredient(ItemID.MythrilChainmail, 1);
			recipe3.AddIngredient(ItemID.TitaniumBreastplate, 1);
			recipe3.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe3.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe3.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe3.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe3.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe3.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe3.AddTile(TileID.Anvils);
			recipe3.SetResult(this);
			recipe3.AddRecipe();

			ModRecipe recipe4 = new ModRecipe(mod);
			recipe4.AddIngredient(ItemID.AnglerVest, 1);
			recipe4.AddIngredient(ItemID.CopperChainmail, 1);
			recipe4.AddIngredient(ItemID.MeteorSuit, 1);
			recipe4.AddIngredient(ItemID.CobaltBreastplate, 1);
			recipe4.AddIngredient(ItemID.OrichalcumBreastplate, 1);
			recipe4.AddIngredient(ItemID.TitaniumBreastplate, 1);
			recipe4.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe4.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe4.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe4.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe4.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe4.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe4.AddTile(TileID.Anvils);
			recipe4.SetResult(this);
			recipe4.AddRecipe();

			ModRecipe recipe5 = new ModRecipe(mod);
			recipe5.AddIngredient(ItemID.AnglerVest, 1);
			recipe5.AddIngredient(ItemID.CopperChainmail, 1);
			recipe5.AddIngredient(ItemID.MeteorSuit, 1);
			recipe5.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe5.AddIngredient(ItemID.MythrilChainmail, 1);
			recipe5.AddIngredient(ItemID.AdamantiteBreastplate, 1);
			recipe5.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe5.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe5.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe5.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe5.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe5.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe5.AddTile(TileID.Anvils);
			recipe5.SetResult(this);
			recipe5.AddRecipe();

			ModRecipe recipe6 = new ModRecipe(mod);
			recipe6.AddIngredient(ItemID.AnglerVest, 1);
			recipe6.AddIngredient(ItemID.CopperChainmail, 1);
			recipe6.AddIngredient(ItemID.MeteorSuit, 1);
			recipe6.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe6.AddIngredient(ItemID.OrichalcumBreastplate, 1);
			recipe6.AddIngredient(ItemID.AdamantiteBreastplate, 1);
			recipe6.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe6.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe6.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe6.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe6.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe6.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe6.AddTile(TileID.Anvils);
			recipe6.SetResult(this);
			recipe6.AddRecipe();

			ModRecipe recipe7 = new ModRecipe(mod);
			recipe7.AddIngredient(ItemID.AnglerVest, 1);
			recipe7.AddIngredient(ItemID.CopperChainmail, 1);
			recipe7.AddIngredient(ItemID.MeteorSuit, 1);
			recipe7.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe7.AddIngredient(ItemID.MythrilChainmail, 1);
			recipe7.AddIngredient(ItemID.TitaniumBreastplate, 1);
			recipe7.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe7.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe7.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe7.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe7.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe7.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe7.AddTile(TileID.Anvils);
			recipe7.SetResult(this);
			recipe7.AddRecipe();

			ModRecipe recipe8 = new ModRecipe(mod);
			recipe8.AddIngredient(ItemID.AnglerVest, 1);
			recipe8.AddIngredient(ItemID.CopperChainmail, 1);
			recipe8.AddIngredient(ItemID.MeteorSuit, 1);
			recipe8.AddIngredient(ItemID.PalladiumHelmet, 1);
			recipe8.AddIngredient(ItemID.OrichalcumBreastplate, 1);
			recipe8.AddIngredient(ItemID.TitaniumBreastplate, 1);
			recipe8.AddIngredient(ItemID.ChlorophytePlateMail, 1);
			recipe8.AddIngredient(ItemType<TerraBreastplate>(), 1);
			recipe8.AddIngredient(ItemID.SolarFlareBreastplate, 1);
			recipe8.AddIngredient(ItemID.VortexBreastplate, 1);
			recipe8.AddIngredient(ItemID.NebulaBreastplate, 1);
			recipe8.AddIngredient(ItemID.StardustBreastplate, 1);
			recipe8.AddTile(TileID.Anvils);
			recipe8.SetResult(this);
			recipe8.AddRecipe();
		}
	}
}