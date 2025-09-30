using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Property;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	public class DialogueController_Fixer : DialogueController
	{
		// Token: 0x06002671 RID: 9841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x6ECC70", Offset = "0x6EB670", VA = "0x1806ECC70", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x6ED320", Offset = "0x6EBD20", VA = "0x1806ED320", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x6EC7F0", Offset = "0x6EB1F0", VA = "0x1806EC7F0", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x6ED5E0", Offset = "0x6EBFE0", VA = "0x1806ED5E0", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x6ED2A0", Offset = "0x6EBCA0", VA = "0x1806ED2A0", Slot = "14")]
		public override bool DecideBranch(string branchLabel, out int index)
		{
			return default(bool);
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x6ECFC0", Offset = "0x6EB9C0", VA = "0x1806ECFC0")]
		private void Confirm()
		{
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x6ED7B0", Offset = "0x6EC1B0", VA = "0x1806ED7B0")]
		public DialogueController_Fixer()
		{
		}

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		[FieldOffset(Offset = "0x80")]
		private EEmployeeType selectedEmployeeType;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0x88")]
		private Property selectedProperty;

		// Token: 0x04001DA5 RID: 7589
		[Token(Token = "0x4001DA5")]
		[FieldOffset(Offset = "0x90")]
		private bool lastConfirmationWasInitial;
	}
}
