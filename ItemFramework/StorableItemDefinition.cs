using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Levelling;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000A07 RID: 2567
	[Token(Token = "0x2000A07")]
	[CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/StorableItemDefinition", order = 1)]
	[Serializable]
	public class StorableItemDefinition : ItemDefinition
	{
		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x170009C6")]
		public bool IsPurchasable
		{
			[Token(Token = "0x600462D")]
			[Address(RVA = "0x8C92F0", Offset = "0x8C7CF0", VA = "0x1808C92F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x8C91D0", Offset = "0x8C7BD0", VA = "0x1808C91D0", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x8C9240", Offset = "0x8C7C40", VA = "0x1808C9240")]
		public StorableItemDefinition()
		{
		}

		// Token: 0x0400310F RID: 12559
		[Token(Token = "0x400310F")]
		[FieldOffset(Offset = "0x80")]
		[Header("Purchasing")]
		public float BasePurchasePrice;

		// Token: 0x04003110 RID: 12560
		[Token(Token = "0x4003110")]
		[FieldOffset(Offset = "0x88")]
		public List<ShopListing.CategoryInstance> ShopCategories;

		// Token: 0x04003111 RID: 12561
		[Token(Token = "0x4003111")]
		[FieldOffset(Offset = "0x90")]
		public bool RequiresLevelToPurchase;

		// Token: 0x04003112 RID: 12562
		[Token(Token = "0x4003112")]
		[FieldOffset(Offset = "0x94")]
		public FullRank RequiredRank;

		// Token: 0x04003113 RID: 12563
		[Token(Token = "0x4003113")]
		[FieldOffset(Offset = "0x9C")]
		[Range(0f, 1f)]
		[Header("Reselling")]
		public float ResellMultiplier;

		// Token: 0x04003114 RID: 12564
		[Token(Token = "0x4003114")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Storable Item")]
		public StoredItem StoredItem;

		// Token: 0x04003115 RID: 12565
		[Token(Token = "0x4003115")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("Optional station item if this item can be used at a station.")]
		public StationItem StationItem;

		// Token: 0x04003116 RID: 12566
		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		[Header("Other Settings")]
		public float CombatUtilityForNPCs;
	}
}
