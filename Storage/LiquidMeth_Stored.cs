using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000947 RID: 2375
	[Token(Token = "0x2000947")]
	public class LiquidMeth_Stored : StoredItem
	{
		// Token: 0x060040C3 RID: 16579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x865990", Offset = "0x864390", VA = "0x180865990", Slot = "6")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x860660", Offset = "0x85F060", VA = "0x180860660")]
		public LiquidMeth_Stored()
		{
		}

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x80")]
		public LiquidMethVisuals Visuals;
	}
}
