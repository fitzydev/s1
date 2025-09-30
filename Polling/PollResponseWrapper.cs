using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	[Serializable]
	public class PollResponseWrapper
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public PollResponseWrapper()
		{
		}

		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		[FieldOffset(Offset = "0x10")]
		public bool success;

		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0x18")]
		public PollResponse data;
	}
}
