using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	public abstract class Quest_Employees : Quest
	{
		// Token: 0x0600111A RID: 4378
		[Token(Token = "0x600111A")]
		public abstract List<Employee> GetEmployees();

		// Token: 0x0600111B RID: 4379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x59D690", Offset = "0x59C090", VA = "0x18059D690", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x59D3C0", Offset = "0x59BDC0", VA = "0x18059D3C0")]
		protected bool AreAnyEmployeesAssignedBeds()
		{
			return default(bool);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x59D550", Offset = "0x59BF50", VA = "0x18059D550")]
		protected bool AreAnyEmployeesPaid()
		{
			return default(bool);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x59D730", Offset = "0x59C130", VA = "0x18059D730")]
		protected Quest_Employees()
		{
		}

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x138")]
		public EEmployeeType EmployeeType;

		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry AssignBedEntry;

		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x148")]
		public QuestEntry PayEntry;
	}
}
