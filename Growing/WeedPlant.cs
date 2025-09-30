using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	// Token: 0x02000931 RID: 2353
	[Token(Token = "0x2000931")]
	public class WeedPlant : Plant
	{
		// Token: 0x06004059 RID: 16473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004059")]
		[Address(RVA = "0x878940", Offset = "0x877340", VA = "0x180878940", Slot = "10")]
		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405A")]
		[Address(RVA = "0x85E500", Offset = "0x85CF00", VA = "0x18085E500")]
		public WeedPlant()
		{
		}

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0xA0")]
		public PlantHarvestable BranchPrefab;
	}
}
