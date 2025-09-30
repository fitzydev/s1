using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000934 RID: 2356
	[Token(Token = "0x2000934")]
	public class FunctionalBaggie : FunctionalPackaging
	{
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x000110E8 File Offset: 0x0000F2E8
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000904")]
		public override CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x6004060")]
			[Address(RVA = "0x659850", Offset = "0x658250", VA = "0x180659850", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x6004061")]
			[Address(RVA = "0x659B00", Offset = "0x658500", VA = "0x180659B00", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004062")]
		[Address(RVA = "0x861300", Offset = "0x85FD00", VA = "0x180861300")]
		public void SetClosed(float closedDelta)
		{
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004063")]
		[Address(RVA = "0x8613A0", Offset = "0x85FDA0", VA = "0x1808613A0", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x861230", Offset = "0x85FC30", VA = "0x180861230", Slot = "20")]
		public override void Seal()
		{
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x8611F0", Offset = "0x85FBF0", VA = "0x1808611F0", Slot = "17")]
		protected override void FullyPacked()
		{
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004066")]
		[Address(RVA = "0x8614A0", Offset = "0x85FEA0", VA = "0x1808614A0")]
		public FunctionalBaggie()
		{
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004067")]
		[Address(RVA = "0x861430", Offset = "0x85FE30", VA = "0x180861430")]
		[CompilerGenerated]
		private IEnumerator <Seal>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x130")]
		public SkinnedMeshRenderer[] BagMeshes;

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x138")]
		public GameObject FunnelCollidersContainer;

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x140")]
		public GameObject FullyPackedBlocker;

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x148")]
		public Collider DynamicCollider;

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0x154")]
		private float ClosedDelta;
	}
}
