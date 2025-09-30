using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000663 RID: 1635
	[Token(Token = "0x2000663")]
	public class NPCInventory : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028ED RID: 10477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000682")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60028EC")]
			[Address(RVA = "0x708B20", Offset = "0x707520", VA = "0x180708B20", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028ED")]
			[Address(RVA = "0x708B30", Offset = "0x707530", VA = "0x180708B30", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EE")]
		[Address(RVA = "0x703A40", Offset = "0x702440", VA = "0x180703A40", Slot = "28")]
		public virtual void Awake()
		{
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x7087A0", Offset = "0x7071A0", VA = "0x1807087A0", Slot = "29")]
		protected virtual void Start()
		{
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x705400", Offset = "0x703E00", VA = "0x180705400", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x704FF0", Offset = "0x7039F0", VA = "0x180704FF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x705160", Offset = "0x703B60", VA = "0x180705160", Slot = "30")]
		protected virtual void OnSleepStart()
		{
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x704550", Offset = "0x702F50", VA = "0x180704550")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x7089F0", Offset = "0x7073F0", VA = "0x1807089F0")]
		public int _GetItemAmount(string id)
		{
			return 0;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x704400", Offset = "0x702E00", VA = "0x180704400")]
		public int GetIdenticalItemAmount(ItemInstance item)
		{
			return 0;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x704590", Offset = "0x702F90", VA = "0x180704590")]
		public int GetMaxItemCount(string[] ids)
		{
			return 0;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x703A90", Offset = "0x702490", VA = "0x180703A90")]
		public bool CanItemFit(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x703DE0", Offset = "0x7027E0", VA = "0x180703DE0")]
		public int GetCapacityForItem(ItemInstance item)
		{
			return 0;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x7047B0", Offset = "0x7031B0", VA = "0x1807047B0")]
		public void InsertItem(ItemInstance item, bool network = true)
		{
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x704280", Offset = "0x702C80", VA = "0x180704280")]
		public ItemInstance GetFirstItem(string id, [Optional] NPCInventory.ItemFilter filter)
		{
			return null;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x704100", Offset = "0x702B00", VA = "0x180704100")]
		public ItemInstance GetFirstIdenticalItem(ItemInstance item, [Optional] NPCInventory.ItemFilter filter)
		{
			return null;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FC")]
		[Address(RVA = "0x704C30", Offset = "0x703630", VA = "0x180704C30", Slot = "31")]
		protected virtual void InventoryContentsChanged()
		{
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FD")]
		[Address(RVA = "0x704720", Offset = "0x703120", VA = "0x180704720")]
		public void Hovered()
		{
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x704B90", Offset = "0x703590", VA = "0x180704B90")]
		public void Interacted()
		{
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FF")]
		[Address(RVA = "0x708710", Offset = "0x707110", VA = "0x180708710")]
		private void StartPickpocket()
		{
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002900")]
		[Address(RVA = "0x703DC0", Offset = "0x7027C0", VA = "0x180703DC0")]
		public void ExpirePickpocket()
		{
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x6002901")]
		[Address(RVA = "0x703AC0", Offset = "0x7024C0", VA = "0x180703AC0")]
		private bool CanPickpocket()
		{
			return default(bool);
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002902")]
		[Address(RVA = "0x7054E0", Offset = "0x703EE0", VA = "0x1807054E0")]
		[Button]
		public void PrintInventoryContents()
		{
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x703D10", Offset = "0x702710", VA = "0x180703D10")]
		public void Clear()
		{
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x6002904")]
		[Address(RVA = "0x704010", Offset = "0x702A10", VA = "0x180704010")]
		public float GetCashInInventory()
		{
			return 0f;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002905")]
		[Address(RVA = "0x705770", Offset = "0x704170", VA = "0x180705770")]
		public void RemoveCash(float amountToRemove)
		{
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002906")]
		[Address(RVA = "0x7035F0", Offset = "0x701FF0", VA = "0x1807035F0")]
		public void AddCash(float amountToAdd)
		{
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002907")]
		[Address(RVA = "0x708570", Offset = "0x706F70", VA = "0x180708570", Slot = "21")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002908")]
		[Address(RVA = "0x7082B0", Offset = "0x706CB0", VA = "0x1807082B0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002909")]
		[Address(RVA = "0x7077C0", Offset = "0x7061C0", VA = "0x1807077C0", Slot = "22")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x707610", Offset = "0x706010", VA = "0x180707610")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290B")]
		[Address(RVA = "0x7080C0", Offset = "0x706AC0", VA = "0x1807080C0", Slot = "23")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x707D90", Offset = "0x706790", VA = "0x180707D90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x707BF0", Offset = "0x7065F0", VA = "0x180707BF0", Slot = "24")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x707930", Offset = "0x706330", VA = "0x180707930")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x708A40", Offset = "0x707440", VA = "0x180708A40")]
		public NPCInventory()
		{
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x704CB0", Offset = "0x7036B0", VA = "0x180704CB0", Slot = "32")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002911")]
		[Address(RVA = "0x704C90", Offset = "0x703690", VA = "0x180704C90", Slot = "33")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x704C50", Offset = "0x703650", VA = "0x180704C50", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x707030", Offset = "0x705A30", VA = "0x180707030")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x705B80", Offset = "0x704580", VA = "0x180705B80", Slot = "34")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x706260", Offset = "0x704C60", VA = "0x180706260")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x706A30", Offset = "0x705430", VA = "0x180706A30")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x705C00", Offset = "0x704600", VA = "0x180705C00")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x705EE0", Offset = "0x7048E0", VA = "0x180705EE0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x7074A0", Offset = "0x705EA0", VA = "0x1807074A0")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x7064F0", Offset = "0x704EF0", VA = "0x1807064F0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x706BB0", Offset = "0x7055B0", VA = "0x180706BB0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x7058C0", Offset = "0x7042C0", VA = "0x1807058C0", Slot = "35")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x705F70", Offset = "0x704970", VA = "0x180705F70")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x706590", Offset = "0x704F90", VA = "0x180706590")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x7058D0", Offset = "0x7042D0", VA = "0x1807058D0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x705CC0", Offset = "0x7046C0", VA = "0x180705CC0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002921")]
		[Address(RVA = "0x706EA0", Offset = "0x7058A0", VA = "0x180706EA0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002922")]
		[Address(RVA = "0x705A50", Offset = "0x704450", VA = "0x180705A50", Slot = "36")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002923")]
		[Address(RVA = "0x706110", Offset = "0x704B10", VA = "0x180706110")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002924")]
		[Address(RVA = "0x707310", Offset = "0x705D10", VA = "0x180707310")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002925")]
		[Address(RVA = "0x705AD0", Offset = "0x7044D0", VA = "0x180705AD0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002926")]
		[Address(RVA = "0x7063F0", Offset = "0x704DF0", VA = "0x1807063F0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002927")]
		[Address(RVA = "0x706890", Offset = "0x705290", VA = "0x180706890")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002928")]
		[Address(RVA = "0x705DF0", Offset = "0x7047F0", VA = "0x180705DF0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002929")]
		[Address(RVA = "0x706D30", Offset = "0x705730", VA = "0x180706D30")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x705950", Offset = "0x704350", VA = "0x180705950", Slot = "37")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x706020", Offset = "0x704A20", VA = "0x180706020")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x706710", Offset = "0x705110", VA = "0x180706710")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x7059D0", Offset = "0x7043D0", VA = "0x1807059D0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x705D60", Offset = "0x704760", VA = "0x180705D60")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x7071A0", Offset = "0x705BA0", VA = "0x1807071A0")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002930")]
		[Address(RVA = "0x706350", Offset = "0x704D50", VA = "0x180706350")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002931")]
		[Address(RVA = "0x703700", Offset = "0x702100", VA = "0x180703700", Slot = "38")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCInventory_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public InteractableObject PickpocketIntObj;

		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		public const float COOLDOWN = 30f;

		// Token: 0x04001ED4 RID: 7892
		[Token(Token = "0x4001ED4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public int SlotCount;

		// Token: 0x04001ED5 RID: 7893
		[Token(Token = "0x4001ED5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public bool CanBePickpocketed;

		// Token: 0x04001ED6 RID: 7894
		[Token(Token = "0x4001ED6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float PickpocketDifficultyMultiplier;

		// Token: 0x04001ED7 RID: 7895
		[Token(Token = "0x4001ED7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public bool ClearInventoryEachNight;

		// Token: 0x04001ED8 RID: 7896
		[Token(Token = "0x4001ED8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public ItemDefinition[] TestItems;

		// Token: 0x04001ED9 RID: 7897
		[Token(Token = "0x4001ED9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public ItemDefinition[] StartupItems;

		// Token: 0x04001EDA RID: 7898
		[Token(Token = "0x4001EDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Header("Random cash")]
		public bool RandomCash;

		// Token: 0x04001EDB RID: 7899
		[Token(Token = "0x4001EDB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public int RandomCashMin;

		// Token: 0x04001EDC RID: 7900
		[Token(Token = "0x4001EDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public int RandomCashMax;

		// Token: 0x04001EDD RID: 7901
		[Token(Token = "0x4001EDD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[Header("Random items")]
		public bool RandomItems;

		// Token: 0x04001EDE RID: 7902
		[Token(Token = "0x4001EDE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public StorableItemDefinition[] RandomItemDefinitions;

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public int RandomItemMin;

		// Token: 0x04001EE0 RID: 7904
		[Token(Token = "0x4001EE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public int RandomItemMax;

		// Token: 0x04001EE1 RID: 7905
		[Token(Token = "0x4001EE1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NPC npc;

		// Token: 0x04001EE3 RID: 7907
		[Token(Token = "0x4001EE3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public UnityEvent onContentsChanged;

		// Token: 0x04001EE4 RID: 7908
		[Token(Token = "0x4001EE4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float timeOnLastExpire;

		// Token: 0x04001EE5 RID: 7909
		[Token(Token = "0x4001EE5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted;

		// Token: 0x04001EE6 RID: 7910
		[Token(Token = "0x4001EE6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17D")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted;

		// Token: 0x02000664 RID: 1636
		// (Invoke) Token: 0x06002933 RID: 10547
		[Token(Token = "0x2000664")]
		public delegate bool ItemFilter(ItemInstance item);
	}
}
