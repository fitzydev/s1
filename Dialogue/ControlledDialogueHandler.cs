using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000620 RID: 1568
	[Token(Token = "0x2000620")]
	public class ControlledDialogueHandler : DialogueHandler
	{
		// Token: 0x060026A2 RID: 9890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x6E8210", Offset = "0x6E6C10", VA = "0x1806E8210", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x6E85D0", Offset = "0x6E6FD0", VA = "0x1806E85D0", Slot = "12")]
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x6E85A0", Offset = "0x6E6FA0", VA = "0x1806E85A0", Slot = "13")]
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x6E8570", Offset = "0x6E6F70", VA = "0x1806E8570", Slot = "16")]
		protected override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x6E84F0", Offset = "0x6E6EF0", VA = "0x1806E84F0", Slot = "14")]
		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x6E8270", Offset = "0x6E6C70", VA = "0x1806E8270", Slot = "11")]
		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x6E8410", Offset = "0x6E6E10", VA = "0x1806E8410", Slot = "9")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x6E8600", Offset = "0x6E7000", VA = "0x1806E8600")]
		public ControlledDialogueHandler()
		{
		}

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0xB0")]
		private DialogueController controller;
	}
}
