using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	[Serializable]
	public class VariableSetter
	{
		// Token: 0x06000E21 RID: 3617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0xAD0CF0", Offset = "0xACF6F0", VA = "0x180AD0CF0")]
		public void Execute()
		{
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public VariableSetter()
		{
		}

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x10")]
		public string VariableName;

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x18")]
		public string NewValue;
	}
}
