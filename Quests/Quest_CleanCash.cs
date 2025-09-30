using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x20002F3")]
	public class Quest_CleanCash : Quest
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001102")]
		[Address(RVA = "0xADD460", Offset = "0xADBE60", VA = "0x180ADD460", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001103")]
		[Address(RVA = "0xADD760", Offset = "0xADC160", VA = "0x180ADD760")]
		public Quest_CleanCash()
		{
		}

		// Token: 0x040010D9 RID: 4313
		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry BuyBusinessEntry;

		// Token: 0x040010DA RID: 4314
		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry GoToBusinessEntry;
	}
}
