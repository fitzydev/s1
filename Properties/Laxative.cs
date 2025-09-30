using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	[CreateAssetMenu(fileName = "Laxative", menuName = "Properties/Laxative Property")]
	public class Laxative : Property
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x598310", Offset = "0x596D10", VA = "0x180598310", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x598350", Offset = "0x596D50", VA = "0x180598350", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E2")]
		[Address(RVA = "0x598390", Offset = "0x596D90", VA = "0x180598390", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E3")]
		[Address(RVA = "0x5983D0", Offset = "0x596DD0", VA = "0x1805983D0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Laxative()
		{
		}
	}
}
