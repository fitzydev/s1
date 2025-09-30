using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	public class Quest_GearingUp : Quest
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x59DD30", Offset = "0x59C730", VA = "0x18059DD30", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x59DA50", Offset = "0x59C450", VA = "0x18059DA50", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x59DA00", Offset = "0x59C400", VA = "0x18059DA00")]
		private void DropReady()
		{
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x59DDE0", Offset = "0x59C7E0", VA = "0x18059DDE0")]
		public Quest_GearingUp()
		{
		}

		// Token: 0x040010EE RID: 4334
		[Token(Token = "0x40010EE")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry WaitForDropEntry;

		// Token: 0x040010EF RID: 4335
		[Token(Token = "0x40010EF")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry CollectDropEntry;

		// Token: 0x040010F0 RID: 4336
		[Token(Token = "0x40010F0")]
		[FieldOffset(Offset = "0x148")]
		public Supplier Supplier;

		// Token: 0x040010F1 RID: 4337
		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x150")]
		private bool setCollectionPosition;
	}
}
