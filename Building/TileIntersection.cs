using System;
using Il2CppDummyDll;
using ScheduleOne.Tiles;

namespace ScheduleOne.Building
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	public class TileIntersection
	{
		// Token: 0x0600396A RID: 14698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396A")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public TileIntersection()
		{
		}

		// Token: 0x040027BE RID: 10174
		[Token(Token = "0x40027BE")]
		[FieldOffset(Offset = "0x10")]
		public FootprintTile footprint;

		// Token: 0x040027BF RID: 10175
		[Token(Token = "0x40027BF")]
		[FieldOffset(Offset = "0x18")]
		public Tile tile;
	}
}
