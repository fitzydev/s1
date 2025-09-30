using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	public class Quest_DefeatCartel : Quest
	{
		// Token: 0x0600110E RID: 4366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110E")]
		[Address(RVA = "0x59CF30", Offset = "0x59B930", VA = "0x18059CF30", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110F")]
		[Address(RVA = "0x59CB60", Offset = "0x59B560", VA = "0x18059CB60")]
		private void OnSleepEnd()
		{
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001110")]
		[Address(RVA = "0x59CAC0", Offset = "0x59B4C0", VA = "0x18059CAC0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x59CD10", Offset = "0x59B710", VA = "0x18059CD10", Slot = "42")]
		public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x59CC80", Offset = "0x59B680", VA = "0x18059CC80")]
		public void PlayCountdownMusic()
		{
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x59CA30", Offset = "0x59B430", VA = "0x18059CA30")]
		private void Defeat()
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001114")]
		[Address(RVA = "0x59CE00", Offset = "0x59B800", VA = "0x18059CE00", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x59D0F0", Offset = "0x59BAF0", VA = "0x18059D0F0")]
		public Quest_DefeatCartel()
		{
		}

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		public const float DIG_TUNNEL_COST = 10000f;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public Sam Sam;

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x140")]
		public Manor Manor;

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x148")]
		public QuestEntry DigTunnelEntry;

		// Token: 0x040010E2 RID: 4322
		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry WaitForTunnelEntry;

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x158")]
		public QuestEntry EnquireAboutRDXEntry;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x160")]
		public QuestEntry ObtainRDXEntry;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x168")]
		public QuestEntry EnquireAboutBombEntry;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x170")]
		public QuestEntry KillBanditEntry;

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x178")]
		public NPC Bandit;

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x180")]
		public GameObject BanditScheduleContainer;
	}
}
