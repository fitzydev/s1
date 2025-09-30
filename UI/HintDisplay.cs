using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AAA RID: 2730
	[Token(Token = "0x2000AAA")]
	public class HintDisplay : Singleton<HintDisplay>
	{
		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x00013530 File Offset: 0x00011730
		// (set) Token: 0x06004A34 RID: 18996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6B")]
		public bool IsOpen
		{
			[Token(Token = "0x6004A33")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A34")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x9197D0", Offset = "0x9181D0", VA = "0x1809197D0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x9198D0", Offset = "0x9182D0", VA = "0x1809198D0")]
		public void Update()
		{
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x9194E0", Offset = "0x917EE0", VA = "0x1809194E0")]
		public void ShowHint_10s(string text)
		{
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x9194F0", Offset = "0x917EF0", VA = "0x1809194F0")]
		public void ShowHint_20s(string text)
		{
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x9197C0", Offset = "0x9181C0", VA = "0x1809197C0")]
		public void ShowHint(string text)
		{
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0x919500", Offset = "0x917F00", VA = "0x180919500")]
		public void ShowHint(string text, float autoCloseTime = 0f)
		{
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3B")]
		[Address(RVA = "0x918E50", Offset = "0x917850", VA = "0x180918E50")]
		public void Hide()
		{
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3C")]
		[Address(RVA = "0x9193A0", Offset = "0x917DA0", VA = "0x1809193A0")]
		private void SetAlpha(float alpha)
		{
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3D")]
		[Address(RVA = "0x9190A0", Offset = "0x917AA0", VA = "0x1809190A0")]
		public void QueueHint_10s(string message)
		{
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3E")]
		[Address(RVA = "0x9191A0", Offset = "0x917BA0", VA = "0x1809191A0")]
		public void QueueHint_20s(string message)
		{
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x9192A0", Offset = "0x917CA0", VA = "0x1809192A0")]
		public void QueueHint(string message, float time)
		{
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x918E70", Offset = "0x917870", VA = "0x180918E70")]
		private string ProcessText(string text)
		{
			return null;
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x919B30", Offset = "0x918530", VA = "0x180919B30")]
		public HintDisplay()
		{
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A42")]
		[Address(RVA = "0x919850", Offset = "0x918250", VA = "0x180919850")]
		[CompilerGenerated]
		private IEnumerator <ShowHint>g__AutoClose|22_0(float time)
		{
			return null;
		}

		// Token: 0x04003505 RID: 13573
		[Token(Token = "0x4003505")]
		public const float FadeTime = 0.3f;

		// Token: 0x04003507 RID: 13575
		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04003508 RID: 13576
		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI Label;

		// Token: 0x04003509 RID: 13577
		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup Group;

		// Token: 0x0400350A RID: 13578
		[Token(Token = "0x400350A")]
		[FieldOffset(Offset = "0x48")]
		public InputPrompt DismissPrompt;

		// Token: 0x0400350B RID: 13579
		[Token(Token = "0x400350B")]
		[FieldOffset(Offset = "0x50")]
		public Animation FlashAnim;

		// Token: 0x0400350C RID: 13580
		[Token(Token = "0x400350C")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public Vector2 Padding;

		// Token: 0x0400350D RID: 13581
		[Token(Token = "0x400350D")]
		[FieldOffset(Offset = "0x60")]
		public Vector2 Offset;

		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine autoCloseRoutine;

		// Token: 0x0400350F RID: 13583
		[Token(Token = "0x400350F")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine fadeRoutine;

		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x78")]
		private List<HintDisplay.Hint> hintQueue;

		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x80")]
		private float timeSinceOpened;

		// Token: 0x02000AAB RID: 2731
		[Token(Token = "0x2000AAB")]
		private class Hint
		{
			// Token: 0x06004A43 RID: 19011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A43")]
			[Address(RVA = "0x6670B0", Offset = "0x665AB0", VA = "0x1806670B0")]
			public Hint(string text, float duration)
			{
			}

			// Token: 0x04003512 RID: 13586
			[Token(Token = "0x4003512")]
			[FieldOffset(Offset = "0x10")]
			public string Text;

			// Token: 0x04003513 RID: 13587
			[Token(Token = "0x4003513")]
			[FieldOffset(Offset = "0x18")]
			public float Duration;
		}
	}
}
