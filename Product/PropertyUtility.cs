using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020009AD RID: 2477
	[Token(Token = "0x20009AD")]
	public class PropertyUtility : Singleton<PropertyUtility>
	{
		// Token: 0x060043F0 RID: 17392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F0")]
		[Address(RVA = "0x8A7F80", Offset = "0x8A6980", VA = "0x1808A7F80", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F1")]
		[Address(RVA = "0x8A8C10", Offset = "0x8A7610", VA = "0x1808A8C10", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F2")]
		[Address(RVA = "0x8A89B0", Offset = "0x8A73B0", VA = "0x1808A89B0")]
		public List<Property> GetProperties(int tier)
		{
			return null;
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F3")]
		[Address(RVA = "0x8A85F0", Offset = "0x8A6FF0", VA = "0x1808A85F0")]
		public List<Property> GetProperties(List<string> ids)
		{
			return null;
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F4")]
		[Address(RVA = "0x8A8AF0", Offset = "0x8A74F0", VA = "0x1808A8AF0")]
		public static PropertyUtility.PropertyData GetPropertyData(EProperty property)
		{
			return null;
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F5")]
		[Address(RVA = "0x8A80D0", Offset = "0x8A6AD0", VA = "0x1808A80D0")]
		public static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType)
		{
			return null;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x8A81F0", Offset = "0x8A6BF0", VA = "0x1808A81F0")]
		public static List<Color32> GetOrderedPropertyColors(List<Property> properties)
		{
			return null;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F7")]
		[Address(RVA = "0x8A8C50", Offset = "0x8A7650", VA = "0x1808A8C50")]
		public PropertyUtility()
		{
		}

		// Token: 0x04002F76 RID: 12150
		[Token(Token = "0x4002F76")]
		[FieldOffset(Offset = "0x28")]
		public List<PropertyUtility.PropertyData> PropertyDatas;

		// Token: 0x04002F77 RID: 12151
		[Token(Token = "0x4002F77")]
		[FieldOffset(Offset = "0x30")]
		public List<PropertyUtility.DrugTypeData> DrugTypeDatas;

		// Token: 0x04002F78 RID: 12152
		[Token(Token = "0x4002F78")]
		[FieldOffset(Offset = "0x38")]
		public List<Property> AllProperties;

		// Token: 0x04002F79 RID: 12153
		[Token(Token = "0x4002F79")]
		[FieldOffset(Offset = "0x40")]
		[Header("Test Mixing")]
		public List<ProductDefinition> Products;

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		[FieldOffset(Offset = "0x48")]
		public List<PropertyItemDefinition> Properties;

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, Property> PropertiesDict;

		// Token: 0x020009AE RID: 2478
		[Token(Token = "0x20009AE")]
		[Serializable]
		public class PropertyData
		{
			// Token: 0x060043F8 RID: 17400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043F8")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public PropertyData()
			{
			}

			// Token: 0x04002F7C RID: 12156
			[Token(Token = "0x4002F7C")]
			[FieldOffset(Offset = "0x10")]
			public EProperty Property;

			// Token: 0x04002F7D RID: 12157
			[Token(Token = "0x4002F7D")]
			[FieldOffset(Offset = "0x18")]
			public string Name;

			// Token: 0x04002F7E RID: 12158
			[Token(Token = "0x4002F7E")]
			[FieldOffset(Offset = "0x20")]
			public string Description;

			// Token: 0x04002F7F RID: 12159
			[Token(Token = "0x4002F7F")]
			[FieldOffset(Offset = "0x28")]
			public Color Color;
		}

		// Token: 0x020009AF RID: 2479
		[Token(Token = "0x20009AF")]
		[Serializable]
		public class DrugTypeData
		{
			// Token: 0x060043F9 RID: 17401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043F9")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public DrugTypeData()
			{
			}

			// Token: 0x04002F80 RID: 12160
			[Token(Token = "0x4002F80")]
			[FieldOffset(Offset = "0x10")]
			public EDrugType DrugType;

			// Token: 0x04002F81 RID: 12161
			[Token(Token = "0x4002F81")]
			[FieldOffset(Offset = "0x18")]
			public string Name;

			// Token: 0x04002F82 RID: 12162
			[Token(Token = "0x4002F82")]
			[FieldOffset(Offset = "0x20")]
			public Color Color;
		}
	}
}
