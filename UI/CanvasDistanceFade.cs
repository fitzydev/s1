using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A77 RID: 2679
	[Token(Token = "0x2000A77")]
	public class CanvasDistanceFade : MonoBehaviour
	{
		// Token: 0x060048E6 RID: 18662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E6")]
		[Address(RVA = "0x8FF3A0", Offset = "0x8FDDA0", VA = "0x1808FF3A0")]
		public void LateUpdate()
		{
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E7")]
		[Address(RVA = "0x8FF5D0", Offset = "0x8FDFD0", VA = "0x1808FF5D0")]
		public CanvasDistanceFade()
		{
		}

		// Token: 0x040033DB RID: 13275
		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x20")]
		public CanvasGroup CanvasGroup;

		// Token: 0x040033DC RID: 13276
		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x28")]
		public float MinDistance;

		// Token: 0x040033DD RID: 13277
		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxDistance;
	}
}
