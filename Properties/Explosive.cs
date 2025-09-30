using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	[CreateAssetMenu(fileName = "Explosive", menuName = "Properties/Explosive Property")]
	public class Explosive : Property
	{
		// Token: 0x060011C1 RID: 4545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x593350", Offset = "0x591D50", VA = "0x180593350", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x593390", Offset = "0x591D90", VA = "0x180593390", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x5933D0", Offset = "0x591DD0", VA = "0x1805933D0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x593410", Offset = "0x591E10", VA = "0x180593410", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Explosive()
		{
		}
	}
}
