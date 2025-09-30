using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	public class Quest_Botanists : Quest_Employees
	{
		// Token: 0x060010FC RID: 4348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0xADC620", Offset = "0xADB020", VA = "0x180ADC620", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0xADC5A0", Offset = "0xADAFA0", VA = "0x180ADC5A0", Slot = "56")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0xADCF30", Offset = "0xADB930", VA = "0x180ADCF30")]
		public Quest_Botanists()
		{
		}

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignSuppliesEntry;

		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x158")]
		public QuestEntry AssignWorkEntry;

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x160")]
		public QuestEntry AssignDestinationEntry;
	}
}
