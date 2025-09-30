using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020009B6 RID: 2486
	[Token(Token = "0x20009B6")]
	[Serializable]
	public class WeedAppearanceSettings
	{
		// Token: 0x06004407 RID: 17415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004407")]
		[Address(RVA = "0x8A9BC0", Offset = "0x8A85C0", VA = "0x1808A9BC0")]
		public WeedAppearanceSettings(Color32 mainColor, Color32 secondaryColor, Color32 leafColor, Color32 stemColor)
		{
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004408")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public WeedAppearanceSettings()
		{
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x6004409")]
		[Address(RVA = "0x8A99A0", Offset = "0x8A83A0", VA = "0x1808A99A0")]
		public bool IsUnintialized()
		{
			return default(bool);
		}

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x10")]
		public Color32 MainColor;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x14")]
		public Color32 SecondaryColor;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x18")]
		public Color32 LeafColor;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x1C")]
		public Color32 StemColor;
	}
}
