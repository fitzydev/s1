using System;
using Il2CppDummyDll;
using ScheduleOne.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020009AB RID: 2475
	[Token(Token = "0x20009AB")]
	public class Product_Stored : StoredItem
	{
		// Token: 0x060043EB RID: 17387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043EB")]
		[Address(RVA = "0x8A7D50", Offset = "0x8A6750", VA = "0x1808A7D50", Slot = "6")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x860660", Offset = "0x85F060", VA = "0x180860660")]
		public Product_Stored()
		{
		}

		// Token: 0x04002F74 RID: 12148
		[Token(Token = "0x4002F74")]
		[FieldOffset(Offset = "0x80")]
		public FilledPackagingVisuals Visuals;
	}
}
