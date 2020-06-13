using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenithArmour.Items.Ingredients
{

	public class BrokenHeroArmourPiece : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'A piece of an ancient hero's armour. Looks like it could be reforged with some skill'");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(gold: 4);
			item.rare = ItemRarityID.Pink;
			item.maxStack = 1;
		}


	}
}