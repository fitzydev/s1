using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x020008CB RID: 2251
	[Token(Token = "0x20008CB")]
	public class TrashContainer : NetworkBehaviour
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E37 RID: 15927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008C9")]
		public TrashContent Content
		{
			[Token(Token = "0x6003E36")]
			[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E37")]
			[Address(RVA = "0x66F090", Offset = "0x66DA90", VA = "0x18066F090")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x00010B60 File Offset: 0x0000ED60
		[Token(Token = "0x170008CA")]
		public int TrashLevel
		{
			[Token(Token = "0x6003E38")]
			[Address(RVA = "0x852990", Offset = "0x851390", VA = "0x180852990")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x00010B78 File Offset: 0x0000ED78
		[Token(Token = "0x170008CB")]
		public float NormalizedTrashLevel
		{
			[Token(Token = "0x6003E39")]
			[Address(RVA = "0x852950", Offset = "0x851350", VA = "0x180852950")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3A")]
		[Address(RVA = "0x850AD0", Offset = "0x84F4D0", VA = "0x180850AD0", Slot = "19")]
		public virtual void AddTrash(TrashItem item)
		{
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3B")]
		[Address(RVA = "0x851900", Offset = "0x850300", VA = "0x180851900", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3C")]
		[Address(RVA = "0x852690", Offset = "0x851090", VA = "0x180852690")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendTrash(string trashID, int quantity)
		{
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3D")]
		[Address(RVA = "0x850D60", Offset = "0x84F760", VA = "0x180850D60")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void AddTrash(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3E")]
		[Address(RVA = "0x852580", Offset = "0x850F80", VA = "0x180852580")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendClear()
		{
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E3F")]
		[Address(RVA = "0x851490", Offset = "0x84FE90", VA = "0x180851490")]
		[ObserversRpc(RunLocally = true)]
		private void Clear()
		{
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E40")]
		[Address(RVA = "0x8515B0", Offset = "0x84FFB0", VA = "0x1808515B0")]
		[TargetRpc]
		private void LoadContent(NetworkConnection conn, TrashContentData data)
		{
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E41")]
		[Address(RVA = "0x852800", Offset = "0x851200", VA = "0x180852800")]
		public void TriggerEnter(Collider other)
		{
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00010B90 File Offset: 0x0000ED90
		[Token(Token = "0x6003E42")]
		[Address(RVA = "0x851460", Offset = "0x84FE60", VA = "0x180851460")]
		public bool CanBeBagged()
		{
			return default(bool);
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E43")]
		[Address(RVA = "0x851020", Offset = "0x84FA20", VA = "0x180851020")]
		public void BagTrash()
		{
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E44")]
		[Address(RVA = "0x8528D0", Offset = "0x8512D0", VA = "0x1808528D0")]
		public TrashContainer()
		{
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E45")]
		[Address(RVA = "0x851710", Offset = "0x850110", VA = "0x180851710", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E46")]
		[Address(RVA = "0x7C6FD0", Offset = "0x7C59D0", VA = "0x1807C6FD0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E47")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E48")]
		[Address(RVA = "0x8522A0", Offset = "0x850CA0", VA = "0x1808522A0")]
		private void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
		{
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E49")]
		[Address(RVA = "0x851C00", Offset = "0x850600", VA = "0x180851C00")]
		private void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x851D40", Offset = "0x850740", VA = "0x180851D40")]
		private void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E4B")]
		[Address(RVA = "0x851EF0", Offset = "0x8508F0", VA = "0x180851EF0")]
		private void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0x851A80", Offset = "0x850480", VA = "0x180851A80")]
		private void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0x851C20", Offset = "0x850620", VA = "0x180851C20")]
		private void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E4E")]
		[Address(RVA = "0x852410", Offset = "0x850E10", VA = "0x180852410")]
		private void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x851DE0", Offset = "0x8507E0", VA = "0x180851DE0")]
		private void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x852190", Offset = "0x850B90", VA = "0x180852190")]
		private void RpcWriter___Server_SendClear_2166136261()
		{
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x851490", Offset = "0x84FE90", VA = "0x180851490")]
		private void RpcLogic___SendClear_2166136261()
		{
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x851CF0", Offset = "0x8506F0", VA = "0x180851CF0")]
		private void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x852070", Offset = "0x850A70", VA = "0x180852070")]
		private void RpcWriter___Observers_Clear_2166136261()
		{
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x851B20", Offset = "0x850520", VA = "0x180851B20")]
		private void RpcLogic___Clear_2166136261()
		{
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x851CB0", Offset = "0x8506B0", VA = "0x180851CB0")]
		private void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x8515B0", Offset = "0x84FFB0", VA = "0x1808515B0")]
		private void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x851BB0", Offset = "0x8505B0", VA = "0x180851BB0")]
		private void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x851E70", Offset = "0x850870", VA = "0x180851E70")]
		private void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E59")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "22")]
		public virtual void Awake()
		{
		}

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		[Range(1f, 50f)]
		public int TrashCapacity;

		// Token: 0x04002BC2 RID: 11202
		[Token(Token = "0x4002BC2")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public Transform TrashBagDropLocation;

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		[FieldOffset(Offset = "0x130")]
		public UnityEvent<string> onTrashAdded;

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x138")]
		public UnityEvent onTrashLevelChanged;

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted;
	}
}
