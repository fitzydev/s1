using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034B RID: 843
	[Token(Token = "0x200034B")]
	public class Draggable : Clickable
	{
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038A")]
		public Rigidbody Rb
		{
			[Token(Token = "0x600128F")]
			[Address(RVA = "0x506BA0", Offset = "0x5055A0", VA = "0x180506BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001290")]
			[Address(RVA = "0x592AE0", Offset = "0x5914E0", VA = "0x180592AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00007F08 File Offset: 0x00006108
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038B")]
		public override CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x6001291")]
			[Address(RVA = "0x592AC0", Offset = "0x5914C0", VA = "0x180592AC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x6001292")]
			[Address(RVA = "0x592AD0", Offset = "0x5914D0", VA = "0x180592AD0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x5920E0", Offset = "0x590AE0", VA = "0x1805920E0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x592270", Offset = "0x590C70", VA = "0x180592270", Slot = "9")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "10")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "11")]
		public virtual void PostFixedUpdate()
		{
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x592690", Offset = "0x591090", VA = "0x180592690", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x5928E0", Offset = "0x5912E0", VA = "0x1805928E0", Slot = "13")]
		protected virtual void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x592940", Offset = "0x591340", VA = "0x180592940", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x5921D0", Offset = "0x590BD0", VA = "0x1805921D0", Slot = "7")]
		public override void EndClick()
		{
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x5929E0", Offset = "0x5913E0", VA = "0x1805929E0")]
		public Draggable()
		{
		}

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		[FieldOffset(Offset = "0x50")]
		[Header("Drag Force")]
		public float DragForceMultiplier;

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x40011AF")]
		[FieldOffset(Offset = "0x58")]
		public Transform DragForceOrigin;

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x60")]
		[Header("Rotation")]
		public bool RotationEnabled;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x64")]
		public float TorqueMultiplier;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		public Draggable.EDragProjectionMode DragProjectionMode;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0x6C")]
		public bool DisableGravityWhenDragged;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x70")]
		public float NormalRBDrag;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x74")]
		public float HeldRBDrag;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		[FieldOffset(Offset = "0x78")]
		public bool CanBeMultiDragged;

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x40011B9")]
		[FieldOffset(Offset = "0x8C")]
		[Header("Additional force")]
		public float idleUpForce;

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public bool LocationRestrictionEnabled;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0x94")]
		[HideInInspector]
		public Vector3 Origin;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x40011BC")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public float MaxDistanceFromOrigin;

		// Token: 0x040011BD RID: 4541
		[Token(Token = "0x40011BD")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent<Collider> onTriggerExit;

		// Token: 0x040011BE RID: 4542
		[Token(Token = "0x40011BE")]
		[FieldOffset(Offset = "0xB0")]
		protected DraggableConstraint constraint;

		// Token: 0x0200034C RID: 844
		[Token(Token = "0x200034C")]
		public enum EDragProjectionMode
		{
			// Token: 0x040011C0 RID: 4544
			[Token(Token = "0x40011C0")]
			CameraForward,
			// Token: 0x040011C1 RID: 4545
			[Token(Token = "0x40011C1")]
			FlatCameraForward
		}
	}
}
