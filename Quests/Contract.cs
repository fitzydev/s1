using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	public class Contract : Quest
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000350")]
		public NetworkObject Customer
		{
			[Token(Token = "0x600100A")]
			[Address(RVA = "0x672D50", Offset = "0x671750", VA = "0x180672D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600100B")]
			[Address(RVA = "0x672DF0", Offset = "0x6717F0", VA = "0x180672DF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000351")]
		public Dealer Dealer
		{
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600100D")]
			[Address(RVA = "0x6FBE90", Offset = "0x6FA890", VA = "0x1806FBE90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x000079E0 File Offset: 0x00005BE0
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000352")]
		public float Payment
		{
			[Token(Token = "0x600100E")]
			[Address(RVA = "0x538600", Offset = "0x537000", VA = "0x180538600")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600100F")]
			[Address(RVA = "0x659870", Offset = "0x658270", VA = "0x180659870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x000079F8 File Offset: 0x00005BF8
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000353")]
		public int PickupScheduleIndex
		{
			[Token(Token = "0x6001010")]
			[Address(RVA = "0x7479C0", Offset = "0x7463C0", VA = "0x1807479C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001011")]
			[Address(RVA = "0x747A70", Offset = "0x746470", VA = "0x180747A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00007A10 File Offset: 0x00005C10
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000354")]
		public GameDateTime AcceptTime
		{
			[Token(Token = "0x6001012")]
			[Address(RVA = "0xAD37B0", Offset = "0xAD21B0", VA = "0x180AD37B0")]
			[CompilerGenerated]
			get
			{
				return default(GameDateTime);
			}
			[Token(Token = "0x6001013")]
			[Address(RVA = "0xAD37C0", Offset = "0xAD21C0", VA = "0x180AD37C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001014")]
		[Address(RVA = "0xAD31F0", Offset = "0xAD1BF0", VA = "0x180AD31F0", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001015")]
		[Address(RVA = "0xAD28F0", Offset = "0xAD12F0", VA = "0x180AD28F0", Slot = "56")]
		public virtual void InitializeContract(string title, string description, QuestEntryData[] entries, string guid, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001016")]
		[Address(RVA = "0xAD3080", Offset = "0xAD1A80", VA = "0x180AD3080", Slot = "57")]
		public virtual void SilentlyInitializeContract(string title, string description, QuestEntryData[] entries, string guid, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001017")]
		[Address(RVA = "0xAD2BB0", Offset = "0xAD15B0", VA = "0x180AD2BB0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001018")]
		[Address(RVA = "0xAD2BD0", Offset = "0xAD15D0", VA = "0x180AD2BD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001019")]
		[Address(RVA = "0xAD32B0", Offset = "0xAD1CB0", VA = "0x180AD32B0")]
		private void UpdateTiming()
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101A")]
		[Address(RVA = "0xAD1B30", Offset = "0xAD0530", VA = "0x180AD1B30", Slot = "39")]
		public override void End()
		{
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101B")]
		[Address(RVA = "0xAD14E0", Offset = "0xACFEE0", VA = "0x180AD14E0", Slot = "35")]
		public override void Complete(bool network = true)
		{
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101C")]
		[Address(RVA = "0xAD2E90", Offset = "0xAD1890", VA = "0x180AD2E90")]
		public void SetDealer(Dealer dealer)
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101D")]
		[Address(RVA = "0xAD3200", Offset = "0xAD1C00", VA = "0x180AD3200", Slot = "58")]
		public virtual void SubmitPayment(float bonusTotal)
		{
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101E")]
		[Address(RVA = "0xAD2D70", Offset = "0xAD1770", VA = "0x180AD2D70", Slot = "46")]
		protected override void SendExpiryReminder()
		{
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600101F")]
		[Address(RVA = "0xAD2C50", Offset = "0xAD1650", VA = "0x180AD2C50", Slot = "47")]
		protected override void SendExpiredNotification()
		{
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x6001020")]
		[Address(RVA = "0xAD3000", Offset = "0xAD1A00", VA = "0x180AD3000", Slot = "41")]
		protected override bool ShouldShowJournalEntry()
		{
			return default(bool);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x6001021")]
		[Address(RVA = "0xAD13E0", Offset = "0xACFDE0", VA = "0x180AD13E0", Slot = "45")]
		protected override bool CanExpire()
		{
			return default(bool);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6001022")]
		[Address(RVA = "0xAD15F0", Offset = "0xACFFF0", VA = "0x180AD15F0")]
		public bool DoesProductListMatchSpecified(List<ItemInstance> items, bool enforceQuality)
		{
			return default(bool);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6001023")]
		[Address(RVA = "0xAD1C20", Offset = "0xAD0620", VA = "0x180AD1C20")]
		public float GetProductListMatch(List<ItemInstance> items, out int matchedProductCount)
		{
			return 0f;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001024")]
		[Address(RVA = "0xAD24A0", Offset = "0xAD0EA0", VA = "0x180AD24A0", Slot = "54")]
		public override SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x6001025")]
		[Address(RVA = "0xAD2F80", Offset = "0xAD1980", VA = "0x180AD2F80")]
		public new bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001026")]
		[Address(RVA = "0xAD3760", Offset = "0xAD2160", VA = "0x180AD3760")]
		public Contract()
		{
		}

		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		public const int DefaultExpiryTime = 2880;

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x0")]
		public static List<Contract> Contracts;

		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0x150")]
		[Header("Contract Settings")]
		public ProductList ProductList;

		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0x158")]
		public DeliveryLocation DeliveryLocation;

		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0x160")]
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		[FieldOffset(Offset = "0x174")]
		private bool completedContractsIncremented;

		// Token: 0x020002E2 RID: 738
		[Token(Token = "0x20002E2")]
		public class BonusPayment
		{
			// Token: 0x06001028 RID: 4136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001028")]
			[Address(RVA = "0xAD0D90", Offset = "0xACF790", VA = "0x180AD0D90")]
			public BonusPayment(string title, float amount)
			{
			}

			// Token: 0x0400105E RID: 4190
			[Token(Token = "0x400105E")]
			[FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x0400105F RID: 4191
			[Token(Token = "0x400105F")]
			[FieldOffset(Offset = "0x18")]
			public float Amount;
		}
	}
}
