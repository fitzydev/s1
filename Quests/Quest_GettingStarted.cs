using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FD RID: 765
	[Token(Token = "0x20002FD")]
	public class Quest_GettingStarted : Quest
	{
		// Token: 0x06001128 RID: 4392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x59DE30", Offset = "0x59C830", VA = "0x18059DE30", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x59DE40", Offset = "0x59C840", VA = "0x18059DE40", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x59DE50", Offset = "0x59C850", VA = "0x18059DE50")]
		public Quest_GettingStarted()
		{
		}

		// Token: 0x040010F4 RID: 4340
		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x138")]
		public float CashAmount;

		// Token: 0x040010F5 RID: 4341
		[Token(Token = "0x40010F5")]
		[FieldOffset(Offset = "0x140")]
		public DeadDrop CashDrop;

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x148")]
		public UncleNelson Nelson;
	}
}
