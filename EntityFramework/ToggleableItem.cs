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
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	public class ToggleableItem : GridItem
	{
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x0000AC38 File Offset: 0x00008E38
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B8")]
		public bool IsOn
		{
			[Token(Token = "0x60021A0")]
			[Address(RVA = "0x69DDB0", Offset = "0x69C7B0", VA = "0x18069DDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021A1")]
			[Address(RVA = "0x69DDC0", Offset = "0x69C7C0", VA = "0x18069DDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x69CE00", Offset = "0x69B800", VA = "0x18069CE00", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A3")]
		[Address(RVA = "0x69D1B0", Offset = "0x69BBB0", VA = "0x18069D1B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x69DC70", Offset = "0x69C670", VA = "0x18069DC70")]
		public void Toggle()
		{
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x69DD40", Offset = "0x69C740", VA = "0x18069DD40")]
		public void TurnOn(bool network = true)
		{
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x69DCC0", Offset = "0x69C6C0", VA = "0x18069DCC0")]
		public void TurnOff(bool network = true)
		{
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x69D880", Offset = "0x69C280", VA = "0x18069D880")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool on)
		{
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x69D9C0", Offset = "0x69C3C0", VA = "0x18069D9C0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetIsOn(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x69CE50", Offset = "0x69B850", VA = "0x18069CE50", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x697210", Offset = "0x695C10", VA = "0x180697210")]
		public ToggleableItem()
		{
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x69CF80", Offset = "0x69B980", VA = "0x18069CF80", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x69CF50", Offset = "0x69B950", VA = "0x18069CF50", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x69D5F0", Offset = "0x69BFF0", VA = "0x18069D5F0")]
		private void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x69D1F0", Offset = "0x69BBF0", VA = "0x18069D1F0")]
		private void RpcLogic___SendIsOn_1140765316(bool on)
		{
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x69D350", Offset = "0x69BD50", VA = "0x18069D350")]
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x69D4B0", Offset = "0x69BEB0", VA = "0x18069D4B0")]
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x69D210", Offset = "0x69BC10", VA = "0x18069D210")]
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x69D280", Offset = "0x69BC80", VA = "0x18069D280")]
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720")]
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x69D3E0", Offset = "0x69BDE0", VA = "0x18069D3E0")]
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x69CC10", Offset = "0x69B610", VA = "0x18069CC10", Slot = "71")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.ToggleableItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001B15 RID: 6933
		[Token(Token = "0x4001B15")]
		[FieldOffset(Offset = "0x21C")]
		[Header("Settings")]
		public ToggleableItem.EStartupAction StartupAction;

		// Token: 0x04001B16 RID: 6934
		[Token(Token = "0x4001B16")]
		[FieldOffset(Offset = "0x220")]
		public UnityEvent onTurnedOn;

		// Token: 0x04001B17 RID: 6935
		[Token(Token = "0x4001B17")]
		[FieldOffset(Offset = "0x228")]
		public UnityEvent onTurnedOff;

		// Token: 0x04001B18 RID: 6936
		[Token(Token = "0x4001B18")]
		[FieldOffset(Offset = "0x230")]
		public UnityEvent onTurnOnOrOff;

		// Token: 0x04001B19 RID: 6937
		[Token(Token = "0x4001B19")]
		[FieldOffset(Offset = "0x238")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B1A RID: 6938
		[Token(Token = "0x4001B1A")]
		[FieldOffset(Offset = "0x239")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x020005B0 RID: 1456
		[Token(Token = "0x20005B0")]
		public enum EStartupAction
		{
			// Token: 0x04001B1C RID: 6940
			[Token(Token = "0x4001B1C")]
			None,
			// Token: 0x04001B1D RID: 6941
			[Token(Token = "0x4001B1D")]
			TurnOn,
			// Token: 0x04001B1E RID: 6942
			[Token(Token = "0x4001B1E")]
			TurnOff,
			// Token: 0x04001B1F RID: 6943
			[Token(Token = "0x4001B1F")]
			Toggle
		}
	}
}
