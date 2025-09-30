using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	public class ExitAction
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000785")]
		public bool Used
		{
			[Token(Token = "0x60033B9")]
			[Address(RVA = "0x4A1AC0", Offset = "0x4A04C0", VA = "0x1804A1AC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033BA")]
			[Address(RVA = "0x777270", Offset = "0x775C70", VA = "0x180777270")]
			set
			{
			}
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BB")]
		[Address(RVA = "0x777260", Offset = "0x775C60", VA = "0x180777260")]
		public void Use()
		{
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public ExitAction()
		{
		}

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0x10")]
		public ExitType exitType;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0x14")]
		private bool used;
	}
}
