using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A6E RID: 2670
	[Token(Token = "0x2000A6E")]
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x00013020 File Offset: 0x00011220
		// (set) Token: 0x060048AF RID: 18607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A32")]
		public bool isShown
		{
			[Token(Token = "0x60048AE")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048AF")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B0")]
		[Address(RVA = "0x8FD320", Offset = "0x8FBD20", VA = "0x1808FD320", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B1")]
		[Address(RVA = "0x8FD490", Offset = "0x8FBE90", VA = "0x1808FD490")]
		public void Open(float fadeTime = 0.5f)
		{
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B2")]
		[Address(RVA = "0x8FD390", Offset = "0x8FBD90", VA = "0x1808FD390")]
		public void Close(float fadeTime = 0.5f)
		{
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048B3")]
		[Address(RVA = "0x8FD400", Offset = "0x8FBE00", VA = "0x1808FD400")]
		private IEnumerator Fade(float endOpacity, float fadeTime)
		{
			return null;
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B4")]
		[Address(RVA = "0x8FD520", Offset = "0x8FBF20", VA = "0x1808FD520")]
		public BlackOverlay()
		{
		}

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup group;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine fadeRoutine;
	}
}
