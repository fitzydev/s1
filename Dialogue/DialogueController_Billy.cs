using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	public class DialogueController_Billy : DialogueController
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x6EA8D0", Offset = "0x6E92D0", VA = "0x1806EA8D0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x6EA840", Offset = "0x6E9240", VA = "0x1806EA840", Slot = "9")]
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x6EAB80", Offset = "0x6E9580", VA = "0x1806EAB80")]
		public DialogueController_Billy()
		{
		}

		// Token: 0x04001D9F RID: 7583
		[Token(Token = "0x4001D9F")]
		[FieldOffset(Offset = "0x80")]
		private Quest_DefeatCartel questDefeatCartel;
	}
}
