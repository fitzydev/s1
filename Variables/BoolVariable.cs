using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	public class BoolVariable : Variable<bool>
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0xA9C700", Offset = "0xA9B100", VA = "0x180A9C700")]
		public BoolVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, bool value)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0xA9C650", Offset = "0xA9B050", VA = "0x180A9C650", Slot = "8")]
		public override bool TryDeserialize(string valueString, out bool value)
		{
			return default(bool);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0xA9C510", Offset = "0xA9AF10", VA = "0x180A9C510", Slot = "7")]
		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return default(bool);
		}
	}
}
