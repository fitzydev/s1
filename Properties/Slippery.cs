using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000331 RID: 817
	[Token(Token = "0x2000331")]
	[CreateAssetMenu(fileName = "Slippery", menuName = "Properties/Slippery Property")]
	public class Slippery : Property
	{
		// Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x5A25D0", Offset = "0x5A0FD0", VA = "0x1805A25D0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x5A2600", Offset = "0x5A1000", VA = "0x1805A2600", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600121A")]
		[Address(RVA = "0x5A2620", Offset = "0x5A1020", VA = "0x1805A2620", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600121B")]
		[Address(RVA = "0x5A2650", Offset = "0x5A1050", VA = "0x1805A2650", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600121C")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Slippery()
		{
		}
	}
}
