using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Depth.NPCs.BaronBiome
{
    public class BaronSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Baron Muk");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
        }

        public override void SetDefaults()
        {
            npc.aiStyle = 1;
            aiType = NPCID.BlueSlime;
            npc.npcSlots = 2f;
            npc.knockBackResist = 0.95f;
            npc.damage = 20;
            npc.lifeMax = 100;
            npc.defense = 5;
            npc.width = 32;
            npc.height = 26;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            animationType = 8;
            animationType = NPCID.BlueSlime;
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.5f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.5f);
        }

        public override void AI()
        {
            if (npc.life < 15)
            {
                npc.defense += 3;
            }
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(2) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HardenGel"), Main.rand.Next(1, 2));
            }
        }

    }
}