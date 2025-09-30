using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A9C RID: 2716
	[Token(Token = "0x2000A9C")]
	public class Flipboard : MonoBehaviour
	{
		// Token: 0x060049E4 RID: 18916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E4")]
		[Address(RVA = "0x9154E0", Offset = "0x913EE0", VA = "0x1809154E0")]
		public void Update()
		{
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E5")]
		[Address(RVA = "0x915490", Offset = "0x913E90", VA = "0x180915490")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E6")]
		[Address(RVA = "0x915570", Offset = "0x913F70", VA = "0x180915570")]
		public Flipboard()
		{
		}

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x20")]
		public Sprite[] Sprites;

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x28")]
		public Image Image;

		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x30")]
		public float FlipTime;

		// Token: 0x040034B0 RID: 13488
		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x34")]
		public float SpeedMultiplier;

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x38")]
		private float time;

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0x3C")]
		private int index;
	}
}
