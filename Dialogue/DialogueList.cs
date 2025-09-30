using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	[Serializable]
	public class DialogueList
	{
		// Token: 0x060026ED RID: 9965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x6F54F0", Offset = "0x6F3EF0", VA = "0x1806F54F0")]
		public string GetRandomLine()
		{
			return null;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DialogueList()
		{
		}

		// Token: 0x04001DE4 RID: 7652
		[Token(Token = "0x4001DE4")]
		[FieldOffset(Offset = "0x10")]
		public string[] Lines;
	}
}
