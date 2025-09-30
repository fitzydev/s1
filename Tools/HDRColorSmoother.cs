using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000903 RID: 2307
	[Token(Token = "0x2000903")]
	[Serializable]
	public class HDRColorSmoother
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06003FA0 RID: 16288 RVA: 0x00010F68 File Offset: 0x0000F168
		// (set) Token: 0x06003FA1 RID: 16289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F5")]
		public Color CurrentValue
		{
			[Token(Token = "0x6003FA0")]
			[Address(RVA = "0x4A4AD0", Offset = "0x4A34D0", VA = "0x1804A4AD0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6003FA1")]
			[Address(RVA = "0x4A4AE0", Offset = "0x4A34E0", VA = "0x1804A4AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x00010F80 File Offset: 0x0000F180
		// (set) Token: 0x06003FA3 RID: 16291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F6")]
		public float Multiplier
		{
			[Token(Token = "0x6003FA2")]
			[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003FA3")]
			[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA4")]
		[Address(RVA = "0x864180", Offset = "0x862B80", VA = "0x180864180")]
		public void Initialize()
		{
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x864010", Offset = "0x862A10", VA = "0x180864010")]
		public void Destroy()
		{
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x8645B0", Offset = "0x862FB0", VA = "0x1808645B0")]
		public void SetDefault(Color value)
		{
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
		public void SetMultiplier(float value)
		{
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x863D00", Offset = "0x862700", VA = "0x180863D00")]
		public void AddOverride(Color value, int priority, string label)
		{
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x864350", Offset = "0x862D50", VA = "0x180864350")]
		public void RemoveOverride(string label)
		{
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x85EE30", Offset = "0x85D830", VA = "0x18085EE30")]
		public void Update()
		{
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x864620", Offset = "0x863020", VA = "0x180864620")]
		public HDRColorSmoother()
		{
		}

		// Token: 0x04002C97 RID: 11415
		[Token(Token = "0x4002C97")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[ColorUsage(true, true)]
		private Color DefaultValue;

		// Token: 0x04002C98 RID: 11416
		[Token(Token = "0x4002C98")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float SmoothingSpeed;

		// Token: 0x04002C99 RID: 11417
		[Token(Token = "0x4002C99")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<HDRColorSmoother.Override> overrides;

		// Token: 0x04002C9A RID: 11418
		[Token(Token = "0x4002C9A")]
		[FieldOffset(Offset = "0x40")]
		private HDRColorSmoother.Override activeOverride;

		// Token: 0x04002C9B RID: 11419
		[Token(Token = "0x4002C9B")]
		[FieldOffset(Offset = "0x48")]
		private int activeCount;

		// Token: 0x02000904 RID: 2308
		[Token(Token = "0x2000904")]
		[Serializable]
		public class Override
		{
			// Token: 0x06003FAC RID: 16300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FAC")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Override()
			{
			}

			// Token: 0x04002C9C RID: 11420
			[Token(Token = "0x4002C9C")]
			[FieldOffset(Offset = "0x10")]
			public Color Value;

			// Token: 0x04002C9D RID: 11421
			[Token(Token = "0x4002C9D")]
			[FieldOffset(Offset = "0x20")]
			public int Priority;

			// Token: 0x04002C9E RID: 11422
			[Token(Token = "0x4002C9E")]
			[FieldOffset(Offset = "0x28")]
			public string Label;
		}
	}
}
