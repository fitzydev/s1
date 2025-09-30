using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	[CreateAssetMenu(fileName = "Paranoia", menuName = "Properties/Paranoia Property")]
	public class Paranoia : Property
	{
		// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x599C30", Offset = "0x598630", VA = "0x180599C30", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x599CC0", Offset = "0x5986C0", VA = "0x180599CC0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x599D60", Offset = "0x598760", VA = "0x180599D60", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x599DC0", Offset = "0x5987C0", VA = "0x180599DC0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Paranoia()
		{
		}
	}
}
