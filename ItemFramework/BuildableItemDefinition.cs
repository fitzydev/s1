using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009E2 RID: 2530
	[Token(Token = "0x20009E2")]
	[CreateAssetMenu(fileName = "BuildableItemDefinition", menuName = "ScriptableObjects/BuildableItemDefinition", order = 1)]
	[Serializable]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		// Token: 0x06004551 RID: 17745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x873FB0", Offset = "0x8729B0", VA = "0x180873FB0")]
		public BuildableItemDefinition()
		{
		}

		// Token: 0x04003094 RID: 12436
		[Token(Token = "0x4003094")]
		[FieldOffset(Offset = "0xB8")]
		public BuildableItem BuiltItem;

		// Token: 0x04003095 RID: 12437
		[Token(Token = "0x4003095")]
		[FieldOffset(Offset = "0xC0")]
		public BuildableItemDefinition.EBuildSoundType BuildSoundType;

		// Token: 0x020009E3 RID: 2531
		[Token(Token = "0x20009E3")]
		public enum EBuildSoundType
		{
			// Token: 0x04003097 RID: 12439
			[Token(Token = "0x4003097")]
			Cardboard,
			// Token: 0x04003098 RID: 12440
			[Token(Token = "0x4003098")]
			Wood,
			// Token: 0x04003099 RID: 12441
			[Token(Token = "0x4003099")]
			Metal
		}
	}
}
