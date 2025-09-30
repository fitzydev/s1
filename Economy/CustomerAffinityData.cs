using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x20005DC")]
	[Serializable]
	public class CustomerAffinityData
	{
		// Token: 0x06002464 RID: 9316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x6D05A0", Offset = "0x6CEFA0", VA = "0x1806D05A0")]
		public void CopyTo(CustomerAffinityData data)
		{
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x6D08A0", Offset = "0x6CF2A0", VA = "0x1806D08A0")]
		public float GetAffinity(EDrugType type)
		{
			return 0f;
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x6D0A10", Offset = "0x6CF410", VA = "0x1806D0A10")]
		public CustomerAffinityData()
		{
		}

		// Token: 0x04001C45 RID: 7237
		[Token(Token = "0x4001C45")]
		[FieldOffset(Offset = "0x10")]
		[Header("Product Affinities - How much the customer likes each product type. -1 = hates, 0 = neutral, 1 = loves.")]
		public List<ProductTypeAffinity> ProductAffinities;
	}
}
