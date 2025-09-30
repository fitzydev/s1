using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public class Task
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038F")]
		public virtual string TaskName
		{
			[Token(Token = "0x60012BA")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012BB")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000390")]
		public string CurrentInstruction
		{
			[Token(Token = "0x60012BC")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00007FB0 File Offset: 0x000061B0
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000391")]
		public bool TaskActive
		{
			[Token(Token = "0x60012BE")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60012BF")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x5A5BE0", Offset = "0x5A45E0", VA = "0x1805A5BE0")]
		public Task()
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x5A4BA0", Offset = "0x5A35A0", VA = "0x1805A4BA0", Slot = "6")]
		public virtual void StopTask()
		{
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x5A4DF0", Offset = "0x5A37F0", VA = "0x1805A4DF0", Slot = "7")]
		public virtual void Success()
		{
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x5A35F0", Offset = "0x5A1FF0", VA = "0x1805A35F0", Slot = "8")]
		public virtual void Fail()
		{
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x5A5850", Offset = "0x5A4250", VA = "0x1805A5850", Slot = "9")]
		public virtual void Update()
		{
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x5A4EC0", Offset = "0x5A38C0", VA = "0x1805A4EC0", Slot = "10")]
		protected virtual void UpdateCursor()
		{
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C6")]
		[Address(RVA = "0x5A4680", Offset = "0x5A3080", VA = "0x1805A4680", Slot = "11")]
		public virtual void LateUpdate()
		{
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x5A42E0", Offset = "0x5A2CE0", VA = "0x1805A42E0")]
		private Vector3 GetMultiDragOrigin()
		{
			return default(Vector3);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x5A3640", Offset = "0x5A2040", VA = "0x1805A3640", Slot = "12")]
		public virtual void FixedUpdate()
		{
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x5A3E70", Offset = "0x5A2870", VA = "0x1805A3E70")]
		public void ForceStartClick(Clickable _clickable)
		{
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x5A3DC0", Offset = "0x5A27C0", VA = "0x1805A3DC0")]
		public void ForceEndClick(Clickable _clickable)
		{
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x5A5070", Offset = "0x5A3A70", VA = "0x1805A5070")]
		private void UpdateDraggablePhysics()
		{
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x5A3FA0", Offset = "0x5A29A0", VA = "0x1805A3FA0", Slot = "13")]
		protected virtual Clickable GetClickable(out RaycastHit hit)
		{
			return null;
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x5A35B0", Offset = "0x5A1FB0", VA = "0x1805A35B0")]
		protected void EnableMultiDragging(Transform projectionPlane, float radius = 0.08f)
		{
		}

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		public const float ClickDetectionRange = 3f;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x10")]
		public float ClickDetectionRadius;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x14")]
		protected float MultiGrabRadius;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		public const float MultiGrabForceMultiplier = 1.25f;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x29")]
		public bool ClickDetectionEnabled;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		[FieldOffset(Offset = "0x2C")]
		public Task.EOutcome Outcome;

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x30")]
		public Action onTaskSuccess;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x38")]
		public Action onTaskFail;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x40")]
		public Action onTaskStop;

		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		[FieldOffset(Offset = "0x48")]
		protected Clickable clickable;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		[FieldOffset(Offset = "0x50")]
		protected Draggable draggable;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x58")]
		protected DraggableConstraint constraint;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0x60")]
		protected float hitDistance;

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x64")]
		protected Vector3 relativeHitOffset;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0x70")]
		private bool multiDraggingEnabled;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0x78")]
		private Transform multiGrabProjectionPlane;

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0x80")]
		private List<Draggable> multiDragTargets;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		[FieldOffset(Offset = "0x88")]
		private bool isMultiDragging;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		[FieldOffset(Offset = "0x90")]
		private List<Clickable> forcedClickables;

		// Token: 0x02000352 RID: 850
		[Token(Token = "0x2000352")]
		public enum EOutcome
		{
			// Token: 0x04001200 RID: 4608
			[Token(Token = "0x4001200")]
			Cancelled,
			// Token: 0x04001201 RID: 4609
			[Token(Token = "0x4001201")]
			Success,
			// Token: 0x04001202 RID: 4610
			[Token(Token = "0x4001202")]
			Fail
		}
	}
}
