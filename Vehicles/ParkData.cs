using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200086A RID: 2154
	[Token(Token = "0x200086A")]
	[Serializable]
	public class ParkData
	{
		// Token: 0x06003B7A RID: 15226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x81EC00", Offset = "0x81D600", VA = "0x18081EC00")]
		public ParkData(Guid lotGUID, int spotIndex, EParkingAlignment alignment)
		{
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7B")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public ParkData()
		{
		}

		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		[FieldOffset(Offset = "0x10")]
		public Guid lotGUID;

		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		[FieldOffset(Offset = "0x20")]
		public int spotIndex;

		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		[FieldOffset(Offset = "0x24")]
		public EParkingAlignment alignment;
	}
}
