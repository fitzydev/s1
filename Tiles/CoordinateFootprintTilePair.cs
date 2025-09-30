using System;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	[Serializable]
	public struct CoordinateFootprintTilePair
	{
		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x04000F57 RID: 3927
		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0x8")]
		public FootprintTile footprintTile;
	}
}
