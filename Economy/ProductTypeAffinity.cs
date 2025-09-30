using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	[Serializable]
	public class ProductTypeAffinity
	{
		// Token: 0x06002463 RID: 9315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public ProductTypeAffinity()
		{
		}

		// Token: 0x04001C43 RID: 7235
		[Token(Token = "0x4001C43")]
		[FieldOffset(Offset = "0x10")]
		public EDrugType DrugType;

		// Token: 0x04001C44 RID: 7236
		[Token(Token = "0x4001C44")]
		[FieldOffset(Offset = "0x14")]
		[Range(-1f, 1f)]
		public float Affinity;
	}
}
