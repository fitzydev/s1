using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	[Serializable]
	public class QuestWindowConfig
	{
		// Token: 0x06001176 RID: 4470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x59CA10", Offset = "0x59B410", VA = "0x18059CA10")]
		public QuestWindowConfig()
		{
		}

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x10")]
		public bool IsEnabled;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x14")]
		public int WindowStartTime;

		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x4001132")]
		[FieldOffset(Offset = "0x18")]
		public int WindowEndTime;
	}
}
