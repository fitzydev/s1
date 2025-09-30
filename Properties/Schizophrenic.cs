using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2000329")]
	[CreateAssetMenu(fileName = "Schizophrenic", menuName = "Properties/Schizophrenic Property")]
	public class Schizophrenic : Property
	{
		// Token: 0x060011F4 RID: 4596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x5A1580", Offset = "0x59FF80", VA = "0x1805A1580", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x5A1660", Offset = "0x5A0060", VA = "0x1805A1660", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x5A19A0", Offset = "0x5A03A0", VA = "0x1805A19A0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x5A1A20", Offset = "0x5A0420", VA = "0x1805A1A20", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Schizophrenic()
		{
		}
	}
}
