using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Properties;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CBA RID: 3258
	[Token(Token = "0x2000CBA")]
	[Serializable]
	public class MixOperation
	{
		// Token: 0x06005B6B RID: 23403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0xA3E9F0", Offset = "0xA3D3F0", VA = "0x180A3E9F0")]
		public MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity)
		{
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public MixOperation()
		{
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00016458 File Offset: 0x00014658
		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0xA3E750", Offset = "0xA3D150", VA = "0x180A3E750")]
		public EDrugType GetOutput(out List<Property> properties)
		{
			return EDrugType.Marijuana;
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x00016470 File Offset: 0x00014670
		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0xA3E840", Offset = "0xA3D240", VA = "0x180A3E840")]
		public bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			return default(bool);
		}

		// Token: 0x040042B9 RID: 17081
		[Token(Token = "0x40042B9")]
		[FieldOffset(Offset = "0x10")]
		public string ProductID;

		// Token: 0x040042BA RID: 17082
		[Token(Token = "0x40042BA")]
		[FieldOffset(Offset = "0x18")]
		public EQuality ProductQuality;

		// Token: 0x040042BB RID: 17083
		[Token(Token = "0x40042BB")]
		[FieldOffset(Offset = "0x20")]
		public string IngredientID;

		// Token: 0x040042BC RID: 17084
		[Token(Token = "0x40042BC")]
		[FieldOffset(Offset = "0x28")]
		public int Quantity;
	}
}
