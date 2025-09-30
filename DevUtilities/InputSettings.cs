using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	[Serializable]
	public class InputSettings
	{
		// Token: 0x06003392 RID: 13202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003392")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public InputSettings()
		{
		}

		// Token: 0x040023E6 RID: 9190
		[Token(Token = "0x40023E6")]
		[FieldOffset(Offset = "0x10")]
		public float MouseSensitivity;

		// Token: 0x040023E7 RID: 9191
		[Token(Token = "0x40023E7")]
		[FieldOffset(Offset = "0x14")]
		public bool InvertMouse;

		// Token: 0x040023E8 RID: 9192
		[Token(Token = "0x40023E8")]
		[FieldOffset(Offset = "0x18")]
		public InputSettings.EActionMode SprintMode;

		// Token: 0x040023E9 RID: 9193
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0x20")]
		public string BindingOverrides;

		// Token: 0x0200077B RID: 1915
		[Token(Token = "0x200077B")]
		public enum EActionMode
		{
			// Token: 0x040023EB RID: 9195
			[Token(Token = "0x40023EB")]
			Press,
			// Token: 0x040023EC RID: 9196
			[Token(Token = "0x40023EC")]
			Hold
		}
	}
}
