using System;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	public class CoordinatePair
	{
		// Token: 0x06000F54 RID: 3924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x5D6910", Offset = "0x5D5310", VA = "0x1805D6910")]
		public CoordinatePair(Coordinate _c1, Coordinate _c2)
		{
		}

		// Token: 0x04000F58 RID: 3928
		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x10")]
		public Coordinate coord1;

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x18")]
		public Coordinate coord2;
	}
}
