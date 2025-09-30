using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	[Serializable]
	public struct GameDateTime
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x47BE70", Offset = "0x47A870", VA = "0x18047BE70")]
		public GameDateTime(int _elapsedDays, int _time)
		{
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
		public GameDateTime(int _minSum)
		{
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0xABBD30", Offset = "0xABA730", VA = "0x180ABBD30")]
		public GameDateTime(GameDateTimeData data)
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0xABBD00", Offset = "0xABA700", VA = "0x180ABBD00")]
		public int GetMinSum()
		{
			return 0;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0xABBC80", Offset = "0xABA680", VA = "0x180ABBC80")]
		public GameDateTime AddMins(int mins)
		{
			return default(GameDateTime);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0xABBCE0", Offset = "0xABA6E0", VA = "0x180ABBCE0")]
		public GameDateTime GetCopy()
		{
			return default(GameDateTime);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0xABBE10", Offset = "0xABA810", VA = "0x180ABBE10")]
		public static GameDateTime operator +(GameDateTime a, GameDateTime b)
		{
			return default(GameDateTime);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0xABBF50", Offset = "0xABA950", VA = "0x180ABBF50")]
		public static GameDateTime operator -(GameDateTime a, GameDateTime b)
		{
			return default(GameDateTime);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0xABBE90", Offset = "0xABA890", VA = "0x180ABBE90")]
		public static bool operator >(GameDateTime a, GameDateTime b)
		{
			return default(bool);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0xABBEF0", Offset = "0xABA8F0", VA = "0x180ABBEF0")]
		public static bool operator <(GameDateTime a, GameDateTime b)
		{
			return default(bool);
		}

		// Token: 0x04000EF4 RID: 3828
		[Token(Token = "0x4000EF4")]
		[FieldOffset(Offset = "0x0")]
		public int elapsedDays;

		// Token: 0x04000EF5 RID: 3829
		[Token(Token = "0x4000EF5")]
		[FieldOffset(Offset = "0x4")]
		public int time;
	}
}
