using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000582 RID: 1410
	[Token(Token = "0x2000582")]
	public class NetworkedInteractableToggleable : NetworkBehaviour
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0000A548 File Offset: 0x00008748
		// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000575")]
		public bool IsActivated
		{
			[Token(Token = "0x6001FA4")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FA5")]
			[Address(RVA = "0x6775B0", Offset = "0x675FB0", VA = "0x1806775B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x677390", Offset = "0x675D90", VA = "0x180677390")]
		public void Start()
		{
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x6769E0", Offset = "0x6753E0", VA = "0x1806769E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x676800", Offset = "0x675200", VA = "0x180676800")]
		public void Hovered()
		{
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x676890", Offset = "0x675290", VA = "0x180676890")]
		public void Interacted()
		{
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x677010", Offset = "0x675A10", VA = "0x180677010")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendToggle()
		{
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x677130", Offset = "0x675B30", VA = "0x180677130")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetState(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x676A20", Offset = "0x675420", VA = "0x180676A20")]
		public void PoliceDetected()
		{
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x677480", Offset = "0x675E80", VA = "0x180677480")]
		public NetworkedInteractableToggleable()
		{
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0x6768C0", Offset = "0x6752C0", VA = "0x1806768C0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0x6768A0", Offset = "0x6752A0", VA = "0x1806768A0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0x676DA0", Offset = "0x6757A0", VA = "0x180676DA0")]
		private void RpcWriter___Server_SendToggle_2166136261()
		{
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0x676A60", Offset = "0x675460", VA = "0x180676A60")]
		public void RpcLogic___SendToggle_2166136261()
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0x676B80", Offset = "0x675580", VA = "0x180676B80")]
		private void RpcReader___Server_SendToggle_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0x676C60", Offset = "0x675660", VA = "0x180676C60")]
		private void RpcWriter___Observers_SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0x676A80", Offset = "0x675480", VA = "0x180676A80")]
		public void RpcLogic___SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x676B00", Offset = "0x675500", VA = "0x180676B00")]
		private void RpcReader___Observers_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x676EB0", Offset = "0x6758B0", VA = "0x180676EB0")]
		private void RpcWriter___Target_SetState_214505783(NetworkConnection conn, bool activated)
		{
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x676BE0", Offset = "0x6755E0", VA = "0x180676BE0")]
		private void RpcReader___Target_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x120")]
		public string ActivateMessage;

		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x128")]
		public string DeactivateMessage;

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x130")]
		public float CoolDown;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onToggle;

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x148")]
		public UnityEvent onActivate;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent onDeactivate;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x158")]
		private float lastActivated;

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x15C")]
		private bool NetworkInitialize___EarlyScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted;

		// Token: 0x04001A05 RID: 6661
		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x15D")]
		private bool NetworkInitialize__LateScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted;
	}
}
