using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F1 RID: 2545
	[Token(Token = "0x20009F1")]
	public interface IItemSlotOwner
	{
		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06004579 RID: 17785
		// (set) Token: 0x0600457A RID: 17786
		[Token(Token = "0x170009AB")]
		List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6004579")]
			get;
			[Token(Token = "0x600457A")]
			set;
		}

		// Token: 0x0600457B RID: 17787
		[Token(Token = "0x600457B")]
		void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance);

		// Token: 0x0600457C RID: 17788
		[Token(Token = "0x600457C")]
		void SetItemSlotQuantity(int itemSlotIndex, int quantity);

		// Token: 0x0600457D RID: 17789
		[Token(Token = "0x600457D")]
		void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason);

		// Token: 0x0600457E RID: 17790
		[Token(Token = "0x600457E")]
		void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter);

		// Token: 0x0600457F RID: 17791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x8BF040", Offset = "0x8BDA40", VA = "0x1808BF040", Slot = "6")]
		void SendItemSlotDataToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x6004580")]
		[Address(RVA = "0x8BEF00", Offset = "0x8BD900", VA = "0x1808BEF00", Slot = "7")]
		int GetTotalItemCount()
		{
			return 0;
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x6004581")]
		[Address(RVA = "0x8BEC90", Offset = "0x8BD690", VA = "0x1808BEC90", Slot = "8")]
		int GetItemCount(string id)
		{
			return 0;
		}
	}
}
