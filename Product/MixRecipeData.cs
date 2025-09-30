using System;
using Il2CppDummyDll;

namespace ScheduleOne.Product
{
	// Token: 0x02000991 RID: 2449
	[Token(Token = "0x2000991")]
	[Serializable]
	public class MixRecipeData
	{
		// Token: 0x060042CF RID: 17103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CF")]
		[Address(RVA = "0x42FE90", Offset = "0x42E890", VA = "0x18042FE90")]
		public MixRecipeData(string product, string mixer, string output)
		{
		}

		// Token: 0x04002EEA RID: 12010
		[Token(Token = "0x4002EEA")]
		[FieldOffset(Offset = "0x10")]
		public string Product;

		// Token: 0x04002EEB RID: 12011
		[Token(Token = "0x4002EEB")]
		[FieldOffset(Offset = "0x18")]
		public string Mixer;

		// Token: 0x04002EEC RID: 12012
		[Token(Token = "0x4002EEC")]
		[FieldOffset(Offset = "0x20")]
		public string Output;
	}
}
