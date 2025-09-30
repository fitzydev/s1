using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000945 RID: 2373
	[Token(Token = "0x2000945")]
	public class FunctionalPackaging : Draggable
	{
		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x00011178 File Offset: 0x0000F378
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090B")]
		public bool IsSealed
		{
			[Token(Token = "0x60040A9")]
			[Address(RVA = "0x50D9F0", Offset = "0x50C3F0", VA = "0x18050D9F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040AA")]
			[Address(RVA = "0x50DAB0", Offset = "0x50C4B0", VA = "0x18050DAB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x00011190 File Offset: 0x0000F390
		// (set) Token: 0x060040AC RID: 16556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090C")]
		public bool IsFull
		{
			[Token(Token = "0x60040AB")]
			[Address(RVA = "0x526840", Offset = "0x525240", VA = "0x180526840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040AC")]
			[Address(RVA = "0x526C80", Offset = "0x525680", VA = "0x180526C80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060040AD RID: 16557 RVA: 0x000111A8 File Offset: 0x0000F3A8
		// (set) Token: 0x060040AE RID: 16558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090D")]
		public bool ReachedOutput
		{
			[Token(Token = "0x60040AD")]
			[Address(RVA = "0x863160", Offset = "0x861B60", VA = "0x180863160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040AE")]
			[Address(RVA = "0x863170", Offset = "0x861B70", VA = "0x180863170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x8625E0", Offset = "0x860FE0", VA = "0x1808625E0", Slot = "14")]
		public virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x861C40", Offset = "0x860640", VA = "0x180861C40")]
		public void AlignTo(Transform alignment)
		{
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x862180", Offset = "0x860B80", VA = "0x180862180", Slot = "15")]
		public virtual void Destroy()
		{
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x8621E0", Offset = "0x860BE0", VA = "0x1808621E0", Slot = "9")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x862B40", Offset = "0x861540", VA = "0x180862B40", Slot = "16")]
		protected virtual void PackProduct(FunctionalProduct product)
		{
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x862430", Offset = "0x860E30", VA = "0x180862430", Slot = "17")]
		protected virtual void FullyPacked()
		{
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x862700", Offset = "0x861100", VA = "0x180862700", Slot = "18")]
		protected virtual void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x7795C0", Offset = "0x777FC0", VA = "0x1807795C0", Slot = "19")]
		protected virtual void EnableSealing()
		{
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x862DE0", Offset = "0x8617E0", VA = "0x180862DE0", Slot = "20")]
		public virtual void Seal()
		{
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x863040", Offset = "0x861A40", VA = "0x180863040")]
		public FunctionalPackaging()
		{
		}

		// Token: 0x04002DA1 RID: 11681
		[Token(Token = "0x4002DA1")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Settings")]
		public string SealInstruction;

		// Token: 0x04002DA2 RID: 11682
		[Token(Token = "0x4002DA2")]
		[FieldOffset(Offset = "0xC8")]
		public bool AutoEnableSealing;

		// Token: 0x04002DA3 RID: 11683
		[Token(Token = "0x4002DA3")]
		[FieldOffset(Offset = "0xCC")]
		public float ProductContactTime;

		// Token: 0x04002DA4 RID: 11684
		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0xD0")]
		public float ProductContactMaxVelocity;

		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0xD8")]
		[Header("References")]
		public PackagingDefinition Definition;

		// Token: 0x04002DA6 RID: 11686
		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0xE0")]
		public Transform AlignmentPoint;

		// Token: 0x04002DA7 RID: 11687
		[Token(Token = "0x4002DA7")]
		[FieldOffset(Offset = "0xE8")]
		public Transform[] ProductAlignmentPoints;

		// Token: 0x04002DA8 RID: 11688
		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0xF0")]
		public AudioSourceController SealSound;

		// Token: 0x04002DA9 RID: 11689
		[Token(Token = "0x4002DA9")]
		[FieldOffset(Offset = "0xF8")]
		protected List<FunctionalProduct> PackedProducts;

		// Token: 0x04002DAA RID: 11690
		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0x100")]
		public Action onFullyPacked;

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x108")]
		public Action onSealed;

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0x110")]
		public Action onReachOutput;

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0x118")]
		private PackagingStation station;

		// Token: 0x04002DAE RID: 11694
		[Token(Token = "0x4002DAE")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<FunctionalProduct, float> productContactTime;

		// Token: 0x04002DAF RID: 11695
		[Token(Token = "0x4002DAF")]
		[FieldOffset(Offset = "0x128")]
		private SmoothedVelocityCalculator VelocityCalculator;
	}
}
