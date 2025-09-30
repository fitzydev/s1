using System;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F8 RID: 2552
	[Token(Token = "0x20009F8")]
	[Serializable]
	public abstract class ItemInstance
	{
		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AC")]
		[CodegenExclude]
		public ItemDefinition Definition
		{
			[Token(Token = "0x6004591")]
			[Address(RVA = "0x8C0900", Offset = "0x8BF300", VA = "0x1808C0900")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AD")]
		[CodegenExclude]
		public virtual string Name
		{
			[Token(Token = "0x6004592")]
			[Address(RVA = "0x8C0AA0", Offset = "0x8BF4A0", VA = "0x1808C0AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AE")]
		[CodegenExclude]
		public virtual string Description
		{
			[Token(Token = "0x6004593")]
			[Address(RVA = "0x8C0A00", Offset = "0x8BF400", VA = "0x1808C0A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AF")]
		[CodegenExclude]
		public virtual Sprite Icon
		{
			[Token(Token = "0x6004594")]
			[Address(RVA = "0x8C0A40", Offset = "0x8BF440", VA = "0x1808C0A40", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x170009B0")]
		[CodegenExclude]
		public virtual EItemCategory Category
		{
			[Token(Token = "0x6004595")]
			[Address(RVA = "0x8C08E0", Offset = "0x8BF2E0", VA = "0x1808C08E0", Slot = "7")]
			get
			{
				return EItemCategory.Product;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x170009B1")]
		[CodegenExclude]
		public virtual int StackLimit
		{
			[Token(Token = "0x6004596")]
			[Address(RVA = "0x8C0AC0", Offset = "0x8BF4C0", VA = "0x1808C0AC0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x170009B2")]
		[CodegenExclude]
		public virtual Color LabelDisplayColor
		{
			[Token(Token = "0x6004597")]
			[Address(RVA = "0x8C0A60", Offset = "0x8BF460", VA = "0x1808C0A60", Slot = "9")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B3")]
		[CodegenExclude]
		public virtual Equippable Equippable
		{
			[Token(Token = "0x6004598")]
			[Address(RVA = "0x8C0A20", Offset = "0x8BF420", VA = "0x1808C0A20", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x8C07D0", Offset = "0x8BF1D0", VA = "0x1808C07D0")]
		public ItemInstance()
		{
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459A")]
		[Address(RVA = "0x8C0830", Offset = "0x8BF230", VA = "0x1808C0830")]
		public ItemInstance(ItemDefinition definition, int quantity)
		{
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x8C03A0", Offset = "0x8BEDA0", VA = "0x1808C03A0", Slot = "11")]
		public virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return default(bool);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x8C0510", Offset = "0x8BEF10", VA = "0x1808C0510", Slot = "12")]
		public virtual ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x600459D")]
		[Address(RVA = "0x8C0610", Offset = "0x8BF010", VA = "0x1808C0610", Slot = "13")]
		public virtual bool IsValidInstance()
		{
			return default(bool);
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x8C05F0", Offset = "0x8BEFF0", VA = "0x1808C05F0")]
		protected void InvokeDataChange()
		{
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459F")]
		[Address(RVA = "0x8C06E0", Offset = "0x8BF0E0", VA = "0x1808C06E0")]
		public void SetQuantity(int quantity)
		{
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A0")]
		[Address(RVA = "0x8C0420", Offset = "0x8BEE20", VA = "0x1808C0420")]
		public void ChangeQuantity(int change)
		{
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A1")]
		[Address(RVA = "0x8C0570", Offset = "0x8BEF70", VA = "0x1808C0570", Slot = "14")]
		public virtual ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x8C05E0", Offset = "0x8BEFE0", VA = "0x1808C05E0", Slot = "15")]
		public virtual float GetMonetaryValue()
		{
			return 0f;
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A3")]
		[Address(RVA = "0x8C06C0", Offset = "0x8BF0C0", VA = "0x1808C06C0")]
		public void RequestClearSlot()
		{
		}

		// Token: 0x040030CF RID: 12495
		[Token(Token = "0x40030CF")]
		[FieldOffset(Offset = "0x10")]
		[CodegenExclude]
		protected ItemDefinition definition;

		// Token: 0x040030D0 RID: 12496
		[Token(Token = "0x40030D0")]
		[FieldOffset(Offset = "0x18")]
		public string ID;

		// Token: 0x040030D1 RID: 12497
		[Token(Token = "0x40030D1")]
		[FieldOffset(Offset = "0x20")]
		public int Quantity;

		// Token: 0x040030D2 RID: 12498
		[Token(Token = "0x40030D2")]
		[FieldOffset(Offset = "0x28")]
		[CodegenExclude]
		public Action onDataChanged;

		// Token: 0x040030D3 RID: 12499
		[Token(Token = "0x40030D3")]
		[FieldOffset(Offset = "0x30")]
		[CodegenExclude]
		public Action requestClearSlot;
	}
}
