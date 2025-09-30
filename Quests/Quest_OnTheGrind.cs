using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	public class Quest_OnTheGrind : Quest
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x59E300", Offset = "0x59CD00", VA = "0x18059E300", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x59E420", Offset = "0x59CE20", VA = "0x18059E420")]
		public Quest_OnTheGrind()
		{
		}

		// Token: 0x040010FB RID: 4347
		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry CompleteDealsEntry;
	}
}
