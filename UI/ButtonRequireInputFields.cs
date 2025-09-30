using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000B08 RID: 2824
	[Token(Token = "0x2000B08")]
	public class ButtonRequireInputFields : MonoBehaviour
	{
		// Token: 0x06004CBB RID: 19643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0x92BC20", Offset = "0x92A620", VA = "0x18092BC20")]
		public void Update()
		{
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBC")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ButtonRequireInputFields()
		{
		}

		// Token: 0x04003790 RID: 14224
		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x20")]
		public List<ButtonRequireInputFields.Input> Inputs;

		// Token: 0x04003791 RID: 14225
		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0x28")]
		public TMP_Dropdown Dropdown;

		// Token: 0x04003792 RID: 14226
		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x30")]
		public Button Button;

		// Token: 0x02000B09 RID: 2825
		[Token(Token = "0x2000B09")]
		[Serializable]
		public class Input
		{
			// Token: 0x06004CBD RID: 19645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CBD")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Input()
			{
			}

			// Token: 0x04003793 RID: 14227
			[Token(Token = "0x4003793")]
			[FieldOffset(Offset = "0x10")]
			public TMP_InputField InputField;

			// Token: 0x04003794 RID: 14228
			[Token(Token = "0x4003794")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform ErrorMessage;
		}
	}
}
