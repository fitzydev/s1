using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000983 RID: 2435
	[Token(Token = "0x2000983")]
	[Serializable]
	public class CocaineAppearanceSettings
	{
		// Token: 0x0600429C RID: 17052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429C")]
		[Address(RVA = "0x879DE0", Offset = "0x8787E0", VA = "0x180879DE0")]
		public CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor)
		{
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429D")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public CocaineAppearanceSettings()
		{
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x600429E")]
		[Address(RVA = "0x879CC0", Offset = "0x8786C0", VA = "0x180879CC0")]
		public bool IsUnintialized()
		{
			return default(bool);
		}

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x10")]
		public Color32 MainColor;

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x14")]
		public Color32 SecondaryColor;
	}
}
