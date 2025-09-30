using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F3 RID: 2547
	[Token(Token = "0x20009F3")]
	[CreateAssetMenu(fileName = "IntegerItemDefinition", menuName = "ScriptableObjects/IntegerItemDefinition", order = 1)]
	[Serializable]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		// Token: 0x06004585 RID: 17797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004585")]
		[Address(RVA = "0x8BF3F0", Offset = "0x8BDDF0", VA = "0x1808BF3F0", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004586")]
		[Address(RVA = "0x873FB0", Offset = "0x8729B0", VA = "0x180873FB0")]
		public IntegerItemDefinition()
		{
		}

		// Token: 0x040030B6 RID: 12470
		[Token(Token = "0x40030B6")]
		[FieldOffset(Offset = "0xB8")]
		public int DefaultValue;
	}
}
