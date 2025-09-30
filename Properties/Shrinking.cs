using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	[CreateAssetMenu(fileName = "Shrinking", menuName = "Properties/Shrinking Property")]
	public class Shrinking : Property
	{
		// Token: 0x06001213 RID: 4627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x5A24D0", Offset = "0x5A0ED0", VA = "0x1805A24D0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x5A2520", Offset = "0x5A0F20", VA = "0x1805A2520", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001215")]
		[Address(RVA = "0x5A2550", Offset = "0x5A0F50", VA = "0x1805A2550", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001216")]
		[Address(RVA = "0x5A25A0", Offset = "0x5A0FA0", VA = "0x1805A25A0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Shrinking()
		{
		}

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		public const float Scale = 0.8f;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		public const float LerpTime = 1f;
	}
}
