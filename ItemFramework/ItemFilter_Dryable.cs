using System;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009EB RID: 2539
	[Token(Token = "0x20009EB")]
	public class ItemFilter_Dryable : ItemFilter
	{
		// Token: 0x0600456C RID: 17772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456C")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public ItemFilter_Dryable()
		{
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x000123F0 File Offset: 0x000105F0
		[Token(Token = "0x600456D")]
		[Address(RVA = "0x8BF890", Offset = "0x8BE290", VA = "0x1808BF890", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x8BFA70", Offset = "0x8BE470", VA = "0x1808BFA70")]
		public static bool IsItemDryable(ItemInstance instance)
		{
			return default(bool);
		}
	}
}
