using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C64 RID: 3172
	[Token(Token = "0x2000C64")]
	public class VMSBoard : MonoBehaviour
	{
		// Token: 0x0600553D RID: 21821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553D")]
		[Address(RVA = "0x9DE7D0", Offset = "0x9DD1D0", VA = "0x1809DE7D0")]
		public void SetText(string text, Color col)
		{
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553E")]
		[Address(RVA = "0x9DE840", Offset = "0x9DD240", VA = "0x1809DE840")]
		public void SetText(string text)
		{
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600553F")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VMSBoard()
		{
		}

		// Token: 0x04003F3E RID: 16190
		[Token(Token = "0x4003F3E")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public TextMeshProUGUI Label;
	}
}
