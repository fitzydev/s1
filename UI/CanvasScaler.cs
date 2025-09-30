using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	[RequireComponent(typeof(CanvasScaler))]
	public class CanvasScaler : MonoBehaviour
	{
		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x17000A3B")]
		public static float NormalizedCanvasScaleFactor
		{
			[Token(Token = "0x60048E8")]
			[Address(RVA = "0x8FFB00", Offset = "0x8FE500", VA = "0x1808FFB00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x8FF5F0", Offset = "0x8FDFF0", VA = "0x1808FF5F0")]
		public void Awake()
		{
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EA")]
		[Address(RVA = "0x8FF810", Offset = "0x8FE210", VA = "0x1808FF810")]
		private void OnDestroy()
		{
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x8FF950", Offset = "0x8FE350", VA = "0x1808FF950")]
		private void RefreshScale()
		{
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x8FFA00", Offset = "0x8FE400", VA = "0x1808FFA00")]
		public static void SetScaleFactor(float scaleFactor)
		{
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x8FFAE0", Offset = "0x8FE4E0", VA = "0x1808FFAE0")]
		public CanvasScaler()
		{
		}

		// Token: 0x040033DE RID: 13278
		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x0")]
		public static float CanvasScaleFactor;

		// Token: 0x040033DF RID: 13279
		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x8")]
		public static Action OnCanvasScaleFactorChanged;

		// Token: 0x040033E0 RID: 13280
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		// Token: 0x040033E1 RID: 13281
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 referenceResolution;

		// Token: 0x040033E2 RID: 13282
		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x30")]
		private CanvasScaler canvasScaler;
	}
}
