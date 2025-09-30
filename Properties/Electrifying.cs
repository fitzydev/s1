using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	[CreateAssetMenu(fileName = "Electrifying", menuName = "Properties/Electrifying Property")]
	public class Electrifying : Property
	{
		// Token: 0x060011B7 RID: 4535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0x592BF0", Offset = "0x5915F0", VA = "0x180592BF0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x592C80", Offset = "0x591680", VA = "0x180592C80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x592D10", Offset = "0x591710", VA = "0x180592D10", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x592D70", Offset = "0x591770", VA = "0x180592D70", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Electrifying()
		{
		}

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x78")]
		public Color EyeColor;
	}
}
