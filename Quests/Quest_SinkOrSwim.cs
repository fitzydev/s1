using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	public class Quest_SinkOrSwim : Quest
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x59E850", Offset = "0x59D250", VA = "0x18059E850", Slot = "30")]
		protected override void Awake()
		{
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x59EF50", Offset = "0x59D950", VA = "0x18059EF50", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x59DE30", Offset = "0x59C830", VA = "0x18059DE30", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001139")]
		[Address(RVA = "0x59EB80", Offset = "0x59D580", VA = "0x18059EB80")]
		private void HourPass()
		{
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x59EC40", Offset = "0x59D640", VA = "0x18059EC40")]
		private void SleepStart()
		{
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x59EE50", Offset = "0x59D850", VA = "0x18059EE50")]
		private void SpawnLoanSharkVehicle()
		{
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x59E890", Offset = "0x59D290", VA = "0x18059E890")]
		private void CheckArrival()
		{
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x59EBF0", Offset = "0x59D5F0", VA = "0x18059EBF0", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x59F330", Offset = "0x59DD30", VA = "0x18059F330")]
		private void UpdateName()
		{
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x59F500", Offset = "0x59DF00", VA = "0x18059F500")]
		public Quest_SinkOrSwim()
		{
		}

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		public const int DAYS_TO_COMPLETE = 4;

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x138")]
		public string QuestName;

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x140")]
		public int NelsonCallTime;

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x148")]
		public Transform LoanSharkVehiclePosition;

		// Token: 0x04001102 RID: 4354
		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x150")]
		public GameObject LoanSharkGraves;
	}
}
