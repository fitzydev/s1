using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Doors
{
	// Token: 0x02000600 RID: 1536
	[Token(Token = "0x2000600")]
	public class DealerStaticDoor : StaticDoor
	{
		// Token: 0x060025F3 RID: 9715 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x60025F3")]
		[Address(RVA = "0x6E86F0", Offset = "0x6E70F0", VA = "0x1806E86F0", Slot = "9")]
		protected override bool IsKnockValid(out string message)
		{
			return default(bool);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x6E8900", Offset = "0x6E7300", VA = "0x1806E8900")]
		public DealerStaticDoor()
		{
		}

		// Token: 0x04001D39 RID: 7481
		[Token(Token = "0x4001D39")]
		[FieldOffset(Offset = "0x50")]
		public Dealer Dealer;
	}
}
