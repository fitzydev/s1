using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2000B0C")]
	public class SlidingRect : MonoBehaviour
	{
		// Token: 0x06004CC6 RID: 19654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC6")]
		[Address(RVA = "0x935780", Offset = "0x934180", VA = "0x180935780")]
		public void Update()
		{
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x935840", Offset = "0x934240", VA = "0x180935840")]
		public SlidingRect()
		{
		}

		// Token: 0x0400379E RID: 14238
		[Token(Token = "0x400379E")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform Rect;

		// Token: 0x0400379F RID: 14239
		[Token(Token = "0x400379F")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 Start;

		// Token: 0x040037A0 RID: 14240
		[Token(Token = "0x40037A0")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 End;

		// Token: 0x040037A1 RID: 14241
		[Token(Token = "0x40037A1")]
		[FieldOffset(Offset = "0x38")]
		public float Duration;

		// Token: 0x040037A2 RID: 14242
		[Token(Token = "0x40037A2")]
		[FieldOffset(Offset = "0x3C")]
		public float SpeedMultiplier;

		// Token: 0x040037A3 RID: 14243
		[Token(Token = "0x40037A3")]
		[FieldOffset(Offset = "0x40")]
		private float _time;
	}
}
