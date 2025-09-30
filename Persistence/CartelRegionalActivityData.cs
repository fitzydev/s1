using System;
using Il2CppDummyDll;
using ScheduleOne.Map;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003A3 RID: 931
	[Token(Token = "0x20003A3")]
	[Serializable]
	public class CartelRegionalActivityData
	{
		// Token: 0x060014E5 RID: 5349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x5C6990", Offset = "0x5C5390", VA = "0x1805C6990")]
		public CartelRegionalActivityData(EMapRegion region, int currentActivityIndex, int hoursUntilNextActivity)
		{
		}

		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x4001369")]
		[FieldOffset(Offset = "0x10")]
		public EMapRegion Region;

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x400136A")]
		[FieldOffset(Offset = "0x14")]
		public int CurrentActivityIndex;

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x400136B")]
		[FieldOffset(Offset = "0x18")]
		public int HoursUntilNextActivity;
	}
}
