using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AC4 RID: 2756
	[Token(Token = "0x2000AC4")]
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		// Token: 0x06004AD5 RID: 19157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x91F880", Offset = "0x91E280", VA = "0x18091F880")]
		public void ShowTooltip(string text, Color col)
		{
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x91F810", Offset = "0x91E210", VA = "0x18091F810")]
		public void ShowIcon(Sprite sprite, Color col)
		{
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x91F670", Offset = "0x91E070", VA = "0x18091F670")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x91F8F0", Offset = "0x91E2F0", VA = "0x18091F8F0")]
		public MouseTooltip()
		{
		}

		// Token: 0x040035C0 RID: 13760
		[Token(Token = "0x40035C0")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform IconRect;

		// Token: 0x040035C1 RID: 13761
		[Token(Token = "0x40035C1")]
		[FieldOffset(Offset = "0x30")]
		public Image IconImg;

		// Token: 0x040035C2 RID: 13762
		[Token(Token = "0x40035C2")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform TooltipRect;

		// Token: 0x040035C3 RID: 13763
		[Token(Token = "0x40035C3")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI TooltipLabel;

		// Token: 0x040035C4 RID: 13764
		[Token(Token = "0x40035C4")]
		[FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public Vector3 TooltipOffset_NoIcon;

		// Token: 0x040035C5 RID: 13765
		[Token(Token = "0x40035C5")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 TooltipOffset_WithIcon;

		// Token: 0x040035C6 RID: 13766
		[Token(Token = "0x40035C6")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 IconOffset;

		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Colors")]
		public Color Color_Invalid;

		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x80")]
		[Header("Sprites")]
		public Sprite Sprite_Cross;

		// Token: 0x040035C9 RID: 13769
		[Token(Token = "0x40035C9")]
		[FieldOffset(Offset = "0x88")]
		private bool tooltipShownThisFrame;

		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x89")]
		private bool iconShownThisFrame;
	}
}
