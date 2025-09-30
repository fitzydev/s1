using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	public interface ITransitEntity
	{
		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060019A1 RID: 6561
		[Token(Token = "0x17000482")]
		string Name
		{
			[Token(Token = "0x60019A1")]
			get;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060019A2 RID: 6562
		// (set) Token: 0x060019A3 RID: 6563
		[Token(Token = "0x17000483")]
		List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60019A2")]
			get;
			[Token(Token = "0x60019A3")]
			set;
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060019A4 RID: 6564
		// (set) Token: 0x060019A5 RID: 6565
		[Token(Token = "0x17000484")]
		List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60019A4")]
			get;
			[Token(Token = "0x60019A5")]
			set;
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060019A6 RID: 6566
		[Token(Token = "0x17000485")]
		Transform LinkOrigin
		{
			[Token(Token = "0x60019A6")]
			get;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060019A7 RID: 6567
		[Token(Token = "0x17000486")]
		Transform[] AccessPoints
		{
			[Token(Token = "0x60019A7")]
			get;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060019A8 RID: 6568
		[Token(Token = "0x17000487")]
		bool Selectable
		{
			[Token(Token = "0x60019A8")]
			get;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060019A9 RID: 6569
		[Token(Token = "0x17000488")]
		bool IsAcceptingItems
		{
			[Token(Token = "0x60019A9")]
			get;
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060019AA RID: 6570
		[Token(Token = "0x17000489")]
		bool IsDestroyed
		{
			[Token(Token = "0x60019AA")]
			get;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060019AB RID: 6571
		[Token(Token = "0x1700048A")]
		Guid GUID
		{
			[Token(Token = "0x60019AB")]
			get;
		}

		// Token: 0x060019AC RID: 6572
		[Token(Token = "0x60019AC")]
		void ShowOutline(Color color);

		// Token: 0x060019AD RID: 6573
		[Token(Token = "0x60019AD")]
		void HideOutline();

		// Token: 0x060019AE RID: 6574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x636330", Offset = "0x634D30", VA = "0x180636330", Slot = "13")]
		void InsertItemIntoInput(ItemInstance item, [Optional] NPC inserter)
		{
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x6366A0", Offset = "0x6350A0", VA = "0x1806366A0", Slot = "14")]
		void InsertItemIntoOutput(ItemInstance item, [Optional] NPC inserter)
		{
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x635AF0", Offset = "0x6344F0", VA = "0x180635AF0", Slot = "15")]
		int GetInputCapacityForItem(ItemInstance item, [Optional] NPC asker, bool checkPlayerFilters = true)
		{
			return 0;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x635E90", Offset = "0x634890", VA = "0x180635E90", Slot = "16")]
		int GetOutputCapacityForItem(ItemInstance item, [Optional] NPC asker)
		{
			return 0;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x636230", Offset = "0x634C30", VA = "0x180636230", Slot = "17")]
		ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			return null;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x636C90", Offset = "0x635690", VA = "0x180636C90", Slot = "18")]
		List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			return null;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x636A00", Offset = "0x635400", VA = "0x180636A00", Slot = "19")]
		void RemoveSlotLocks(NetworkObject locker)
		{
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x635560", Offset = "0x633F60", VA = "0x180635560", Slot = "20")]
		ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType)
		{
			return null;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x635820", Offset = "0x634220", VA = "0x180635820", Slot = "21")]
		ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType)
		{
			return null;
		}

		// Token: 0x020004EE RID: 1262
		[Token(Token = "0x20004EE")]
		public enum ESlotType
		{
			// Token: 0x0400165C RID: 5724
			[Token(Token = "0x400165C")]
			Input,
			// Token: 0x0400165D RID: 5725
			[Token(Token = "0x400165D")]
			Output,
			// Token: 0x0400165E RID: 5726
			[Token(Token = "0x400165E")]
			Both
		}
	}
}
