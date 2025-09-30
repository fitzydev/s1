using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B0F RID: 2831
	[Token(Token = "0x2000B0F")]
	public class UIMover : MonoBehaviour
	{
		// Token: 0x06004CD5 RID: 19669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD5")]
		[Address(RVA = "0x93F470", Offset = "0x93DE70", VA = "0x18093F470")]
		private void Start()
		{
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD6")]
		[Address(RVA = "0x93F4C0", Offset = "0x93DEC0", VA = "0x18093F4C0")]
		public void Update()
		{
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD7")]
		[Address(RVA = "0x93F550", Offset = "0x93DF50", VA = "0x18093F550")]
		public UIMover()
		{
		}

		// Token: 0x040037A8 RID: 14248
		[Token(Token = "0x40037A8")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform Rect;

		// Token: 0x040037A9 RID: 14249
		[Token(Token = "0x40037A9")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 MinSpeed;

		// Token: 0x040037AA RID: 14250
		[Token(Token = "0x40037AA")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 MaxSpeed;

		// Token: 0x040037AB RID: 14251
		[Token(Token = "0x40037AB")]
		[FieldOffset(Offset = "0x38")]
		public float SpeedMultiplier;

		// Token: 0x040037AC RID: 14252
		[Token(Token = "0x40037AC")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 speed;
	}
}
