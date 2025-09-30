using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	public class Quest_NeedingTheGreen : Quest
	{
		// Token: 0x0600112D RID: 4397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x59E020", Offset = "0x59CA20", VA = "0x18059E020", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x59E2A0", Offset = "0x59CCA0", VA = "0x18059E2A0")]
		public Quest_NeedingTheGreen()
		{
		}

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x138")]
		public Quest[] PrerequisiteQuests;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry EarnEntry;

		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x148")]
		public float LifetimeEarningsRequirement;
	}
}
