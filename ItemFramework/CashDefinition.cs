using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009DD RID: 2525
	[Token(Token = "0x20009DD")]
	[CreateAssetMenu(fileName = "CashDefinition", menuName = "ScriptableObjects/CashDefinition", order = 1)]
	[Serializable]
	public class CashDefinition : StorableItemDefinition
	{
		// Token: 0x06004544 RID: 17732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004544")]
		[Address(RVA = "0x8B13E0", Offset = "0x8AFDE0", VA = "0x1808B13E0", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004545")]
		[Address(RVA = "0x873FB0", Offset = "0x8729B0", VA = "0x180873FB0")]
		public CashDefinition()
		{
		}
	}
}
