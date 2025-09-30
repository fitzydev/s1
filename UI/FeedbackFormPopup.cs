using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A9B RID: 2715
	[Token(Token = "0x2000A9B")]
	public class FeedbackFormPopup : MonoBehaviour
	{
		// Token: 0x060049E0 RID: 18912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x915380", Offset = "0x913D80", VA = "0x180915380")]
		public void Open(string text)
		{
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x6FE5D0", Offset = "0x6FCFD0", VA = "0x1806FE5D0")]
		public void Close()
		{
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x915440", Offset = "0x913E40", VA = "0x180915440")]
		private void Update()
		{
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E3")]
		[Address(RVA = "0x83BAD0", Offset = "0x83A4D0", VA = "0x18083BAD0")]
		public FeedbackFormPopup()
		{
		}

		// Token: 0x040034AA RID: 13482
		[Token(Token = "0x40034AA")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		// Token: 0x040034AB RID: 13483
		[Token(Token = "0x40034AB")]
		[FieldOffset(Offset = "0x28")]
		public bool AutoClose;

		// Token: 0x040034AC RID: 13484
		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0x2C")]
		private float closeTime;
	}
}
