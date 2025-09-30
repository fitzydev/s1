using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Clothing;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009EA RID: 2538
	[Token(Token = "0x20009EA")]
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x000123C0 File Offset: 0x000105C0
		// (set) Token: 0x06004569 RID: 17769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AA")]
		public EClothingSlot SlotType
		{
			[Token(Token = "0x6004568")]
			[Address(RVA = "0x42D220", Offset = "0x42BC20", VA = "0x18042D220")]
			[CompilerGenerated]
			get
			{
				return EClothingSlot.Feet;
			}
			[Token(Token = "0x6004569")]
			[Address(RVA = "0x493F90", Offset = "0x492990", VA = "0x180493F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456A")]
		[Address(RVA = "0x436F80", Offset = "0x435980", VA = "0x180436F80")]
		public ItemFilter_ClothingSlot(EClothingSlot slot)
		{
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x600456B")]
		[Address(RVA = "0x8BF760", Offset = "0x8BE160", VA = "0x1808BF760", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}
	}
}
