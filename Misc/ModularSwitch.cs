using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Misc
{
	// Token: 0x02000CE0 RID: 3296
	[Token(Token = "0x2000CE0")]
	public class ModularSwitch : NetworkBehaviour
	{
		// Token: 0x06005D60 RID: 23904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D60")]
		[Address(RVA = "0xA5F630", Offset = "0xA5E030", VA = "0x180A5F630", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D61")]
		[Address(RVA = "0xA5F8B0", Offset = "0xA5E2B0", VA = "0x180A5F8B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D62")]
		[Address(RVA = "0xA5F730", Offset = "0xA5E130", VA = "0x180A5F730", Slot = "20")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D63")]
		[Address(RVA = "0xA5F680", Offset = "0xA5E080", VA = "0x180A5F680")]
		public void Hovered()
		{
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D64")]
		[Address(RVA = "0xA5F710", Offset = "0xA5E110", VA = "0x180A5F710")]
		public void Interacted()
		{
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D65")]
		[Address(RVA = "0xA5FE80", Offset = "0xA5E880", VA = "0x180A5FE80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool isOn)
		{
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D66")]
		[Address(RVA = "0xA5FFB0", Offset = "0xA5E9B0", VA = "0x180A5FFB0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetIsOn(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D67")]
		[Address(RVA = "0xA60330", Offset = "0xA5ED30", VA = "0x180A60330")]
		public void SwitchOn()
		{
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D68")]
		[Address(RVA = "0xA60220", Offset = "0xA5EC20", VA = "0x180A60220")]
		public void SwitchOff()
		{
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D69")]
		[Address(RVA = "0xA60440", Offset = "0xA5EE40", VA = "0x180A60440")]
		public ModularSwitch()
		{
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0xA5F790", Offset = "0xA5E190", VA = "0x180A5F790", Slot = "21")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0x5ACFE0", Offset = "0x5AB9E0", VA = "0x1805ACFE0", Slot = "22")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0x5AB8F0", Offset = "0x5AA2F0", VA = "0x1805AB8F0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0xA5FBF0", Offset = "0xA5E5F0", VA = "0x180A5FBF0")]
		private void RpcWriter___Server_SendIsOn_1140765316(bool isOn)
		{
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6E")]
		[Address(RVA = "0xA5F8F0", Offset = "0xA5E2F0", VA = "0x180A5F8F0")]
		private void RpcLogic___SendIsOn_1140765316(bool isOn)
		{
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0xA5F9A0", Offset = "0xA5E3A0", VA = "0x180A5F9A0")]
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D70")]
		[Address(RVA = "0xA5FAB0", Offset = "0xA5E4B0", VA = "0x180A5FAB0")]
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D71")]
		[Address(RVA = "0xA5F900", Offset = "0xA5E300", VA = "0x180A5F900")]
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0xA5F920", Offset = "0xA5E320", VA = "0x180A5F920")]
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D73")]
		[Address(RVA = "0xA5FD20", Offset = "0xA5E720", VA = "0x180A5FD20")]
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D74")]
		[Address(RVA = "0xA5FA30", Offset = "0xA5E430", VA = "0x180A5FA30")]
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D75")]
		[Address(RVA = "0xA5F3D0", Offset = "0xA5DDD0", VA = "0x180A5F3D0", Slot = "23")]
		protected virtual void Awake_UserLogic_ScheduleOne.Misc.ModularSwitch_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040043C4 RID: 17348
		[Token(Token = "0x40043C4")]
		[FieldOffset(Offset = "0x118")]
		public bool isOn;

		// Token: 0x040043C5 RID: 17349
		[Token(Token = "0x40043C5")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x040043C6 RID: 17350
		[Token(Token = "0x40043C6")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Transform button;

		// Token: 0x040043C7 RID: 17351
		[Token(Token = "0x40043C7")]
		[FieldOffset(Offset = "0x130")]
		public AudioSourceController OnAudio;

		// Token: 0x040043C8 RID: 17352
		[Token(Token = "0x40043C8")]
		[FieldOffset(Offset = "0x138")]
		public AudioSourceController OffAudio;

		// Token: 0x040043C9 RID: 17353
		[Token(Token = "0x40043C9")]
		[FieldOffset(Offset = "0x140")]
		public ToggleableLight[] LightsToControl;

		// Token: 0x040043CA RID: 17354
		[Token(Token = "0x40043CA")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Header("Settings")]
		protected List<ModularSwitch> SwitchesToSyncWith;

		// Token: 0x040043CB RID: 17355
		[Token(Token = "0x40043CB")]
		[FieldOffset(Offset = "0x150")]
		public ModularSwitch.ButtonChange onToggled;

		// Token: 0x040043CC RID: 17356
		[Token(Token = "0x40043CC")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent switchedOn;

		// Token: 0x040043CD RID: 17357
		[Token(Token = "0x40043CD")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent switchedOff;

		// Token: 0x040043CE RID: 17358
		[Token(Token = "0x40043CE")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted;

		// Token: 0x040043CF RID: 17359
		[Token(Token = "0x40043CF")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted;

		// Token: 0x02000CE1 RID: 3297
		// (Invoke) Token: 0x06005D77 RID: 23927
		[Token(Token = "0x2000CE1")]
		public delegate void ButtonChange(bool isOn);
	}
}
