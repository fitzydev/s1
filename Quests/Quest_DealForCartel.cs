using System;
using Il2CppDummyDll;
using ScheduleOne.Cartel;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	public class Quest_DealForCartel : Quest
	{
		// Token: 0x06001109 RID: 4361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001109")]
		[Address(RVA = "0xADE8E0", Offset = "0xADD2E0", VA = "0x180ADE8E0")]
		public void Initialize(CartelDealInfo dealInfo)
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110A")]
		[Address(RVA = "0xADEBC0", Offset = "0xADD5C0", VA = "0x180ADEBC0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110B")]
		[Address(RVA = "0xADEC50", Offset = "0xADD650", VA = "0x180ADEC50")]
		private void UpdateTimingLabel()
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110C")]
		[Address(RVA = "0xADEBF0", Offset = "0xADD5F0", VA = "0x180ADEBF0")]
		public void NotifyDealCompleted()
		{
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110D")]
		[Address(RVA = "0xADF090", Offset = "0xADDA90", VA = "0x180ADF090")]
		public Quest_DealForCartel()
		{
		}

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry MainEntry;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x140")]
		private CartelDealInfo dealInfo;
	}
}
