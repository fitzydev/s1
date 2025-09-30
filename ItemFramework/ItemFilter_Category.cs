using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009E9 RID: 2537
	[Token(Token = "0x20009E9")]
	public class ItemFilter_Category : ItemFilter
	{
		// Token: 0x06004566 RID: 17766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004566")]
		[Address(RVA = "0x8BF6C0", Offset = "0x8BE0C0", VA = "0x1808BF6C0")]
		public ItemFilter_Category(List<EItemCategory> acceptedCategories)
		{
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x000123A8 File Offset: 0x000105A8
		[Token(Token = "0x6004567")]
		[Address(RVA = "0x8BF640", Offset = "0x8BE040", VA = "0x1808BF640", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x040030AF RID: 12463
		[Token(Token = "0x40030AF")]
		[FieldOffset(Offset = "0x10")]
		public List<EItemCategory> AcceptedCategories;
	}
}
