using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	[Serializable]
	public class SprayStroke
	{
		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x67BBA0", Offset = "0x67A5A0", VA = "0x18067BBA0")]
		public SprayStroke(UShort2 start, UShort2 end, ESprayColor color)
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public SprayStroke()
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x67B090", Offset = "0x679A90", VA = "0x18067B090")]
		public List<PixelData> GetPixelsFromStroke()
		{
			return null;
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x67B540", Offset = "0x679F40", VA = "0x18067B540")]
		public static List<SprayStroke> GetStrokesFromPixels(List<UShort2> coords, ESprayColor color, SpraySurface surface)
		{
			return null;
		}

		// Token: 0x04001A34 RID: 6708
		[Token(Token = "0x4001A34")]
		public const int MIN_STROKE_LENGTH = 6;

		// Token: 0x04001A35 RID: 6709
		[Token(Token = "0x4001A35")]
		public const int ANGLE_THRESHOLD_DEG = 10;

		// Token: 0x04001A36 RID: 6710
		[Token(Token = "0x4001A36")]
		public const float MAX_STROKE_DEVIATION = 5f;

		// Token: 0x04001A37 RID: 6711
		[Token(Token = "0x4001A37")]
		public const int FORWARD_SAMPLE_COUNT = 5;

		// Token: 0x04001A38 RID: 6712
		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x10")]
		public UShort2 Start;

		// Token: 0x04001A39 RID: 6713
		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x14")]
		public UShort2 End;

		// Token: 0x04001A3A RID: 6714
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x18")]
		public ESprayColor Color;
	}
}
