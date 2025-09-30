using System;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009ED RID: 2541
	[Token(Token = "0x20009ED")]
	public class ItemFilter_LegalStatus : ItemFilter
	{
		// Token: 0x06004571 RID: 17777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x436F80", Offset = "0x435980", VA = "0x180436F80")]
		public ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus)
		{
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x8BFD80", Offset = "0x8BE780", VA = "0x1808BFD80", Slot = "4")]
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x040030B3 RID: 12467
		[Token(Token = "0x40030B3")]
		[FieldOffset(Offset = "0x10")]
		public ELegalStatus RequiredLegalStatus;
	}
}
