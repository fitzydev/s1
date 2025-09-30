using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AE3 RID: 2787
	[Token(Token = "0x2000AE3")]
	public class HospitalBillScreen : Singleton<HospitalBillScreen>
	{
		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06004BBD RID: 19389 RVA: 0x000139E0 File Offset: 0x00011BE0
		// (set) Token: 0x06004BBE RID: 19390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA5")]
		public bool isOpen
		{
			[Token(Token = "0x6004BBD")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004BBE")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0x92D000", Offset = "0x92BA00", VA = "0x18092D000", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x92D440", Offset = "0x92BE40", VA = "0x18092D440")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x92D750", Offset = "0x92C150", VA = "0x18092D750")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x92D490", Offset = "0x92BE90", VA = "0x18092D490")]
		public void Open()
		{
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x92D230", Offset = "0x92BC30", VA = "0x18092D230")]
		public void Close()
		{
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x92D850", Offset = "0x92C250", VA = "0x18092D850")]
		public HospitalBillScreen()
		{
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x92D7E0", Offset = "0x92C1E0", VA = "0x18092D7E0")]
		[CompilerGenerated]
		private IEnumerator <Close>g__CloseRoutine|16_0()
		{
			return null;
		}

		// Token: 0x040036BE RID: 14014
		[Token(Token = "0x40036BE")]
		public const float BILL_COST = 250f;

		// Token: 0x040036C0 RID: 14016
		[Token(Token = "0x40036C0")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040036C1 RID: 14017
		[Token(Token = "0x40036C1")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x040036C2 RID: 14018
		[Token(Token = "0x40036C2")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup CanvasGroup;

		// Token: 0x040036C3 RID: 14019
		[Token(Token = "0x40036C3")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI PatientNameLabel;

		// Token: 0x040036C4 RID: 14020
		[Token(Token = "0x40036C4")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI BillNumberLabel;

		// Token: 0x040036C5 RID: 14021
		[Token(Token = "0x40036C5")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI PaidAmountLabel;

		// Token: 0x040036C6 RID: 14022
		[Token(Token = "0x40036C6")]
		[FieldOffset(Offset = "0x60")]
		private bool arrested;
	}
}
