using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x20002F4")]
	public class Quest_Cleaners : Quest_Employees
	{
		// Token: 0x06001104 RID: 4356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001104")]
		[Address(RVA = "0xADD830", Offset = "0xADC230", VA = "0x180ADD830", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001105")]
		[Address(RVA = "0xADD7B0", Offset = "0xADC1B0", VA = "0x180ADD7B0", Slot = "56")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001106")]
		[Address(RVA = "0xADCF30", Offset = "0xADB930", VA = "0x180ADCF30")]
		public Quest_Cleaners()
		{
		}

		// Token: 0x040010DB RID: 4315
		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignWorkEntry;
	}
}
