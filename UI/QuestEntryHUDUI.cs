using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AF8 RID: 2808
	[Token(Token = "0x2000AF8")]
	public class QuestEntryHUDUI : MonoBehaviour
	{
		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06004C42 RID: 19522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004C43 RID: 19523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB8")]
		public QuestEntry QuestEntry
		{
			[Token(Token = "0x6004C42")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C43")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x931060", Offset = "0x92FA60", VA = "0x180931060")]
		public void Initialize(QuestEntry entry)
		{
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x930B90", Offset = "0x92F590", VA = "0x180930B90")]
		public void Destroy()
		{
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x9313C0", Offset = "0x92FDC0", VA = "0x1809313C0", Slot = "4")]
		public virtual void UpdateUI()
		{
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x930ED0", Offset = "0x92F8D0", VA = "0x180930ED0")]
		private void FadeIn()
		{
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x930D40", Offset = "0x92F740", VA = "0x180930D40")]
		private void EntryEnded()
		{
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x930F50", Offset = "0x92F950", VA = "0x180930F50")]
		private void FadeOut()
		{
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x930A30", Offset = "0x92F430", VA = "0x180930A30")]
		private void Complete()
		{
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public QuestEntryHUDUI()
		{
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x931350", Offset = "0x92FD50", VA = "0x180931350")]
		[CompilerGenerated]
		private IEnumerator <FadeOut>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x9312E0", Offset = "0x92FCE0", VA = "0x1809312E0")]
		[CompilerGenerated]
		private IEnumerator <Complete>g__Routine|12_0()
		{
			return null;
		}

		// Token: 0x04003733 RID: 14131
		[Token(Token = "0x4003733")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI MainLabel;

		// Token: 0x04003734 RID: 14132
		[Token(Token = "0x4003734")]
		[FieldOffset(Offset = "0x30")]
		public Animation Animation;
	}
}
