using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AB0 RID: 2736
	[Token(Token = "0x2000AB0")]
	public class HUD : Singleton<HUD>
	{
		// Token: 0x06004A55 RID: 19029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x9182C0", Offset = "0x916CC0", VA = "0x1809182C0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x918800", Offset = "0x917200", VA = "0x180918800")]
		public void SetCrosshairVisible(bool vis)
		{
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x918730", Offset = "0x917130", VA = "0x180918730")]
		public void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A58")]
		[Address(RVA = "0x918A10", Offset = "0x917410", VA = "0x180918A10")]
		private void Update()
		{
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x918950", Offset = "0x917350", VA = "0x180918950")]
		private void UpdateQuestEntryTitle()
		{
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5A")]
		[Address(RVA = "0x918540", Offset = "0x916F40", VA = "0x180918540")]
		private void RefreshFPS()
		{
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x6004A5B")]
		[Address(RVA = "0x918420", Offset = "0x916E20", VA = "0x180918420")]
		private float GetAverageFPS()
		{
			return 0f;
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5C")]
		[Address(RVA = "0x918500", Offset = "0x916F00", VA = "0x180918500", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0x918390", Offset = "0x916D90", VA = "0x180918390")]
		protected IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			return null;
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x918840", Offset = "0x917240", VA = "0x180918840")]
		public void ShowRadialIndicator(float fill)
		{
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x918880", Offset = "0x917280", VA = "0x180918880")]
		public void ShowTopScreenText(string t)
		{
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A60")]
		[Address(RVA = "0x9184D0", Offset = "0x916ED0", VA = "0x1809184D0")]
		public void HideTopScreenText()
		{
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x918DB0", Offset = "0x9177B0", VA = "0x180918DB0")]
		public HUD()
		{
		}

		// Token: 0x04003521 RID: 13601
		[Token(Token = "0x4003521")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003522 RID: 13602
		[Token(Token = "0x4003522")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform canvasRect;

		// Token: 0x04003523 RID: 13603
		[Token(Token = "0x4003523")]
		[FieldOffset(Offset = "0x38")]
		public Image crosshair;

		// Token: 0x04003524 RID: 13604
		[Token(Token = "0x4003524")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Image blackOverlay;

		// Token: 0x04003525 RID: 13605
		[Token(Token = "0x4003525")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Image radialIndicator;

		// Token: 0x04003526 RID: 13606
		[Token(Token = "0x4003526")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected GraphicRaycaster raycaster;

		// Token: 0x04003527 RID: 13607
		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected TextMeshProUGUI topScreenText;

		// Token: 0x04003528 RID: 13608
		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected RectTransform topScreenText_Background;

		// Token: 0x04003529 RID: 13609
		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x68")]
		public Text fpsLabel;

		// Token: 0x0400352A RID: 13610
		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform cashSlotContainer;

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform cashSlotUI;

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform onlineBalanceContainer;

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform onlineBalanceSlotUI;

		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform managementSlotContainer;

		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x98")]
		public ItemSlotUI managementSlotUI;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform HotbarContainer;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform SlotContainer;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0xB0")]
		public ItemSlotUI discardSlot;

		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0xB8")]
		public Image discardSlotFill;

		// Token: 0x04003534 RID: 13620
		[Token(Token = "0x4003534")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI selectedItemLabel;

		// Token: 0x04003535 RID: 13621
		[Token(Token = "0x4003535")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform QuestEntryContainer;

		// Token: 0x04003536 RID: 13622
		[Token(Token = "0x4003536")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI QuestEntryTitle;

		// Token: 0x04003537 RID: 13623
		[Token(Token = "0x4003537")]
		[FieldOffset(Offset = "0xD8")]
		public CrimeStatusUI CrimeStatusUI;

		// Token: 0x04003538 RID: 13624
		[Token(Token = "0x4003538")]
		[FieldOffset(Offset = "0xE0")]
		public BalanceDisplay OnlineBalanceDisplay;

		// Token: 0x04003539 RID: 13625
		[Token(Token = "0x4003539")]
		[FieldOffset(Offset = "0xE8")]
		public BalanceDisplay SafeBalanceDisplay;

		// Token: 0x0400353A RID: 13626
		[Token(Token = "0x400353A")]
		[FieldOffset(Offset = "0xF0")]
		public CrosshairText CrosshairText;

		// Token: 0x0400353B RID: 13627
		[Token(Token = "0x400353B")]
		[FieldOffset(Offset = "0xF8")]
		public RectTransform UnreadMessagesPrompt;

		// Token: 0x0400353C RID: 13628
		[Token(Token = "0x400353C")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI SleepPrompt;

		// Token: 0x0400353D RID: 13629
		[Token(Token = "0x400353D")]
		[FieldOffset(Offset = "0x108")]
		public TextMeshProUGUI CurfewPrompt;

		// Token: 0x0400353E RID: 13630
		[Token(Token = "0x400353E")]
		[FieldOffset(Offset = "0x110")]
		[Header("Settings")]
		public Gradient RedGreenGradient;

		// Token: 0x0400353F RID: 13631
		[Token(Token = "0x400353F")]
		[FieldOffset(Offset = "0x118")]
		private int SampleSize;

		// Token: 0x04003540 RID: 13632
		[Token(Token = "0x4003540")]
		[FieldOffset(Offset = "0x120")]
		private List<float> _previousFPS;

		// Token: 0x04003541 RID: 13633
		[Token(Token = "0x4003541")]
		[FieldOffset(Offset = "0x128")]
		private EventSystem eventSystem;

		// Token: 0x04003542 RID: 13634
		[Token(Token = "0x4003542")]
		[FieldOffset(Offset = "0x130")]
		private Coroutine blackOverlayFade;

		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		[FieldOffset(Offset = "0x138")]
		private bool radialIndicatorSetThisFrame;
	}
}
