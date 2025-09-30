using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B18 RID: 2840
	[Token(Token = "0x2000B18")]
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD5")]
		public string ShownText
		{
			[Token(Token = "0x6004D08")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D09")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0A")]
		[Address(RVA = "0x9412A0", Offset = "0x93FCA0", VA = "0x1809412A0")]
		private void Awake()
		{
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0B")]
		[Address(RVA = "0x941320", Offset = "0x93FD20", VA = "0x180941320")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0C")]
		[Address(RVA = "0x941750", Offset = "0x940150", VA = "0x180941750")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0x941AA0", Offset = "0x9404A0", VA = "0x180941AA0")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0E")]
		[Address(RVA = "0x9417D0", Offset = "0x9401D0", VA = "0x1809417D0")]
		public void ShowText(string text, float duration = 0f)
		{
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0F")]
		[Address(RVA = "0x9416D0", Offset = "0x9400D0", VA = "0x1809416D0")]
		public void HideText()
		{
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D10")]
		[Address(RVA = "0x941770", Offset = "0x940170", VA = "0x180941770")]
		private void SetOpacity(float op)
		{
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D11")]
		[Address(RVA = "0x941EE0", Offset = "0x9408E0", VA = "0x180941EE0")]
		public WorldspaceDialogueRenderer()
		{
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D12")]
		[Address(RVA = "0x941A20", Offset = "0x940420", VA = "0x180941A20")]
		[CompilerGenerated]
		private IEnumerator <ShowText>g__Wait|22_0(float dur)
		{
			return null;
		}

		// Token: 0x040037D7 RID: 14295
		[Token(Token = "0x40037D7")]
		private const float FadeDist = 2f;

		// Token: 0x040037D9 RID: 14297
		[Token(Token = "0x40037D9")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float MaxRange;

		// Token: 0x040037DA RID: 14298
		[Token(Token = "0x40037DA")]
		[FieldOffset(Offset = "0x2C")]
		public float BaseScale;

		// Token: 0x040037DB RID: 14299
		[Token(Token = "0x40037DB")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve Scale;

		// Token: 0x040037DC RID: 14300
		[Token(Token = "0x40037DC")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 Padding;

		// Token: 0x040037DD RID: 14301
		[Token(Token = "0x40037DD")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 WorldSpaceOffset;

		// Token: 0x040037DE RID: 14302
		[Token(Token = "0x40037DE")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040037DF RID: 14303
		[Token(Token = "0x40037DF")]
		[FieldOffset(Offset = "0x58")]
		public CanvasGroup CanvasGroup;

		// Token: 0x040037E0 RID: 14304
		[Token(Token = "0x40037E0")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform Background;

		// Token: 0x040037E1 RID: 14305
		[Token(Token = "0x40037E1")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI Text;

		// Token: 0x040037E2 RID: 14306
		[Token(Token = "0x40037E2")]
		[FieldOffset(Offset = "0x70")]
		public Animation Anim;

		// Token: 0x040037E3 RID: 14307
		[Token(Token = "0x40037E3")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 localOffset;

		// Token: 0x040037E4 RID: 14308
		[Token(Token = "0x40037E4")]
		[FieldOffset(Offset = "0x84")]
		private float CurrentOpacity;

		// Token: 0x040037E5 RID: 14309
		[Token(Token = "0x40037E5")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine hideCoroutine;
	}
}
