using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x0200092E RID: 2350
	[Token(Token = "0x200092E")]
	[CreateAssetMenu(fileName = "SeedDefinition", menuName = "ScriptableObjects/Item Definitions/SeedDefinition", order = 1)]
	[Serializable]
	public class SeedDefinition : StorableItemDefinition
	{
		// Token: 0x0600404A RID: 16458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x873FB0", Offset = "0x8729B0", VA = "0x180873FB0")]
		public SeedDefinition()
		{
		}

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0xB8")]
		public FunctionalSeed FunctionSeedPrefab;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0xC0")]
		public Plant PlantPrefab;
	}
}
