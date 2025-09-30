using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200032A RID: 810
	[Token(Token = "0x200032A")]
	[CreateAssetMenu(fileName = "Sedating", menuName = "Properties/Sedating Property")]
	public class Sedating : Property
	{
		// Token: 0x060011F9 RID: 4601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x5A1CF0", Offset = "0x5A06F0", VA = "0x1805A1CF0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x5A1D80", Offset = "0x5A0780", VA = "0x1805A1D80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x58E190", Offset = "0x58CB90", VA = "0x18058E190", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x5A1FB0", Offset = "0x5A09B0", VA = "0x1805A1FB0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Sedating()
		{
		}
	}
}
