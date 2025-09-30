using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000326 RID: 806
	[Token(Token = "0x2000326")]
	[CreateAssetMenu(fileName = "Lethal", menuName = "Properties/Lethal Property")]
	public class Lethal : Property
	{
		// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x598410", Offset = "0x596E10", VA = "0x180598410", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x598510", Offset = "0x596F10", VA = "0x180598510", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x598750", Offset = "0x597150", VA = "0x180598750", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x598810", Offset = "0x597210", VA = "0x180598810", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Lethal()
		{
		}

		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x4001148")]
		public const float HEALTH_DRAIN_PLAYER = 15f;

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		public const float HEALTH_DRAIN_NPC = 15f;
	}
}
