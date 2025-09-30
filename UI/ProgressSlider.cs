using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AF3 RID: 2803
	[Token(Token = "0x2000AF3")]
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		// Token: 0x06004C26 RID: 19494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x92F300", Offset = "0x92DD00", VA = "0x18092F300")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x92F340", Offset = "0x92DD40", VA = "0x18092F340")]
		public void ShowProgress(float progress)
		{
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x92F270", Offset = "0x92DC70", VA = "0x18092F270")]
		public void Configure(string label, Color sliderFillColor)
		{
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x92F370", Offset = "0x92DD70", VA = "0x18092F370")]
		public ProgressSlider()
		{
		}

		// Token: 0x04003723 RID: 14115
		[Token(Token = "0x4003723")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x04003724 RID: 14116
		[Token(Token = "0x4003724")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI Label;

		// Token: 0x04003725 RID: 14117
		[Token(Token = "0x4003725")]
		[FieldOffset(Offset = "0x38")]
		public Slider Slider;

		// Token: 0x04003726 RID: 14118
		[Token(Token = "0x4003726")]
		[FieldOffset(Offset = "0x40")]
		public Image SliderFill;

		// Token: 0x04003727 RID: 14119
		[Token(Token = "0x4003727")]
		[FieldOffset(Offset = "0x48")]
		private bool progressSetThisFrame;
	}
}
