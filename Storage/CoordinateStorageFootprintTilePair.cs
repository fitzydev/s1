using System;
using Il2CppDummyDll;
using ScheduleOne.Tiles;

namespace ScheduleOne.Storage
{
	// Token: 0x0200095B RID: 2395
	[Token(Token = "0x200095B")]
	[Serializable]
	public struct CoordinateStorageFootprintTilePair
	{
		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x8")]
		public FootprintTile tile;
	}
}
