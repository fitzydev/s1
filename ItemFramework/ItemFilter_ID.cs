using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009EC RID: 2540
	[Token(Token = "0x20009EC")]
	public class ItemFilter_ID : ItemFilter
	{
		// Token: 0x0600456F RID: 17775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x8BFCE0", Offset = "0x8BE6E0", VA = "0x1808BFCE0")]
		public ItemFilter_ID(List<string> ids)
		{
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x8BFC50", Offset = "0x8BE650", VA = "0x1808BFC50", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x040030B1 RID: 12465
		[Token(Token = "0x40030B1")]
		[FieldOffset(Offset = "0x10")]
		public bool IsWhitelist;

		// Token: 0x040030B2 RID: 12466
		[Token(Token = "0x40030B2")]
		[FieldOffset(Offset = "0x18")]
		public List<string> IDs;
	}
}
