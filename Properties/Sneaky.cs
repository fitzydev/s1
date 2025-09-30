using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	[CreateAssetMenu(fileName = "Sneaky", menuName = "Properties/Sneaky Property")]
	public class Sneaky : Property
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x5A28D0", Offset = "0x5A12D0", VA = "0x1805A28D0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x5A2910", Offset = "0x5A1310", VA = "0x1805A2910", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x5A2AE0", Offset = "0x5A14E0", VA = "0x1805A2AE0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x5A2B20", Offset = "0x5A1520", VA = "0x1805A2B20", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Sneaky()
		{
		}

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		public const float SPEED_MULTIPLIER = 0.85f;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		public const float FOOTSTEP_VOL_MULTIPLIER = 0.4f;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x78")]
		private VisibilityAttribute visibilityAttribute;
	}
}
