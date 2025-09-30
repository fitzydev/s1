using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000936 RID: 2358
	[Token(Token = "0x2000936")]
	public class FunctionalJar : FunctionalPackaging
	{
		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x00011118 File Offset: 0x0000F318
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000907")]
		public override CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x600406E")]
			[Address(RVA = "0x5489A0", Offset = "0x5473A0", VA = "0x1805489A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x600406F")]
			[Address(RVA = "0x548DF0", Offset = "0x5477F0", VA = "0x180548DF0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x861650", Offset = "0x860050", VA = "0x180861650", Slot = "14")]
		public override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
		{
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004071")]
		[Address(RVA = "0x8614E0", Offset = "0x85FEE0", VA = "0x1808614E0", Slot = "15")]
		public override void Destroy()
		{
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004072")]
		[Address(RVA = "0x861590", Offset = "0x85FF90", VA = "0x180861590", Slot = "19")]
		protected override void EnableSealing()
		{
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004073")]
		[Address(RVA = "0x861930", Offset = "0x860330", VA = "0x180861930", Slot = "12")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004074")]
		[Address(RVA = "0x861940", Offset = "0x860340", VA = "0x180861940", Slot = "18")]
		protected override void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x861A30", Offset = "0x860430", VA = "0x180861A30", Slot = "20")]
		public override void Seal()
		{
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x861610", Offset = "0x860010", VA = "0x180861610", Slot = "17")]
		protected override void FullyPacked()
		{
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004077")]
		[Address(RVA = "0x861BD0", Offset = "0x8605D0", VA = "0x180861BD0")]
		public FunctionalJar()
		{
		}

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public Draggable Lid;

		// Token: 0x04002D4D RID: 11597
		[Token(Token = "0x4002D4D")]
		[FieldOffset(Offset = "0x140")]
		public Transform LidStartPoint;

		// Token: 0x04002D4E RID: 11598
		[Token(Token = "0x4002D4E")]
		[FieldOffset(Offset = "0x148")]
		public Collider LidSensor;

		// Token: 0x04002D4F RID: 11599
		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x150")]
		public Collider LidCollider;

		// Token: 0x04002D50 RID: 11600
		[Token(Token = "0x4002D50")]
		[FieldOffset(Offset = "0x158")]
		public GameObject FullyPackedBlocker;

		// Token: 0x04002D51 RID: 11601
		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x160")]
		private GameObject LidObject;

		// Token: 0x04002D52 RID: 11602
		[Token(Token = "0x4002D52")]
		[FieldOffset(Offset = "0x168")]
		private Vector3 lidPosition;
	}
}
