using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Levelling
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	public class RankData : SaveData
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x64C0D0", Offset = "0x64AAD0", VA = "0x18064C0D0")]
		public RankData(int rank, int tier, int xp, int totalXP, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x04001719 RID: 5913
		[Token(Token = "0x4001719")]
		[FieldOffset(Offset = "0x28")]
		public int Rank;

		// Token: 0x0400171A RID: 5914
		[Token(Token = "0x400171A")]
		[FieldOffset(Offset = "0x2C")]
		public int Tier;

		// Token: 0x0400171B RID: 5915
		[Token(Token = "0x400171B")]
		[FieldOffset(Offset = "0x30")]
		public int XP;

		// Token: 0x0400171C RID: 5916
		[Token(Token = "0x400171C")]
		[FieldOffset(Offset = "0x34")]
		public int TotalXP;

		// Token: 0x0400171D RID: 5917
		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x38")]
		public List<EMapRegion> UnlockedRegions;
	}
}
