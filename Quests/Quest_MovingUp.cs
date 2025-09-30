using System;
using Il2CppDummyDll;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	public class Quest_MovingUp : Quest
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x59DEB0", Offset = "0x59C8B0", VA = "0x18059DEB0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x59DFD0", Offset = "0x59C9D0", VA = "0x18059DFD0")]
		public Quest_MovingUp()
		{
		}

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry ReachCustomersEntry;
	}
}
