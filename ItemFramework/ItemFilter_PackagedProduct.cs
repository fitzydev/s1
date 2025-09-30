using System;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009EF RID: 2543
	[Token(Token = "0x20009EF")]
	public class ItemFilter_PackagedProduct : ItemFilter_Category
	{
		// Token: 0x06004575 RID: 17781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x8C0010", Offset = "0x8BEA10", VA = "0x1808C0010")]
		public ItemFilter_PackagedProduct()
		{
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x8BFEF0", Offset = "0x8BE8F0", VA = "0x1808BFEF0", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}
	}
}
