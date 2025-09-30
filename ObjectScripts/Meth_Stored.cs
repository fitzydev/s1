using System;
using Il2CppDummyDll;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	public class Meth_Stored : StoredItem
	{
		// Token: 0x06005751 RID: 22353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005751")]
		[Address(RVA = "0xA1D2E0", Offset = "0xA1BCE0", VA = "0x180A1D2E0", Slot = "6")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005752")]
		[Address(RVA = "0x860660", Offset = "0x85F060", VA = "0x180860660")]
		public Meth_Stored()
		{
		}

		// Token: 0x04004098 RID: 16536
		[Token(Token = "0x4004098")]
		[FieldOffset(Offset = "0x80")]
		public MethVisuals Visuals;
	}
}
