using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	public enum EQuestState
	{
		// Token: 0x0400106C RID: 4204
		[Token(Token = "0x400106C")]
		Inactive,
		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		Active,
		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		Completed,
		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		Failed,
		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		Expired,
		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		Cancelled
	}
}
