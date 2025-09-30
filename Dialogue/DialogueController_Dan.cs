using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	public class DialogueController_Dan : DialogueController
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x6EB310", Offset = "0x6E9D10", VA = "0x1806EB310", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x6EB200", Offset = "0x6E9C00", VA = "0x1806EB200", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x6EB3C0", Offset = "0x6E9DC0", VA = "0x1806EB3C0")]
		public DialogueController_Dan()
		{
		}

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0x80")]
		public ItemDefinition ItemToGive;
	}
}
