using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	[Serializable]
	public class DialogueEvent
	{
		// Token: 0x060026FC RID: 9980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DialogueEvent()
		{
		}

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[FieldOffset(Offset = "0x10")]
		public DialogueContainer Dialogue;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent onDialogueEnded;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[FieldOffset(Offset = "0x20")]
		public DialogueNodeEvent[] NodeEvents;
	}
}
