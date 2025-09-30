using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000A02 RID: 2562
	[Token(Token = "0x2000A02")]
	public class ItemSlotSiblingSet
	{
		// Token: 0x0600461E RID: 17950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461E")]
		[Address(RVA = "0x8C5C20", Offset = "0x8C4620", VA = "0x1808C5C20")]
		public ItemSlotSiblingSet(params ItemSlot[] slots)
		{
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461F")]
		[Address(RVA = "0x8C5AC0", Offset = "0x8C44C0", VA = "0x1808C5AC0")]
		public ItemSlotSiblingSet(List<ItemSlot> slots)
		{
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004620")]
		[Address(RVA = "0x8C5970", Offset = "0x8C4370", VA = "0x1808C5970")]
		public void AddSlot(ItemSlot slot)
		{
		}

		// Token: 0x04003105 RID: 12549
		[Token(Token = "0x4003105")]
		[FieldOffset(Offset = "0x10")]
		public List<ItemSlot> Slots;
	}
}
