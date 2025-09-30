using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	[Serializable]
	public struct FullRank
	{
		// Token: 0x06001A9A RID: 6810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x47BE70", Offset = "0x47A870", VA = "0x18047BE70")]
		public FullRank(ERank rank, int tier)
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x634A50", Offset = "0x633450", VA = "0x180634A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x6349E0", Offset = "0x6333E0", VA = "0x1806349E0")]
		public FullRank NextRank()
		{
			return default(FullRank);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x634A30", Offset = "0x633430", VA = "0x180634A30")]
		public float ToFloat()
		{
			return 0f;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x634870", Offset = "0x633270", VA = "0x180634870")]
		public int GetRankIndex()
		{
			return 0;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x634880", Offset = "0x633280", VA = "0x180634880")]
		public static string GetString(FullRank rank)
		{
			return null;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x634BF0", Offset = "0x6335F0", VA = "0x180634BF0")]
		public static bool operator >(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x634C70", Offset = "0x633670", VA = "0x180634C70")]
		public static bool operator <(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x634C30", Offset = "0x633630", VA = "0x180634C30")]
		public static bool operator <=(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x634BB0", Offset = "0x6335B0", VA = "0x180634BB0")]
		public static bool operator >=(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x533300", Offset = "0x531D00", VA = "0x180533300")]
		public static bool operator ==(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x634C10", Offset = "0x633610", VA = "0x180634C10")]
		public static bool operator !=(FullRank a, FullRank b)
		{
			return default(bool);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x634780", Offset = "0x633180", VA = "0x180634780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x634820", Offset = "0x633220", VA = "0x180634820", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x634730", Offset = "0x633130", VA = "0x180634730")]
		public int CompareTo(FullRank other)
		{
			return 0;
		}

		// Token: 0x040016F4 RID: 5876
		[Token(Token = "0x40016F4")]
		public const int TIER_COUNT = 5;

		// Token: 0x040016F5 RID: 5877
		[Token(Token = "0x40016F5")]
		[FieldOffset(Offset = "0x0")]
		public ERank Rank;

		// Token: 0x040016F6 RID: 5878
		[Token(Token = "0x40016F6")]
		[FieldOffset(Offset = "0x4")]
		[Range(1f, 5f)]
		public int Tier;
	}
}
