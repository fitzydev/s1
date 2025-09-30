using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	[Serializable]
	public class CartelGoonAppearance
	{
		// Token: 0x060038DA RID: 14554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DA")]
		[Address(RVA = "0x8036A0", Offset = "0x8020A0", VA = "0x1808036A0")]
		public CartelGoonAppearance(bool isMale, int baseAppearanceIndex, Color skinColor, Color hairColor, int clothingIndex, int voiceIndex)
		{
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DB")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public CartelGoonAppearance()
		{
		}

		// Token: 0x04002771 RID: 10097
		[Token(Token = "0x4002771")]
		[FieldOffset(Offset = "0x10")]
		public bool IsMale;

		// Token: 0x04002772 RID: 10098
		[Token(Token = "0x4002772")]
		[FieldOffset(Offset = "0x14")]
		public int BaseAppearanceIndex;

		// Token: 0x04002773 RID: 10099
		[Token(Token = "0x4002773")]
		[FieldOffset(Offset = "0x18")]
		public Color SkinColor;

		// Token: 0x04002774 RID: 10100
		[Token(Token = "0x4002774")]
		[FieldOffset(Offset = "0x28")]
		public Color HairColor;

		// Token: 0x04002775 RID: 10101
		[Token(Token = "0x4002775")]
		[FieldOffset(Offset = "0x38")]
		public int ClothingIndex;

		// Token: 0x04002776 RID: 10102
		[Token(Token = "0x4002776")]
		[FieldOffset(Offset = "0x3C")]
		public int VoiceIndex;
	}
}
