
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenithArmour.Items.Ingredients;
using static Terraria.ModLoader.ModContent;

namespace ZenithArmour.Items.Armour
{
	[AutoloadEquip(EquipType.Body)]
	public class RoundTableBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Knight of the Round Table Breastplate");
			Tooltip.SetDefault("16% increased melee speed");
		}
		
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 10);
			item.rare = ItemRarityID.Pink;
			item.defense = 20;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.16f;

		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ItemType<RoundTableHelmet>() && legs.type == ItemType<RoundTableLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "9% increased damage";
			player.meleeDamage += 0.09f;
			player.rangedDamage += 0.09f;
			player.magicDamage += 0.09f;
			player.thrownDamage += 0.09f;


		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedPlateMail, 1);
			recipe.AddIngredient(ItemType<BrokenHeroArmourPiece>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}