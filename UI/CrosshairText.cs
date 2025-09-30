using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A87 RID: 2695
	[Token(Token = "0x2000A87")]
	public class CrosshairText : MonoBehaviour
	{
		// Token: 0x06004947 RID: 18759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004947")]
		[Address(RVA = "0x8EEA50", Offset = "0x8ED450", VA = "0x1808EEA50")]
		private void Awake()
		{
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x9060C0", Offset = "0x904AC0", VA = "0x1809060C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004949")]
		[Address(RVA = "0x906100", Offset = "0x904B00", VA = "0x180906100")]
		public void Show(string text, [Optional] Color col)
		{
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x8EEA50", Offset = "0x8ED450", VA = "0x1808EEA50")]
		public void Hide()
		{
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600494B")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CrosshairText()
		{
		}

		// Token: 0x04003429 RID: 13353
		[Token(Token = "0x4003429")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		// Token: 0x0400342A RID: 13354
		[Token(Token = "0x400342A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool setThisFrame;
	}
}
