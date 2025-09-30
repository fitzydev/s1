using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2000ADD")]
	public class CrimeStatusUI : MonoBehaviour
	{
		// Token: 0x06004B98 RID: 19352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x92BF50", Offset = "0x92A950", VA = "0x18092BF50")]
		public void UpdateStatus()
		{
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B99")]
		[Address(RVA = "0x92BE50", Offset = "0x92A850", VA = "0x18092BE50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9A")]
		[Address(RVA = "0x92BEE0", Offset = "0x92A8E0", VA = "0x18092BEE0")]
		private IEnumerator Routine()
		{
			return null;
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9B")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CrimeStatusUI()
		{
		}

		// Token: 0x04003693 RID: 13971
		[Token(Token = "0x4003693")]
		public const float SmallTextSize = 0.75f;

		// Token: 0x04003694 RID: 13972
		[Token(Token = "0x4003694")]
		public const float LargeTextSize = 1f;

		// Token: 0x04003695 RID: 13973
		[Token(Token = "0x4003695")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public RectTransform CrimeStatusContainer;

		// Token: 0x04003696 RID: 13974
		[Token(Token = "0x4003696")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup CrimeStatusGroup;

		// Token: 0x04003697 RID: 13975
		[Token(Token = "0x4003697")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BodysearchLabel;

		// Token: 0x04003698 RID: 13976
		[Token(Token = "0x4003698")]
		[FieldOffset(Offset = "0x38")]
		public Image InvestigatingMask;

		// Token: 0x04003699 RID: 13977
		[Token(Token = "0x4003699")]
		[FieldOffset(Offset = "0x40")]
		public Image UnderArrestMask;

		// Token: 0x0400369A RID: 13978
		[Token(Token = "0x400369A")]
		[FieldOffset(Offset = "0x48")]
		public Image WantedMask;

		// Token: 0x0400369B RID: 13979
		[Token(Token = "0x400369B")]
		[FieldOffset(Offset = "0x50")]
		public Image WantedDeadMask;

		// Token: 0x0400369C RID: 13980
		[Token(Token = "0x400369C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrestProgressContainer;

		// Token: 0x0400369D RID: 13981
		[Token(Token = "0x400369D")]
		[FieldOffset(Offset = "0x60")]
		private bool animateText;

		// Token: 0x0400369E RID: 13982
		[Token(Token = "0x400369E")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine routine;
	}
}
