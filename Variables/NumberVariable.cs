using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	public class NumberVariable : Variable<float>
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0xAAC9E0", Offset = "0xAAB3E0", VA = "0x180AAC9E0")]
		public NumberVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, float value)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0xAAC990", Offset = "0xAAB390", VA = "0x180AAC990", Slot = "8")]
		public override bool TryDeserialize(string valueString, out float value)
		{
			return default(bool);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0xAAC7B0", Offset = "0xAAB1B0", VA = "0x180AAC7B0", Slot = "7")]
		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return default(bool);
		}
	}
}
