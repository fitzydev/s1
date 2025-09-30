using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Properties;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000996 RID: 2454
	[Token(Token = "0x2000996")]
	[CreateAssetMenu(fileName = "ProductDefinition", menuName = "ScriptableObjects/ProductDefinition", order = 1)]
	[Serializable]
	public class ProductDefinition : PropertyItemDefinition, ISaveable
	{
		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x17000956")]
		public EDrugType DrugType
		{
			[Token(Token = "0x60042E1")]
			[Address(RVA = "0x882A20", Offset = "0x881420", VA = "0x180882A20")]
			get
			{
				return EDrugType.Marijuana;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x17000957")]
		public float Price
		{
			[Token(Token = "0x60042E2")]
			[Address(RVA = "0x882A80", Offset = "0x881480", VA = "0x180882A80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000958")]
		public List<StationRecipe> Recipes
		{
			[Token(Token = "0x60042E3")]
			[Address(RVA = "0x53B830", Offset = "0x53A230", VA = "0x18053B830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042E4")]
			[Address(RVA = "0x60C840", Offset = "0x60B240", VA = "0x18060C840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000959")]
		public string SaveFolderName
		{
			[Token(Token = "0x60042E5")]
			[Address(RVA = "0x882B10", Offset = "0x881510", VA = "0x180882B10", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095A")]
		public string SaveFileName
		{
			[Token(Token = "0x60042E6")]
			[Address(RVA = "0x882B10", Offset = "0x881510", VA = "0x180882B10", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095B")]
		public Loader Loader
		{
			[Token(Token = "0x60042E7")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060042E8 RID: 17128 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x1700095C")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60042E8")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060042E9 RID: 17129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060042EA RID: 17130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700095D")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60042E9")]
			[Address(RVA = "0x60C7B0", Offset = "0x60B1B0", VA = "0x18060C7B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042EA")]
			[Address(RVA = "0x60C860", Offset = "0x60B260", VA = "0x18060C860", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060042EC RID: 17132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700095E")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60042EB")]
			[Address(RVA = "0x53B7E0", Offset = "0x53A1E0", VA = "0x18053B7E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042EC")]
			[Address(RVA = "0x5432B0", Offset = "0x541CB0", VA = "0x1805432B0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x000119A0 File Offset: 0x0000FBA0
		// (set) Token: 0x060042EE RID: 17134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700095F")]
		public bool HasChanged
		{
			[Token(Token = "0x60042ED")]
			[Address(RVA = "0x516D30", Offset = "0x515730", VA = "0x180516D30", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60042EE")]
			[Address(RVA = "0x516F20", Offset = "0x515920", VA = "0x180516F20", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x882370", Offset = "0x880D70", VA = "0x180882370", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
		public void OnValidate()
		{
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x882650", Offset = "0x881050", VA = "0x180882650")]
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes)
		{
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x8825C0", Offset = "0x880FC0", VA = "0x1808825C0", Slot = "29")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x000119B8 File Offset: 0x0000FBB8
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x8822A0", Offset = "0x880CA0", VA = "0x1808822A0")]
		public float GetAddictiveness()
		{
			return 0f;
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F4")]
		[Address(RVA = "0x8821B0", Offset = "0x880BB0", VA = "0x1808821B0")]
		public void CleanRecipes()
		{
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F5")]
		[Address(RVA = "0x882020", Offset = "0x880A20", VA = "0x180882020")]
		public void AddRecipe(StationRecipe recipe)
		{
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F6")]
		[Address(RVA = "0x8823F0", Offset = "0x880DF0", VA = "0x1808823F0", Slot = "30")]
		public virtual ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F7")]
		[Address(RVA = "0x882580", Offset = "0x880F80", VA = "0x180882580", Slot = "31")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F8")]
		[Address(RVA = "0x8828F0", Offset = "0x8812F0", VA = "0x1808828F0")]
		public ProductDefinition()
		{
		}

		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Product Settings")]
		public List<DrugTypeContainer> DrugTypes;

		// Token: 0x04002F02 RID: 12034
		[Token(Token = "0x4002F02")]
		[FieldOffset(Offset = "0xC8")]
		public float LawIntensityChange;

		// Token: 0x04002F03 RID: 12035
		[Token(Token = "0x4002F03")]
		[FieldOffset(Offset = "0xCC")]
		public float BasePrice;

		// Token: 0x04002F04 RID: 12036
		[Token(Token = "0x4002F04")]
		[FieldOffset(Offset = "0xD0")]
		public float MarketValue;

		// Token: 0x04002F05 RID: 12037
		[Token(Token = "0x4002F05")]
		[FieldOffset(Offset = "0xD8")]
		public FunctionalProduct FunctionalProduct;

		// Token: 0x04002F06 RID: 12038
		[Token(Token = "0x4002F06")]
		[FieldOffset(Offset = "0xE0")]
		public int EffectsDuration;

		// Token: 0x04002F07 RID: 12039
		[Token(Token = "0x4002F07")]
		[FieldOffset(Offset = "0xE4")]
		[Range(0f, 1f)]
		public float BaseAddictiveness;

		// Token: 0x04002F08 RID: 12040
		[Token(Token = "0x4002F08")]
		[FieldOffset(Offset = "0xE8")]
		[Header("Packaging that can be applied to this product. MUST BE ORDERED FROm LOWEST TO HIGHEST QUANTITY")]
		public PackagingDefinition[] ValidPackaging;
	}
}
