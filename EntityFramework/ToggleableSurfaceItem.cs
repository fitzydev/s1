using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x020005B1 RID: 1457
	[Token(Token = "0x20005B1")]
	public class ToggleableSurfaceItem : SurfaceItem
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0000AC50 File Offset: 0x00008E50
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B9")]
		public bool IsOn
		{
			[Token(Token = "0x60021B7")]
			[Address(RVA = "0x69EE20", Offset = "0x69D820", VA = "0x18069EE20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021B8")]
			[Address(RVA = "0x69EE30", Offset = "0x69D830", VA = "0x18069EE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x69DE80", Offset = "0x69C880", VA = "0x18069DE80", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x69E210", Offset = "0x69CC10", VA = "0x18069E210", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x69ECD0", Offset = "0x69D6D0", VA = "0x18069ECD0")]
		public void Toggle()
		{
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x69EDA0", Offset = "0x69D7A0", VA = "0x18069EDA0")]
		public void TurnOn(bool network = true)
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x69ED20", Offset = "0x69D720", VA = "0x18069ED20")]
		public void TurnOff(bool network = true)
		{
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x69E8E0", Offset = "0x69D2E0", VA = "0x18069E8E0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x69EA20", Offset = "0x69D420", VA = "0x18069EA20")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetIsOn(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x69DF40", Offset = "0x69C940", VA = "0x18069DF40", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x69EE10", Offset = "0x69D810", VA = "0x18069EE10")]
		public ToggleableSurfaceItem()
		{
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x69E0E0", Offset = "0x69CAE0", VA = "0x18069E0E0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x69E0B0", Offset = "0x69CAB0", VA = "0x18069E0B0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C4")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x69E650", Offset = "0x69D050", VA = "0x18069E650")]
		private void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x69E250", Offset = "0x69CC50", VA = "0x18069E250")]
		private void RpcLogic___SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x69E3B0", Offset = "0x69CDB0", VA = "0x18069E3B0")]
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x69E510", Offset = "0x69CF10", VA = "0x18069E510")]
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x69E270", Offset = "0x69CC70", VA = "0x18069E270")]
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x69E2E0", Offset = "0x69CCE0", VA = "0x18069E2E0")]
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x69E780", Offset = "0x69D180", VA = "0x18069E780")]
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x69E440", Offset = "0x69CE40", VA = "0x18069E440")]
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x69DDD0", Offset = "0x69C7D0", VA = "0x18069DDD0", Slot = "70")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableSurfaceItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		[FieldOffset(Offset = "0x20C")]
		[Header("Settings")]
		public ToggleableSurfaceItem.EStartupAction StartupAction;

		// Token: 0x04001B22 RID: 6946
		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x210")]
		public UnityEvent onTurnedOn;

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x218")]
		public UnityEvent onTurnedOff;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x220")]
		public UnityEvent onTurnOnOrOff;

		// Token: 0x04001B25 RID: 6949
		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x228")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B26 RID: 6950
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x229")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x020005B2 RID: 1458
		[Token(Token = "0x20005B2")]
		public enum EStartupAction
		{
			// Token: 0x04001B28 RID: 6952
			[Token(Token = "0x4001B28")]
			None,
			// Token: 0x04001B29 RID: 6953
			[Token(Token = "0x4001B29")]
			TurnOn,
			// Token: 0x04001B2A RID: 6954
			[Token(Token = "0x4001B2A")]
			TurnOff,
			// Token: 0x04001B2B RID: 6955
			[Token(Token = "0x4001B2B")]
			Toggle
		}
	}
}
