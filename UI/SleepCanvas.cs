using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x00013A58 File Offset: 0x00011C58
		// (set) Token: 0x06004BEF RID: 19439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAF")]
		public bool IsMenuOpen
		{
			[Token(Token = "0x6004BEE")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004BEF")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004BF1 RID: 19441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB0")]
		public string QueuedSleepMessage
		{
			[Token(Token = "0x6004BF0")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BF1")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF2")]
		[Address(RVA = "0x9340C0", Offset = "0x932AC0", VA = "0x1809340C0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF3")]
		[Address(RVA = "0x9346E0", Offset = "0x9330E0", VA = "0x1809346E0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF4")]
		[Address(RVA = "0x9349D0", Offset = "0x9333D0", VA = "0x1809349D0")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF5")]
		[Address(RVA = "0x9354C0", Offset = "0x933EC0", VA = "0x1809354C0")]
		public void Update()
		{
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x933F80", Offset = "0x932980", VA = "0x180933F80")]
		public void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x935360", Offset = "0x933D60", VA = "0x180935360")]
		private void UpdateHourSetting()
		{
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x935470", Offset = "0x933E70", VA = "0x180935470")]
		private void UpdateTimeLabels()
		{
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x9353A0", Offset = "0x933DA0", VA = "0x1809353A0")]
		private void UpdateSleepButton()
		{
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x9343F0", Offset = "0x932DF0", VA = "0x1809343F0")]
		private void ChangeSleepAmount(int change)
		{
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x9345A0", Offset = "0x932FA0", VA = "0x1809345A0")]
		private int ClampWakeTime(int time)
		{
			return 0;
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x00013A88 File Offset: 0x00011C88
		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x934500", Offset = "0x932F00", VA = "0x180934500")]
		private int ClampTime(int time, int startTime, int endTime)
		{
			return 0;
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x935040", Offset = "0x933A40", VA = "0x180935040")]
		private void SleepButtonPressed()
		{
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x9350C0", Offset = "0x933AC0", VA = "0x1809350C0")]
		private void SleepStart()
		{
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x934730", Offset = "0x933130", VA = "0x180934730")]
		private void LerpBlackOverlay(float transparency, float lerpTime)
		{
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x934850", Offset = "0x933250", VA = "0x180934850")]
		public void QueueSleepMessage(string message, float displayTime = 3f)
		{
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C01")]
		[Address(RVA = "0x9356C0", Offset = "0x9340C0", VA = "0x1809356C0")]
		public SleepCanvas()
		{
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x9352F0", Offset = "0x933CF0", VA = "0x1809352F0")]
		[CompilerGenerated]
		private IEnumerator <SleepStart>g__Sleep|41_0()
		{
			return null;
		}

		// Token: 0x040036EE RID: 14062
		[Token(Token = "0x40036EE")]
		public const int MaxSleepTime = 12;

		// Token: 0x040036EF RID: 14063
		[Token(Token = "0x40036EF")]
		public const int MinSleepTime = 4;

		// Token: 0x040036F2 RID: 14066
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x38")]
		private float QueuedMessageDisplayTime;

		// Token: 0x040036F3 RID: 14067
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040036F4 RID: 14068
		[Token(Token = "0x40036F4")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform Container;

		// Token: 0x040036F5 RID: 14069
		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform MenuContainer;

		// Token: 0x040036F6 RID: 14070
		[Token(Token = "0x40036F6")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI CurrentTimeLabel;

		// Token: 0x040036F7 RID: 14071
		[Token(Token = "0x40036F7")]
		[FieldOffset(Offset = "0x60")]
		public Button IncreaseButton;

		// Token: 0x040036F8 RID: 14072
		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x68")]
		public Button DecreaseButton;

		// Token: 0x040036F9 RID: 14073
		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI EndTimeLabel;

		// Token: 0x040036FA RID: 14074
		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x78")]
		public Button SleepButton;

		// Token: 0x040036FB RID: 14075
		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI SleepButtonLabel;

		// Token: 0x040036FC RID: 14076
		[Token(Token = "0x40036FC")]
		[FieldOffset(Offset = "0x88")]
		public Image BlackOverlay;

		// Token: 0x040036FD RID: 14077
		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI SleepMessageLabel;

		// Token: 0x040036FE RID: 14078
		[Token(Token = "0x40036FE")]
		[FieldOffset(Offset = "0x98")]
		public CanvasGroup SleepMessageGroup;

		// Token: 0x040036FF RID: 14079
		[Token(Token = "0x40036FF")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI TimeLabel;

		// Token: 0x04003700 RID: 14080
		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI WakeLabel;

		// Token: 0x04003701 RID: 14081
		[Token(Token = "0x4003701")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI WaitingForHostLabel;

		// Token: 0x04003702 RID: 14082
		[Token(Token = "0x4003702")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onSleepFullyFaded;

		// Token: 0x04003703 RID: 14083
		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0xC0")]
		public UnityEvent onSleepEndFade;

		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0xC8")]
		private List<IPostSleepEvent> queuedPostSleepEvents;
	}
}
