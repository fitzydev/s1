using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.Product.Packaging;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2000564")]
	public class PlayerInventory : PlayerSingleton<PlayerInventory>
	{
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x17000541")]
		public int TOTAL_SLOT_COUNT
		{
			[Token(Token = "0x6001E7F")]
			[Address(RVA = "0x65E660", Offset = "0x65D060", VA = "0x18065E660")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000542")]
		public CashSlot cashSlot
		{
			[Token(Token = "0x6001E80")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E81")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000543")]
		public CashInstance cashInstance
		{
			[Token(Token = "0x6001E82")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E83")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0000A0B0 File Offset: 0x000082B0
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000544")]
		public int EquippedSlotIndex
		{
			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x526820", Offset = "0x525220", VA = "0x180526820")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E85")]
			[Address(RVA = "0x65E700", Offset = "0x65D100", VA = "0x18065E700")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0000A0C8 File Offset: 0x000082C8
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000545")]
		public bool HotbarEnabled
		{
			[Token(Token = "0x6001E86")]
			[Address(RVA = "0x65E650", Offset = "0x65D050", VA = "0x18065E650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E87")]
			[Address(RVA = "0x65E720", Offset = "0x65D120", VA = "0x18065E720")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x0000A0E0 File Offset: 0x000082E0
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000546")]
		public bool EquippingEnabled
		{
			[Token(Token = "0x6001E88")]
			[Address(RVA = "0x65E640", Offset = "0x65D040", VA = "0x18065E640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E89")]
			[Address(RVA = "0x65E710", Offset = "0x65D110", VA = "0x18065E710")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000547")]
		public Equippable equippable
		{
			[Token(Token = "0x6001E8A")]
			[Address(RVA = "0x4F2140", Offset = "0x4F0B40", VA = "0x1804F2140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E8B")]
			[Address(RVA = "0x639E10", Offset = "0x638810", VA = "0x180639E10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000548")]
		public HotbarSlot equippedSlot
		{
			[Token(Token = "0x6001E8C")]
			[Address(RVA = "0x65E680", Offset = "0x65D080", VA = "0x18065E680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x17000549")]
		public bool isAnythingEquipped
		{
			[Token(Token = "0x6001E8D")]
			[Address(RVA = "0x65E6A0", Offset = "0x65D0A0", VA = "0x18065E6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x65ACA0", Offset = "0x6596A0", VA = "0x18065ACA0")]
		public HotbarSlot IndexAllSlots(int index)
		{
			return null;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x65A440", Offset = "0x658E40", VA = "0x18065A440", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x65C190", Offset = "0x65AB90", VA = "0x18065C190")]
		private void SetupInventoryUI()
		{
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x65B3C0", Offset = "0x659DC0", VA = "0x18065B3C0")]
		private void RepositionUI()
		{
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x65CBC0", Offset = "0x65B5C0", VA = "0x18065CBC0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x65AB10", Offset = "0x659510", VA = "0x18065AB10")]
		private void GiveStartupItems()
		{
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x65DD60", Offset = "0x65C760", VA = "0x18065DD60", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x65D100", Offset = "0x65BB00", VA = "0x18065D100")]
		private void UpdateHotbarSelection()
		{
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0x65A780", Offset = "0x659180", VA = "0x18065A780")]
		public void Equip(HotbarSlot slot)
		{
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x65BF20", Offset = "0x65A920", VA = "0x18065BF20")]
		public void SetInventoryEnabled(bool enabled)
		{
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x65BD00", Offset = "0x65A700", VA = "0x18065BD00")]
		public void SetEquippingEnabled(bool enabled)
		{
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x65A740", Offset = "0x659140", VA = "0x18065A740")]
		private void ClipboardAcquiredVarChange(bool newVal)
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x65A740", Offset = "0x659140", VA = "0x18065A740")]
		public void SetManagementClipboardEnabled(bool enabled)
		{
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x65C000", Offset = "0x65AA00", VA = "0x18065C000")]
		public void SetViewmodelVisible(bool visible)
		{
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x65A490", Offset = "0x658E90", VA = "0x18065A490")]
		public bool CanItemFitInInventory(ItemInstance item, int quantity = 1)
		{
			return default(bool);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x65A020", Offset = "0x658A20", VA = "0x18065A020")]
		public void AddItemToInventory(ItemInstance item)
		{
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x65A9B0", Offset = "0x6593B0", VA = "0x18065A9B0")]
		public uint GetAmountOfItem(string ID)
		{
			return 0U;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x65AE00", Offset = "0x659800", VA = "0x18065AE00")]
		public void RemoveAmountOfItem(string ID, uint amount = 1U)
		{
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x65A680", Offset = "0x659080", VA = "0x18065A680")]
		public void ClearInventory()
		{
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0x65B060", Offset = "0x659A60", VA = "0x18065B060")]
		public void RemoveProductFromInventory(EStealthLevel maxStealth)
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x65B290", Offset = "0x659C90", VA = "0x18065B290")]
		public void RemoveRandomItemsFromInventory()
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x65BC70", Offset = "0x65A670", VA = "0x18065BC70")]
		public void SetEquippable(Equippable eq)
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x65A7B0", Offset = "0x6591B0", VA = "0x18065A7B0")]
		public void EquippedSlotChanged()
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x65AD90", Offset = "0x659790", VA = "0x18065AD90")]
		public void Reequip()
		{
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x65A7E0", Offset = "0x6591E0", VA = "0x18065A7E0")]
		public List<ItemSlot> GetAllInventorySlots()
		{
			return null;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x65D5B0", Offset = "0x65BFB0", VA = "0x18065D5B0")]
		private void UpdateInventoryVariables()
		{
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x65E4C0", Offset = "0x65CEC0", VA = "0x18065E4C0")]
		public PlayerInventory()
		{
		}

		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		public const float LABEL_DISPLAY_TIME = 2f;

		// Token: 0x040018DF RID: 6367
		[Token(Token = "0x40018DF")]
		public const float LABEL_FADE_TIME = 0.5f;

		// Token: 0x040018E0 RID: 6368
		[Token(Token = "0x40018E0")]
		public const float DISCARD_TIME = 1.5f;

		// Token: 0x040018E1 RID: 6369
		[Token(Token = "0x40018E1")]
		public const int INVENTORY_SLOT_COUNT = 8;

		// Token: 0x040018E2 RID: 6370
		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x20")]
		[Header("Startup Items (Editor only)")]
		[SerializeField]
		private bool giveStartupItems;

		// Token: 0x040018E3 RID: 6371
		[Token(Token = "0x40018E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PlayerInventory.ItemAmount> startupItems;

		// Token: 0x040018E4 RID: 6372
		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform equipContainer;

		// Token: 0x040018E5 RID: 6373
		[Token(Token = "0x40018E5")]
		[FieldOffset(Offset = "0x38")]
		public List<HotbarSlot> hotbarSlots;

		// Token: 0x040018E8 RID: 6376
		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x50")]
		private ClipboardSlot clipboardSlot;

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x58")]
		private List<ItemSlotUI> slotUIs;

		// Token: 0x040018EA RID: 6378
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x60")]
		private ItemSlot discardSlot;

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x68")]
		[Header("Item Variables")]
		public List<PlayerInventory.ItemVariable> ItemVariables;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x80")]
		public Action<bool> onInventoryStateChanged;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x88")]
		public Action<int> onEquippedSlotChanged;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x90")]
		private int PriorEquippedSlotIndex;

		// Token: 0x040018F3 RID: 6387
		[Token(Token = "0x40018F3")]
		[FieldOffset(Offset = "0x94")]
		private int PreviousEquippedSlotIndex;

		// Token: 0x040018F4 RID: 6388
		[Token(Token = "0x40018F4")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent onPreItemEquipped;

		// Token: 0x040018F5 RID: 6389
		[Token(Token = "0x40018F5")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent onItemEquipped;

		// Token: 0x040018F6 RID: 6390
		[Token(Token = "0x40018F6")]
		[FieldOffset(Offset = "0xA8")]
		private bool ManagementSlotEnabled;

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[FieldOffset(Offset = "0xAC")]
		public float currentEquipTime;

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[FieldOffset(Offset = "0xB0")]
		protected float currentDiscardTime;

		// Token: 0x02000565 RID: 1381
		[Token(Token = "0x2000565")]
		[Serializable]
		public class ItemVariable
		{
			// Token: 0x06001EAA RID: 7850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ItemVariable()
			{
			}

			// Token: 0x040018F9 RID: 6393
			[Token(Token = "0x40018F9")]
			[FieldOffset(Offset = "0x10")]
			public ItemDefinition Definition;

			// Token: 0x040018FA RID: 6394
			[Token(Token = "0x40018FA")]
			[FieldOffset(Offset = "0x18")]
			public string VariableName;
		}

		// Token: 0x02000566 RID: 1382
		[Token(Token = "0x2000566")]
		[Serializable]
		private class ItemAmount
		{
			// Token: 0x06001EAB RID: 7851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x651090", Offset = "0x64FA90", VA = "0x180651090")]
			public ItemAmount()
			{
			}

			// Token: 0x040018FB RID: 6395
			[Token(Token = "0x40018FB")]
			[FieldOffset(Offset = "0x10")]
			public ItemDefinition Definition;

			// Token: 0x040018FC RID: 6396
			[Token(Token = "0x40018FC")]
			[FieldOffset(Offset = "0x18")]
			public int Amount;
		}
	}
}
