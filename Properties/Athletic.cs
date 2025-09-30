using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	[CreateAssetMenu(fileName = "Athletic", menuName = "Properties/Athletic Property")]
	public class Athletic : Property
	{
		// Token: 0x06001199 RID: 4505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x58DD80", Offset = "0x58C780", VA = "0x18058DD80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119A")]
		[Address(RVA = "0x58DE10", Offset = "0x58C810", VA = "0x18058DE10", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x58E190", Offset = "0x58CB90", VA = "0x18058E190", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119C")]
		[Address(RVA = "0x58E210", Offset = "0x58CC10", VA = "0x18058E210", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119D")]
		[Address(RVA = "0x58E520", Offset = "0x58CF20", VA = "0x18058E520")]
		public Athletic()
		{
		}

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		public const float SPEED_MULTIPLIER = 1.3f;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		public const float NPC_SPEED_MULTIPLIER = 1.8f;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[ColorUsage(true, true)]
		public Color TintColor;
	}
}
