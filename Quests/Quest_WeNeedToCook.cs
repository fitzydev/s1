using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	public class Quest_WeNeedToCook : Quest
	{
		// Token: 0x06001172 RID: 4466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x5A0B30", Offset = "0x59F530", VA = "0x1805A0B30", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x5A0BE0", Offset = "0x59F5E0", VA = "0x1805A0BE0")]
		public Quest_WeNeedToCook()
		{
		}

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x138")]
		public Quest[] PrerequisiteQuests;

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x140")]
		public Supplier MethSupplier;
	}
}
