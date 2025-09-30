using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008ED RID: 2285
	[Token(Token = "0x20008ED")]
	[Serializable]
	public class ColorSmoother
	{
		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x00010E18 File Offset: 0x0000F018
		// (set) Token: 0x06003F50 RID: 16208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EE")]
		public Color CurrentValue
		{
			[Token(Token = "0x6003F4F")]
			[Address(RVA = "0x4A4AD0", Offset = "0x4A34D0", VA = "0x1804A4AD0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6003F50")]
			[Address(RVA = "0x4A4AE0", Offset = "0x4A34E0", VA = "0x1804A4AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003F51 RID: 16209 RVA: 0x00010E30 File Offset: 0x0000F030
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EF")]
		public float Multiplier
		{
			[Token(Token = "0x6003F51")]
			[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003F52")]
			[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x00010E48 File Offset: 0x0000F048
		[Token(Token = "0x170008F0")]
		public Color Default
		{
			[Token(Token = "0x6003F53")]
			[Address(RVA = "0x85EFF0", Offset = "0x85D9F0", VA = "0x18085EFF0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x85E990", Offset = "0x85D390", VA = "0x18085E990")]
		public void Initialize()
		{
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x85E820", Offset = "0x85D220", VA = "0x18085E820")]
		public void Destroy()
		{
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x85EDC0", Offset = "0x85D7C0", VA = "0x18085EDC0")]
		public void SetDefault(Color value)
		{
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
		public void SetMultiplier(float value)
		{
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x85E510", Offset = "0x85CF10", VA = "0x18085E510")]
		public void AddOverride(Color value, int priority, string label)
		{
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x85EB60", Offset = "0x85D560", VA = "0x18085EB60")]
		public void RemoveOverride(string label)
		{
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x85EE30", Offset = "0x85D830", VA = "0x18085EE30")]
		public void Update()
		{
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x85EF50", Offset = "0x85D950", VA = "0x18085EF50")]
		public ColorSmoother()
		{
		}

		// Token: 0x04002C5C RID: 11356
		[Token(Token = "0x4002C5C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color DefaultValue;

		// Token: 0x04002C5D RID: 11357
		[Token(Token = "0x4002C5D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float SmoothingSpeed;

		// Token: 0x04002C5E RID: 11358
		[Token(Token = "0x4002C5E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ColorSmoother.Override> overrides;

		// Token: 0x04002C5F RID: 11359
		[Token(Token = "0x4002C5F")]
		[FieldOffset(Offset = "0x40")]
		private ColorSmoother.Override activeOverride;

		// Token: 0x04002C60 RID: 11360
		[Token(Token = "0x4002C60")]
		[FieldOffset(Offset = "0x48")]
		private int activeCount;

		// Token: 0x020008EE RID: 2286
		[Token(Token = "0x20008EE")]
		[Serializable]
		public class Override
		{
			// Token: 0x06003F5C RID: 16220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F5C")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Override()
			{
			}

			// Token: 0x04002C61 RID: 11361
			[Token(Token = "0x4002C61")]
			[FieldOffset(Offset = "0x10")]
			public Color Value;

			// Token: 0x04002C62 RID: 11362
			[Token(Token = "0x4002C62")]
			[FieldOffset(Offset = "0x20")]
			public int Priority;

			// Token: 0x04002C63 RID: 11363
			[Token(Token = "0x4002C63")]
			[FieldOffset(Offset = "0x28")]
			public string Label;
		}
	}
}
