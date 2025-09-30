using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AE7 RID: 2791
	[Token(Token = "0x2000AE7")]
	public class PassOutScreen : Singleton<PassOutScreen>
	{
		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x00013A10 File Offset: 0x00011C10
		// (set) Token: 0x06004BD3 RID: 19411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAA")]
		public bool isOpen
		{
			[Token(Token = "0x6004BD2")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004BD3")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x92E410", Offset = "0x92CE10", VA = "0x18092E410", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x92E690", Offset = "0x92D090", VA = "0x18092E690")]
		private void Continue()
		{
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x92E710", Offset = "0x92D110", VA = "0x18092E710")]
		private void LoadSaveClicked()
		{
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x92E720", Offset = "0x92D120", VA = "0x18092E720")]
		public void Open()
		{
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x92E490", Offset = "0x92CE90", VA = "0x18092E490")]
		public void Close()
		{
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x92EA00", Offset = "0x92D400", VA = "0x18092EA00")]
		public PassOutScreen()
		{
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x92E920", Offset = "0x92D320", VA = "0x18092E920")]
		[CompilerGenerated]
		private IEnumerator <Continue>g__Routine|14_0()
		{
			return null;
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0x92E990", Offset = "0x92D390", VA = "0x18092E990")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|16_0()
		{
			return null;
		}

		// Token: 0x040036D0 RID: 14032
		[Token(Token = "0x40036D0")]
		public const float CASH_LOSS_MIN = 50f;

		// Token: 0x040036D1 RID: 14033
		[Token(Token = "0x40036D1")]
		public const float CASH_LOSS_MAX = 500f;

		// Token: 0x040036D2 RID: 14034
		[Token(Token = "0x40036D2")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040036D3 RID: 14035
		[Token(Token = "0x40036D3")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup Group;

		// Token: 0x040036D4 RID: 14036
		[Token(Token = "0x40036D4")]
		[FieldOffset(Offset = "0x40")]
		public Transform RecoveryPointsContainer;

		// Token: 0x040036D5 RID: 14037
		[Token(Token = "0x40036D5")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI MainLabel;

		// Token: 0x040036D6 RID: 14038
		[Token(Token = "0x40036D6")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI ContextLabel;

		// Token: 0x040036D7 RID: 14039
		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x58")]
		public Animation Anim;

		// Token: 0x040036D8 RID: 14040
		[Token(Token = "0x40036D8")]
		[FieldOffset(Offset = "0x60")]
		private float cashLoss;
	}
}
