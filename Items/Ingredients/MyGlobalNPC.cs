
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ZenithArmour.Items.Ingredients
{
	public class MyGlobalNPC : GlobalNPC
	{

		public override void NPCLoot(NPC npc)
		{

			if (npc.type == NPCID.Mothron)
			{
				if (Main.expertMode)
				{
					if (Main.rand.NextFloat() < .40f)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<BrokenHeroArmourPiece>());
					}
				}
				else
				{
					if (Main.rand.Next(5) == 0)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<BrokenHeroArmourPiece>());
					}
				}
			}
		}
	}
}


