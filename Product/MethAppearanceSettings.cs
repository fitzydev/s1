using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200098D RID: 2445
	[Token(Token = "0x200098D")]
	[Serializable]
	public class MethAppearanceSettings
	{
		// Token: 0x060042B9 RID: 17081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x879DE0", Offset = "0x8787E0", VA = "0x180879DE0")]
		public MethAppearanceSettings(Color32 mainColor, Color32 secondaryColor)
		{
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public MethAppearanceSettings()
		{
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x879CC0", Offset = "0x8786C0", VA = "0x180879CC0")]
		public bool IsUnintialized()
		{
			return default(bool);
		}

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x10")]
		public Color32 MainColor;

		// Token: 0x04002EE4 RID: 12004
		[Token(Token = "0x4002EE4")]
		[FieldOffset(Offset = "0x14")]
		public Color32 SecondaryColor;
	}
}
