using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	[Serializable]
	public class PollAnswer
	{
		// Token: 0x06001257 RID: 4695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x599E30", Offset = "0x598830", VA = "0x180599E30")]
		public PollAnswer(int _pollId, int _answer, string _ticket)
		{
		}

		// Token: 0x0400117A RID: 4474
		[Token(Token = "0x400117A")]
		[FieldOffset(Offset = "0x10")]
		public int pollId;

		// Token: 0x0400117B RID: 4475
		[Token(Token = "0x400117B")]
		[FieldOffset(Offset = "0x14")]
		public int answer;

		// Token: 0x0400117C RID: 4476
		[Token(Token = "0x400117C")]
		[FieldOffset(Offset = "0x18")]
		public string ticket;
	}
}
