using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	[Serializable]
	public class PID
	{
		// Token: 0x06003343 RID: 13123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003343")]
		[Address(RVA = "0x785BD0", Offset = "0x7845D0", VA = "0x180785BD0")]
		public PID(float pFactor, float iFactor, float dFactor)
		{
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x0000E220 File Offset: 0x0000C420
		[Token(Token = "0x6003344")]
		[Address(RVA = "0x785B90", Offset = "0x784590", VA = "0x180785B90")]
		public float Update(float setpoint, float actual, float timeFrame)
		{
			return 0f;
		}

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0x10")]
		public float pFactor;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x14")]
		public float iFactor;

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0x18")]
		public float dFactor;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0x1C")]
		private float integral;

		// Token: 0x04002392 RID: 9106
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0x20")]
		private float lastError;
	}
}
