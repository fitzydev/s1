using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	// Token: 0x020009A8 RID: 2472
	[Token(Token = "0x20009A8")]
	public class Product_Equippable : Equippable_Viewmodel
	{
		// Token: 0x060043DB RID: 17371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DB")]
		[Address(RVA = "0x8A70A0", Offset = "0x8A5AA0", VA = "0x1808A70A0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0x8A74D0", Offset = "0x8A5ED0", VA = "0x1808A74D0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x8A76B0", Offset = "0x8A60B0", VA = "0x1808A76B0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x8A6E60", Offset = "0x8A5860", VA = "0x1808A6E60", Slot = "11")]
		protected virtual void Consume()
		{
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DF")]
		[Address(RVA = "0x8A6DA0", Offset = "0x8A57A0", VA = "0x1808A6DA0", Slot = "12")]
		protected virtual void ApplyEffects()
		{
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043E0")]
		[Address(RVA = "0x8A7C20", Offset = "0x8A6620", VA = "0x1808A7C20")]
		public Product_Equippable()
		{
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043E1")]
		[Address(RVA = "0x8A7460", Offset = "0x8A5E60", VA = "0x1808A7460")]
		[CompilerGenerated]
		private IEnumerator <Consume>g__ConsumeRoutine|20_0()
		{
			return null;
		}

		// Token: 0x04002F5E RID: 12126
		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public FilledPackagingVisuals Visuals;

		// Token: 0x04002F5F RID: 12127
		[Token(Token = "0x4002F5F")]
		[FieldOffset(Offset = "0x70")]
		public Transform ModelContainer;

		// Token: 0x04002F60 RID: 12128
		[Token(Token = "0x4002F60")]
		[FieldOffset(Offset = "0x78")]
		[Header("Settings")]
		public bool Consumable;

		// Token: 0x04002F61 RID: 12129
		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x80")]
		public string ConsumeDescription;

		// Token: 0x04002F62 RID: 12130
		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x88")]
		public float ConsumeTime;

		// Token: 0x04002F63 RID: 12131
		[Token(Token = "0x4002F63")]
		[FieldOffset(Offset = "0x8C")]
		public float EffectsApplyDelay;

		// Token: 0x04002F64 RID: 12132
		[Token(Token = "0x4002F64")]
		[FieldOffset(Offset = "0x90")]
		public string ConsumeAnimationBool;

		// Token: 0x04002F65 RID: 12133
		[Token(Token = "0x4002F65")]
		[FieldOffset(Offset = "0x98")]
		public string ConsumeAnimationTrigger;

		// Token: 0x04002F66 RID: 12134
		[Token(Token = "0x4002F66")]
		[FieldOffset(Offset = "0xA0")]
		public string ConsumeEquippableAssetPath;

		// Token: 0x04002F67 RID: 12135
		[Token(Token = "0x4002F67")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Events")]
		public UnityEvent onConsumeInputStart;

		// Token: 0x04002F68 RID: 12136
		[Token(Token = "0x4002F68")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent onConsumeInputComplete;

		// Token: 0x04002F69 RID: 12137
		[Token(Token = "0x4002F69")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onConsumeInputCancel;

		// Token: 0x04002F6A RID: 12138
		[Token(Token = "0x4002F6A")]
		[FieldOffset(Offset = "0xC0")]
		private float consumeTime;

		// Token: 0x04002F6B RID: 12139
		[Token(Token = "0x4002F6B")]
		[FieldOffset(Offset = "0xC4")]
		private bool consumingInProgress;

		// Token: 0x04002F6C RID: 12140
		[Token(Token = "0x4002F6C")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 defaultModelPosition;

		// Token: 0x04002F6D RID: 12141
		[Token(Token = "0x4002F6D")]
		[FieldOffset(Offset = "0xD4")]
		private int productAmount;

		// Token: 0x04002F6E RID: 12142
		[Token(Token = "0x4002F6E")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine consumeRoutine;
	}
}
