using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	[CreateAssetMenu(fileName = "ThoughtProvoking", menuName = "Properties/ThoughtProvoking Property")]
	public class ThoughtProvoking : Property
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x5A5E80", Offset = "0x5A4880", VA = "0x1805A5E80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x5A5EC0", Offset = "0x5A48C0", VA = "0x1805A5EC0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x5A5F00", Offset = "0x5A4900", VA = "0x1805A5F00", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x5A5F40", Offset = "0x5A4940", VA = "0x1805A5F40", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public ThoughtProvoking()
		{
		}
	}
}
