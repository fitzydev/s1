using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	[Serializable]
	public class QuestStateSetter
	{
		// Token: 0x06001174 RID: 4468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x59C860", Offset = "0x59B260", VA = "0x18059C860")]
		public void Execute()
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public QuestStateSetter()
		{
		}

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x10")]
		public string QuestName;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x18")]
		public bool SetQuestState;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x1C")]
		public QuestManager.EQuestAction QuestState;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x20")]
		public bool SetQuestEntryState;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x24")]
		public int QuestEntryIndex;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x28")]
		public EQuestState QuestEntryState;
	}
}
