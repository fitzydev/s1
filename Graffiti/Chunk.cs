using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	public class Chunk
	{
		// Token: 0x06001FBD RID: 8125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x66F1E0", Offset = "0x66DBE0", VA = "0x18066F1E0")]
		public Chunk(UShort2 lowerLeft, UShort2 upperRight)
		{
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x66F100", Offset = "0x66DB00", VA = "0x18066F100")]
		public void SetPixelColor(UShort2 coord, ESprayColor color)
		{
		}

		// Token: 0x04001A0D RID: 6669
		[Token(Token = "0x4001A0D")]
		[FieldOffset(Offset = "0x10")]
		public UShort2 LowerLeftCorner;

		// Token: 0x04001A0E RID: 6670
		[Token(Token = "0x4001A0E")]
		[FieldOffset(Offset = "0x14")]
		public UShort2 UpperRightCorner;

		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<UShort2, PixelData> paintedPixelData;
	}
}
