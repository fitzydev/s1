using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	public class MapHeightSampler
	{
		// Token: 0x060032E5 RID: 13029 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x779A60", Offset = "0x778460", VA = "0x180779A60")]
		public static bool Sample(float x, out float y, float z)
		{
			return default(bool);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public MapHeightSampler()
		{
		}

		// Token: 0x0400234C RID: 9036
		[Token(Token = "0x400234C")]
		[FieldOffset(Offset = "0x0")]
		private static float SampleHeight;

		// Token: 0x0400234D RID: 9037
		[Token(Token = "0x400234D")]
		[FieldOffset(Offset = "0x4")]
		private static float SampleDistance;

		// Token: 0x0400234E RID: 9038
		[Token(Token = "0x400234E")]
		[FieldOffset(Offset = "0x8")]
		public static Vector3 ResetPosition;
	}
}
