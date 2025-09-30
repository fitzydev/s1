using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000825 RID: 2085
	[Token(Token = "0x2000825")]
	public class BuildStart_StoredItem : BuildStart_Base
	{
		// Token: 0x06003955 RID: 14677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003955")]
		[Address(RVA = "0x7F7CD0", Offset = "0x7F66D0", VA = "0x1807F7CD0", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003956")]
		[Address(RVA = "0x7F7A20", Offset = "0x7F6420", VA = "0x1807F7A20", Slot = "5")]
		protected virtual GameObject CreateGhostModel(StorableItemInstance item)
		{
			return null;
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003957")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BuildStart_StoredItem()
		{
		}
	}
}
