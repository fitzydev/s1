using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000981 RID: 2433
	[Token(Token = "0x2000981")]
	[CreateAssetMenu(fileName = "LiquidMethDefinition", menuName = "ScriptableObjects/LiquidMethDefinition", order = 1)]
	[Serializable]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		// Token: 0x06004299 RID: 17049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x87D5B0", Offset = "0x87BFB0", VA = "0x18087D5B0")]
		public LiquidMethDefinition()
		{
		}

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Liquid Meth Color Settings")]
		public Color StaticLiquidColor;

		// Token: 0x04002EBB RID: 11963
		[Token(Token = "0x4002EBB")]
		[FieldOffset(Offset = "0xD0")]
		public Color LiquidVolumeColor;

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0xE0")]
		public Color PourParticlesColor;

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0xF0")]
		public Color CookableLiquidColor;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x100")]
		public Color CookableSolidColor;
	}
}
