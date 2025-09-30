using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Economy;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000628 RID: 1576
	[Token(Token = "0x2000628")]
	public class DialogueController_Dealer : DialogueController
	{
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064E")]
		public Dealer Dealer
		{
			[Token(Token = "0x60026D5")]
			[Address(RVA = "0x506BA0", Offset = "0x5055A0", VA = "0x180506BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026D6")]
			[Address(RVA = "0x592AE0", Offset = "0x5914E0", VA = "0x180592AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x6EBA40", Offset = "0x6EA440", VA = "0x1806EBA40", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x6EB7A0", Offset = "0x6EA1A0", VA = "0x1806EB7A0", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x6EB670", Offset = "0x6EA070", VA = "0x1806EB670", Slot = "10")]
		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x6EB410", Offset = "0x6E9E10", VA = "0x1806EB410", Slot = "13")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x6EB550", Offset = "0x6E9F50", VA = "0x1806EB550", Slot = "12")]
		public override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x6EBAD0", Offset = "0x6EA4D0", VA = "0x1806EBAD0")]
		public DialogueController_Dealer()
		{
		}
	}
}
