using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x0200095A RID: 2394
	[Token(Token = "0x200095A")]
	public class StorageVisualizer : MonoBehaviour
	{
		// Token: 0x060041B3 RID: 16819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B3")]
		[Address(RVA = "0x88E440", Offset = "0x88CE40", VA = "0x18088E440", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B4")]
		[Address(RVA = "0x88F830", Offset = "0x88E230", VA = "0x18088F830", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B5")]
		[Address(RVA = "0x88E280", Offset = "0x88CC80", VA = "0x18088E280")]
		public void AddSlot(ItemSlot slot, bool update = false)
		{
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B6")]
		[Address(RVA = "0x88ED70", Offset = "0x88D770", VA = "0x18088ED70")]
		public Dictionary<StorableItemInstance, int> GetVisualRepresentation()
		{
			return null;
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B7")]
		[Address(RVA = "0x88EDB0", Offset = "0x88D7B0", VA = "0x18088EDB0", Slot = "6")]
		public virtual void RefreshVisuals()
		{
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B8")]
		[Address(RVA = "0x88E6F0", Offset = "0x88D0F0", VA = "0x18088E6F0")]
		private List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			return null;
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B9")]
		[Address(RVA = "0x88E520", Offset = "0x88CF20", VA = "0x18088E520")]
		private void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement)
		{
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BA")]
		[Address(RVA = "0x88EA80", Offset = "0x88D480", VA = "0x18088EA80")]
		public Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			return null;
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041BB")]
		[Address(RVA = "0x88EDA0", Offset = "0x88D7A0", VA = "0x18088EDA0")]
		protected void QueueRefresh()
		{
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041BC")]
		[Address(RVA = "0x886CB0", Offset = "0x8856B0", VA = "0x180886CB0")]
		public StorageVisualizer()
		{
		}

		// Token: 0x04002E03 RID: 11779
		[Token(Token = "0x4002E03")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public StorageGrid[] StorageGrids;

		// Token: 0x04002E04 RID: 11780
		[Token(Token = "0x4002E04")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemContainer;

		// Token: 0x04002E05 RID: 11781
		[Token(Token = "0x4002E05")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		[Tooltip("Should storage visuals be fully recalculated when item(s) are removed?")]
		public bool FullRefreshOnItemRemoved;

		// Token: 0x04002E06 RID: 11782
		[Token(Token = "0x4002E06")]
		[FieldOffset(Offset = "0x38")]
		protected List<ItemSlot> itemSlots;

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		[FieldOffset(Offset = "0x40")]
		protected int totalFootprintCapacity;

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x48")]
		protected Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0x50")]
		public bool BlockRefreshes;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[FieldOffset(Offset = "0x51")]
		protected bool updateVisuals;
	}
}
