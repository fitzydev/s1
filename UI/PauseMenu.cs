using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000ACE RID: 2766
	[Token(Token = "0x2000ACE")]
	public class PauseMenu : Singleton<PauseMenu>
	{
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x00013740 File Offset: 0x00011940
		// (set) Token: 0x06004B0C RID: 19212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A8B")]
		public bool IsPaused
		{
			[Token(Token = "0x6004B0B")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B0C")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0x922130", Offset = "0x920B30", VA = "0x180922130", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0x922B80", Offset = "0x921580", VA = "0x180922B80", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x9221E0", Offset = "0x920BE0", VA = "0x1809221E0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B10")]
		[Address(RVA = "0x922C90", Offset = "0x921690", VA = "0x180922C90")]
		private void Update()
		{
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x922280", Offset = "0x920C80", VA = "0x180922280")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x922330", Offset = "0x920D30", VA = "0x180922330")]
		public void Pause()
		{
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x9227B0", Offset = "0x9211B0", VA = "0x1809227B0")]
		public void Resume()
		{
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B14")]
		[Address(RVA = "0x922C00", Offset = "0x921600", VA = "0x180922C00")]
		public void StuckButtonClicked()
		{
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x922CC0", Offset = "0x9216C0", VA = "0x180922CC0")]
		public PauseMenu()
		{
		}

		// Token: 0x04003602 RID: 13826
		[Token(Token = "0x4003602")]
		[FieldOffset(Offset = "0x30")]
		public Canvas Canvas;

		// Token: 0x04003603 RID: 13827
		[Token(Token = "0x4003603")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04003604 RID: 13828
		[Token(Token = "0x4003604")]
		[FieldOffset(Offset = "0x40")]
		public MainMenuScreen Screen;

		// Token: 0x04003605 RID: 13829
		[Token(Token = "0x4003605")]
		[FieldOffset(Offset = "0x48")]
		public FeedbackForm FeedbackForm;

		// Token: 0x04003606 RID: 13830
		[Token(Token = "0x4003606")]
		[FieldOffset(Offset = "0x50")]
		private bool noActiveUIElements;

		// Token: 0x04003607 RID: 13831
		[Token(Token = "0x4003607")]
		[FieldOffset(Offset = "0x51")]
		private bool justPaused;

		// Token: 0x04003608 RID: 13832
		[Token(Token = "0x4003608")]
		[FieldOffset(Offset = "0x52")]
		private bool justResumed;

		// Token: 0x04003609 RID: 13833
		[Token(Token = "0x4003609")]
		[FieldOffset(Offset = "0x53")]
		private bool couldLook;

		// Token: 0x0400360A RID: 13834
		[Token(Token = "0x400360A")]
		[FieldOffset(Offset = "0x54")]
		private bool lockedMouse;

		// Token: 0x0400360B RID: 13835
		[Token(Token = "0x400360B")]
		[FieldOffset(Offset = "0x55")]
		private bool crosshairVisible;

		// Token: 0x0400360C RID: 13836
		[Token(Token = "0x400360C")]
		[FieldOffset(Offset = "0x56")]
		private bool hudVisible;

		// Token: 0x0400360D RID: 13837
		[Token(Token = "0x400360D")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onPause;

		// Token: 0x0400360E RID: 13838
		[Token(Token = "0x400360E")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onResume;
	}
}
