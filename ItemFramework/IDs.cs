using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009E7 RID: 2535
	[Token(Token = "0x20009E7")]
	public class IDs : ItemFilter
	{
		// Token: 0x06004562 RID: 17762 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x8BEBB0", Offset = "0x8BD5B0", VA = "0x1808BEBB0", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x8BEC10", Offset = "0x8BD610", VA = "0x1808BEC10")]
		public IDs()
		{
		}

		// Token: 0x040030AE RID: 12462
		[Token(Token = "0x40030AE")]
		[FieldOffset(Offset = "0x10")]
		public List<string> AcceptedIDs;
	}
}
