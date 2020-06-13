
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Body)]
	public class TerraBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Terra Breastplate");
			Tooltip.SetDefault("\n25% increased melee damage, speed and critical strike chance");
				
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 40);
			item.rare = ItemRarityID.Lime;
			item.defense = 23;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.25f;
			player.meleeCrit += 25;
			player.meleeSpeed += 0.25f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ItemType<TerraHelmet>() && legs.type == ItemType<TerraLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases max minions by 4";
			player.maxMinions += 4;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoltenBreastplate, 1);
			recipe.AddIngredient(ItemID.JungleShirt, 1);
			recipe.AddIngredient(ItemID.NecroBreastplate, 1);
			recipe.AddIngredient(ItemID.BeeBreastplate, 1);
			recipe.AddIngredient(ItemType<RoundTableBreastplate>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}