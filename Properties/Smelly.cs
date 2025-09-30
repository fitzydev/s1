using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	[CreateAssetMenu(fileName = "Smelly", menuName = "Properties/Smelly Property")]
	public class Smelly : Property
	{
		// Token: 0x0600121D RID: 4637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600121D")]
		[Address(RVA = "0x5A2670", Offset = "0x5A1070", VA = "0x1805A2670", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600121E")]
		[Address(RVA = "0x5A26B0", Offset = "0x5A10B0", VA = "0x1805A26B0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600121F")]
		[Address(RVA = "0x5A27A0", Offset = "0x5A11A0", VA = "0x1805A27A0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001220")]
		[Address(RVA = "0x5A27E0", Offset = "0x5A11E0", VA = "0x1805A27E0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001221")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Smelly()
		{
		}
	}
}
