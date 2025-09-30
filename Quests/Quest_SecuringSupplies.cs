using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	public class Quest_SecuringSupplies : Quest
	{
		// Token: 0x06001134 RID: 4404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x59E7E0", Offset = "0x59D1E0", VA = "0x18059E7E0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x59E800", Offset = "0x59D200", VA = "0x18059E800")]
		public Quest_SecuringSupplies()
		{
		}

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x138")]
		public Supplier Supplier;
	}
}
