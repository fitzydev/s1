using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	[CreateAssetMenu(fileName = "CalorieDense", menuName = "Properties/CalorieDense Property")]
	public class CalorieDense : Property
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x58EBF0", Offset = "0x58D5F0", VA = "0x18058EBF0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x58EC70", Offset = "0x58D670", VA = "0x18058EC70", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x58ECF0", Offset = "0x58D6F0", VA = "0x18058ECF0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x58ED50", Offset = "0x58D750", VA = "0x18058ED50", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public CalorieDense()
		{
		}
	}
}
