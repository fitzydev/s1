using System;
using Il2CppDummyDll;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000650 RID: 1616
	[Token(Token = "0x2000650")]
	[Serializable]
	public class DialogueNodeData
	{
		// Token: 0x0600277C RID: 10108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4530", VA = "0x1806F5B30")]
		public DialogueNodeData GetCopy()
		{
			return null;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DialogueNodeData()
		{
		}

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		[FieldOffset(Offset = "0x10")]
		public string Guid;

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x18")]
		public string DialogueText;

		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		[FieldOffset(Offset = "0x20")]
		public string DialogueNodeLabel;

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 Position;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x30")]
		public DialogueChoiceData[] choices;

		// Token: 0x04001E43 RID: 7747
		[Token(Token = "0x4001E43")]
		[FieldOffset(Offset = "0x38")]
		public EVOLineType VoiceLine;
	}
}
