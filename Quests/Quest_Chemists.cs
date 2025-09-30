using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	public class Quest_Chemists : Quest_Employees
	{
		// Token: 0x060010FF RID: 4351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0xADD1D0", Offset = "0xADBBD0", VA = "0x180ADD1D0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001100")]
		[Address(RVA = "0xADD150", Offset = "0xADBB50", VA = "0x180ADD150", Slot = "56")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001101")]
		[Address(RVA = "0xADCF30", Offset = "0xADB930", VA = "0x180ADCF30")]
		public Quest_Chemists()
		{
		}

		// Token: 0x040010D8 RID: 4312
		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignWorkEntry;
	}
}
