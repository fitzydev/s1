using System;
using Il2CppDummyDll;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	public class PixelData
	{
		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x677660", Offset = "0x676060", VA = "0x180677660")]
		public PixelData(UShort2 coordinate, ESprayColor color)
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x6775C0", Offset = "0x675FC0", VA = "0x1806775C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x10")]
		public UShort2 Coordinate;

		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x14")]
		public ESprayColor Color;
	}
}
