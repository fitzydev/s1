using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x0200092C RID: 2348
	[Token(Token = "0x200092C")]
	public class PlantHarvestable : MonoBehaviour
	{
		// Token: 0x06004046 RID: 16454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004046")]
		[Address(RVA = "0x870C80", Offset = "0x86F680", VA = "0x180870C80", Slot = "4")]
		public virtual void Harvest(bool giveProduct = true)
		{
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004047")]
		[Address(RVA = "0x8712D0", Offset = "0x86FCD0", VA = "0x1808712D0")]
		public PlantHarvestable()
		{
		}

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x20")]
		public StorableItemDefinition Product;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x28")]
		public int ProductQuantity;
	}
}
