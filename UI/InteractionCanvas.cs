using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AB5 RID: 2741
	[Token(Token = "0x2000AB5")]
	public class InteractionCanvas : Singleton<InteractionCanvas>
	{
		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x000135C0 File Offset: 0x000117C0
		// (set) Token: 0x06004A73 RID: 19059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A74")]
		public float TempDisplayScale
		{
			[Token(Token = "0x6004A72")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A73")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x91A510", Offset = "0x918F10", VA = "0x18091A510", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x919F80", Offset = "0x918980", VA = "0x180919F80")]
		public void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)
		{
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x91A650", Offset = "0x919050", VA = "0x18091A650")]
		public void LerpDisplayScale(float endScale)
		{
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x91A480", Offset = "0x918E80", VA = "0x18091A480")]
		protected IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			return null;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x91A720", Offset = "0x919120", VA = "0x18091A720")]
		public InteractionCanvas()
		{
		}

		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		public const float DISPLAY_SIZE_MULTIPLIER = 0.75f;

		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public Color DefaultMessageColor;

		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0x3C")]
		public Color DefaultIconColor;

		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x4C")]
		public Color DefaultKeyColor;

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x5C")]
		public Color InvalidMessageColor;

		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x6C")]
		public Color InvalidIconColor;

		// Token: 0x0400355A RID: 13658
		[Token(Token = "0x400355A")]
		[FieldOffset(Offset = "0x80")]
		public Sprite KeyIcon;

		// Token: 0x0400355B RID: 13659
		[Token(Token = "0x400355B")]
		[FieldOffset(Offset = "0x88")]
		public Sprite LeftMouseIcon;

		// Token: 0x0400355C RID: 13660
		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0x90")]
		public Sprite CrossIcon;

		// Token: 0x0400355D RID: 13661
		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0x98")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400355E RID: 13662
		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform Container;

		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0xA8")]
		public Image Icon;

		// Token: 0x04003560 RID: 13664
		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0xB0")]
		public Text IconText;

		// Token: 0x04003561 RID: 13665
		[Token(Token = "0x4003561")]
		[FieldOffset(Offset = "0xB8")]
		public Text MessageText;

		// Token: 0x04003562 RID: 13666
		[Token(Token = "0x4003562")]
		[FieldOffset(Offset = "0xC0")]
		public RectTransform WSLabelContainer;

		// Token: 0x04003563 RID: 13667
		[Token(Token = "0x4003563")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform BackgroundImage;

		// Token: 0x04003564 RID: 13668
		[Token(Token = "0x4003564")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Prefabs")]
		public GameObject WSLabelPrefab;

		// Token: 0x04003565 RID: 13669
		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0xD8")]
		private bool interactionDisplayEnabledThisFrame;

		// Token: 0x04003566 RID: 13670
		[Token(Token = "0x4003566")]
		[FieldOffset(Offset = "0xE0")]
		[HideInInspector]
		public List<WorldSpaceLabel> ActiveWSlabels;

		// Token: 0x04003567 RID: 13671
		[Token(Token = "0x4003567")]
		[FieldOffset(Offset = "0xE8")]
		private Coroutine ILerpDisplayScale_Coroutine;
	}
}
