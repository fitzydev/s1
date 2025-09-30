using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	public class Quest_Packagers : Quest_Employees
	{
		// Token: 0x06001131 RID: 4401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x59E4F0", Offset = "0x59CEF0", VA = "0x18059E4F0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x59E470", Offset = "0x59CE70", VA = "0x18059E470", Slot = "56")]
		public override List<Employee> GetEmployees()
		{
			return null;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x59D730", Offset = "0x59C130", VA = "0x18059D730")]
		public Quest_Packagers()
		{
		}

		// Token: 0x040010FC RID: 4348
		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry AssignWorkEntry;
	}
}
