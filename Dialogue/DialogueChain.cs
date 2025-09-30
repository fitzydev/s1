using System;
using Il2CppDummyDll;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200062D RID: 1581
	[Token(Token = "0x200062D")]
	[Serializable]
	public class DialogueChain
	{
		// Token: 0x060026EF RID: 9967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x6E8920", Offset = "0x6E7320", VA = "0x1806E8920")]
		public MessageChain GetMessageChain()
		{
			return null;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DialogueChain()
		{
		}

		// Token: 0x04001DE5 RID: 7653
		[Token(Token = "0x4001DE5")]
		[FieldOffset(Offset = "0x10")]
		[TextArea(1, 10)]
		public string[] Lines;
	}
}
