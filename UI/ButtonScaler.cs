using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	public class ButtonScaler : MonoBehaviour
	{
		// Token: 0x060048D7 RID: 18647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D7")]
		[Address(RVA = "0x8FEF40", Offset = "0x8FD940", VA = "0x1808FEF40")]
		private void Awake()
		{
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D8")]
		[Address(RVA = "0x8FF230", Offset = "0x8FDC30", VA = "0x1808FF230")]
		private void Hovered()
		{
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D9")]
		[Address(RVA = "0x8FF1F0", Offset = "0x8FDBF0", VA = "0x1808FF1F0")]
		private void HoverEnd()
		{
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048DA")]
		[Address(RVA = "0x8FF270", Offset = "0x8FDC70", VA = "0x1808FF270")]
		private void SetScale(float endScale)
		{
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048DB")]
		[Address(RVA = "0x8FF380", Offset = "0x8FDD80", VA = "0x1808FF380")]
		public ButtonScaler()
		{
		}

		// Token: 0x040033CE RID: 13262
		[Token(Token = "0x40033CE")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform ScaleTarget;

		// Token: 0x040033CF RID: 13263
		[Token(Token = "0x40033CF")]
		[FieldOffset(Offset = "0x28")]
		public float HoverScale;

		// Token: 0x040033D0 RID: 13264
		[Token(Token = "0x40033D0")]
		[FieldOffset(Offset = "0x2C")]
		public float ScaleTime;

		// Token: 0x040033D1 RID: 13265
		[Token(Token = "0x40033D1")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine scaleCoroutine;

		// Token: 0x040033D2 RID: 13266
		[Token(Token = "0x40033D2")]
		[FieldOffset(Offset = "0x38")]
		private Button button;
	}
}
