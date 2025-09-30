using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x0200094D RID: 2381
	[Token(Token = "0x200094D")]
	public class PalletSlotDetector : MonoBehaviour
	{
		// Token: 0x06004123 RID: 16675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004123")]
		[Address(RVA = "0x880700", Offset = "0x87F100", VA = "0x180880700", Slot = "4")]
		protected virtual void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004124")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PalletSlotDetector()
		{
		}

		// Token: 0x04002DD4 RID: 11732
		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x20")]
		public Pallet pallet;
	}
}
