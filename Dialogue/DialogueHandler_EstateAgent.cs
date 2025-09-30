using System;
using Il2CppDummyDll;
using ScheduleOne.Property;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	public class DialogueHandler_EstateAgent : ControlledDialogueHandler
	{
		// Token: 0x06002735 RID: 10037 RVA: 0x0000C150 File Offset: 0x0000A350
		[Token(Token = "0x6002735")]
		[Address(RVA = "0x6F1E50", Offset = "0x6F0850", VA = "0x1806F1E50", Slot = "9")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0000C168 File Offset: 0x0000A368
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x6F2B10", Offset = "0x6F1510", VA = "0x1806F2B10", Slot = "10")]
		public override bool ShouldChoiceBeShown(string choiceLabel)
		{
			return default(bool);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x6F2190", Offset = "0x6F0B90", VA = "0x1806F2190", Slot = "14")]
		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x6F23F0", Offset = "0x6F0DF0", VA = "0x1806F23F0", Slot = "15")]
		protected override void DialogueCallback(string choiceLabel)
		{
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x6F29C0", Offset = "0x6F13C0", VA = "0x1806F29C0", Slot = "12")]
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x6F2650", Offset = "0x6F1050", VA = "0x1806F2650", Slot = "13")]
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x6E8600", Offset = "0x6E7000", VA = "0x1806E8600")]
		public DialogueHandler_EstateAgent()
		{
		}

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[FieldOffset(Offset = "0xB8")]
		private Property selectedProperty;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[FieldOffset(Offset = "0xC0")]
		private Business selectedBusiness;
	}
}
