using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020009B7 RID: 2487
	[Token(Token = "0x20009B7")]
	[CreateAssetMenu(fileName = "WeedDefinition", menuName = "ScriptableObjects/Item Definitions/WeedDefinition", order = 1)]
	[Serializable]
	public class WeedDefinition : ProductDefinition
	{
		// Token: 0x0600440A RID: 17418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440A")]
		[Address(RVA = "0x8AA220", Offset = "0x8A8C20", VA = "0x1808AA220", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440B")]
		[Address(RVA = "0x8AA450", Offset = "0x8A8E50", VA = "0x1808AA450")]
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance)
		{
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x8AA2A0", Offset = "0x8A8CA0", VA = "0x1808AA2A0", Slot = "30")]
		public override ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440D")]
		[Address(RVA = "0x8A9C10", Offset = "0x8A8610", VA = "0x1808A9C10")]
		public static WeedAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			return null;
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x87A870", Offset = "0x879270", VA = "0x18087A870")]
		public WeedDefinition()
		{
		}

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x110")]
		[Header("Weed Materials")]
		public Material MainMat;

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x118")]
		public Material SecondaryMat;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x120")]
		public Material LeafMat;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x128")]
		public Material StemMat;

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x130")]
		private WeedAppearanceSettings appearance;
	}
}
