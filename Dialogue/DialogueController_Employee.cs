using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Property;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000629 RID: 1577
	[Token(Token = "0x2000629")]
	public class DialogueController_Employee : DialogueController
	{
		// Token: 0x060026DD RID: 9949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Awake()
		{
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x6EBC20", Offset = "0x6EA620", VA = "0x1806EBC20", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x6EC480", Offset = "0x6EAE80", VA = "0x1806EC480", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x6EBE40", Offset = "0x6EA840", VA = "0x1806EBE40")]
		private List<DialogueChoiceData> GetChoices()
		{
			return null;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x6EC3F0", Offset = "0x6EADF0", VA = "0x1806EC3F0")]
		private Property GetPropertyByCode(string code)
		{
			return null;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x6EBB30", Offset = "0x6EA530", VA = "0x1806EBB30", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x6EC580", Offset = "0x6EAF80", VA = "0x1806EC580", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x6EC7A0", Offset = "0x6EB1A0", VA = "0x1806EC7A0")]
		public DialogueController_Employee()
		{
		}

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[FieldOffset(Offset = "0x80")]
		private Property selectedProperty;
	}
}
