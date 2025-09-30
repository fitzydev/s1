using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Graffiti;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AA8 RID: 2728
	[Token(Token = "0x2000AA8")]
	public class GraffitiMenu : Singleton<GraffitiMenu>
	{
		// Token: 0x06004A27 RID: 18983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x9178D0", Offset = "0x9162D0", VA = "0x1809178D0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x917D10", Offset = "0x916710", VA = "0x180917D10")]
		public void Open()
		{
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x915730", Offset = "0x914130", VA = "0x180915730")]
		public void Close()
		{
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x917F50", Offset = "0x916950", VA = "0x180917F50")]
		public void ShowConfirmPanel()
		{
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x917D70", Offset = "0x916770", VA = "0x180917D70")]
		private void SelectColor(ESprayColor color)
		{
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2C")]
		[Address(RVA = "0x917F80", Offset = "0x916980", VA = "0x180917F80")]
		public void UpdateRemainingPaintIndicator(float remainingPaint)
		{
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x917CB0", Offset = "0x9166B0", VA = "0x180917CB0")]
		private void ClearClicked()
		{
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x917CE0", Offset = "0x9166E0", VA = "0x180917CE0")]
		private void ConfirmClicked()
		{
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x900640", Offset = "0x8FF040", VA = "0x180900640")]
		private void CancelClicked()
		{
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x918230", Offset = "0x916C30", VA = "0x180918230")]
		public GraffitiMenu()
		{
		}

		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform ColorButtonContainer;

		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0x38")]
		public Button ClearButton;

		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0x40")]
		public Transform ConfirmPanel;

		// Token: 0x040034F7 RID: 13559
		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0x48")]
		public Button ConfirmButton;

		// Token: 0x040034F8 RID: 13560
		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0x50")]
		public Button CancelButton;

		// Token: 0x040034F9 RID: 13561
		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform RemainigPaintContainer;

		// Token: 0x040034FA RID: 13562
		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0x60")]
		public Slider RemainingPaintSlider;

		// Token: 0x040034FB RID: 13563
		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0x68")]
		public Image[] RemainingPaintImages;

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI RemainingPaintLabel;

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0x78")]
		[Header("Prefabs")]
		public GameObject ColorButtonPrefab;

		// Token: 0x040034FE RID: 13566
		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0x80")]
		public Action<ESprayColor> onColorSelected;

		// Token: 0x040034FF RID: 13567
		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x88")]
		public Action onClearClicked;

		// Token: 0x04003500 RID: 13568
		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x90")]
		public Action onConfirmClicked;

		// Token: 0x04003501 RID: 13569
		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x98")]
		private List<Button> colorButtons;

		// Token: 0x04003502 RID: 13570
		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0xA0")]
		private SpraySurface activeSurface;
	}
}
