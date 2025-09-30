using System;
using Il2CppDummyDll;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	public class DialogueController_Ming : DialogueController
	{
		// Token: 0x06002678 RID: 9848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x6EE790", Offset = "0x6ED190", VA = "0x1806EE790", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x6EE180", Offset = "0x6ECB80", VA = "0x1806EE180")]
		private bool CanBuyRoom(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x6EE5D0", Offset = "0x6ECFD0", VA = "0x1806EE5D0", Slot = "10")]
		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x6EE6B0", Offset = "0x6ED0B0", VA = "0x1806EE6B0", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x6EE310", Offset = "0x6ECD10", VA = "0x1806EE310", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x6EE430", Offset = "0x6ECE30", VA = "0x1806EE430", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x6EEAA0", Offset = "0x6ED4A0", VA = "0x1806EEAA0")]
		public DialogueController_Ming()
		{
		}

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0x80")]
		public Property Property;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[FieldOffset(Offset = "0x88")]
		public float Price;

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		[FieldOffset(Offset = "0x90")]
		public DialogueContainer BuyDialogue;

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x98")]
		public string BuyText;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[FieldOffset(Offset = "0xA0")]
		public string RemindText;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[FieldOffset(Offset = "0xA8")]
		public DialogueContainer RemindLocationDialogue;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		[FieldOffset(Offset = "0xB0")]
		public QuestEntry[] PurchaseRoomQuests;

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onPurchase;
	}
}
