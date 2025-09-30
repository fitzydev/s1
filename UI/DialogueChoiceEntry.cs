using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A92 RID: 2706
	[Token(Token = "0x2000A92")]
	[Serializable]
	public class DialogueChoiceEntry
	{
		// Token: 0x0600499E RID: 18846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499E")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DialogueChoiceEntry()
		{
		}

		// Token: 0x04003473 RID: 13427
		[Token(Token = "0x4003473")]
		[FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		// Token: 0x04003474 RID: 13428
		[Token(Token = "0x4003474")]
		[FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI text;

		// Token: 0x04003475 RID: 13429
		[Token(Token = "0x4003475")]
		[FieldOffset(Offset = "0x20")]
		public Button button;

		// Token: 0x04003476 RID: 13430
		[Token(Token = "0x4003476")]
		[FieldOffset(Offset = "0x28")]
		public GameObject notPossibleGameObject;

		// Token: 0x04003477 RID: 13431
		[Token(Token = "0x4003477")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI notPossibleText;

		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup canvasGroup;
	}
}
