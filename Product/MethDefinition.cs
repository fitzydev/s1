using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200098E RID: 2446
	[Token(Token = "0x200098E")]
	[CreateAssetMenu(fileName = "MethDefinition", menuName = "ScriptableObjects/Item Definitions/MethDefinition", order = 1)]
	[Serializable]
	public class MethDefinition : ProductDefinition
	{
		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060042BC RID: 17084 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060042BD RID: 17085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000955")]
		public MethAppearanceSettings AppearanceSettings
		{
			[Token(Token = "0x60042BC")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042BD")]
			[Address(RVA = "0x5ADF40", Offset = "0x5AC940", VA = "0x1805ADF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042BE")]
		[Address(RVA = "0x87DFE0", Offset = "0x87C9E0", VA = "0x18087DFE0", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BF")]
		[Address(RVA = "0x87E280", Offset = "0x87CC80", VA = "0x18087E280")]
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x87E0D0", Offset = "0x87CAD0", VA = "0x18087E0D0", Slot = "30")]
		public override ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x87DA10", Offset = "0x87C410", VA = "0x18087DA10")]
		public static MethAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			return null;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x87E460", Offset = "0x87CE60", VA = "0x18087E460")]
		public MethDefinition()
		{
		}

		// Token: 0x04002EE5 RID: 12005
		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x110")]
		public Material CrystalMaterial;

		// Token: 0x04002EE6 RID: 12006
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x118")]
		[ColorUsage(true, true)]
		[SerializeField]
		public Color TintColor;
	}
}
