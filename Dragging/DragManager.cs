using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Dragging
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	public class DragManager : NetworkSingleton<DragManager>
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063C")]
		public Draggable CurrentDraggable
		{
			[Token(Token = "0x60025CE")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025CF")]
			[Address(RVA = "0x6FBE90", Offset = "0x6FA890", VA = "0x1806FBE90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x1700063D")]
		public bool IsDragging
		{
			[Token(Token = "0x60025D0")]
			[Address(RVA = "0x6FBE30", Offset = "0x6FA830", VA = "0x1806FBE30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x6F8D00", Offset = "0x6F7700", VA = "0x1806F8D00", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x6FB470", Offset = "0x6F9E70", VA = "0x1806FB470")]
		public void Update()
		{
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x6F8310", Offset = "0x6F6D10", VA = "0x1806F8310")]
		public void FixedUpdate()
		{
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x6F88F0", Offset = "0x6F72F0", VA = "0x1806F88F0")]
		public bool IsDraggingAllowed()
		{
			return default(bool);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x6F90D0", Offset = "0x6F7AD0", VA = "0x1806F90D0")]
		public void RegisterDraggable(Draggable draggable)
		{
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x6F8280", Offset = "0x6F6C80", VA = "0x1806F8280")]
		public void Deregister(Draggable draggable)
		{
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x6FAF60", Offset = "0x6F9960", VA = "0x1806FAF60")]
		public void StartDragging(Draggable draggable)
		{
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x6FA820", Offset = "0x6F9220", VA = "0x1806FA820")]
		[ServerRpc(RequireOwnership = false)]
		private void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x6F92B0", Offset = "0x6F7CB0", VA = "0x1806F92B0")]
		[ObserversRpc]
		private void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x6FB160", Offset = "0x6F9B60", VA = "0x1806FB160")]
		public void StopDragging(Vector3 velocity)
		{
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x6FACE0", Offset = "0x6F96E0", VA = "0x1806FACE0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x6FAE10", Offset = "0x6F9810", VA = "0x1806FAE10")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x6F8750", Offset = "0x6F7150", VA = "0x1806F8750")]
		private Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x6FBD60", Offset = "0x6FA760", VA = "0x1806FBD60")]
		public DragManager()
		{
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x6F8B40", Offset = "0x6F7540", VA = "0x1806F8B40", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x6F8AF0", Offset = "0x6F74F0", VA = "0x1806F8AF0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x6FA820", Offset = "0x6F9220", VA = "0x1806FA820")]
		private void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x6F92B0", Offset = "0x6F7CB0", VA = "0x1806F92B0")]
		private void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x6F9E40", Offset = "0x6F8840", VA = "0x1806F9E40")]
		private void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x6F92B0", Offset = "0x6F7CB0", VA = "0x1806F92B0")]
		private void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x6F96A0", Offset = "0x6F80A0", VA = "0x1806F96A0")]
		private void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x6F9B00", Offset = "0x6F8500", VA = "0x1806F9B00")]
		private void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x6FA540", Offset = "0x6F8F40", VA = "0x1806FA540")]
		private void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E9")]
		[Address(RVA = "0x6F91B0", Offset = "0x6F7BB0", VA = "0x1806F91B0")]
		private void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x6F9C20", Offset = "0x6F8620", VA = "0x1806F9C20")]
		private void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x6FA220", Offset = "0x6F8C20", VA = "0x1806FA220")]
		private void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x6F9460", Offset = "0x6F7E60", VA = "0x1806F9460")]
		private void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x6F9930", Offset = "0x6F8330", VA = "0x1806F9930")]
		private void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x6FA9C0", Offset = "0x6F93C0", VA = "0x1806FA9C0")]
		private void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x6FA050", Offset = "0x6F8A50", VA = "0x1806FA050")]
		private void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x6F8210", Offset = "0x6F6C10", VA = "0x1806F8210", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04001D2B RID: 7467
		[Token(Token = "0x4001D2B")]
		public const float DRAGGABLE_OFFSET = 1.25f;

		// Token: 0x04001D2C RID: 7468
		[Token(Token = "0x4001D2C")]
		[FieldOffset(Offset = "0x120")]
		public AudioSourceController ThrowSound;

		// Token: 0x04001D2D RID: 7469
		[Token(Token = "0x4001D2D")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public float DragForce;

		// Token: 0x04001D2E RID: 7470
		[Token(Token = "0x4001D2E")]
		[FieldOffset(Offset = "0x12C")]
		public float DampingFactor;

		// Token: 0x04001D2F RID: 7471
		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x130")]
		public float TorqueForce;

		// Token: 0x04001D30 RID: 7472
		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x134")]
		public float TorqueDampingFactor;

		// Token: 0x04001D31 RID: 7473
		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x138")]
		public float ThrowForce;

		// Token: 0x04001D32 RID: 7474
		[Token(Token = "0x4001D32")]
		[FieldOffset(Offset = "0x13C")]
		public float MassInfluence;

		// Token: 0x04001D34 RID: 7476
		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x148")]
		private List<Draggable> AllDraggables;

		// Token: 0x04001D35 RID: 7477
		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x150")]
		private Draggable lastThrownDraggable;

		// Token: 0x04001D36 RID: 7478
		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x158")]
		private Draggable lastHeldDraggable;

		// Token: 0x04001D37 RID: 7479
		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x160")]
		private bool NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001D38 RID: 7480
		[Token(Token = "0x4001D38")]
		[FieldOffset(Offset = "0x161")]
		private bool NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted;
	}
}
