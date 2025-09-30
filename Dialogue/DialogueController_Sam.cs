using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000618 RID: 1560
	[Token(Token = "0x2000618")]
	public class DialogueController_Sam : DialogueController
	{
		// Token: 0x06002683 RID: 9859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x6EF340", Offset = "0x6EDD40", VA = "0x1806EF340", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x6EF050", Offset = "0x6EDA50", VA = "0x1806EF050", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x6EF270", Offset = "0x6EDC70", VA = "0x1806EF270", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x6EF170", Offset = "0x6EDB70", VA = "0x1806EF170", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002687")]
		[Address(RVA = "0x6EF5F0", Offset = "0x6EDFF0", VA = "0x1806EF5F0")]
		public DialogueController_Sam()
		{
		}

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[FieldOffset(Offset = "0x80")]
		private Quest_DefeatCartel questDefeatCartel;
	}
}
