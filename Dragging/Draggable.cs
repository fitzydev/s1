using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dragging
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(InteractableObject))]
	public class Draggable : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x17000638")]
		public bool IsBeingDragged
		{
			[Token(Token = "0x60025B9")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060025BB RID: 9659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000639")]
		public Player CurrentDragger
		{
			[Token(Token = "0x60025BA")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025BB")]
			[Address(RVA = "0x6FD100", Offset = "0x6FBB00", VA = "0x1806FD100")]
			protected set
			{
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x0000BB08 File Offset: 0x00009D08
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063A")]
		public Guid GUID
		{
			[Token(Token = "0x60025BC")]
			[Address(RVA = "0x6FD0D0", Offset = "0x6FBAD0", VA = "0x1806FD0D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60025BD")]
			[Address(RVA = "0x6FD170", Offset = "0x6FBB70", VA = "0x1806FD170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x6FCBF0", Offset = "0x6FB5F0", VA = "0x1806FCBF0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x0000BB20 File Offset: 0x00009D20
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063B")]
		public Vector3 initialPosition
		{
			[Token(Token = "0x60025BF")]
			[Address(RVA = "0x6FD0E0", Offset = "0x6FBAE0", VA = "0x1806FD0E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60025C0")]
			[Address(RVA = "0x6FD180", Offset = "0x6FBB80", VA = "0x1806FD180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x6FC4A0", Offset = "0x6FAEA0", VA = "0x1806FC4A0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C2")]
		[Address(RVA = "0x6FCD00", Offset = "0x6FB700", VA = "0x1806FCD00", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x6FCC40", Offset = "0x6FB640", VA = "0x1806FCC40", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x6FCB10", Offset = "0x6FB510", VA = "0x1806FCB10")]
		protected void OnValidate()
		{
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x6FC950", Offset = "0x6FB350", VA = "0x1806FC950")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x6FCEB0", Offset = "0x6FB8B0", VA = "0x1806FCEB0")]
		public void UpdateDraggable(float fixedDeltaTime)
		{
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x6FBEB0", Offset = "0x6FA8B0", VA = "0x1806FBEB0")]
		public void ApplyDragForces(Vector3 targetPosition)
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x6FC810", Offset = "0x6FB210", VA = "0x1806FC810", Slot = "9")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x6FC8C0", Offset = "0x6FB2C0", VA = "0x1806FC8C0", Slot = "10")]
		protected virtual void Interacted()
		{
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x6FC730", Offset = "0x6FB130", VA = "0x1806FC730")]
		private bool CanInteract()
		{
			return default(bool);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x6FCCB0", Offset = "0x6FB6B0", VA = "0x1806FCCB0")]
		public void StartDragging(Player dragger)
		{
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x6FCE50", Offset = "0x6FB850", VA = "0x1806FCE50")]
		public void StopDragging()
		{
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x6FD060", Offset = "0x6FBA60", VA = "0x1806FD060")]
		public Draggable()
		{
		}

		// Token: 0x04001D13 RID: 7443
		[Token(Token = "0x4001D13")]
		public const float INITIAL_REPLICATION_DISTANCE = 1f;

		// Token: 0x04001D14 RID: 7444
		[Token(Token = "0x4001D14")]
		public const float MAX_DRAG_START_RANGE = 2.5f;

		// Token: 0x04001D15 RID: 7445
		[Token(Token = "0x4001D15")]
		public const float MAX_TARGET_OFFSET = 1.5f;

		// Token: 0x04001D16 RID: 7446
		[Token(Token = "0x4001D16")]
		[FieldOffset(Offset = "0x20")]
		private bool isBeingDragged;

		// Token: 0x04001D17 RID: 7447
		[Token(Token = "0x4001D17")]
		[FieldOffset(Offset = "0x28")]
		private Player currentDragger;

		// Token: 0x04001D19 RID: 7449
		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04001D1A RID: 7450
		[Token(Token = "0x4001D1A")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Rigidbody Rigidbody;

		// Token: 0x04001D1B RID: 7451
		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x50")]
		public InteractableObject IntObj;

		// Token: 0x04001D1C RID: 7452
		[Token(Token = "0x4001D1C")]
		[FieldOffset(Offset = "0x58")]
		public Transform DragOrigin;

		// Token: 0x04001D1D RID: 7453
		[Token(Token = "0x4001D1D")]
		[FieldOffset(Offset = "0x60")]
		[Header("Settings")]
		public bool CreateCoM;

		// Token: 0x04001D1E RID: 7454
		[Token(Token = "0x4001D1E")]
		[FieldOffset(Offset = "0x64")]
		[Range(0.5f, 2f)]
		public float HoldDistanceMultiplier;

		// Token: 0x04001D1F RID: 7455
		[Token(Token = "0x4001D1F")]
		[FieldOffset(Offset = "0x68")]
		[Range(0f, 5f)]
		public float DragForceMultiplier;

		// Token: 0x04001D20 RID: 7456
		[Token(Token = "0x4001D20")]
		[FieldOffset(Offset = "0x6C")]
		public Draggable.EInitialReplicationMode InitialReplicationMode;

		// Token: 0x04001D21 RID: 7457
		[Token(Token = "0x4001D21")]
		[FieldOffset(Offset = "0x70")]
		private float timeSinceLastDrag;

		// Token: 0x04001D22 RID: 7458
		[Token(Token = "0x4001D22")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onDragStart;

		// Token: 0x04001D23 RID: 7459
		[Token(Token = "0x4001D23")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onDragEnd;

		// Token: 0x04001D24 RID: 7460
		[Token(Token = "0x4001D24")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onHovered;

		// Token: 0x04001D25 RID: 7461
		[Token(Token = "0x4001D25")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent onInteracted;

		// Token: 0x020005FD RID: 1533
		[Token(Token = "0x20005FD")]
		public enum EInitialReplicationMode
		{
			// Token: 0x04001D28 RID: 7464
			[Token(Token = "0x4001D28")]
			Off,
			// Token: 0x04001D29 RID: 7465
			[Token(Token = "0x4001D29")]
			OnlyIfMoved,
			// Token: 0x04001D2A RID: 7466
			[Token(Token = "0x4001D2A")]
			Full
		}
	}
}
