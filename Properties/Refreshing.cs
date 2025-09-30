using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000328")]
	[CreateAssetMenu(fileName = "Refreshing", menuName = "Properties/Refreshing Property")]
	public class Refreshing : Property
	{
		// Token: 0x060011EF RID: 4591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Refreshing()
		{
		}
	}
}
