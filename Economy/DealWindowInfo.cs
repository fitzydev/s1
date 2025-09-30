using System;
using Il2CppDummyDll;

namespace ScheduleOne.Economy
{
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	public struct DealWindowInfo
	{
		// Token: 0x06002539 RID: 9529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x47BE70", Offset = "0x47A870", VA = "0x18047BE70")]
		public DealWindowInfo(int startTime, int endTime)
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x6D2830", Offset = "0x6D1230", VA = "0x1806D2830")]
		public static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			return default(DealWindowInfo);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x6D2920", Offset = "0x6D1320", VA = "0x1806D2920")]
		public static EDealWindow GetWindow(int time)
		{
			return EDealWindow.Morning;
		}

		// Token: 0x04001CB3 RID: 7347
		[Token(Token = "0x4001CB3")]
		public const int WINDOW_DURATION_MINS = 360;

		// Token: 0x04001CB4 RID: 7348
		[Token(Token = "0x4001CB4")]
		public const int WINDOW_COUNT = 4;

		// Token: 0x04001CB5 RID: 7349
		[Token(Token = "0x4001CB5")]
		[FieldOffset(Offset = "0x0")]
		public int StartTime;

		// Token: 0x04001CB6 RID: 7350
		[Token(Token = "0x4001CB6")]
		[FieldOffset(Offset = "0x4")]
		public int EndTime;

		// Token: 0x04001CB7 RID: 7351
		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DealWindowInfo Morning;

		// Token: 0x04001CB8 RID: 7352
		[Token(Token = "0x4001CB8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DealWindowInfo Afternoon;

		// Token: 0x04001CB9 RID: 7353
		[Token(Token = "0x4001CB9")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DealWindowInfo Night;

		// Token: 0x04001CBA RID: 7354
		[Token(Token = "0x4001CBA")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DealWindowInfo LateNight;
	}
}
