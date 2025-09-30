using System;
using Il2CppDummyDll;

namespace ScheduleOne.Property
{
	// Token: 0x020008AF RID: 2223
	[Token(Token = "0x20008AF")]
	public class LaunderingOperation
	{
		// Token: 0x06003CF1 RID: 15601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x83F390", Offset = "0x83DD90", VA = "0x18083F390")]
		public LaunderingOperation(Business _business, float _amount, int _minutesSinceStarted)
		{
		}

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0x10")]
		public Business business;

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0x18")]
		public float amount;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0x1C")]
		public int minutesSinceStarted;

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		[FieldOffset(Offset = "0x20")]
		public int completionTime_Minutes;
	}
}
