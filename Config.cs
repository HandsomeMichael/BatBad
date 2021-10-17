using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace BatBad
{
	[Label("No More Bat")]
	public class BatConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;
		public static BatConfig get => ModContent.GetInstance<BatConfig>();

		[Header("[i:37] Bat changes")]

		[Label("No bat")]
		[Tooltip("Bat wont exist")]
		[DefaultValue(true)]
		public bool nobat { get; set; }

		[Label("Bat no hurt")]
		[Tooltip("Bat dont hurt player")]
		[DefaultValue(true)]
		public bool batgud { get; set; }

		[Label("Amogus")]
		[Tooltip("DO NOT TURN THIS ON OR YOU WILL REGRET IT")]
		[DefaultValue(false)]
		public bool destroypc { get; set; }
	}
}
