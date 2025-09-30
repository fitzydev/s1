using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C9C RID: 3228
	[Token(Token = "0x2000C9C")]
	public class Beaker : StationItem
	{
		// Token: 0x06005885 RID: 22661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005885")]
		[Address(RVA = "0xA02E40", Offset = "0xA01840", VA = "0x180A02E40")]
		private void Start()
		{
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005886")]
		[Address(RVA = "0xA02F10", Offset = "0xA01910", VA = "0x180A02F10")]
		private void Update()
		{
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005887")]
		[Address(RVA = "0xA02DC0", Offset = "0xA017C0", VA = "0x180A02DC0")]
		public void SetStatic(bool stat)
		{
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005888")]
		[Address(RVA = "0xA03040", Offset = "0xA01A40", VA = "0x180A03040")]
		public Beaker()
		{
		}

		// Token: 0x04004129 RID: 16681
		[Token(Token = "0x4004129")]
		[FieldOffset(Offset = "0x38")]
		public float ClampAngle_MaxLiquid;

		// Token: 0x0400412A RID: 16682
		[Token(Token = "0x400412A")]
		[FieldOffset(Offset = "0x3C")]
		public float ClampAngle_MinLiquid;

		// Token: 0x0400412B RID: 16683
		[Token(Token = "0x400412B")]
		[FieldOffset(Offset = "0x40")]
		public float AngleToPour_MaxLiquid;

		// Token: 0x0400412C RID: 16684
		[Token(Token = "0x400412C")]
		[FieldOffset(Offset = "0x44")]
		public float AngleToPour_MinLiquid;

		// Token: 0x0400412D RID: 16685
		[Token(Token = "0x400412D")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Draggable Draggable;

		// Token: 0x0400412E RID: 16686
		[Token(Token = "0x400412E")]
		[FieldOffset(Offset = "0x50")]
		public DraggableConstraint Constraint;

		// Token: 0x0400412F RID: 16687
		[Token(Token = "0x400412F")]
		[FieldOffset(Offset = "0x58")]
		public Collider ConcaveCollider;

		// Token: 0x04004130 RID: 16688
		[Token(Token = "0x4004130")]
		[FieldOffset(Offset = "0x60")]
		public Collider ConvexCollider;

		// Token: 0x04004131 RID: 16689
		[Token(Token = "0x4004131")]
		[FieldOffset(Offset = "0x68")]
		public Transform CenterOfMass;

		// Token: 0x04004132 RID: 16690
		[Token(Token = "0x4004132")]
		[FieldOffset(Offset = "0x70")]
		public ConfigurableJoint Joint;

		// Token: 0x04004133 RID: 16691
		[Token(Token = "0x4004133")]
		[FieldOffset(Offset = "0x78")]
		public Rigidbody Anchor;

		// Token: 0x04004134 RID: 16692
		[Token(Token = "0x4004134")]
		[FieldOffset(Offset = "0x80")]
		public LiquidContainer Container;

		// Token: 0x04004135 RID: 16693
		[Token(Token = "0x4004135")]
		[FieldOffset(Offset = "0x88")]
		public Fillable Fillable;

		// Token: 0x04004136 RID: 16694
		[Token(Token = "0x4004136")]
		[FieldOffset(Offset = "0x90")]
		public PourableModule Pourable;

		// Token: 0x04004137 RID: 16695
		[Token(Token = "0x4004137")]
		[FieldOffset(Offset = "0x98")]
		public GameObject FilterPaper;
	}
}
