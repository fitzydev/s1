using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	[Serializable]
	public class Condition
	{
		// Token: 0x06000DE9 RID: 3561 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0xA9FE70", Offset = "0xA9E870", VA = "0x180A9FE70")]
		public bool Evaluate()
		{
			return default(bool);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0xA9FFA0", Offset = "0xA9E9A0", VA = "0x180A9FFA0")]
		public Condition()
		{
		}

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x10")]
		public string VariableName;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x18")]
		public Condition.EConditionType Operator;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x20")]
		public string Value;

		// Token: 0x0200029D RID: 669
		[Token(Token = "0x200029D")]
		public enum EConditionType
		{
			// Token: 0x04000E27 RID: 3623
			[Token(Token = "0x4000E27")]
			GreaterThan,
			// Token: 0x04000E28 RID: 3624
			[Token(Token = "0x4000E28")]
			LessThan,
			// Token: 0x04000E29 RID: 3625
			[Token(Token = "0x4000E29")]
			EqualTo,
			// Token: 0x04000E2A RID: 3626
			[Token(Token = "0x4000E2A")]
			NotEqualTo,
			// Token: 0x04000E2B RID: 3627
			[Token(Token = "0x4000E2B")]
			GreaterThanOrEqualTo,
			// Token: 0x04000E2C RID: 3628
			[Token(Token = "0x4000E2C")]
			LessThanOrEqualTo
		}
	}
}
