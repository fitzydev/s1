using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000933 RID: 2355
	[Token(Token = "0x2000933")]
	public class FilledPackaging_StoredItem : StoredItem
	{
		// Token: 0x0600405D RID: 16477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x860560", Offset = "0x85EF60", VA = "0x180860560", Slot = "6")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405E")]
		[Address(RVA = "0x860460", Offset = "0x85EE60", VA = "0x180860460", Slot = "9")]
		public override GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			return null;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x860660", Offset = "0x85F060", VA = "0x180860660")]
		public FilledPackaging_StoredItem()
		{
		}

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x80")]
		public FilledPackagingVisuals Visuals;
	}
}
