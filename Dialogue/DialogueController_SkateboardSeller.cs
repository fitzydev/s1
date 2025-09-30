using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	public class DialogueController_SkateboardSeller : DialogueController
	{
		// Token: 0x0600268B RID: 9867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Awake()
		{
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x6EF870", Offset = "0x6EE270", VA = "0x1806EF870", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x6EFEA0", Offset = "0x6EE8A0", VA = "0x1806EFEA0", Slot = "11")]
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x6EFC00", Offset = "0x6EE600", VA = "0x1806EFC00")]
		private List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options)
		{
			return null;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x6EF640", Offset = "0x6EE040", VA = "0x1806EF640", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x6EFFA0", Offset = "0x6EE9A0", VA = "0x1806EFFA0", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x6F00D0", Offset = "0x6EEAD0", VA = "0x1806F00D0")]
		public DialogueController_SkateboardSeller()
		{
		}

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		[FieldOffset(Offset = "0x80")]
		public List<DialogueController_SkateboardSeller.Option> Options;

		// Token: 0x04001DB4 RID: 7604
		[Token(Token = "0x4001DB4")]
		[FieldOffset(Offset = "0x88")]
		private DialogueController_SkateboardSeller.Option chosenWeapon;

		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent onPurchase;

		// Token: 0x0200061B RID: 1563
		[Token(Token = "0x200061B")]
		[Serializable]
		public class Option
		{
			// Token: 0x06002692 RID: 9874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002692")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Option()
			{
			}

			// Token: 0x04001DB6 RID: 7606
			[Token(Token = "0x4001DB6")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04001DB7 RID: 7607
			[Token(Token = "0x4001DB7")]
			[FieldOffset(Offset = "0x18")]
			public float Price;

			// Token: 0x04001DB8 RID: 7608
			[Token(Token = "0x4001DB8")]
			[FieldOffset(Offset = "0x1C")]
			public bool IsAvailable;

			// Token: 0x04001DB9 RID: 7609
			[Token(Token = "0x4001DB9")]
			[FieldOffset(Offset = "0x20")]
			public string NotAvailableReason;

			// Token: 0x04001DBA RID: 7610
			[Token(Token = "0x4001DBA")]
			[FieldOffset(Offset = "0x28")]
			public ItemDefinition Item;
		}
	}
}
