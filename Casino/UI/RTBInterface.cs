using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	public class RTBInterface : Singleton<RTBInterface>
	{
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003752 RID: 14162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EE")]
		public RTBGameController CurrentGame
		{
			[Token(Token = "0x6003751")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003752")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x7EBC00", Offset = "0x7EA600", VA = "0x1807EBC00", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x7EC620", Offset = "0x7EB020", VA = "0x1807EC620")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x7EC960", Offset = "0x7EB360", VA = "0x1807EC960")]
		private string GetStatusText()
		{
			return null;
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003756")]
		[Address(RVA = "0x7ECC30", Offset = "0x7EB630", VA = "0x1807ECC30")]
		public void Open(RTBGameController game)
		{
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003757")]
		[Address(RVA = "0x7EBF70", Offset = "0x7EA970", VA = "0x1807EBF70")]
		public void Close()
		{
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003758")]
		[Address(RVA = "0x7EBEF0", Offset = "0x7EA8F0", VA = "0x1807EBEF0")]
		private void BetSliderChanged(float newValue)
		{
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x7EC910", Offset = "0x7EB310", VA = "0x1807EC910")]
		private float GetBetFromSliderValue(float sliderVal)
		{
			return 0f;
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x7ED5A0", Offset = "0x7EBFA0", VA = "0x1807ED5A0")]
		private void RefreshDisplayedBet()
		{
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x7ED680", Offset = "0x7EC080", VA = "0x1807ED680")]
		private void RefreshReadyButton()
		{
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x7ED280", Offset = "0x7EBC80", VA = "0x1807ED280")]
		private void QuestionReady(string question, string[] answers)
		{
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x7EBB00", Offset = "0x7EA500", VA = "0x1807EBB00")]
		private void AnswerButtonClicked(int index)
		{
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x7EC800", Offset = "0x7EB200", VA = "0x1807EC800")]
		private void ForfeitClicked()
		{
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x7ED220", Offset = "0x7EBC20", VA = "0x1807ED220")]
		private void QuestionDone()
		{
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x7ECBB0", Offset = "0x7EB5B0", VA = "0x1807ECBB0")]
		private void LocalPlayerExitRound()
		{
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x7EC530", Offset = "0x7EAF30", VA = "0x1807EC530")]
		private void Correct()
		{
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003762")]
		[Address(RVA = "0x7ECB90", Offset = "0x7EB590", VA = "0x1807ECB90")]
		private void Incorrect()
		{
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x7ED580", Offset = "0x7EBF80", VA = "0x1807ED580")]
		private void ReadyButtonClicked()
		{
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x7ED910", Offset = "0x7EC310", VA = "0x1807ED910")]
		public RTBInterface()
		{
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003765")]
		[Address(RVA = "0x7ED8A0", Offset = "0x7EC2A0", VA = "0x1807ED8A0")]
		[CompilerGenerated]
		private IEnumerator <QuestionReady>g__Routine|38_0()
		{
			return null;
		}

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x38")]
		public CasinoGamePlayerDisplay PlayerDisplay;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI StatusLabel;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform BetContainer;

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI BetTitleLabel;

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x58")]
		public Slider BetSlider;

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI BetAmount;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x68")]
		public Button ReadyButton;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI ReadyLabel;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI WinningsMultiplierLabel;

		// Token: 0x0400269C RID: 9884
		[Token(Token = "0x400269C")]
		[FieldOffset(Offset = "0x80")]
		[Header("Question and answers")]
		public RectTransform QuestionContainer;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI QuestionLabel;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x90")]
		public Slider TimerSlider;

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x98")]
		public Button[] AnswerButtons;

		// Token: 0x040026A0 RID: 9888
		[Token(Token = "0x40026A0")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI[] AnswerLabels;

		// Token: 0x040026A1 RID: 9889
		[Token(Token = "0x40026A1")]
		[FieldOffset(Offset = "0xA8")]
		public Button ForfeitButton;

		// Token: 0x040026A2 RID: 9890
		[Token(Token = "0x40026A2")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI ForfeitLabel;

		// Token: 0x040026A3 RID: 9891
		[Token(Token = "0x40026A3")]
		[FieldOffset(Offset = "0xB8")]
		public Animation QuestionContainerAnimation;

		// Token: 0x040026A4 RID: 9892
		[Token(Token = "0x40026A4")]
		[FieldOffset(Offset = "0xC0")]
		public AnimationClip QuestionContainerFadeIn;

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[FieldOffset(Offset = "0xC8")]
		public AnimationClip QuestionContainerFadeOut;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		[FieldOffset(Offset = "0xD0")]
		public CanvasGroup QuestionCanvasGroup;

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[FieldOffset(Offset = "0xD8")]
		public RectTransform SelectionIndicator;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onCorrect;

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onFinalCorrect;

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onIncorrect;
	}
}
