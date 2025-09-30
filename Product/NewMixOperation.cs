using System;
using Il2CppDummyDll;

namespace ScheduleOne.Product
{
	// Token: 0x02000995 RID: 2453
	[Token(Token = "0x2000995")]
	[Serializable]
	public class NewMixOperation
	{
		// Token: 0x060042DF RID: 17119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DF")]
		[Address(RVA = "0x5D6910", Offset = "0x5D5310", VA = "0x1805D6910")]
		public NewMixOperation(string productID, string ingredientID)
		{
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public NewMixOperation()
		{
		}

		// Token: 0x04002EFF RID: 12031
		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x10")]
		public string ProductID;

		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x18")]
		public string IngredientID;
	}
}
