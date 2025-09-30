using System;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F0 RID: 2544
	[Token(Token = "0x20009F0")]
	public class ItemFilter_UnpackagedProduct : ItemFilter_Category
	{
		// Token: 0x06004577 RID: 17783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x8C0210", Offset = "0x8BEC10", VA = "0x1808C0210")]
		public ItemFilter_UnpackagedProduct()
		{
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x8C00F0", Offset = "0x8BEAF0", VA = "0x1808C00F0", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}
	}
}
