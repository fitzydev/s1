using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000ACF RID: 2767
	[Token(Token = "0x2000ACF")]
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x00013758 File Offset: 0x00011958
		// (set) Token: 0x06004B17 RID: 19223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A8C")]
		public bool IsOpen
		{
			[Token(Token = "0x6004B16")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B17")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x00013770 File Offset: 0x00011970
		// (set) Token: 0x06004B19 RID: 19225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A8D")]
		public float SelectedPayment
		{
			[Token(Token = "0x6004B18")]
			[Address(RVA = "0x4E8A80", Offset = "0x4E7480", VA = "0x1804E8A80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004B19")]
			[Address(RVA = "0x6FF890", Offset = "0x6FE290", VA = "0x1806FF890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x00013788 File Offset: 0x00011988
		// (set) Token: 0x06004B1B RID: 19227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A8E")]
		public float NPCAnger
		{
			[Token(Token = "0x6004B1A")]
			[Address(RVA = "0x4873B0", Offset = "0x485DB0", VA = "0x1804873B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004B1B")]
			[Address(RVA = "0x7BE2D0", Offset = "0x7BCCD0", VA = "0x1807BE2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x922D30", Offset = "0x921730", VA = "0x180922D30", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x925540", Offset = "0x923F40", VA = "0x180925540", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x924570", Offset = "0x922F70", VA = "0x180924570", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x9247B0", Offset = "0x9231B0", VA = "0x1809247B0")]
		public void Open()
		{
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x923620", Offset = "0x922020", VA = "0x180923620")]
		public void Close(bool returnItemsToPlayer)
		{
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x923EC0", Offset = "0x9228C0", VA = "0x180923EC0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x9247A0", Offset = "0x9231A0", VA = "0x1809247A0")]
		private void OnMinPass()
		{
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x924560", Offset = "0x922F60", VA = "0x180924560")]
		private void OnDayPass()
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x925D40", Offset = "0x924740", VA = "0x180925D40")]
		private void Update()
		{
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x9243E0", Offset = "0x922DE0", VA = "0x1809243E0")]
		private List<ItemInstance> GetPawnItems()
		{
			return null;
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x924C60", Offset = "0x923660", VA = "0x180924C60")]
		private void PawnSlotChanged()
		{
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x925A10", Offset = "0x924410", VA = "0x180925A10")]
		private void UpdateValueRangeLabels()
		{
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x925490", Offset = "0x923E90", VA = "0x180925490")]
		public void StartButtonPressed()
		{
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x925490", Offset = "0x923E90", VA = "0x180925490")]
		private void StartNegotiation()
		{
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x924CC0", Offset = "0x9236C0", VA = "0x180924CC0")]
		private void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter)
		{
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x923B70", Offset = "0x922570", VA = "0x180923B70")]
		private PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			return PawnShopInterface.EShopResponse.Accept;
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x923AF0", Offset = "0x9224F0", VA = "0x180923AF0")]
		private void EndNegotiation()
		{
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x924C70", Offset = "0x923670", VA = "0x180924C70")]
		public void PaymentSubmitted(string value)
		{
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x923610", Offset = "0x922010", VA = "0x180923610")]
		public void ChangePayment(float change)
		{
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x925390", Offset = "0x923D90", VA = "0x180925390")]
		public void SetSelectedPayment(float amount)
		{
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x9252D0", Offset = "0x923CD0", VA = "0x1809252D0")]
		public void SetPlayerResponse(PawnShopInterface.EPlayerResponse response)
		{
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x922D00", Offset = "0x921700", VA = "0x180922D00")]
		public void AcceptOrCounter()
		{
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x923240", Offset = "0x921C40", VA = "0x180923240")]
		public void Cancel()
		{
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x923250", Offset = "0x921C50", VA = "0x180923250")]
		private void ChangeAnger(float change)
		{
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x9250B0", Offset = "0x923AB0", VA = "0x1809250B0")]
		private void SetAngeredToday(bool angered)
		{
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x9258F0", Offset = "0x9242F0", VA = "0x1809258F0")]
		private void Think()
		{
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x925180", Offset = "0x923B80", VA = "0x180925180")]
		private void SetOffer(float amount)
		{
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x923F20", Offset = "0x922920", VA = "0x180923F20")]
		private void FinalizeDeal(float amount)
		{
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x9244C0", Offset = "0x922EC0", VA = "0x1809244C0")]
		private float GetTotalValue()
		{
			return 0f;
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x000137D0 File Offset: 0x000119D0
		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x924F60", Offset = "0x923960", VA = "0x180924F60")]
		private float RoundOffer(float offer)
		{
			return 0f;
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x924050", Offset = "0x922A50", VA = "0x180924050")]
		private float GetItemValue(ItemInstance item)
		{
			return 0f;
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x924EB0", Offset = "0x9238B0", VA = "0x180924EB0")]
		private void ResetUI()
		{
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x926040", Offset = "0x924A40", VA = "0x180926040")]
		public PawnShopInterface()
		{
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x9259A0", Offset = "0x9243A0", VA = "0x1809259A0")]
		[CompilerGenerated]
		private IEnumerator <StartNegotiation>g__NegotiationRoutine|67_0()
		{
			return null;
		}

		// Token: 0x0400360F RID: 13839
		[Token(Token = "0x400360F")]
		public const float PAYMENT_MIN = 1f;

		// Token: 0x04003610 RID: 13840
		[Token(Token = "0x4003610")]
		public const float PAYMENT_MAX = 999999f;

		// Token: 0x04003611 RID: 13841
		[Token(Token = "0x4003611")]
		public const float THINK_TIME = 0.75f;

		// Token: 0x04003612 RID: 13842
		[Token(Token = "0x4003612")]
		public const float MIN_VALUE_MULTIPLIER = 0.5f;

		// Token: 0x04003613 RID: 13843
		[Token(Token = "0x4003613")]
		public const float MAX_VALUE_MULTIPLIER = 2f;

		// Token: 0x04003614 RID: 13844
		[Token(Token = "0x4003614")]
		public const int PAWN_SLOT_COUNT = 5;

		// Token: 0x04003616 RID: 13846
		[Token(Token = "0x4003616")]
		[FieldOffset(Offset = "0x2C")]
		private PawnShopInterface.EState CurrentState;

		// Token: 0x04003617 RID: 13847
		[Token(Token = "0x4003617")]
		[FieldOffset(Offset = "0x30")]
		private PawnShopInterface.EPlayerResponse PlayerResponse;

		// Token: 0x04003618 RID: 13848
		[Token(Token = "0x4003618")]
		[FieldOffset(Offset = "0x34")]
		private int CurrentNegotiationRound;

		// Token: 0x04003619 RID: 13849
		[Token(Token = "0x4003619")]
		[FieldOffset(Offset = "0x38")]
		private float InitialShopOffer;

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		[FieldOffset(Offset = "0x3C")]
		private float LastShopOffer;

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0x40")]
		private float LastRefusedAmount;

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0x48")]
		public NPC PawnShopNPC;

		// Token: 0x0400361F RID: 13855
		[Token(Token = "0x400361F")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve RandomCurve;

		// Token: 0x04003620 RID: 13856
		[Token(Token = "0x4003620")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform Container;

		// Token: 0x04003622 RID: 13858
		[Token(Token = "0x4003622")]
		[FieldOffset(Offset = "0x70")]
		public ItemSlotUI[] Slots;

		// Token: 0x04003623 RID: 13859
		[Token(Token = "0x4003623")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI[] ValueRangeLabels;

		// Token: 0x04003624 RID: 13860
		[Token(Token = "0x4003624")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI TotalValueLabel;

		// Token: 0x04003625 RID: 13861
		[Token(Token = "0x4003625")]
		[FieldOffset(Offset = "0x88")]
		public Button StartButton;

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x90")]
		public Animation Step1Animation;

		// Token: 0x04003627 RID: 13863
		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x98")]
		public CanvasGroup Step1CanvasGroup;

		// Token: 0x04003628 RID: 13864
		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0xA0")]
		public Animation Step2Animation;

		// Token: 0x04003629 RID: 13865
		[Token(Token = "0x4003629")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup Step2CanvasGroup;

		// Token: 0x0400362A RID: 13866
		[Token(Token = "0x400362A")]
		[FieldOffset(Offset = "0xB0")]
		public AnimationClip FadeInAnim;

		// Token: 0x0400362B RID: 13867
		[Token(Token = "0x400362B")]
		[FieldOffset(Offset = "0xB8")]
		public AnimationClip FadeOutAnim;

		// Token: 0x0400362C RID: 13868
		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0xC0")]
		public TMP_InputField OfferInputField;

		// Token: 0x0400362D RID: 13869
		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0xC8")]
		public Slider AngerSlider;

		// Token: 0x0400362E RID: 13870
		[Token(Token = "0x400362E")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI AcceptCounterButtonLabel;

		// Token: 0x0400362F RID: 13871
		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0xD8")]
		[Header("Settings")]
		public string[] OfferLines;

		// Token: 0x04003630 RID: 13872
		[Token(Token = "0x4003630")]
		[FieldOffset(Offset = "0xE0")]
		public string[] ThinkLines;

		// Token: 0x04003631 RID: 13873
		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0xE8")]
		public string[] AcceptLines;

		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0xF0")]
		public string[] CounterLines;

		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0xF8")]
		public string[] RefusalLines;

		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		[FieldOffset(Offset = "0x100")]
		public string[] DealFinalizedLines;

		// Token: 0x04003635 RID: 13877
		[Token(Token = "0x4003635")]
		[FieldOffset(Offset = "0x108")]
		public string[] AngeredLines;

		// Token: 0x04003636 RID: 13878
		[Token(Token = "0x4003636")]
		[FieldOffset(Offset = "0x110")]
		public string[] CrashOutLines;

		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		[FieldOffset(Offset = "0x118")]
		private ItemSlot[] PawnSlots;

		// Token: 0x04003638 RID: 13880
		[Token(Token = "0x4003638")]
		[FieldOffset(Offset = "0x120")]
		private Coroutine routine;

		// Token: 0x02000AD0 RID: 2768
		[Token(Token = "0x2000AD0")]
		public enum EState
		{
			// Token: 0x0400363A RID: 13882
			[Token(Token = "0x400363A")]
			WaitingForOffer,
			// Token: 0x0400363B RID: 13883
			[Token(Token = "0x400363B")]
			Negotiating
		}

		// Token: 0x02000AD1 RID: 2769
		[Token(Token = "0x2000AD1")]
		public enum EPlayerResponse
		{
			// Token: 0x0400363D RID: 13885
			[Token(Token = "0x400363D")]
			None,
			// Token: 0x0400363E RID: 13886
			[Token(Token = "0x400363E")]
			Accept,
			// Token: 0x0400363F RID: 13887
			[Token(Token = "0x400363F")]
			Counter,
			// Token: 0x04003640 RID: 13888
			[Token(Token = "0x4003640")]
			Cancel
		}

		// Token: 0x02000AD2 RID: 2770
		[Token(Token = "0x2000AD2")]
		public enum EShopResponse
		{
			// Token: 0x04003642 RID: 13890
			[Token(Token = "0x4003642")]
			Accept,
			// Token: 0x04003643 RID: 13891
			[Token(Token = "0x4003643")]
			Counter,
			// Token: 0x04003644 RID: 13892
			[Token(Token = "0x4003644")]
			Refusal
		}
	}
}
