using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	// Token: 0x02000929 RID: 2345
	[Token(Token = "0x2000929")]
	public class CocaPlant : Plant
	{
		// Token: 0x06004030 RID: 16432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004030")]
		[Address(RVA = "0x85E410", Offset = "0x85CE10", VA = "0x18085E410", Slot = "10")]
		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004031")]
		[Address(RVA = "0x85E500", Offset = "0x85CF00", VA = "0x18085E500")]
		public CocaPlant()
		{
		}

		// Token: 0x04002D16 RID: 11542
		[Token(Token = "0x4002D16")]
		[FieldOffset(Offset = "0xA0")]
		public PlantHarvestable Harvestable;
	}
}
