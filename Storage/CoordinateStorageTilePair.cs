using System;
using Il2CppDummyDll;
using ScheduleOne.Tiles;

namespace ScheduleOne.Storage
{
	// Token: 0x02000955 RID: 2389
	[Token(Token = "0x2000955")]
	[Serializable]
	public struct CoordinateStorageTilePair
	{
		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x04002DF1 RID: 11761
		[Token(Token = "0x4002DF1")]
		[FieldOffset(Offset = "0x8")]
		public StorageTile tile;
	}
}
