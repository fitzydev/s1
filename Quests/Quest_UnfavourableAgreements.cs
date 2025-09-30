using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	public class Quest_UnfavourableAgreements : Quest
	{
		// Token: 0x06001153 RID: 4435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0", Slot = "30")]
		protected override void Awake()
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x5A0840", Offset = "0x59F240", VA = "0x1805A0840", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x5A00A0", Offset = "0x59EAA0", VA = "0x1805A00A0")]
		private void CheckQuestStart()
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x5A0070", Offset = "0x59EA70", VA = "0x1805A0070", Slot = "34")]
		public override void Begin(bool network = true)
		{
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x5A0510", Offset = "0x59EF10", VA = "0x1805A0510", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x5A06C0", Offset = "0x59F0C0", VA = "0x1805A06C0", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x5A03F0", Offset = "0x59EDF0", VA = "0x1805A03F0")]
		private void MeetingEnded()
		{
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x5A03C0", Offset = "0x59EDC0", VA = "0x1805A03C0")]
		private void DriveCallback(VehicleAgent.ENavigationResult result)
		{
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x5A0610", Offset = "0x59F010", VA = "0x1805A0610")]
		private void Park()
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x5A0A90", Offset = "0x59F490", VA = "0x1805A0A90")]
		public Quest_UnfavourableAgreements()
		{
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x5A0A20", Offset = "0x59F420", VA = "0x1805A0A20")]
		[CompilerGenerated]
		private IEnumerator <MeetingEnded>g__Wait|14_0()
		{
			return null;
		}

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x138")]
		public LandVehicle MeetingVehicle;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x140")]
		public ParkingLot MeetingParkingLot;

		// Token: 0x04001114 RID: 4372
		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x148")]
		public ParkingLot ManorParkingLot;

		// Token: 0x04001115 RID: 4373
		[Token(Token = "0x4001115")]
		[FieldOffset(Offset = "0x150")]
		public Thomas Thomas;

		// Token: 0x04001116 RID: 4374
		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x158")]
		public QuestEntry ReadMessageQuestEntry;

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x160")]
		public QuestEntry MeetingQuestEntry;

		// Token: 0x04001118 RID: 4376
		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x168")]
		public Quest PrereqQuest;

		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onMeetingConcluded;
	}
}
