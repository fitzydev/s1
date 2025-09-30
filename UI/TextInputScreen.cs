using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2000B0D")]
	public class TextInputScreen : Singleton<TextInputScreen>
	{
		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x00013CC8 File Offset: 0x00011EC8
		[Token(Token = "0x17000ACE")]
		public bool IsOpen
		{
			[Token(Token = "0x6004CC8")]
			[Address(RVA = "0x921AD0", Offset = "0x9204D0", VA = "0x180921AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x9372C0", Offset = "0x935CC0", VA = "0x1809372C0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCA")]
		[Address(RVA = "0x937900", Offset = "0x936300", VA = "0x180937900")]
		public void Submit()
		{
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCB")]
		[Address(RVA = "0x937370", Offset = "0x935D70", VA = "0x180937370")]
		public void Cancel()
		{
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCC")]
		[Address(RVA = "0x937910", Offset = "0x936310", VA = "0x180937910")]
		private void Update()
		{
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0x9375F0", Offset = "0x935FF0", VA = "0x1809375F0")]
		public void Exit(ExitAction action)
		{
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x937650", Offset = "0x936050", VA = "0x180937650")]
		public void Open(string header, string text, TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000)
		{
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x937380", Offset = "0x935D80", VA = "0x180937380")]
		private void Close(bool submit)
		{
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD0")]
		[Address(RVA = "0x937960", Offset = "0x936360", VA = "0x180937960")]
		public TextInputScreen()
		{
		}

		// Token: 0x040037A4 RID: 14244
		[Token(Token = "0x40037A4")]
		[FieldOffset(Offset = "0x28")]
		public Canvas Canvas;

		// Token: 0x040037A5 RID: 14245
		[Token(Token = "0x40037A5")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI HeaderLabel;

		// Token: 0x040037A6 RID: 14246
		[Token(Token = "0x40037A6")]
		[FieldOffset(Offset = "0x38")]
		public TMP_InputField InputField;

		// Token: 0x040037A7 RID: 14247
		[Token(Token = "0x40037A7")]
		[FieldOffset(Offset = "0x40")]
		private TextInputScreen.OnSubmit onSubmit;

		// Token: 0x02000B0E RID: 2830
		// (Invoke) Token: 0x06004CD2 RID: 19666
		[Token(Token = "0x2000B0E")]
		public delegate void OnSubmit(string text);
	}
}
