using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	[CreateAssetMenu(fileName = "CalmingProperty", menuName = "Properties/Calming Property")]
	public class Calming : Property
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x58E8E0", Offset = "0x58D2E0", VA = "0x18058E8E0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x58E920", Offset = "0x58D320", VA = "0x18058E920", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x58EA80", Offset = "0x58D480", VA = "0x18058EA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x58EAC0", Offset = "0x58D4C0", VA = "0x18058EAC0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Calming()
		{
		}
	}
}
