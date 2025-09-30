using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Variables
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	[Serializable]
	public class QuestCondition
	{
		// Token: 0x06000DF0 RID: 3568 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0xAADBE0", Offset = "0xAAC5E0", VA = "0x180AADBE0")]
		public bool Evaluate()
		{
			return default(bool);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0xAADE10", Offset = "0xAAC810", VA = "0x180AADE10")]
		public QuestCondition()
		{
		}

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x10")]
		public bool CheckQuestState;

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x18")]
		public string QuestName;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x20")]
		public EQuestState QuestState;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x24")]
		public bool CheckQuestEntryState;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x28")]
		public int QuestEntryIndex;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x2C")]
		public EQuestState QuestEntryState;
	}
}
