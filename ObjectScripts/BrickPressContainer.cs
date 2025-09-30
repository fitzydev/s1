using System;
using Il2CppDummyDll;
using ScheduleOne.Packaging;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C92 RID: 3218
	[Token(Token = "0x2000C92")]
	public class BrickPressContainer : MonoBehaviour
	{
		// Token: 0x060057DF RID: 22495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057DF")]
		[Address(RVA = "0xA03070", Offset = "0xA01A70", VA = "0x180A03070")]
		public void SetContents(ProductItemInstance product, float fillLevel)
		{
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E0")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BrickPressContainer()
		{
		}

		// Token: 0x040040CE RID: 16590
		[Token(Token = "0x40040CE")]
		[FieldOffset(Offset = "0x20")]
		public FilledPackagingVisuals Visuals;

		// Token: 0x040040CF RID: 16591
		[Token(Token = "0x40040CF")]
		[FieldOffset(Offset = "0x28")]
		public Transform ContentsContainer;

		// Token: 0x040040D0 RID: 16592
		[Token(Token = "0x40040D0")]
		[FieldOffset(Offset = "0x30")]
		public Transform Contents_Min;

		// Token: 0x040040D1 RID: 16593
		[Token(Token = "0x40040D1")]
		[FieldOffset(Offset = "0x38")]
		public Transform Contents_Max;
	}
}
