using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x020007EC RID: 2028
	[Token(Token = "0x20007EC")]
	public class BlackjackInterface : Singleton<BlackjackInterface>
	{
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007ED")]
		public BlackjackGameController CurrentGame
		{
			[Token(Token = "0x6003738")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003739")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x7DA240", Offset = "0x7D8C40", VA = "0x1807DA240", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373B")]
		[Address(RVA = "0x7DAAC0", Offset = "0x7D94C0", VA = "0x1807DAAC0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x7DB400", Offset = "0x7D9E00", VA = "0x1807DB400")]
		public void Open(BlackjackGameController game)
		{
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x7DA500", Offset = "0x7D8F00", VA = "0x1807DA500")]
		public void Close()
		{
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x7DA480", Offset = "0x7D8E80", VA = "0x1807DA480")]
		private void BetSliderChanged(float newValue)
		{
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x7DAF10", Offset = "0x7D9910", VA = "0x1807DAF10")]
		private float GetBetFromSliderValue(float sliderVal)
		{
			return 0f;
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x7DBA10", Offset = "0x7DA410", VA = "0x1807DBA10")]
		private void RefreshDisplayedBet()
		{
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x7DBAF0", Offset = "0x7DA4F0", VA = "0x1807DBAF0")]
		private void RefreshReadyButton()
		{
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x7DB1C0", Offset = "0x7D9BC0", VA = "0x1807DB1C0")]
		private void LocalPlayerReadyForInput()
		{
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x7DBD10", Offset = "0x7DA710", VA = "0x1807DBD10")]
		private void ShowScores()
		{
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x7DAF60", Offset = "0x7D9960", VA = "0x1807DAF60")]
		private void HideScores()
		{
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x7DAFA0", Offset = "0x7D99A0", VA = "0x1807DAFA0")]
		private void HitClicked()
		{
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x7DBD50", Offset = "0x7DA750", VA = "0x1807DBD50")]
		private void StandClicked()
		{
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x7DB110", Offset = "0x7D9B10", VA = "0x1807DB110")]
		private void LocalPlayerExitRound()
		{
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x7DB9F0", Offset = "0x7DA3F0", VA = "0x1807DB9F0")]
		private void ReadyButtonClicked()
		{
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x7DB250", Offset = "0x7D9C50", VA = "0x1807DB250")]
		private void OnLocalPlayerBust()
		{
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x7DB270", Offset = "0x7D9C70", VA = "0x1807DB270")]
		private void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout)
		{
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x7DBEC0", Offset = "0x7DA8C0", VA = "0x1807DBEC0")]
		public BlackjackInterface()
		{
		}

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04002673 RID: 9843
		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x38")]
		public CasinoGamePlayerDisplay PlayerDisplay;

		// Token: 0x04002674 RID: 9844
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform BetContainer;

		// Token: 0x04002675 RID: 9845
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI BetTitleLabel;

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x50")]
		public Slider BetSlider;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI BetAmount;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x60")]
		public Button ReadyButton;

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI ReadyLabel;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform WaitingContainer;

		// Token: 0x0400267B RID: 9851
		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI WaitingLabel;

		// Token: 0x0400267C RID: 9852
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI DealerScoreLabel;

		// Token: 0x0400267D RID: 9853
		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI PlayerScoreLabel;

		// Token: 0x0400267E RID: 9854
		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x90")]
		public Button HitButton;

		// Token: 0x0400267F RID: 9855
		[Token(Token = "0x400267F")]
		[FieldOffset(Offset = "0x98")]
		public Button StandButton;

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0xA0")]
		public Animation InputContainerAnimation;

		// Token: 0x04002681 RID: 9857
		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup InputContainerCanvasGroup;

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0xB0")]
		public AnimationClip InputContainerFadeIn;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0xB8")]
		public AnimationClip InputContainerFadeOut;

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform SelectionIndicator;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0xC8")]
		public Animation ScoresContainerAnimation;

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0xD0")]
		public CanvasGroup ScoresContainerCanvasGroup;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI PositiveOutcomeLabel;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI PayoutLabel;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onBust;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onBlackjack;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0xF8")]
		public UnityEvent onWin;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0x100")]
		public UnityEvent onLose;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0x108")]
		public UnityEvent onPush;
	}
}
