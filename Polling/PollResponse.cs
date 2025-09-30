using System;
using Il2CppDummyDll;

namespace ScheduleOne.Polling
{
	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	[Serializable]
	public class PollResponse
	{
		// Token: 0x0600127E RID: 4734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x59AE70", Offset = "0x599870", VA = "0x18059AE70")]
		public PollData GetActive()
		{
			return null;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x59AF00", Offset = "0x599900", VA = "0x18059AF00")]
		public PollData GetConfirmed()
		{
			return null;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public PollResponse()
		{
		}

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x10")]
		public PollData[] polls;

		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0x18")]
		public int active;

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x1C")]
		public int confirmed;
	}
}
