using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2000946")]
	public class FunctionalProduct : Draggable
	{
		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060040BA RID: 16570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700090E")]
		public SmoothedVelocityCalculator VelocityCalculator
		{
			[Token(Token = "0x60040B9")]
			[Address(RVA = "0x50D8B0", Offset = "0x50C2B0", VA = "0x18050D8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040BA")]
			[Address(RVA = "0x50DA50", Offset = "0x50C450", VA = "0x18050DA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x8637D0", Offset = "0x8621D0", VA = "0x1808637D0", Slot = "14")]
		public virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x863960", Offset = "0x862360", VA = "0x180863960", Slot = "15")]
		public virtual void Initialize(ItemInstance item)
		{
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x863700", Offset = "0x862100", VA = "0x180863700", Slot = "16")]
		public virtual void InitializeVisuals(ItemInstance item)
		{
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x863180", Offset = "0x861B80", VA = "0x180863180")]
		public void AlignTo(Transform alignment)
		{
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x8636F0", Offset = "0x8620F0", VA = "0x1808636F0", Slot = "9")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x863AD0", Offset = "0x8624D0", VA = "0x180863AD0", Slot = "12")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x863570", Offset = "0x861F70", VA = "0x180863570")]
		private void Clamp()
		{
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x8614C0", Offset = "0x85FEC0", VA = "0x1808614C0")]
		public FunctionalProduct()
		{
		}

		// Token: 0x04002DB0 RID: 11696
		[Token(Token = "0x4002DB0")]
		[FieldOffset(Offset = "0xB8")]
		public bool ClampZ;

		// Token: 0x04002DB1 RID: 11697
		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0xC0")]
		[Header("References")]
		public Transform AlignmentPoint;

		// Token: 0x04002DB2 RID: 11698
		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0xC8")]
		public FilledPackagingVisuals Visuals;

		// Token: 0x04002DB3 RID: 11699
		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 startLocalPos;

		// Token: 0x04002DB4 RID: 11700
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0xDC")]
		private float lowestMaxZ;
	}
}
