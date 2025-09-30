using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CFF RID: 3327
	[Token(Token = "0x2000CFF")]
	public class NPCPresenceAccessZone : AccessZone
	{
		// Token: 0x06005E16 RID: 24086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E16")]
		[Address(RVA = "0xA54950", Offset = "0xA53350", VA = "0x180A54950", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E17")]
		[Address(RVA = "0xA616C0", Offset = "0xA600C0", VA = "0x180A616C0", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E18")]
		[Address(RVA = "0xA615B0", Offset = "0xA5FFB0", VA = "0x180A615B0", Slot = "7")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E19")]
		[Address(RVA = "0xA617C0", Offset = "0xA601C0", VA = "0x180A617C0")]
		public NPCPresenceAccessZone()
		{
		}

		// Token: 0x04004460 RID: 17504
		[Token(Token = "0x4004460")]
		public const float CooldownTime = 0.5f;

		// Token: 0x04004461 RID: 17505
		[Token(Token = "0x4004461")]
		[FieldOffset(Offset = "0x48")]
		public Collider DetectionZone;

		// Token: 0x04004462 RID: 17506
		[Token(Token = "0x4004462")]
		[FieldOffset(Offset = "0x50")]
		public NPC TargetNPC;

		// Token: 0x04004463 RID: 17507
		[Token(Token = "0x4004463")]
		[FieldOffset(Offset = "0x58")]
		private float timeSinceNPCSensed;
	}
}
