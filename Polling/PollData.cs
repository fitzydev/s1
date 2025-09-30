using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x02000342 RID: 834
	[Token(Token = "0x2000342")]
	[Serializable]
	public class PollData
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public PollData()
		{
		}

		// Token: 0x0400117D RID: 4477
		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0x10")]
		public int pollId;

		// Token: 0x0400117E RID: 4478
		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0x18")]
		public string question;

		// Token: 0x0400117F RID: 4479
		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x20")]
		public string[] answers;

		// Token: 0x04001180 RID: 4480
		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x28")]
		public int winnerIndex;

		// Token: 0x04001181 RID: 4481
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x30")]
		public string confirmationMessage;
	}
}
