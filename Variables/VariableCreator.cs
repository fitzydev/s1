using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	[Serializable]
	public class VariableCreator
	{
		// Token: 0x06000DF7 RID: 3575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0xAB7F80", Offset = "0xAB6980", VA = "0x180AB7F80")]
		public VariableCreator()
		{
		}

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x18")]
		public VariableDatabase.EVariableType Type;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0x20")]
		public string InitialValue;

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0x28")]
		public bool Persistent;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0x2C")]
		public EVariableMode Mode;
	}
}
