using System;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	[Serializable]
	public struct CoordinateTilePair
	{
		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x04000F52 RID: 3922
		[Token(Token = "0x4000F52")]
		[FieldOffset(Offset = "0x8")]
		public Tile tile;
	}
}
