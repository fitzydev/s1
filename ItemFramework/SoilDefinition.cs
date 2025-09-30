using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009DF RID: 2527
	[Token(Token = "0x20009DF")]
	[CreateAssetMenu(fileName = "SoilDefinition", menuName = "ScriptableObjects/Item Definitions/SoilDefinition", order = 1)]
	[Serializable]
	public class SoilDefinition : StorableItemDefinition
	{
		// Token: 0x0600454F RID: 17743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x8C91B0", Offset = "0x8C7BB0", VA = "0x1808C91B0")]
		public SoilDefinition()
		{
		}

		// Token: 0x0400308B RID: 12427
		[Token(Token = "0x400308B")]
		[FieldOffset(Offset = "0xB8")]
		public SoilDefinition.ESoilQuality SoilQuality;

		// Token: 0x0400308C RID: 12428
		[Token(Token = "0x400308C")]
		[FieldOffset(Offset = "0xC0")]
		public Material DrySoilMat;

		// Token: 0x0400308D RID: 12429
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0xC8")]
		public Material WetSoilMat;

		// Token: 0x0400308E RID: 12430
		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0xD0")]
		public Color ParticleColor;

		// Token: 0x0400308F RID: 12431
		[Token(Token = "0x400308F")]
		[FieldOffset(Offset = "0xE0")]
		public int Uses;

		// Token: 0x020009E0 RID: 2528
		[Token(Token = "0x20009E0")]
		public enum ESoilQuality
		{
			// Token: 0x04003091 RID: 12433
			[Token(Token = "0x4003091")]
			Basic,
			// Token: 0x04003092 RID: 12434
			[Token(Token = "0x4003092")]
			Premium
		}
	}
}
