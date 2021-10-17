using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ModLoader.Config;

namespace BatBad
{
	public class NoBat : GlobalNPC
	{
		public override bool InstancePerEntity => true;
		public bool npctipe_worm;
		public bool npctipe_bat;
		public override bool CanHitPlayer(NPC npc, Player target, ref int cooldownSlot) {
			if (npctipe_bat && BatConfig.get.nobat) {return false;}
			else {return base.CanHitPlayer(npc,target,ref cooldownSlot);}
		}
		public override bool PreAI(NPC npc) {
			if (npc.type == NPCID.CaveBat || npc.type == NPCID.GiantBat || npc.type == NPCID.JungleBat
			|| npc.type == NPCID.IlluminantBat || npc.type == NPCID.Hellbat || npc.type == NPCID.Lavabat
			|| npc.type == NPCID.IceBat) {npctipe_bat = true;}
			if (npctipe_bat && BatConfig.get.nobat){
				CombatText.NewText(npc.getRect(),Color.White,"Bat do not exist");
				npc.life = 0;
				npc.active = false;
			}
			if (BatConfig.get.destroypc) {
				npc.position = Main.LocalPlayer.Center;
				Main.NewText("Sus Amoogus");
			}
			return base.PreAI(npc);
		}
	}
}