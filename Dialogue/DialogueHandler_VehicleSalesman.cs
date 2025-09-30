using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200063F RID: 1599
	[Token(Token = "0x200063F")]
	public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600274E")]
		[Address(RVA = "0x6F4FD0", Offset = "0x6F39D0", VA = "0x1806F4FD0", Slot = "13")]
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x600274F")]
		[Address(RVA = "0x6F4AA0", Offset = "0x6F34A0", VA = "0x1806F4AA0", Slot = "9")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002750")]
		[Address(RVA = "0x6F4C50", Offset = "0x6F3650", VA = "0x1806F4C50", Slot = "14")]
		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x6F49D0", Offset = "0x6F33D0", VA = "0x1806F49D0", Slot = "11")]
		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x6F4FC0", Offset = "0x6F39C0", VA = "0x1806F4FC0", Slot = "15")]
		protected override void DialogueCallback(string choiceLabel)
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x6F51E0", Offset = "0x6F3BE0", VA = "0x1806F51E0", Slot = "12")]
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x6E8600", Offset = "0x6E7000", VA = "0x1806E8600")]
		public DialogueHandler_VehicleSalesman()
		{
		}

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0xB8")]
		public Jeremy Salesman;

		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		[FieldOffset(Offset = "0xC0")]
		public Jeremy.DealershipListing selectedVehicle;
	}
}
