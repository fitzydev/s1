using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000A00 RID: 2560
	[Token(Token = "0x2000A00")]
	[Serializable]
	public class ItemSlot
	{
		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045E9 RID: 17897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009B6")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60045E8")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E9")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045EB RID: 17899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009B7")]
		public IItemSlotOwner SlotOwner
		{
			[Token(Token = "0x60045EA")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045EB")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x000125E8 File Offset: 0x000107E8
		[Token(Token = "0x170009B8")]
		private int SlotIndex
		{
			[Token(Token = "0x60045EC")]
			[Address(RVA = "0x8C7BE0", Offset = "0x8C65E0", VA = "0x1808C7BE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x00012600 File Offset: 0x00010800
		[Token(Token = "0x170009B9")]
		public int Quantity
		{
			[Token(Token = "0x60045ED")]
			[Address(RVA = "0x8C7BC0", Offset = "0x8C65C0", VA = "0x1808C7BC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x170009BA")]
		public bool IsAtCapacity
		{
			[Token(Token = "0x60045EE")]
			[Address(RVA = "0x8C7B60", Offset = "0x8C6560", VA = "0x1808C7B60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060045EF RID: 17903 RVA: 0x00012630 File Offset: 0x00010830
		[Token(Token = "0x170009BB")]
		public bool IsLocked
		{
			[Token(Token = "0x60045EF")]
			[Address(RVA = "0x8C7BB0", Offset = "0x8C65B0", VA = "0x1808C7BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045F1 RID: 17905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BC")]
		public ItemSlotLock ActiveLock
		{
			[Token(Token = "0x60045F0")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045F1")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x00012648 File Offset: 0x00010848
		// (set) Token: 0x060045F3 RID: 17907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BD")]
		public bool IsRemovalLocked
		{
			[Token(Token = "0x60045F2")]
			[Address(RVA = "0x4FA8A0", Offset = "0x4F92A0", VA = "0x1804FA8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60045F3")]
			[Address(RVA = "0x4FAC50", Offset = "0x4F9650", VA = "0x1804FAC50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00012660 File Offset: 0x00010860
		// (set) Token: 0x060045F5 RID: 17909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BE")]
		public bool IsAddLocked
		{
			[Token(Token = "0x60045F4")]
			[Address(RVA = "0x4FA960", Offset = "0x4F9360", VA = "0x1804FA960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60045F5")]
			[Address(RVA = "0x4FACE0", Offset = "0x4F96E0", VA = "0x1804FACE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045F7 RID: 17911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BF")]
		protected List<ItemFilter> HardFilters
		{
			[Token(Token = "0x60045F6")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045F7")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x00012678 File Offset: 0x00010878
		// (set) Token: 0x060045F9 RID: 17913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C0")]
		public bool CanPlayerSetFilter
		{
			[Token(Token = "0x60045F8")]
			[Address(RVA = "0x4FA970", Offset = "0x4F9370", VA = "0x1804FA970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60045F9")]
			[Address(RVA = "0x4FACF0", Offset = "0x4F96F0", VA = "0x1804FACF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045FB RID: 17915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C1")]
		public SlotFilter PlayerFilter
		{
			[Token(Token = "0x60045FA")]
			[Address(RVA = "0x4E9B20", Offset = "0x4E8520", VA = "0x1804E9B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045FB")]
			[Address(RVA = "0x5FD1D0", Offset = "0x5FBBD0", VA = "0x1805FD1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060045FC RID: 17916 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045FD RID: 17917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C2")]
		public ItemSlotSiblingSet SiblingSet
		{
			[Token(Token = "0x60045FC")]
			[Address(RVA = "0x4573C0", Offset = "0x455DC0", VA = "0x1804573C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045FD")]
			[Address(RVA = "0x6009E0", Offset = "0x5FF3E0", VA = "0x1806009E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x8C7240", Offset = "0x8C5C40", VA = "0x1808C7240")]
		public void SetSlotOwner(IItemSlotOwner owner)
		{
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x8C71B0", Offset = "0x8C5BB0", VA = "0x1808C71B0")]
		public void SetSiblingSet(ItemSlotSiblingSet set)
		{
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004600")]
		[Address(RVA = "0x8C7A50", Offset = "0x8C6450", VA = "0x1808C7A50")]
		public ItemSlot()
		{
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004601")]
		[Address(RVA = "0x8C7930", Offset = "0x8C6330", VA = "0x1808C7930")]
		public ItemSlot(bool canPlayerSetFilter = false)
		{
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x8C6C90", Offset = "0x8C5690", VA = "0x1808C6C90")]
		public void ReplicateStoredInstance()
		{
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x8C7330", Offset = "0x8C5D30", VA = "0x1808C7330", Slot = "4")]
		public virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004604")]
		[Address(RVA = "0x8C6A20", Offset = "0x8C5420", VA = "0x1808C6A20", Slot = "5")]
		public virtual void InsertItem(ItemInstance item)
		{
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004605")]
		[Address(RVA = "0x8C5DF0", Offset = "0x8C47F0", VA = "0x1808C5DF0", Slot = "6")]
		public virtual void AddItem(ItemInstance item, bool _internal = false)
		{
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004606")]
		[Address(RVA = "0x8C62C0", Offset = "0x8C4CC0", VA = "0x1808C62C0", Slot = "7")]
		public virtual void ClearStoredInstance(bool _internal = false)
		{
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004607")]
		[Address(RVA = "0x8C6EF0", Offset = "0x8C58F0", VA = "0x1808C6EF0")]
		public void SetQuantity(int amount, bool _internal = false)
		{
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004608")]
		[Address(RVA = "0x8C60B0", Offset = "0x8C4AB0", VA = "0x1808C60B0")]
		public void ChangeQuantity(int change, bool _internal = false)
		{
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004609")]
		[Address(RVA = "0x8C6B00", Offset = "0x8C5500", VA = "0x1808C6B00", Slot = "8")]
		protected virtual void ItemDataChanged()
		{
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460A")]
		[Address(RVA = "0x8C62A0", Offset = "0x8C4CA0", VA = "0x1808C62A0", Slot = "9")]
		protected virtual void ClearItemInstanceRequested()
		{
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460B")]
		[Address(RVA = "0x8C5CF0", Offset = "0x8C46F0", VA = "0x1808C5CF0")]
		public void AddFilter(ItemFilter filter)
		{
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460C")]
		[Address(RVA = "0x8C5EF0", Offset = "0x8C48F0", VA = "0x1808C5EF0")]
		public void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460D")]
		[Address(RVA = "0x8C6B50", Offset = "0x8C5550", VA = "0x1808C6B50")]
		public void RemoveLock(bool _internal = false)
		{
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460E")]
		[Address(RVA = "0x4FAC50", Offset = "0x4F9650", VA = "0x1804FAC50")]
		public void SetIsRemovalLocked(bool locked)
		{
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460F")]
		[Address(RVA = "0x4FACE0", Offset = "0x4F96E0", VA = "0x1804FACE0")]
		public void SetIsAddLocked(bool locked)
		{
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x6004610")]
		[Address(RVA = "0x8C6600", Offset = "0x8C5000", VA = "0x1808C6600", Slot = "10")]
		public virtual bool DoesItemMatchHardFilters(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x6004611")]
		[Address(RVA = "0x8C67E0", Offset = "0x8C51E0", VA = "0x1808C67E0", Slot = "11")]
		public virtual bool DoesItemMatchPlayerFilters(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004612")]
		[Address(RVA = "0x8C6D60", Offset = "0x8C5760", VA = "0x1808C6D60")]
		public void SetFilterable(bool filterable)
		{
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004613")]
		[Address(RVA = "0x8C6DD0", Offset = "0x8C57D0", VA = "0x1808C6DD0")]
		public void SetPlayerFilter(SlotFilter filter, bool _internal = false)
		{
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x000126C0 File Offset: 0x000108C0
		[Token(Token = "0x6004614")]
		[Address(RVA = "0x8C6930", Offset = "0x8C5330", VA = "0x1808C6930", Slot = "12")]
		public virtual int GetCapacityForItem(ItemInstance item, bool checkPlayerFilters = false)
		{
			return 0;
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x6004615")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "13")]
		public virtual bool CanSlotAcceptCash()
		{
			return default(bool);
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x000126F0 File Offset: 0x000108F0
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x8C7690", Offset = "0x8C6090", VA = "0x1808C7690")]
		public static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x040030F6 RID: 12534
		[Token(Token = "0x40030F6")]
		[FieldOffset(Offset = "0x20")]
		public Action onItemDataChanged;

		// Token: 0x040030F7 RID: 12535
		[Token(Token = "0x40030F7")]
		[FieldOffset(Offset = "0x28")]
		public Action onItemInstanceChanged;

		// Token: 0x040030F9 RID: 12537
		[Token(Token = "0x40030F9")]
		[FieldOffset(Offset = "0x38")]
		public Action onLocked;

		// Token: 0x040030FA RID: 12538
		[Token(Token = "0x40030FA")]
		[FieldOffset(Offset = "0x40")]
		public Action onUnlocked;

		// Token: 0x04003100 RID: 12544
		[Token(Token = "0x4003100")]
		[FieldOffset(Offset = "0x68")]
		public Action onFilterChange;
	}
}
