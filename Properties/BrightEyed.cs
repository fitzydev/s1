using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	[CreateAssetMenu(fileName = "BrightEyed", menuName = "Properties/BrightEyed Property")]
	public class BrightEyed : Property
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x58E640", Offset = "0x58D040", VA = "0x18058E640", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x58E6F0", Offset = "0x58D0F0", VA = "0x18058E6F0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x58E7A0", Offset = "0x58D1A0", VA = "0x18058E7A0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x58E830", Offset = "0x58D230", VA = "0x18058E830", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x58E8C0", Offset = "0x58D2C0", VA = "0x18058E8C0")]
		public BrightEyed()
		{
		}

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x78")]
		public Color EyeColor;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x88")]
		public float Emission;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x8C")]
		public float LightIntensity;
	}
}
