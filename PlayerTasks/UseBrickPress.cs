using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;
using ScheduleOne.Product;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000365 RID: 869
	[Token(Token = "0x2000365")]
	public class UseBrickPress : Task
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A6")]
		public override string TaskName
		{
			[Token(Token = "0x6001347")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001348")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x5BA2E0", Offset = "0x5B8CE0", VA = "0x1805BA2E0")]
		public UseBrickPress(BrickPress _press, ProductItemInstance _product)
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x5BA280", Offset = "0x5B8C80", VA = "0x1805BA280", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x5B9D80", Offset = "0x5B8780", VA = "0x1805B9D80", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x5B9AA0", Offset = "0x5B84A0", VA = "0x1805B9AA0")]
		private void CheckMould()
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x5B97C0", Offset = "0x5B81C0", VA = "0x1805B97C0")]
		private void BeginPress()
		{
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x5B9B70", Offset = "0x5B8570", VA = "0x1805B9B70")]
		private void FinishPress()
		{
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x5BA210", Offset = "0x5B8C10", VA = "0x1805BA210")]
		[CompilerGenerated]
		private IEnumerator <.ctor>g__CheckMould|11_0()
		{
			return null;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x5BA1A0", Offset = "0x5B8BA0", VA = "0x1805BA1A0")]
		[CompilerGenerated]
		private IEnumerator <FinishPress>g__Wait|16_0()
		{
			return null;
		}

		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		public const float PRODUCT_SCALE = 0.75f;

		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0xA0")]
		protected UseBrickPress.EStep currentStep;

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0xA8")]
		protected BrickPress press;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0xB0")]
		protected ProductItemInstance product;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0xB8")]
		protected List<FunctionalProduct> products;

		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0xC0")]
		protected Draggable container;

		// Token: 0x02000366 RID: 870
		[Token(Token = "0x2000366")]
		public enum EStep
		{
			// Token: 0x04001260 RID: 4704
			[Token(Token = "0x4001260")]
			Pouring,
			// Token: 0x04001261 RID: 4705
			[Token(Token = "0x4001261")]
			Pressing,
			// Token: 0x04001262 RID: 4706
			[Token(Token = "0x4001262")]
			Complete
		}
	}
}
