using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	[Serializable]
	public class DialogueChoiceData
	{
		// Token: 0x06002766 RID: 10086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x6E89B0", Offset = "0x6E73B0", VA = "0x1806E89B0")]
		public DialogueChoiceData GetCopy()
		{
			return null;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x6E8A40", Offset = "0x6E7440", VA = "0x1806E8A40")]
		public DialogueChoiceData()
		{
		}

		// Token: 0x04001E31 RID: 7729
		[Token(Token = "0x4001E31")]
		[FieldOffset(Offset = "0x10")]
		public string Guid;

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0x18")]
		public string ChoiceText;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0x20")]
		public string ChoiceLabel;

		// Token: 0x04001E34 RID: 7732
		[Token(Token = "0x4001E34")]
		[FieldOffset(Offset = "0x28")]
		public bool ShowWorldspaceDialogue;
	}
}
