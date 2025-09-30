using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	[CreateAssetMenu(fileName = "Jennerising", menuName = "Properties/Jennerising Property")]
	public class Jennerising : Property
	{
		// Token: 0x060011DB RID: 4571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x596D30", Offset = "0x595730", VA = "0x180596D30", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x596D70", Offset = "0x595770", VA = "0x180596D70", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x596DB0", Offset = "0x5957B0", VA = "0x180596DB0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x596DF0", Offset = "0x5957F0", VA = "0x180596DF0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Jennerising()
		{
		}
	}
}
