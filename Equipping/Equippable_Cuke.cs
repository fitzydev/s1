using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Product;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009BE RID: 2494
	[Token(Token = "0x20009BE")]
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x00011E08 File Offset: 0x00010008
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000978")]
		public bool IsDrinking
		{
			[Token(Token = "0x6004430")]
			[Address(RVA = "0x850260", Offset = "0x84EC60", VA = "0x180850260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004431")]
			[Address(RVA = "0x850310", Offset = "0x84ED10", VA = "0x180850310")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004432")]
		[Address(RVA = "0x893480", Offset = "0x891E80", VA = "0x180893480", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004433")]
		[Address(RVA = "0x893390", Offset = "0x891D90", VA = "0x180893390")]
		public void Drink()
		{
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004434")]
		[Address(RVA = "0x892F60", Offset = "0x891960", VA = "0x180892F60")]
		public void ApplyEffects()
		{
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x8935B0", Offset = "0x891FB0", VA = "0x1808935B0")]
		public Equippable_Cuke()
		{
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x893410", Offset = "0x891E10", VA = "0x180893410")]
		[CompilerGenerated]
		private IEnumerator <Drink>g__DrinkRoutine|17_0()
		{
			return null;
		}

		// Token: 0x04002FB2 RID: 12210
		[Token(Token = "0x4002FB2")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Settings")]
		public float BaseEnergyGain;

		// Token: 0x04002FB3 RID: 12211
		[Token(Token = "0x4002FB3")]
		[FieldOffset(Offset = "0x70")]
		public float MinEnergyGain;

		// Token: 0x04002FB4 RID: 12212
		[Token(Token = "0x4002FB4")]
		[FieldOffset(Offset = "0x74")]
		public float ConsecutiveReduction;

		// Token: 0x04002FB5 RID: 12213
		[Token(Token = "0x4002FB5")]
		[FieldOffset(Offset = "0x78")]
		public float HealthGain;

		// Token: 0x04002FB6 RID: 12214
		[Token(Token = "0x4002FB6")]
		[FieldOffset(Offset = "0x7C")]
		public float AnimationDuration;

		// Token: 0x04002FB7 RID: 12215
		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x80")]
		public bool ClearDrugEffects;

		// Token: 0x04002FB8 RID: 12216
		[Token(Token = "0x4002FB8")]
		[FieldOffset(Offset = "0x88")]
		public ProductDefinition PseudoProduct;

		// Token: 0x04002FB9 RID: 12217
		[Token(Token = "0x4002FB9")]
		[FieldOffset(Offset = "0x90")]
		[Header("References")]
		public Animation OpenAnim;

		// Token: 0x04002FBA RID: 12218
		[Token(Token = "0x4002FBA")]
		[FieldOffset(Offset = "0x98")]
		public Animation DrinkAnim;

		// Token: 0x04002FBB RID: 12219
		[Token(Token = "0x4002FBB")]
		[FieldOffset(Offset = "0xA0")]
		public AudioSourceController OpenSound;

		// Token: 0x04002FBC RID: 12220
		[Token(Token = "0x4002FBC")]
		[FieldOffset(Offset = "0xA8")]
		public AudioSourceController SlurpSound;

		// Token: 0x04002FBD RID: 12221
		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0xB0")]
		public TrashItem TrashPrefab;
	}
}
