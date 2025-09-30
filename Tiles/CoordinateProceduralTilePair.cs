using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x20002C8")]
	[Serializable]
	public struct CoordinateProceduralTilePair
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033B")]
		public ProceduralTile tile
		{
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0xABAC40", Offset = "0xAB9640", VA = "0x180ABAC40")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F53 RID: 3923
		[Token(Token = "0x4000F53")]
		[FieldOffset(Offset = "0x0")]
		public Coordinate coord;

		// Token: 0x04000F54 RID: 3924
		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x8")]
		public NetworkObject tileParent;

		// Token: 0x04000F55 RID: 3925
		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x10")]
		public int tileIndex;
	}
}
