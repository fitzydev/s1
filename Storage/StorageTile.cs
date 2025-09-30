using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000958")]
	public class StorageTile : MonoBehaviour
	{
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000927")]
		public StorageGrid _ownerGrid
		{
			[Token(Token = "0x60041AC")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000928")]
		public StoredItem occupant
		{
			[Token(Token = "0x60041AD")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041AE")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041AF")]
		[Address(RVA = "0x88DD40", Offset = "0x88C740", VA = "0x18088DD40")]
		public void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B0")]
		[Address(RVA = "0x88DD60", Offset = "0x88C760", VA = "0x18088DD60")]
		public void SetOccupant(StoredItem occ)
		{
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B1")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public StorageTile()
		{
		}

		// Token: 0x04002DFE RID: 11774
		[Token(Token = "0x4002DFE")]
		[FieldOffset(Offset = "0x20")]
		public int x;

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[FieldOffset(Offset = "0x24")]
		public int y;

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public StorageGrid ownerGrid;

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		[FieldOffset(Offset = "0x30")]
		public Action onOccupantChanged;
	}
}
