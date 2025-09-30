using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Storage
{
	// Token: 0x02000951 RID: 2385
	[Token(Token = "0x2000951")]
	public class StorageEntity : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x000112C8 File Offset: 0x0000F4C8
		[Token(Token = "0x1700091B")]
		public bool IsOpened
		{
			[Token(Token = "0x6004138")]
			[Address(RVA = "0x88C3A0", Offset = "0x88ADA0", VA = "0x18088C3A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091C")]
		public Player CurrentAccessor
		{
			[Token(Token = "0x6004139")]
			[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600413A")]
			[Address(RVA = "0x66F090", Offset = "0x66DA90", VA = "0x18066F090")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x000112E0 File Offset: 0x0000F4E0
		[Token(Token = "0x1700091D")]
		public int ItemCount
		{
			[Token(Token = "0x600413B")]
			[Address(RVA = "0x88C400", Offset = "0x88AE00", VA = "0x18088C400")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600413D RID: 16701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091E")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x600413C")]
			[Address(RVA = "0x71CA10", Offset = "0x71B410", VA = "0x18071CA10", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600413D")]
			[Address(RVA = "0x7A1A10", Offset = "0x7A0410", VA = "0x1807A1A10", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x886F10", Offset = "0x885910", VA = "0x180886F10", Slot = "28")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600413F")]
		[Address(RVA = "0x88C010", Offset = "0x88AA10", VA = "0x18088C010", Slot = "29")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004140")]
		[Address(RVA = "0x888580", Offset = "0x886F80", VA = "0x180888580", Slot = "30")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004141")]
		[Address(RVA = "0x887AE0", Offset = "0x8864E0", VA = "0x180887AE0")]
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004142")]
		[Address(RVA = "0x888860", Offset = "0x887260", VA = "0x180888860", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004143")]
		[Address(RVA = "0x887410", Offset = "0x885E10", VA = "0x180887410", Slot = "31")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004144")]
		[Address(RVA = "0x8877D0", Offset = "0x8861D0", VA = "0x1808877D0")]
		public Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			return null;
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[Token(Token = "0x6004145")]
		[Address(RVA = "0x8871B0", Offset = "0x885BB0", VA = "0x1808871B0")]
		public bool CanItemFit(ItemInstance item, int quantity = 1)
		{
			return default(bool);
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x00011310 File Offset: 0x0000F510
		[Token(Token = "0x6004146")]
		[Address(RVA = "0x887BE0", Offset = "0x8865E0", VA = "0x180887BE0")]
		public int HowManyCanFit(ItemInstance item)
		{
			return 0;
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004147")]
		[Address(RVA = "0x887DE0", Offset = "0x8867E0", VA = "0x180887DE0")]
		public void InsertItem(ItemInstance item, bool network = true)
		{
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004148")]
		[Address(RVA = "0x8873F0", Offset = "0x885DF0", VA = "0x1808873F0", Slot = "32")]
		protected virtual void ContentsChanged()
		{
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004149")]
		[Address(RVA = "0x8876B0", Offset = "0x8860B0", VA = "0x1808876B0")]
		public List<ItemInstance> GetAllItems()
		{
			return null;
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x8880D0", Offset = "0x886AD0", VA = "0x1808880D0")]
		public void LoadFromItemSet(ItemInstance[] items)
		{
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x8871D0", Offset = "0x885BD0", VA = "0x1808871D0")]
		public void ClearContents()
		{
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x888920", Offset = "0x887320", VA = "0x180888920")]
		public void Open()
		{
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x887280", Offset = "0x885C80", VA = "0x180887280")]
		public void Close()
		{
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414E")]
		[Address(RVA = "0x888840", Offset = "0x887240", VA = "0x180888840", Slot = "33")]
		protected virtual void OnOpened()
		{
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414F")]
		[Address(RVA = "0x888560", Offset = "0x886F60", VA = "0x180888560", Slot = "34")]
		protected virtual void OnClosed()
		{
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x00011328 File Offset: 0x0000F528
		[Token(Token = "0x6004150")]
		[Address(RVA = "0x8870D0", Offset = "0x885AD0", VA = "0x1808870D0", Slot = "35")]
		public virtual bool CanBeOpened()
		{
			return default(bool);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004151")]
		[Address(RVA = "0x88ADE0", Offset = "0x8897E0", VA = "0x18088ADE0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendAccessor(NetworkObject accessor)
		{
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004152")]
		[Address(RVA = "0x888A60", Offset = "0x887460", VA = "0x180888A60")]
		[ObserversRpc(RunLocally = true)]
		private void SetAccessor(NetworkObject accessor)
		{
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004153")]
		[Address(RVA = "0x88BE70", Offset = "0x88A870", VA = "0x18088BE70", Slot = "21")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004154")]
		[Address(RVA = "0x88BBB0", Offset = "0x88A5B0", VA = "0x18088BBB0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004155")]
		[Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "22")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004156")]
		[Address(RVA = "0x88AF10", Offset = "0x889910", VA = "0x18088AF10")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004157")]
		[Address(RVA = "0x88B9C0", Offset = "0x88A3C0", VA = "0x18088B9C0", Slot = "23")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004158")]
		[Address(RVA = "0x88B690", Offset = "0x88A090", VA = "0x18088B690")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004159")]
		[Address(RVA = "0x88B4F0", Offset = "0x889EF0", VA = "0x18088B4F0", Slot = "24")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415A")]
		[Address(RVA = "0x88B230", Offset = "0x889C30", VA = "0x18088B230")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415B")]
		[Address(RVA = "0x88C290", Offset = "0x88AC90", VA = "0x18088C290")]
		public StorageEntity()
		{
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415C")]
		[Address(RVA = "0x8881A0", Offset = "0x886BA0", VA = "0x1808881A0", Slot = "36")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415D")]
		[Address(RVA = "0x5ACFE0", Offset = "0x5AB9E0", VA = "0x1805ACFE0", Slot = "37")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415E")]
		[Address(RVA = "0x85FED0", Offset = "0x85E8D0", VA = "0x18085FED0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415F")]
		[Address(RVA = "0x88A250", Offset = "0x888C50", VA = "0x18088A250")]
		private void RpcWriter___Server_SendAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004160")]
		[Address(RVA = "0x888A60", Offset = "0x887460", VA = "0x180888A60")]
		private void RpcLogic___SendAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004161")]
		[Address(RVA = "0x889450", Offset = "0x887E50", VA = "0x180889450")]
		private void RpcReader___Server_SendAccessor_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004162")]
		[Address(RVA = "0x889AF0", Offset = "0x8884F0", VA = "0x180889AF0")]
		private void RpcWriter___Observers_SetAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004163")]
		[Address(RVA = "0x888BA0", Offset = "0x8875A0", VA = "0x180888BA0")]
		private void RpcLogic___SetAccessor_3323014238(NetworkObject accessor)
		{
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004164")]
		[Address(RVA = "0x889130", Offset = "0x887B30", VA = "0x180889130")]
		private void RpcReader___Observers_SetAccessor_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004165")]
		[Address(RVA = "0x88A800", Offset = "0x889200", VA = "0x18088A800")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004166")]
		[Address(RVA = "0x888FF0", Offset = "0x8879F0", VA = "0x180888FF0", Slot = "38")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004167")]
		[Address(RVA = "0x8897C0", Offset = "0x8881C0", VA = "0x1808897C0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004168")]
		[Address(RVA = "0x88A0D0", Offset = "0x888AD0", VA = "0x18088A0D0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004169")]
		[Address(RVA = "0x889070", Offset = "0x887A70", VA = "0x180889070")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416A")]
		[Address(RVA = "0x8893C0", Offset = "0x887DC0", VA = "0x1808893C0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416B")]
		[Address(RVA = "0x88AC70", Offset = "0x889670", VA = "0x18088AC70")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416C")]
		[Address(RVA = "0x889A50", Offset = "0x888450", VA = "0x180889A50")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416D")]
		[Address(RVA = "0x88A380", Offset = "0x888D80", VA = "0x18088A380")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416E")]
		[Address(RVA = "0x888D30", Offset = "0x887730", VA = "0x180888D30", Slot = "39")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416F")]
		[Address(RVA = "0x8894D0", Offset = "0x887ED0", VA = "0x1808894D0")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004170")]
		[Address(RVA = "0x889C30", Offset = "0x888630", VA = "0x180889C30")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004171")]
		[Address(RVA = "0x888D40", Offset = "0x887740", VA = "0x180888D40")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004172")]
		[Address(RVA = "0x8891A0", Offset = "0x887BA0", VA = "0x1808891A0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004173")]
		[Address(RVA = "0x88A670", Offset = "0x889070", VA = "0x18088A670")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x888EC0", Offset = "0x8878C0", VA = "0x180888EC0", Slot = "40")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004175")]
		[Address(RVA = "0x889670", Offset = "0x888070", VA = "0x180889670")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004176")]
		[Address(RVA = "0x88AAE0", Offset = "0x8894E0", VA = "0x18088AAE0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004177")]
		[Address(RVA = "0x888F40", Offset = "0x887940", VA = "0x180888F40")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004178")]
		[Address(RVA = "0x889950", Offset = "0x888350", VA = "0x180889950")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004179")]
		[Address(RVA = "0x889F30", Offset = "0x888930", VA = "0x180889F30")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417A")]
		[Address(RVA = "0x8892D0", Offset = "0x887CD0", VA = "0x1808892D0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417B")]
		[Address(RVA = "0x88A500", Offset = "0x888F00", VA = "0x18088A500")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417C")]
		[Address(RVA = "0x888DC0", Offset = "0x8877C0", VA = "0x180888DC0", Slot = "41")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417D")]
		[Address(RVA = "0x889580", Offset = "0x887F80", VA = "0x180889580")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417E")]
		[Address(RVA = "0x889DB0", Offset = "0x8887B0", VA = "0x180889DB0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417F")]
		[Address(RVA = "0x888E40", Offset = "0x887840", VA = "0x180888E40")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004180")]
		[Address(RVA = "0x889240", Offset = "0x887C40", VA = "0x180889240")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004181")]
		[Address(RVA = "0x88A970", Offset = "0x889370", VA = "0x18088A970")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004182")]
		[Address(RVA = "0x8898B0", Offset = "0x8882B0", VA = "0x1808898B0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004183")]
		[Address(RVA = "0x886D70", Offset = "0x885770", VA = "0x180886D70", Slot = "42")]
		protected virtual void Awake_UserLogic_ScheduleOne.Storage.StorageEntity_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002DDA RID: 11738
		[Token(Token = "0x4002DDA")]
		public const int MAX_SLOTS = 20;

		// Token: 0x04002DDC RID: 11740
		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public string StorageEntityName;

		// Token: 0x04002DDD RID: 11741
		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x128")]
		public string StorageEntitySubtitle;

		// Token: 0x04002DDE RID: 11742
		[Token(Token = "0x4002DDE")]
		[FieldOffset(Offset = "0x130")]
		[Range(1f, 20f)]
		public int SlotCount;

		// Token: 0x04002DDF RID: 11743
		[Token(Token = "0x4002DDF")]
		[FieldOffset(Offset = "0x134")]
		public bool EmptyOnSleep;

		// Token: 0x04002DE0 RID: 11744
		[Token(Token = "0x4002DE0")]
		[FieldOffset(Offset = "0x135")]
		public bool SlotsAreFilterable;

		// Token: 0x04002DE1 RID: 11745
		[Token(Token = "0x4002DE1")]
		[FieldOffset(Offset = "0x138")]
		[Header("Display Settings")]
		[Range(1f, 5f)]
		[Tooltip("How many rows to enforce when display contents in StorageMenu")]
		public int DisplayRowCount;

		// Token: 0x04002DE2 RID: 11746
		[Token(Token = "0x4002DE2")]
		[FieldOffset(Offset = "0x13C")]
		[Header("Access Settings")]
		public StorageEntity.EAccessSettings AccessSettings;

		// Token: 0x04002DE3 RID: 11747
		[Token(Token = "0x4002DE3")]
		[FieldOffset(Offset = "0x140")]
		[Range(0f, 10f)]
		[Tooltip("If the distance between this StorageEntity and the player is greater than this, the StorageMenu will be closed.")]
		public float MaxAccessDistance;

		// Token: 0x04002DE5 RID: 11749
		[Token(Token = "0x4002DE5")]
		[FieldOffset(Offset = "0x150")]
		[Header("Events")]
		[Tooltip("Invoked when this StorageEntity is accessed in the StorageMenu")]
		public UnityEvent onOpened;

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		[FieldOffset(Offset = "0x158")]
		[Tooltip("Invoked when the StorageMenu is closed.")]
		public UnityEvent onClosed;

		// Token: 0x04002DE7 RID: 11751
		[Token(Token = "0x4002DE7")]
		[FieldOffset(Offset = "0x160")]
		[Tooltip("Invoked when the contents change in any way. i.e. an item is added, removed, or the quantity of an item changes.")]
		public UnityEvent onContentsChanged;

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x04002DE9 RID: 11753
		[Token(Token = "0x4002DE9")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x02000952 RID: 2386
		[Token(Token = "0x2000952")]
		public enum EAccessSettings
		{
			// Token: 0x04002DEB RID: 11755
			[Token(Token = "0x4002DEB")]
			Closed,
			// Token: 0x04002DEC RID: 11756
			[Token(Token = "0x4002DEC")]
			SinglePlayerOnly,
			// Token: 0x04002DED RID: 11757
			[Token(Token = "0x4002DED")]
			Full
		}
	}
}
