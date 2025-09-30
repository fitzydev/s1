using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200032B RID: 811
	[Token(Token = "0x200032B")]
	[CreateAssetMenu(fileName = "Seizure", menuName = "Properties/Seizure Property")]
	public class Seizure : Property
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x5A2190", Offset = "0x5A0B90", VA = "0x1805A2190", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x5A2330", Offset = "0x5A0D30", VA = "0x1805A2330", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001200")]
		[Address(RVA = "0x5A2470", Offset = "0x5A0E70", VA = "0x1805A2470", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x5A24B0", Offset = "0x5A0EB0", VA = "0x1805A24B0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Seizure()
		{
		}

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		public const float CAMERA_JITTER_INTENSITY = 1f;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		public const float DURATION_NPC = 60f;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		public const float DURATION_PLAYER = 30f;
	}
}
