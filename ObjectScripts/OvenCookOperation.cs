using System;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB4 RID: 3252
	[Token(Token = "0x2000CB4")]
	[Serializable]
	public class OvenCookOperation
	{
		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA5")]
		[CodegenExclude]
		public StorableItemDefinition Ingredient
		{
			[Token(Token = "0x6005AAD")]
			[Address(RVA = "0xA3C780", Offset = "0xA3B180", VA = "0x180A3C780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA6")]
		[CodegenExclude]
		public StorableItemDefinition Product
		{
			[Token(Token = "0x6005AAE")]
			[Address(RVA = "0xA3C890", Offset = "0xA3B290", VA = "0x180A3C890")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA7")]
		[CodegenExclude]
		public CookableModule Cookable
		{
			[Token(Token = "0x6005AAF")]
			[Address(RVA = "0xA3C6D0", Offset = "0xA3B0D0", VA = "0x180A3C6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB0")]
		[Address(RVA = "0xA3C5B0", Offset = "0xA3AFB0", VA = "0x180A3C5B0")]
		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID)
		{
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0xA3C650", Offset = "0xA3B050", VA = "0x180A3C650")]
		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress)
		{
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0xA3C630", Offset = "0xA3B030", VA = "0x180A3C630")]
		public OvenCookOperation()
		{
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0xA3C5A0", Offset = "0xA3AFA0", VA = "0x180A3C5A0")]
		public void UpdateCookProgress(int change)
		{
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0xA3C2E0", Offset = "0xA3ACE0", VA = "0x180A3C2E0")]
		public int GetCookDuration()
		{
			return 0;
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB5")]
		[Address(RVA = "0xA3C350", Offset = "0xA3AD50", VA = "0x180A3C350")]
		public ItemInstance GetProductItem(int quantity)
		{
			return null;
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x6005AB6")]
		[Address(RVA = "0xA3C520", Offset = "0xA3AF20", VA = "0x180A3C520")]
		public bool IsReady()
		{
			return default(bool);
		}

		// Token: 0x04004268 RID: 17000
		[Token(Token = "0x4004268")]
		[FieldOffset(Offset = "0x10")]
		[CodegenExclude]
		private StorableItemDefinition _itemDefinition;

		// Token: 0x04004269 RID: 17001
		[Token(Token = "0x4004269")]
		[FieldOffset(Offset = "0x18")]
		[CodegenExclude]
		private StorableItemDefinition _productionDefinition;

		// Token: 0x0400426A RID: 17002
		[Token(Token = "0x400426A")]
		[FieldOffset(Offset = "0x20")]
		[CodegenExclude]
		private CookableModule _cookable;

		// Token: 0x0400426B RID: 17003
		[Token(Token = "0x400426B")]
		[FieldOffset(Offset = "0x28")]
		public string IngredientID;

		// Token: 0x0400426C RID: 17004
		[Token(Token = "0x400426C")]
		[FieldOffset(Offset = "0x30")]
		public EQuality IngredientQuality;

		// Token: 0x0400426D RID: 17005
		[Token(Token = "0x400426D")]
		[FieldOffset(Offset = "0x34")]
		public int IngredientQuantity;

		// Token: 0x0400426E RID: 17006
		[Token(Token = "0x400426E")]
		[FieldOffset(Offset = "0x38")]
		public string ProductID;

		// Token: 0x0400426F RID: 17007
		[Token(Token = "0x400426F")]
		[FieldOffset(Offset = "0x40")]
		public int CookProgress;

		// Token: 0x04004270 RID: 17008
		[Token(Token = "0x4004270")]
		[FieldOffset(Offset = "0x44")]
		[CodegenExclude]
		private int cookDuration;
	}
}
