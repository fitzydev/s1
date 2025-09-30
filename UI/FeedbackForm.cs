using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AeLa.EasyFeedback;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	public class FeedbackForm : FeedbackForm
	{
		// Token: 0x060049C5 RID: 18885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x90C640", Offset = "0x90B040", VA = "0x18090C640", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C6")]
		[Address(RVA = "0x90D900", Offset = "0x90C300", VA = "0x18090D900")]
		private void Update()
		{
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C7")]
		[Address(RVA = "0x90C9E0", Offset = "0x90B3E0", VA = "0x18090C9E0")]
		public void PrepScreenshot()
		{
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C8")]
		[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
		private void OnScreenshotToggle(bool value)
		{
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C9")]
		[Address(RVA = "0x5CD9F0", Offset = "0x5CC3F0", VA = "0x1805CD9F0")]
		private void OnSaveFileToggle(bool value)
		{
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CA")]
		[Address(RVA = "0x90CC10", Offset = "0x90B610", VA = "0x18090CC10")]
		public void SetFormData(string title)
		{
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CB")]
		[Address(RVA = "0x90CAB0", Offset = "0x90B4B0", VA = "0x18090CAB0")]
		public void SetCategory(string categoryName)
		{
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x90CCF0", Offset = "0x90B6F0", VA = "0x18090CCF0", Slot = "5")]
		public override void Submit()
		{
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x90C870", Offset = "0x90B270", VA = "0x18090C870", Slot = "6")]
		protected override string GetTextToAppendToTitle()
		{
			return null;
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x90C7F0", Offset = "0x90B1F0", VA = "0x18090C7F0")]
		private void Clear()
		{
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x90CA40", Offset = "0x90B440", VA = "0x18090CA40")]
		private IEnumerator ScreenshotAndOpenForm()
		{
			return null;
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x90D9B0", Offset = "0x90C3B0", VA = "0x18090D9B0")]
		public FeedbackForm()
		{
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x90D890", Offset = "0x90C290", VA = "0x18090D890")]
		[CompilerGenerated]
		private IEnumerator <Submit>g__Wait|15_0()
		{
			return null;
		}

		// Token: 0x0400349C RID: 13468
		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine ssCoroutine;

		// Token: 0x0400349D RID: 13469
		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0xA0")]
		public CanvasGroup CanvasGroup;

		// Token: 0x0400349E RID: 13470
		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0xA8")]
		public Toggle ScreenshotToggle;

		// Token: 0x0400349F RID: 13471
		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0xB0")]
		public Toggle SaveFileToggle;

		// Token: 0x040034A0 RID: 13472
		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0xB8")]
		public TMP_InputField SummaryField;

		// Token: 0x040034A1 RID: 13473
		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0xC0")]
		public TMP_InputField DescriptionField;

		// Token: 0x040034A2 RID: 13474
		[Token(Token = "0x40034A2")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform Cog;

		// Token: 0x040034A3 RID: 13475
		[Token(Token = "0x40034A3")]
		[FieldOffset(Offset = "0xD0")]
		public TMP_Dropdown CategoryDropdown;
	}
}
