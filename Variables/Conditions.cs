using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	[Serializable]
	public class Conditions
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0xAA0020", Offset = "0xA9EA20", VA = "0x180AA0020")]
		public bool Evaluate()
		{
			return default(bool);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public Conditions()
		{
		}

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x10")]
		public Conditions.EEvaluationType EvaluationType;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x18")]
		public Condition[] ConditionList;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x20")]
		public QuestCondition[] QuestConditionList;

		// Token: 0x0200029F RID: 671
		[Token(Token = "0x200029F")]
		public enum EEvaluationType
		{
			// Token: 0x04000E31 RID: 3633
			[Token(Token = "0x4000E31")]
			And,
			// Token: 0x04000E32 RID: 3634
			[Token(Token = "0x4000E32")]
			Or
		}
	}
}
