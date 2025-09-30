using System;
using Il2CppDummyDll;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	[Serializable]
	public class SystemTrigger
	{
		// Token: 0x0600117C RID: 4476 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x5A3180", Offset = "0x5A1B80", VA = "0x1805A3180")]
		public bool Trigger()
		{
			return default(bool);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117D")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public SystemTrigger()
		{
		}

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x10")]
		public Conditions Conditions;

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x18")]
		[Header("True")]
		public VariableSetter[] onEvaluateTrueVariableSetters;

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0x20")]
		public QuestStateSetter[] onEvaluateTrueQuestSetters;

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onEvaluateTrue;

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x30")]
		[Header("False")]
		public VariableSetter[] onEvaluateFalseVariableSetters;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x38")]
		public QuestStateSetter[] onEvaluateFalseQuestSetters;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onEvaluateFalse;
	}
}
