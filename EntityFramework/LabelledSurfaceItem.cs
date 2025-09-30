using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using TMPro;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x020005A6 RID: 1446
	[Token(Token = "0x20005A6")]
	public class LabelledSurfaceItem : SurfaceItem
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A9")]
		public string Message
		{
			[Token(Token = "0x600212A")]
			[Address(RVA = "0x62FFB0", Offset = "0x62E9B0", VA = "0x18062FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x6984C0", Offset = "0x696EC0", VA = "0x1806984C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x697B90", Offset = "0x696590", VA = "0x180697B90", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x697900", Offset = "0x696300", VA = "0x180697900")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageToServer(string message)
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x6981D0", Offset = "0x696BD0", VA = "0x1806981D0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetMessage(NetworkConnection conn, string message)
		{
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212F")]
		[Address(RVA = "0x6977F0", Offset = "0x6961F0", VA = "0x1806977F0")]
		public void Interacted()
		{
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x697900", Offset = "0x696300", VA = "0x180697900")]
		private void MessageSubmitted(string message)
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x697680", Offset = "0x696080", VA = "0x180697680", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x698460", Offset = "0x696E60", VA = "0x180698460")]
		public LabelledSurfaceItem()
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x697A60", Offset = "0x696460", VA = "0x180697A60", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002134")]
		[Address(RVA = "0x697A30", Offset = "0x696430", VA = "0x180697A30", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002135")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002136")]
		[Address(RVA = "0x697F40", Offset = "0x696940", VA = "0x180697F40")]
		private void RpcWriter___Server_SendMessageToServer_3615296227(string message)
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002137")]
		[Address(RVA = "0x697BF0", Offset = "0x6965F0", VA = "0x180697BF0")]
		public void RpcLogic___SendMessageToServer_3615296227(string message)
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x697CF0", Offset = "0x6966F0", VA = "0x180697CF0")]
		private void RpcReader___Server_SendMessageToServer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002139")]
		[Address(RVA = "0x697E00", Offset = "0x696800", VA = "0x180697E00")]
		private void RpcWriter___Observers_SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x697C00", Offset = "0x696600", VA = "0x180697C00")]
		public void RpcLogic___SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x697C60", Offset = "0x696660", VA = "0x180697C60")]
		private void RpcReader___Observers_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x698070", Offset = "0x696A70", VA = "0x180698070")]
		private void RpcWriter___Target_SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x697D70", Offset = "0x696770", VA = "0x180697D70")]
		private void RpcReader___Target_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x697610", Offset = "0x696010", VA = "0x180697610", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04001AEF RID: 6895
		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x210")]
		public int MaxCharacters;

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public TextMeshPro Label;

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x220")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x221")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted;
	}
}
