using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Doors
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	public class DoorController : NetworkBehaviour
	{
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063E")]
		public bool IsOpen
		{
			[Token(Token = "0x60025F5")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025F6")]
			[Address(RVA = "0x6775B0", Offset = "0x675FB0", VA = "0x1806775B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		// (set) Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063F")]
		public bool openedByNPC
		{
			[Token(Token = "0x60025F7")]
			[Address(RVA = "0x6F7780", Offset = "0x6F6180", VA = "0x1806F7780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025F8")]
			[Address(RVA = "0x6F77D0", Offset = "0x6F61D0", VA = "0x1806F77D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		// (set) Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000640")]
		public float timeSinceNPCSensed
		{
			[Token(Token = "0x60025F9")]
			[Address(RVA = "0x6F77B0", Offset = "0x6F61B0", VA = "0x1806F77B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025FA")]
			[Address(RVA = "0x6F7800", Offset = "0x6F6200", VA = "0x1806F7800")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x0000BC10 File Offset: 0x00009E10
		// (set) Token: 0x060025FC RID: 9724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000641")]
		public bool playerDetectedSinceOpened
		{
			[Token(Token = "0x60025FB")]
			[Address(RVA = "0x6F7790", Offset = "0x6F6190", VA = "0x1806F7790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025FC")]
			[Address(RVA = "0x6F77E0", Offset = "0x6F61E0", VA = "0x1806F77E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x0000BC28 File Offset: 0x00009E28
		// (set) Token: 0x060025FE RID: 9726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000642")]
		public float timeSincePlayerSensed
		{
			[Token(Token = "0x60025FD")]
			[Address(RVA = "0x6F77C0", Offset = "0x6F61C0", VA = "0x1806F77C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025FE")]
			[Address(RVA = "0x6F7810", Offset = "0x6F6210", VA = "0x1806F7810")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x0000BC40 File Offset: 0x00009E40
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000643")]
		public float timeInCurrentState
		{
			[Token(Token = "0x60025FF")]
			[Address(RVA = "0x6F77A0", Offset = "0x6F61A0", VA = "0x1806F77A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002600")]
			[Address(RVA = "0x6F77F0", Offset = "0x6F61F0", VA = "0x1806F77F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002601")]
		[Address(RVA = "0x6F5F60", Offset = "0x6F4960", VA = "0x1806F5F60", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002602")]
		[Address(RVA = "0x6F7460", Offset = "0x6F5E60", VA = "0x1806F7460", Slot = "20")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002603")]
		[Address(RVA = "0x6F75F0", Offset = "0x6F5FF0", VA = "0x1806F75F0", Slot = "21")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002604")]
		[Address(RVA = "0x6F67E0", Offset = "0x6F51E0", VA = "0x1806F67E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002605")]
		[Address(RVA = "0x6F63E0", Offset = "0x6F4DE0", VA = "0x1806F63E0", Slot = "22")]
		public virtual void InteriorHandleHovered()
		{
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002606")]
		[Address(RVA = "0x6F6560", Offset = "0x6F4F60", VA = "0x1806F6560", Slot = "23")]
		public virtual void InteriorHandleInteracted()
		{
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002607")]
		[Address(RVA = "0x6F6180", Offset = "0x6F4B80", VA = "0x1806F6180", Slot = "24")]
		public virtual void ExteriorHandleHovered()
		{
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002608")]
		[Address(RVA = "0x6F6300", Offset = "0x6F4D00", VA = "0x1806F6300", Slot = "25")]
		public virtual void ExteriorHandleInteracted()
		{
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x6F6030", Offset = "0x6F4A30", VA = "0x1806F6030")]
		public bool CanPlayerAccess(EDoorSide side)
		{
			return default(bool);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x6F5FB0", Offset = "0x6F49B0", VA = "0x1806F5FB0", Slot = "26")]
		protected virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260B")]
		[Address(RVA = "0x6F6630", Offset = "0x6F5030", VA = "0x1806F6630", Slot = "27")]
		public virtual void NPCVicinityDetected(EDoorSide side)
		{
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260C")]
		[Address(RVA = "0x6F6830", Offset = "0x6F5230", VA = "0x1806F6830", Slot = "28")]
		public virtual void PlayerVicinityDetected(EDoorSide side)
		{
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x6F6F80", Offset = "0x6F5980", VA = "0x1806F6F80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x6F71C0", Offset = "0x6F5BC0", VA = "0x1806F71C0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x6F7100", Offset = "0x6F5B00", VA = "0x1806F7100", Slot = "29")]
		public virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x6F6060", Offset = "0x6F4A60", VA = "0x1806F6060", Slot = "30")]
		protected virtual void CheckAutoCloseForDistantPlayer()
		{
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x6F76F0", Offset = "0x6F60F0", VA = "0x1806F76F0")]
		public DoorController()
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x6F66C0", Offset = "0x6F50C0", VA = "0x1806F66C0", Slot = "31")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x6806E0", Offset = "0x67F0E0", VA = "0x1806806E0", Slot = "32")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x5C22C0", Offset = "0x5C0CC0", VA = "0x1805C22C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x6F6CC0", Offset = "0x6F56C0", VA = "0x1806F6CC0")]
		private void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x6F68E0", Offset = "0x6F52E0", VA = "0x1806F68E0")]
		public void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x6F69B0", Offset = "0x6F53B0", VA = "0x1806F69B0")]
		private void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x6F6B50", Offset = "0x6F5550", VA = "0x1806F6B50")]
		private void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x6F68C0", Offset = "0x6F52C0", VA = "0x1806F68C0")]
		public void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x6F6910", Offset = "0x6F5310", VA = "0x1806F6910")]
		private void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x6F6E20", Offset = "0x6F5820", VA = "0x1806F6E20")]
		private void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x6F6AB0", Offset = "0x6F54B0", VA = "0x1806F6AB0")]
		private void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x6F5C30", Offset = "0x6F4630", VA = "0x1806F5C30", Slot = "33")]
		protected virtual void Awake_UserLogic_ScheduleOne.Doors.DoorController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001D42 RID: 7490
		[Token(Token = "0x4001D42")]
		public const float DISTANT_PLAYER_THRESHOLD = 40f;

		// Token: 0x04001D44 RID: 7492
		[Token(Token = "0x4001D44")]
		[FieldOffset(Offset = "0x11C")]
		public EDoorAccess PlayerAccess;

		// Token: 0x04001D45 RID: 7493
		[Token(Token = "0x4001D45")]
		[FieldOffset(Offset = "0x120")]
		public bool AutoOpenForPlayer;

		// Token: 0x04001D46 RID: 7494
		[Token(Token = "0x4001D46")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Header("References")]
		protected InteractableObject[] InteriorIntObjs;

		// Token: 0x04001D47 RID: 7495
		[Token(Token = "0x4001D47")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected InteractableObject[] ExteriorIntObjs;

		// Token: 0x04001D48 RID: 7496
		[Token(Token = "0x4001D48")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Tooltip("Used to block player from entering when the door is open for an NPC, but player isn't permitted access.")]
		protected BoxCollider PlayerBlocker;

		// Token: 0x04001D49 RID: 7497
		[Token(Token = "0x4001D49")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Header("Animation")]
		protected Animation InteriorDoorHandleAnimation;

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected Animation ExteriorDoorHandleAnimation;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x150")]
		[Header("Settings")]
		[SerializeField]
		protected bool AutoCloseOnSleep;

		// Token: 0x04001D4C RID: 7500
		[Token(Token = "0x4001D4C")]
		[FieldOffset(Offset = "0x151")]
		[SerializeField]
		protected bool AutoCloseOnDistantPlayer;

		// Token: 0x04001D4D RID: 7501
		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x152")]
		[Header("NPC Access")]
		[SerializeField]
		protected bool OpenableByNPCs;

		// Token: 0x04001D4E RID: 7502
		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x154")]
		[Tooltip("How many seconds to wait after NPC passes through to return to original state")]
		[SerializeField]
		protected float ReturnToOriginalTime;

		// Token: 0x04001D4F RID: 7503
		[Token(Token = "0x4001D4F")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent<EDoorSide> onDoorOpened;

		// Token: 0x04001D50 RID: 7504
		[Token(Token = "0x4001D50")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent onDoorClosed;

		// Token: 0x04001D51 RID: 7505
		[Token(Token = "0x4001D51")]
		[FieldOffset(Offset = "0x168")]
		private EDoorSide lastOpenSide;

		// Token: 0x04001D54 RID: 7508
		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x174")]
		private bool autoOpenedForPlayer;

		// Token: 0x04001D58 RID: 7512
		[Token(Token = "0x4001D58")]
		[FieldOffset(Offset = "0x180")]
		[HideInInspector]
		public string noAccessErrorMessage;

		// Token: 0x04001D59 RID: 7513
		[Token(Token = "0x4001D59")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001D5A RID: 7514
		[Token(Token = "0x4001D5A")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted;
	}
}
