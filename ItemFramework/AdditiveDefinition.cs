using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009E1 RID: 2529
	[Token(Token = "0x20009E1")]
	[CreateAssetMenu(fileName = "AdditiveDefinition", menuName = "ScriptableObjects/Item Definitions/AdditiveDefinition", order = 1)]
	[Serializable]
	public class AdditiveDefinition : StorableItemDefinition
	{
		// Token: 0x06004550 RID: 17744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x873FB0", Offset = "0x8729B0", VA = "0x180873FB0")]
		public AdditiveDefinition()
		{
		}

		// Token: 0x04003093 RID: 12435
		[Token(Token = "0x4003093")]
		[FieldOffset(Offset = "0xB8")]
		public Additive AdditivePrefab;
	}
}
