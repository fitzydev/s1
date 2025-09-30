using System;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Storage
{
	// Token: 0x02000950 RID: 2384
	[Token(Token = "0x2000950")]
	[Serializable]
	public class StorableItemInstance : ItemInstance
	{
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091A")]
		[CodegenExclude]
		public virtual StoredItem StoredItem
		{
			[Token(Token = "0x6004133")]
			[Address(RVA = "0x886410", Offset = "0x884E10", VA = "0x180886410", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x886400", Offset = "0x884E00", VA = "0x180886400")]
		public StorableItemInstance()
		{
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x8862F0", Offset = "0x884CF0", VA = "0x1808862F0")]
		public StorableItemInstance(ItemDefinition definition, int quantity)
		{
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004136")]
		[Address(RVA = "0x886070", Offset = "0x884A70", VA = "0x180886070", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x000112B0 File Offset: 0x0000F4B0
		[Token(Token = "0x6004137")]
		[Address(RVA = "0x8861C0", Offset = "0x884BC0", VA = "0x1808861C0", Slot = "15")]
		public override float GetMonetaryValue()
		{
			return 0f;
		}
	}
}
