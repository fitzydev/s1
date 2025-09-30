using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000ABE RID: 2750
	[Token(Token = "0x2000ABE")]
	public class LoadingScreen : PersistentSingleton<LoadingScreen>
	{
		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x00013638 File Offset: 0x00011838
		// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7C")]
		public bool IsOpen
		{
			[Token(Token = "0x6004AB4")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AB5")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7D")]
		public Sprite[] ContextualBackgroundImages
		{
			[Token(Token = "0x6004AB6")]
			[Address(RVA = "0x91F650", Offset = "0x91E050", VA = "0x18091F650")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x91ED10", Offset = "0x91D710", VA = "0x18091ED10", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x91F560", Offset = "0x91DF60", VA = "0x18091F560")]
		protected void Update()
		{
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x91F240", Offset = "0x91DC40", VA = "0x18091F240")]
		public void Open(bool loadingTutorial = false)
		{
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x91F000", Offset = "0x91DA00", VA = "0x18091F000")]
		public void Close()
		{
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABB")]
		[Address(RVA = "0x91EC50", Offset = "0x91D650", VA = "0x18091EC50")]
		private void AnimateBackground()
		{
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABC")]
		[Address(RVA = "0x91F120", Offset = "0x91DB20", VA = "0x18091F120")]
		private void Fade(float endAlpha)
		{
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABD")]
		[Address(RVA = "0x91F610", Offset = "0x91E010", VA = "0x18091F610")]
		public LoadingScreen()
		{
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABE")]
		[Address(RVA = "0x91F4F0", Offset = "0x91DEF0", VA = "0x18091F4F0")]
		[CompilerGenerated]
		private IEnumerator <AnimateBackground>g__Routine|30_0()
		{
			return null;
		}

		// Token: 0x04003597 RID: 13719
		[Token(Token = "0x4003597")]
		public const float FADE_TIME = 0.25f;

		// Token: 0x04003598 RID: 13720
		[Token(Token = "0x4003598")]
		public const float BACKGROUND_IMAGE_TIME = 8f;

		// Token: 0x04003599 RID: 13721
		[Token(Token = "0x4003599")]
		public const float BACKGROUND_IMAGE_FADE_TIME = 1f;

		// Token: 0x0400359B RID: 13723
		[Token(Token = "0x400359B")]
		[FieldOffset(Offset = "0x30")]
		public StringDatabase LoadingMessagesDatabase;

		// Token: 0x0400359C RID: 13724
		[Token(Token = "0x400359C")]
		[FieldOffset(Offset = "0x38")]
		public Sprite[] BackgroundImages;

		// Token: 0x0400359D RID: 13725
		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x40")]
		public Sprite[] TutorialBackgroundImages;

		// Token: 0x0400359E RID: 13726
		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x50")]
		public CanvasGroup Group;

		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI LoadStatusLabel;

		// Token: 0x040035A1 RID: 13729
		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI LoadingMessageLabel;

		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x68")]
		public Image BackgroundImage1;

		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x70")]
		public Image BackgroundImage2;

		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform TutorialContainer;

		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform CoopTutorialHint;

		// Token: 0x040035A6 RID: 13734
		[Token(Token = "0x40035A6")]
		[FieldOffset(Offset = "0x88")]
		private string[] loadingMessages;

		// Token: 0x040035A7 RID: 13735
		[Token(Token = "0x40035A7")]
		[FieldOffset(Offset = "0x90")]
		private int currentBackgroundImageIndex;

		// Token: 0x040035A8 RID: 13736
		[Token(Token = "0x40035A8")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine fadeRoutine;

		// Token: 0x040035A9 RID: 13737
		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine animateBackgroundRoutine;

		// Token: 0x040035AA RID: 13738
		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine scaleBackgroundRoutine;

		// Token: 0x040035AB RID: 13739
		[Token(Token = "0x40035AB")]
		[FieldOffset(Offset = "0xB0")]
		private bool isLoadingTutorial;
	}
}
