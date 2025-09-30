using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A59 RID: 2649
	[Token(Token = "0x2000A59")]
	public class ACWindow : MonoBehaviour
	{
		// Token: 0x06004846 RID: 18502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004846")]
		[Address(RVA = "0x8FC150", Offset = "0x8FAB50", VA = "0x1808FC150")]
		private void Start()
		{
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004847")]
		[Address(RVA = "0x6FE5A0", Offset = "0x6FCFA0", VA = "0x1806FE5A0")]
		public void Open()
		{
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004848")]
		[Address(RVA = "0x8FC0A0", Offset = "0x8FAAA0", VA = "0x1808FC0A0")]
		public void Close()
		{
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004849")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ACWindow()
		{
		}

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string WindowTitle;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x28")]
		public ACWindow Predecessor;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public TextMeshProUGUI TitleText;

		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x400333D")]
		[FieldOffset(Offset = "0x38")]
		public Button BackButton;
	}
}
