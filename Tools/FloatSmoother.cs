using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008FC RID: 2300
	[Token(Token = "0x20008FC")]
	[Serializable]
	public class FloatSmoother
	{
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06003F86 RID: 16262 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		// (set) Token: 0x06003F87 RID: 16263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F3")]
		public float CurrentValue
		{
			[Token(Token = "0x6003F86")]
			[Address(RVA = "0x4657B0", Offset = "0x4641B0", VA = "0x1804657B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003F87")]
			[Address(RVA = "0x493FC0", Offset = "0x4929C0", VA = "0x180493FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		// (set) Token: 0x06003F89 RID: 16265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F4")]
		public float Multiplier
		{
			[Token(Token = "0x6003F88")]
			[Address(RVA = "0x4657C0", Offset = "0x4641C0", VA = "0x1804657C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003F89")]
			[Address(RVA = "0x465920", Offset = "0x464320", VA = "0x180465920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x860AF0", Offset = "0x85F4F0", VA = "0x180860AF0")]
		public void Initialize()
		{
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x860980", Offset = "0x85F380", VA = "0x180860980")]
		public void Destroy()
		{
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x860F20", Offset = "0x85F920", VA = "0x180860F20")]
		public void SetDefault(float value)
		{
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x465920", Offset = "0x464320", VA = "0x180465920")]
		public void SetMultiplier(float value)
		{
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x4A50D0", Offset = "0x4A3AD0", VA = "0x1804A50D0")]
		public void SetSmoothingSpeed(float value)
		{
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x860670", Offset = "0x85F070", VA = "0x180860670")]
		public void AddOverride(float value, int priority, string label)
		{
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x860CC0", Offset = "0x85F6C0", VA = "0x180860CC0")]
		public void RemoveOverride(string label)
		{
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x860F80", Offset = "0x85F980", VA = "0x180860F80")]
		public void Update()
		{
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x861020", Offset = "0x85FA20", VA = "0x180861020")]
		public FloatSmoother()
		{
		}

		// Token: 0x04002C86 RID: 11398
		[Token(Token = "0x4002C86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float DefaultValue;

		// Token: 0x04002C87 RID: 11399
		[Token(Token = "0x4002C87")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float SmoothingSpeed;

		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		[FieldOffset(Offset = "0x20")]
		private List<FloatSmoother.Override> overrides;

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x28")]
		private FloatSmoother.Override activeOverride;

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		[FieldOffset(Offset = "0x30")]
		private int activeCount;

		// Token: 0x020008FD RID: 2301
		[Token(Token = "0x20008FD")]
		public class Override
		{
			// Token: 0x06003F93 RID: 16275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F93")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Override()
			{
			}

			// Token: 0x04002C8B RID: 11403
			[Token(Token = "0x4002C8B")]
			[FieldOffset(Offset = "0x10")]
			public float Value;

			// Token: 0x04002C8C RID: 11404
			[Token(Token = "0x4002C8C")]
			[FieldOffset(Offset = "0x14")]
			public int Priority;

			// Token: 0x04002C8D RID: 11405
			[Token(Token = "0x4002C8D")]
			[FieldOffset(Offset = "0x18")]
			public string Label;
		}
	}
}
