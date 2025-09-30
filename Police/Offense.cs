using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Police
{
	// Token: 0x020007F4 RID: 2036
	[Token(Token = "0x20007F4")]
	public class Offense
	{
		// Token: 0x06003792 RID: 14226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003792")]
		[Address(RVA = "0x7E6D20", Offset = "0x7E5720", VA = "0x1807E6D20")]
		public Offense(List<Offense.Charge> _charges)
		{
		}

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x10")]
		public List<Offense.Charge> charges;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x18")]
		public List<string> penalties;

		// Token: 0x020007F5 RID: 2037
		[Token(Token = "0x20007F5")]
		public class Charge
		{
			// Token: 0x06003793 RID: 14227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003793")]
			[Address(RVA = "0x7E4870", Offset = "0x7E3270", VA = "0x1807E4870")]
			public Charge(string _chargeName, int _crimeIndex, int _quantity)
			{
			}

			// Token: 0x040026B6 RID: 9910
			[Token(Token = "0x40026B6")]
			[FieldOffset(Offset = "0x10")]
			public string chargeName;

			// Token: 0x040026B7 RID: 9911
			[Token(Token = "0x40026B7")]
			[FieldOffset(Offset = "0x18")]
			public int crimeIndex;

			// Token: 0x040026B8 RID: 9912
			[Token(Token = "0x40026B8")]
			[FieldOffset(Offset = "0x1C")]
			public int quantity;
		}
	}
}
