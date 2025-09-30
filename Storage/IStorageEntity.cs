using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	public interface IStorageEntity
	{
		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060040CA RID: 16586
		[Token(Token = "0x1700090F")]
		Transform storedItemContainer
		{
			[Token(Token = "0x60040CA")]
			get;
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060040CB RID: 16587
		[Token(Token = "0x17000910")]
		Dictionary<StoredItem, Employee> reservedItems
		{
			[Token(Token = "0x60040CB")]
			get;
		}

		// Token: 0x060040CC RID: 16588
		[Token(Token = "0x60040CC")]
		List<StoredItem> GetStoredItems();

		// Token: 0x060040CD RID: 16589
		[Token(Token = "0x60040CD")]
		List<StorageGrid> GetStorageGrids();

		// Token: 0x060040CE RID: 16590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CE")]
		[Address(RVA = "0x864A90", Offset = "0x863490", VA = "0x180864A90", Slot = "4")]
		List<StoredItem> GetStoredItemsByID(string ID)
		{
			return null;
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040CF")]
		[Address(RVA = "0x864EC0", Offset = "0x8638C0", VA = "0x180864EC0", Slot = "5")]
		void ReserveItem(StoredItem item, Employee employee)
		{
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D0")]
		[Address(RVA = "0x864750", Offset = "0x863150", VA = "0x180864750", Slot = "6")]
		void DereserveItem(StoredItem item)
		{
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x000111C0 File Offset: 0x0000F3C0
		[Token(Token = "0x60040D1")]
		[Address(RVA = "0x864E40", Offset = "0x863840", VA = "0x180864E40", Slot = "7")]
		bool IsItemReserved(StoredItem item)
		{
			return default(bool);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D2")]
		[Address(RVA = "0x865340", Offset = "0x863D40", VA = "0x180865340", Slot = "8")]
		Employee WhoIsReserving(StoredItem item)
		{
			return null;
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D3")]
		[Address(RVA = "0x864800", Offset = "0x863200", VA = "0x180864800", Slot = "9")]
		List<StoredItem> GetNonReservedItemsByPrefabID(string prefabID, Employee whosAskin)
		{
			return null;
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x8646C0", Offset = "0x8630C0", VA = "0x1808646C0", Slot = "10")]
		IEnumerator ClearReserve(StoredItem item)
		{
			return null;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x000111D8 File Offset: 0x0000F3D8
		[Token(Token = "0x60040D5")]
		[Address(RVA = "0x865180", Offset = "0x863B80", VA = "0x180865180", Slot = "11")]
		bool TryFitItem(int sizeX, int sizeY, out StorageGrid grid, out Coordinate originCoordinate, out float rotation)
		{
			return default(bool);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x000111F0 File Offset: 0x0000F3F0
		[Token(Token = "0x60040D6")]
		[Address(RVA = "0x864C40", Offset = "0x863640", VA = "0x180864C40", Slot = "12")]
		int HowManyCanFit(int sizeX, int sizeY, int limit = 2147483647)
		{
			return 0;
		}
	}
}
