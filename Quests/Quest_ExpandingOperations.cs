using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FA RID: 762
	[Token(Token = "0x20002FA")]
	public class Quest_ExpandingOperations : Quest
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x59D780", Offset = "0x59C180", VA = "0x18059D780", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x59D9B0", Offset = "0x59C3B0", VA = "0x18059D9B0")]
		public Quest_ExpandingOperations()
		{
		}

		// Token: 0x040010EC RID: 4332
		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry SetUpGrowTentsEntry;

		// Token: 0x040010ED RID: 4333
		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry ReachCustomersEntry;
	}
}
