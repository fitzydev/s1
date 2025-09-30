using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x0200097B RID: 2427
	[Token(Token = "0x200097B")]
	[CreateAssetMenu(fileName = "StationRecipe", menuName = "StationFramework/StationRecipe", order = 1)]
	[Serializable]
	public class StationRecipe : ScriptableObject
	{
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x17000950")]
		public float CookTemperatureLowerBound
		{
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x885FE0", Offset = "0x8849E0", VA = "0x180885FE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x17000951")]
		public float CookTemperatureUpperBound
		{
			[Token(Token = "0x600428B")]
			[Address(RVA = "0x885FF0", Offset = "0x8849F0", VA = "0x180885FF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000952")]
		public string RecipeID
		{
			[Token(Token = "0x600428C")]
			[Address(RVA = "0x886000", Offset = "0x884A00", VA = "0x180886000")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x885C80", Offset = "0x884680", VA = "0x180885C80")]
		public StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			return null;
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428E")]
		[Address(RVA = "0x885E00", Offset = "0x884800", VA = "0x180885E00")]
		public StorableItemInstance GetProductInstance(EQuality quality)
		{
			return null;
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x600428F")]
		[Address(RVA = "0x885930", Offset = "0x884330", VA = "0x180885930")]
		public bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			return default(bool);
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6004290")]
		[Address(RVA = "0x885720", Offset = "0x884120", VA = "0x180885720")]
		public EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			return EQuality.Trash;
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004291")]
		[Address(RVA = "0x885F40", Offset = "0x884940", VA = "0x180885F40")]
		public StationRecipe()
		{
		}

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool IsDiscovered;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0x20")]
		public string RecipeTitle;

		// Token: 0x04002EAA RID: 11946
		[Token(Token = "0x4002EAA")]
		[FieldOffset(Offset = "0x28")]
		public bool Unlocked;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x30")]
		public List<StationRecipe.IngredientQuantity> Ingredients;

		// Token: 0x04002EAC RID: 11948
		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0x38")]
		public StationRecipe.ItemQuantity Product;

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		[FieldOffset(Offset = "0x40")]
		public Color FinalLiquidColor;

		// Token: 0x04002EAE RID: 11950
		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The time it takes to cook this recipe in minutes")]
		public int CookTime_Mins;

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("The temperature at which this recipe should be cooked")]
		[Range(0f, 500f)]
		public float CookTemperature;

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 100f)]
		public float CookTemperatureTolerance;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x5C")]
		public StationRecipe.EQualityCalculationMethod QualityCalculationMethod;

		// Token: 0x0200097C RID: 2428
		[Token(Token = "0x200097C")]
		public enum EQualityCalculationMethod
		{
			// Token: 0x04002EB3 RID: 11955
			[Token(Token = "0x4002EB3")]
			Additive
		}

		// Token: 0x0200097D RID: 2429
		[Token(Token = "0x200097D")]
		[Serializable]
		public class ItemQuantity
		{
			// Token: 0x06004292 RID: 17042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004292")]
			[Address(RVA = "0x87CA30", Offset = "0x87B430", VA = "0x18087CA30")]
			public ItemQuantity()
			{
			}

			// Token: 0x04002EB4 RID: 11956
			[Token(Token = "0x4002EB4")]
			[FieldOffset(Offset = "0x10")]
			public ItemDefinition Item;

			// Token: 0x04002EB5 RID: 11957
			[Token(Token = "0x4002EB5")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;
		}

		// Token: 0x0200097E RID: 2430
		[Token(Token = "0x200097E")]
		[Serializable]
		public class IngredientQuantity
		{
			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x06004293 RID: 17043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000953")]
			public ItemDefinition Item
			{
				[Token(Token = "0x6004293")]
				[Address(RVA = "0x87C9D0", Offset = "0x87B3D0", VA = "0x18087C9D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004294 RID: 17044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004294")]
			[Address(RVA = "0x87C950", Offset = "0x87B350", VA = "0x18087C950")]
			public IngredientQuantity()
			{
			}

			// Token: 0x04002EB6 RID: 11958
			[Token(Token = "0x4002EB6")]
			[FieldOffset(Offset = "0x10")]
			public List<ItemDefinition> Items;

			// Token: 0x04002EB7 RID: 11959
			[Token(Token = "0x4002EB7")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;
		}
	}
}
