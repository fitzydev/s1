using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000922 RID: 2338
	[Token(Token = "0x2000922")]
	public class VehicleSaleSign : MonoBehaviour
	{
		// Token: 0x0600401E RID: 16414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401E")]
		[Address(RVA = "0x878310", Offset = "0x876D10", VA = "0x180878310")]
		private void Awake()
		{
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401F")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleSaleSign()
		{
		}

		// Token: 0x04002CF7 RID: 11511
		[Token(Token = "0x4002CF7")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshPro NameLabel;

		// Token: 0x04002CF8 RID: 11512
		[Token(Token = "0x4002CF8")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshPro PriceLabel;
	}
}
