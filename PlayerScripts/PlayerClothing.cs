using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	public class PlayerClothing : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000534")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6001DF9")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DFA")]
			[Address(RVA = "0x630490", Offset = "0x62EE90", VA = "0x180630490", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000535")]
		private AvatarSettings appearanceSettings
		{
			[Token(Token = "0x6001DFB")]
			[Address(RVA = "0x655AF0", Offset = "0x6544F0", VA = "0x180655AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x6519D0", Offset = "0x6503D0", VA = "0x1806519D0", Slot = "28")]
		public virtual void Awake()
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x6522C0", Offset = "0x650CC0", VA = "0x1806522C0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x651A40", Offset = "0x650440", VA = "0x180651A40")]
		public void InsertClothing(ClothingInstance clothing)
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x651A20", Offset = "0x650420", VA = "0x180651A20", Slot = "29")]
		protected virtual void ClothingChanged()
		{
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x6523A0", Offset = "0x650DA0", VA = "0x1806523A0", Slot = "30")]
		public virtual void RefreshAppearance()
		{
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x655710", Offset = "0x654110", VA = "0x180655710")]
		private bool TryGetInventoryClothing(string assetPath, Color color, out ClothingInstance clothing)
		{
			return default(bool);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x651C10", Offset = "0x650610", VA = "0x180651C10")]
		private bool IsClothingApplied(AvatarSettings settings, ClothingInstance clothing)
		{
			return default(bool);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x651280", Offset = "0x64FC80", VA = "0x180651280")]
		private void ApplyClothing(AvatarSettings settings, ClothingInstance clothing)
		{
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x655570", Offset = "0x653F70", VA = "0x180655570", Slot = "21")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x6552B0", Offset = "0x653CB0", VA = "0x1806552B0")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x6547C0", Offset = "0x6531C0", VA = "0x1806547C0", Slot = "22")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x654610", Offset = "0x653010", VA = "0x180654610")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x6550C0", Offset = "0x653AC0", VA = "0x1806550C0", Slot = "23")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x654D90", Offset = "0x653790", VA = "0x180654D90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x654BF0", Offset = "0x6535F0", VA = "0x180654BF0", Slot = "24")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x654930", Offset = "0x653330", VA = "0x180654930")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0x6559D0", Offset = "0x6543D0", VA = "0x1806559D0")]
		public PlayerClothing()
		{
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x651F80", Offset = "0x650980", VA = "0x180651F80", Slot = "31")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x651F60", Offset = "0x650960", VA = "0x180651F60", Slot = "32")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x5C22C0", Offset = "0x5C0CC0", VA = "0x1805C22C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x654030", Offset = "0x652A30", VA = "0x180654030")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x652B80", Offset = "0x651580", VA = "0x180652B80", Slot = "33")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x653260", Offset = "0x651C60", VA = "0x180653260")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x653A30", Offset = "0x652430", VA = "0x180653A30")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x652C00", Offset = "0x651600", VA = "0x180652C00")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x652EE0", Offset = "0x6518E0", VA = "0x180652EE0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x6544A0", Offset = "0x652EA0", VA = "0x1806544A0")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x6534F0", Offset = "0x651EF0", VA = "0x1806534F0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x653BB0", Offset = "0x6525B0", VA = "0x180653BB0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x6528C0", Offset = "0x6512C0", VA = "0x1806528C0", Slot = "34")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x652F70", Offset = "0x651970", VA = "0x180652F70")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x653590", Offset = "0x651F90", VA = "0x180653590")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x6528D0", Offset = "0x6512D0", VA = "0x1806528D0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x652CC0", Offset = "0x6516C0", VA = "0x180652CC0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x653EA0", Offset = "0x6528A0", VA = "0x180653EA0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x652A50", Offset = "0x651450", VA = "0x180652A50", Slot = "35")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x653110", Offset = "0x651B10", VA = "0x180653110")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x654310", Offset = "0x652D10", VA = "0x180654310")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x652AD0", Offset = "0x6514D0", VA = "0x180652AD0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x6533F0", Offset = "0x651DF0", VA = "0x1806533F0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x653890", Offset = "0x652290", VA = "0x180653890")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x652DF0", Offset = "0x6517F0", VA = "0x180652DF0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x653D30", Offset = "0x652730", VA = "0x180653D30")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E27")]
		[Address(RVA = "0x652950", Offset = "0x651350", VA = "0x180652950", Slot = "36")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x653020", Offset = "0x651A20", VA = "0x180653020")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x653710", Offset = "0x652110", VA = "0x180653710")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x6529D0", Offset = "0x6513D0", VA = "0x1806529D0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x652D60", Offset = "0x651760", VA = "0x180652D60")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x6541A0", Offset = "0x652BA0", VA = "0x1806541A0")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x653350", Offset = "0x651D50", VA = "0x180653350")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x6515B0", Offset = "0x64FFB0", VA = "0x1806515B0", Slot = "37")]
		protected virtual void Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerClothing_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0x118")]
		public Player Player;

		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x40018A0")]
		[FieldOffset(Offset = "0x128")]
		public Dictionary<EClothingSlot, ItemSlot> ClothingSlots;

		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x40018A1")]
		[FieldOffset(Offset = "0x130")]
		private List<ClothingInstance> appliedClothing;

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x138")]
		private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted;

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x139")]
		private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted;
	}
}
