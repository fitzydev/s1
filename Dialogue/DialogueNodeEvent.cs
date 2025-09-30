using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000632 RID: 1586
	[Token(Token = "0x2000632")]
	[Serializable]
	public class DialogueNodeEvent
	{
		// Token: 0x060026FD RID: 9981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DialogueNodeEvent()
		{
		}

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[FieldOffset(Offset = "0x10")]
		public string NodeLabel;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent onNodeDisplayed;
	}
}
