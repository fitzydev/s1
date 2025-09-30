using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Building;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	public class SurfaceItem : BuildableItem
	{
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B2")]
		public Surface ParentSurface
		{
			[Token(Token = "0x6002177")]
			[Address(RVA = "0x69CBD0", Offset = "0x69B5D0", VA = "0x18069CBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002178")]
			[Address(RVA = "0x69CBF0", Offset = "0x69B5F0", VA = "0x18069CBF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x170005B3")]
		public float RotationIncrement
		{
			[Token(Token = "0x6002179")]
			[Address(RVA = "0x69CBE0", Offset = "0x69B5E0", VA = "0x18069CBE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217A")]
		[Address(RVA = "0x69AEC0", Offset = "0x6998C0", VA = "0x18069AEC0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217B")]
		[Address(RVA = "0x69B4E0", Offset = "0x699EE0", VA = "0x18069B4E0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217C")]
		[Address(RVA = "0x69C360", Offset = "0x69AD60", VA = "0x18069C360", Slot = "51")]
		protected override void SendInitToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217D")]
		[Address(RVA = "0x69C440", Offset = "0x69AE40", VA = "0x18069C440")]
		[ServerRpc(RequireOwnership = false)]
		public void SendSurfaceItemData(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217E")]
		[Address(RVA = "0x69B230", Offset = "0x699C30", VA = "0x18069B230", Slot = "65")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void InitializeSurfaceItem(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217F")]
		[Address(RVA = "0x69B070", Offset = "0x699A70", VA = "0x18069B070", Slot = "66")]
		public virtual void InitializeSurfaceItem(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002180")]
		[Address(RVA = "0x69C4A0", Offset = "0x69AEA0", VA = "0x18069C4A0", Slot = "67")]
		protected virtual void SetTransformData(string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002181")]
		[Address(RVA = "0x69B060", Offset = "0x699A60", VA = "0x18069B060", Slot = "49")]
		protected override Property GetProperty([Optional] Transform searchTransform)
		{
			return null;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002182")]
		[Address(RVA = "0x69AF10", Offset = "0x699910", VA = "0x18069AF10", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002183")]
		[Address(RVA = "0x69CA00", Offset = "0x69B400", VA = "0x18069CA00")]
		public SurfaceItem()
		{
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002184")]
		[Address(RVA = "0x69C920", Offset = "0x69B320", VA = "0x18069C920")]
		[CompilerGenerated]
		private IEnumerator <OnStartClient>g__WaitForDataSend|12_0()
		{
			return null;
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002186")]
		[Address(RVA = "0x69C990", Offset = "0x69B390", VA = "0x18069C990")]
		[CompilerGenerated]
		private IEnumerator <SetTransformData>g__Routine|17_0()
		{
			return null;
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x69B3B0", Offset = "0x699DB0", VA = "0x18069B3B0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x69B390", Offset = "0x699D90", VA = "0x18069B390", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x69BD90", Offset = "0x69A790", VA = "0x18069BD90")]
		private void RpcWriter___Server_SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218C")]
		[Address(RVA = "0x69B5F0", Offset = "0x699FF0", VA = "0x18069B5F0")]
		public void RpcLogic___SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218D")]
		[Address(RVA = "0x69B7D0", Offset = "0x69A1D0", VA = "0x18069B7D0")]
		private void RpcReader___Server_SendSurfaceItemData_2652836379(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218E")]
		[Address(RVA = "0x69C060", Offset = "0x69AA60", VA = "0x18069C060")]
		private void RpcWriter___Target_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218F")]
		[Address(RVA = "0x69B570", Offset = "0x699F70", VA = "0x18069B570", Slot = "68")]
		public virtual void RpcLogic___InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002190")]
		[Address(RVA = "0x69B930", Offset = "0x69A330", VA = "0x18069B930")]
		private void RpcReader___Target_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002191")]
		[Address(RVA = "0x69BA90", Offset = "0x69A490", VA = "0x18069BA90")]
		private void RpcWriter___Observers_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002192")]
		[Address(RVA = "0x69B660", Offset = "0x69A060", VA = "0x18069B660")]
		private void RpcReader___Observers_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002193")]
		[Address(RVA = "0x69AEB0", Offset = "0x6998B0", VA = "0x18069AEB0", Slot = "69")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.SurfaceItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001B07 RID: 6919
		[Token(Token = "0x4001B07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[Header("Settings")]
		public List<Surface.ESurfaceType> ValidSurfaceTypes;

		// Token: 0x04001B08 RID: 6920
		[Token(Token = "0x4001B08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool AllowRotation;

		// Token: 0x04001B0A RID: 6922
		[Token(Token = "0x4001B0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected Vector3 RelativePosition;

		// Token: 0x04001B0B RID: 6923
		[Token(Token = "0x4001B0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		protected Quaternion RelativeRotation;

		// Token: 0x04001B0C RID: 6924
		[Token(Token = "0x4001B0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B0D RID: 6925
		[Token(Token = "0x4001B0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x205")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted;
	}
}
