using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	public class CookableModule : ItemModule
	{
		// Token: 0x06004227 RID: 16935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004227")]
		[Address(RVA = "0x87B820", Offset = "0x87A220", VA = "0x18087B820")]
		public CookableModule()
		{
		}

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		[FieldOffset(Offset = "0x30")]
		[Header("Cook Settings")]
		public int CookTime;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x34")]
		public CookableModule.ECookableType CookType;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x38")]
		[Header("Product Settings")]
		public StorableItemDefinition Product;

		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		[FieldOffset(Offset = "0x40")]
		public int ProductQuantity;

		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0x48")]
		public Rigidbody ProductShardPrefab;

		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x50")]
		[Header("Appearance")]
		public Color LiquidColor;

		// Token: 0x04002E52 RID: 11858
		[Token(Token = "0x4002E52")]
		[FieldOffset(Offset = "0x60")]
		public Color SolidColor;

		// Token: 0x02000967 RID: 2407
		[Token(Token = "0x2000967")]
		public enum ECookableType
		{
			// Token: 0x04002E54 RID: 11860
			[Token(Token = "0x4002E54")]
			Liquid,
			// Token: 0x04002E55 RID: 11861
			[Token(Token = "0x4002E55")]
			Solid
		}
	}
}
