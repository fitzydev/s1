using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2000338")]
	public abstract class Property : ScriptableObject
	{
		// Token: 0x0600123B RID: 4667
		[Token(Token = "0x600123B")]
		public abstract void ApplyToNPC(NPC npc);

		// Token: 0x0600123C RID: 4668
		[Token(Token = "0x600123C")]
		public abstract void ClearFromNPC(NPC npc);

		// Token: 0x0600123D RID: 4669
		[Token(Token = "0x600123D")]
		public abstract void ApplyToPlayer(Player player);

		// Token: 0x0600123E RID: 4670
		[Token(Token = "0x600123E")]
		public abstract void ClearFromPlayer(Player player);

		// Token: 0x0600123F RID: 4671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x59C6A0", Offset = "0x59B0A0", VA = "0x18059C6A0")]
		public void OnValidate()
		{
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x59C760", Offset = "0x59B160", VA = "0x18059C760")]
		protected Property()
		{
		}

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x20")]
		public string Description;

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x28")]
		public string ID;

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 5f)]
		public int Tier;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float Addictiveness;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x38")]
		public Color ProductColor;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x48")]
		public Color LabelColor;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x58")]
		public bool ImplementedPriorMixingRework;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x5C")]
		[Header("Value")]
		[Range(-100f, 100f)]
		public int ValueChange;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 2f)]
		public float ValueMultiplier;

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x64")]
		[Range(-1f, 1f)]
		public float AddBaseValueMultiple;

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 MixDirection;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x70")]
		public float MixMagnitude;
	}
}
