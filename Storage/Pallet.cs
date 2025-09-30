using System;
using System.Collections.Generic;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Tiles;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x0200094B RID: 2379
	[Token(Token = "0x200094B")]
	public class Pallet : NetworkBehaviour, IStorageEntity
	{
		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x00011220 File Offset: 0x0000F420
		[Token(Token = "0x17000913")]
		public bool isEmpty
		{
			[Token(Token = "0x60040DD")]
			[Address(RVA = "0x8702C0", Offset = "0x86ECC0", VA = "0x1808702C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060040DE RID: 16606 RVA: 0x00011238 File Offset: 0x0000F438
		[Token(Token = "0x17000914")]
		protected bool carriedByForklift
		{
			[Token(Token = "0x60040DE")]
			[Address(RVA = "0x870270", Offset = "0x86EC70", VA = "0x180870270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060040DF RID: 16607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000915")]
		public Transform storedItemContainer
		{
			[Token(Token = "0x60040DF")]
			[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000916")]
		public Dictionary<StoredItem, Employee> reservedItems
		{
			[Token(Token = "0x60040E0")]
			[Address(RVA = "0x73CAF0", Offset = "0x73B4F0", VA = "0x18073CAF0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x86AD10", Offset = "0x869710", VA = "0x18086AD10", Slot = "32")]
		public virtual void Awake()
		{
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x86C9C0", Offset = "0x86B3C0", VA = "0x18086C9C0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x86FB80", Offset = "0x86E580", VA = "0x18086FB80", Slot = "33")]
		[ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(NetworkConnection conn)
		{
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E4")]
		[Address(RVA = "0x86C600", Offset = "0x86B000", VA = "0x18086C600", Slot = "13")]
		public override void OnOwnershipClient(NetworkConnection prevOwner)
		{
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x86C900", Offset = "0x86B300", VA = "0x18086C900", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x86F920", Offset = "0x86E320", VA = "0x18086F920")]
		private void SendItemsToClient(NetworkConnection connection)
		{
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x86B440", Offset = "0x869E40", VA = "0x18086B440", Slot = "34")]
		public virtual void DestroyPallet()
		{
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x86FFE0", Offset = "0x86E9E0", VA = "0x18086FFE0", Slot = "35")]
		protected virtual void Update()
		{
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x86B9B0", Offset = "0x86A3B0", VA = "0x18086B9B0", Slot = "36")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EA")]
		[Address(RVA = "0x86FB90", Offset = "0x86E590", VA = "0x18086FB90")]
		private void SetPosition(Vector3 position)
		{
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x86FE00", Offset = "0x86E800", VA = "0x18086FE00")]
		private void UpdateOwnership()
		{
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x86ADA0", Offset = "0x8697A0", VA = "0x18086ADA0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void BindToSlot_Server(Guid slotGuid)
		{
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040ED")]
		[Address(RVA = "0x86AF10", Offset = "0x869910", VA = "0x18086AF10")]
		[ObserversRpc]
		[TargetRpc]
		private void BindToSlot(NetworkConnection conn, Guid slotGuid)
		{
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x86B780", Offset = "0x86A180", VA = "0x18086B780")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ExitSlot_Server()
		{
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x86B890", Offset = "0x86A290", VA = "0x18086B890")]
		[ObserversRpc]
		private void ExitSlot()
		{
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x86FBE0", Offset = "0x86E5E0", VA = "0x18086FBE0")]
		public void TriggerStay(Collider other)
		{
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x86C1E0", Offset = "0x86ABE0", VA = "0x18086C1E0", Slot = "21")]
		public List<StoredItem> GetStoredItems()
		{
			return null;
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x86C0F0", Offset = "0x86AAF0", VA = "0x18086C0F0", Slot = "22")]
		public List<StorageGrid> GetStorageGrids()
		{
			return null;
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x86B310", Offset = "0x869D10", VA = "0x18086B310")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x86B170", Offset = "0x869B70", VA = "0x18086B170")]
		[ServerRpc(RequireOwnership = false)]
		private void CreateStoredItem_Server(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x86B5C0", Offset = "0x869FC0", VA = "0x18086B5C0")]
		[ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x86B450", Offset = "0x869E50", VA = "0x18086B450")]
		[ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F7")]
		[Address(RVA = "0x870150", Offset = "0x86EB50", VA = "0x180870150")]
		public Pallet()
		{
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F9")]
		[Address(RVA = "0x86C2C0", Offset = "0x86ACC0", VA = "0x18086C2C0", Slot = "37")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FA")]
		[Address(RVA = "0x7DFF00", Offset = "0x7DE900", VA = "0x1807DFF00", Slot = "38")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FB")]
		[Address(RVA = "0x86C280", Offset = "0x86AC80", VA = "0x18086C280", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FC")]
		[Address(RVA = "0x86F380", Offset = "0x86DD80", VA = "0x18086F380")]
		private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FD")]
		[Address(RVA = "0x86DEF0", Offset = "0x86C8F0", VA = "0x18086DEF0", Slot = "39")]
		protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0x86E870", Offset = "0x86D270", VA = "0x18086E870")]
		private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0x86EF60", Offset = "0x86D960", VA = "0x18086EF60")]
		private void RpcWriter___Server_BindToSlot_Server_1272046255(Guid slotGuid)
		{
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004100")]
		[Address(RVA = "0x86D210", Offset = "0x86BC10", VA = "0x18086D210")]
		public void RpcLogic___BindToSlot_Server_1272046255(Guid slotGuid)
		{
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004101")]
		[Address(RVA = "0x86E450", Offset = "0x86CE50", VA = "0x18086E450")]
		private void RpcReader___Server_BindToSlot_Server_1272046255(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004102")]
		[Address(RVA = "0x86EA80", Offset = "0x86D480", VA = "0x18086EA80")]
		private void RpcWriter___Observers_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004103")]
		[Address(RVA = "0x86CA60", Offset = "0x86B460", VA = "0x18086CA60")]
		private void RpcLogic___BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004104")]
		[Address(RVA = "0x86E190", Offset = "0x86CB90", VA = "0x18086E190")]
		private void RpcReader___Observers_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004105")]
		[Address(RVA = "0x86F5C0", Offset = "0x86DFC0", VA = "0x18086F5C0")]
		private void RpcWriter___Target_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x86E8C0", Offset = "0x86D2C0", VA = "0x18086E8C0")]
		private void RpcReader___Target_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004107")]
		[Address(RVA = "0x86F270", Offset = "0x86DC70", VA = "0x18086F270")]
		private void RpcWriter___Server_ExitSlot_Server_2166136261()
		{
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x86B890", Offset = "0x86A290", VA = "0x18086B890")]
		public void RpcLogic___ExitSlot_Server_2166136261()
		{
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x86E820", Offset = "0x86D220", VA = "0x18086E820")]
		private void RpcReader___Server_ExitSlot_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x86B890", Offset = "0x86A290", VA = "0x18086B890")]
		private void RpcWriter___Observers_ExitSlot_2166136261()
		{
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x86DC20", Offset = "0x86C620", VA = "0x18086DC20")]
		private void RpcLogic___ExitSlot_2166136261()
		{
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410C")]
		[Address(RVA = "0x86E420", Offset = "0x86CE20", VA = "0x18086E420")]
		private void RpcReader___Observers_ExitSlot_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410D")]
		[Address(RVA = "0x86EBF0", Offset = "0x86D5F0", VA = "0x18086EBF0")]
		private void RpcWriter___Observers_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410E")]
		[Address(RVA = "0x86D230", Offset = "0x86BC30", VA = "0x18086D230")]
		public void RpcLogic___CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410F")]
		[Address(RVA = "0x86E1F0", Offset = "0x86CBF0", VA = "0x18086E1F0")]
		private void RpcReader___Observers_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004110")]
		[Address(RVA = "0x86F750", Offset = "0x86E150", VA = "0x18086F750")]
		private void RpcWriter___Target_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004111")]
		[Address(RVA = "0x86E930", Offset = "0x86D330", VA = "0x18086E930")]
		private void RpcReader___Target_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004112")]
		[Address(RVA = "0x86F0C0", Offset = "0x86DAC0", VA = "0x18086F0C0")]
		private void RpcWriter___Server_CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004113")]
		[Address(RVA = "0x86D590", Offset = "0x86BF90", VA = "0x18086D590")]
		private void RpcLogic___CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004114")]
		[Address(RVA = "0x86E4D0", Offset = "0x86CED0", VA = "0x18086E4D0")]
		private void RpcReader___Server_CreateStoredItem_Server_1890711751(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004115")]
		[Address(RVA = "0x86EDD0", Offset = "0x86D7D0", VA = "0x18086EDD0")]
		private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004116")]
		[Address(RVA = "0x86D650", Offset = "0x86C050", VA = "0x18086D650")]
		public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x86E340", Offset = "0x86CD40", VA = "0x18086E340")]
		private void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004118")]
		[Address(RVA = "0x86B450", Offset = "0x869E50", VA = "0x18086B450")]
		private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004119")]
		[Address(RVA = "0x86DA70", Offset = "0x86C470", VA = "0x18086DA70")]
		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x86E620", Offset = "0x86D020", VA = "0x18086E620")]
		private void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x86ACA0", Offset = "0x8696A0", VA = "0x18086ACA0", Slot = "40")]
		protected virtual void Awake_UserLogic_ScheduleOne.Storage.Pallet_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x0")]
		public static List<Pallet> palletsOwnedByLocalPlayer;

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x8")]
		public static int sizeX;

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0xC")]
		public static int sizeY;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x118")]
		[Header("Reference")]
		public Transform _storedItemContainer;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x120")]
		public Rigidbody rb;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x128")]
		public StorageGrid storageGrid;

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x130")]
		public NetworkTransform networkTransform;

		// Token: 0x04002DC4 RID: 11716
		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x138")]
		protected List<Forklift> forkliftsInContact;

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x140")]
		public Guid currentSlotGUID;

		// Token: 0x04002DC6 RID: 11718
		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x150")]
		private PalletSlot currentSlot;

		// Token: 0x04002DC7 RID: 11719
		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x158")]
		private float timeSinceSlotCheck;

		// Token: 0x04002DC8 RID: 11720
		[Token(Token = "0x4002DC8")]
		[FieldOffset(Offset = "0x15C")]
		private float timeBoundToSlot;

		// Token: 0x04002DC9 RID: 11721
		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x160")]
		private float rb_Mass;

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x164")]
		private float rb_Drag;

		// Token: 0x04002DCB RID: 11723
		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x168")]
		private float rb_AngularDrag;

		// Token: 0x04002DCC RID: 11724
		[Token(Token = "0x4002DCC")]
		[FieldOffset(Offset = "0x170")]
		protected Dictionary<StoredItem, Employee> _reservedItems;

		// Token: 0x04002DCD RID: 11725
		[Token(Token = "0x4002DCD")]
		[FieldOffset(Offset = "0x178")]
		private List<string> completedJobs;

		// Token: 0x04002DCE RID: 11726
		[Token(Token = "0x4002DCE")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted;

		// Token: 0x04002DCF RID: 11727
		[Token(Token = "0x4002DCF")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted;
	}
}
