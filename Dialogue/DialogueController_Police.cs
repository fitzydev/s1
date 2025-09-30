using System;
using Il2CppDummyDll;
using ScheduleOne.Police;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200062A RID: 1578
	[Token(Token = "0x200062A")]
	public class DialogueController_Police : DialogueController
	{
		// Token: 0x060026E6 RID: 9958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x6EEF20", Offset = "0x6ED920", VA = "0x1806EEF20", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x6EEE80", Offset = "0x6ED880", VA = "0x1806EEE80", Slot = "8")]
		public override bool CanStartDialogue()
		{
			return default(bool);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x6EF000", Offset = "0x6EDA00", VA = "0x1806EF000")]
		public DialogueController_Police()
		{
		}

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		[FieldOffset(Offset = "0x80")]
		private PoliceOfficer officer;
	}
}
