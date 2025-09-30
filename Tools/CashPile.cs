using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008EB RID: 2283
	[Token(Token = "0x20008EB")]
	public class CashPile : MonoBehaviour
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4A")]
		[Address(RVA = "0x85E030", Offset = "0x85CA30", VA = "0x18085E030")]
		private void Awake()
		{
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0x85E1A0", Offset = "0x85CBA0", VA = "0x18085E1A0")]
		public void SetDisplayedAmount(float amount)
		{
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CashPile()
		{
		}

		// Token: 0x04002C57 RID: 11351
		[Token(Token = "0x4002C57")]
		public const float MAX_AMOUNT = 100000f;

		// Token: 0x04002C58 RID: 11352
		[Token(Token = "0x4002C58")]
		[FieldOffset(Offset = "0x20")]
		public Transform Container;

		// Token: 0x04002C59 RID: 11353
		[Token(Token = "0x4002C59")]
		[FieldOffset(Offset = "0x28")]
		private Transform[] CashInstances;
	}
}
