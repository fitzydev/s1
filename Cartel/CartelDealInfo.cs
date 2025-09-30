using System;
using Il2CppDummyDll;
using ScheduleOne.GameTime;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200080A RID: 2058
	[Token(Token = "0x200080A")]
	[Serializable]
	public class CartelDealInfo
	{
		// Token: 0x0600388C RID: 14476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388C")]
		[Address(RVA = "0x7DF000", Offset = "0x7DDA00", VA = "0x1807DF000")]
		public CartelDealInfo(string requestedProductID, int requestedProductQuantity, int payment, GameDateTime dueTime, CartelDealInfo.EStatus status)
		{
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388D")]
		[Address(RVA = "0x7DEF90", Offset = "0x7DD990", VA = "0x1807DEF90")]
		public CartelDealInfo()
		{
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x600388E")]
		[Address(RVA = "0x7DEF10", Offset = "0x7DD910", VA = "0x1807DEF10")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x10")]
		public string RequestedProductID;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x18")]
		public int RequestedProductQuantity;

		// Token: 0x0400274D RID: 10061
		[Token(Token = "0x400274D")]
		[FieldOffset(Offset = "0x1C")]
		public int PaymentAmount;

		// Token: 0x0400274E RID: 10062
		[Token(Token = "0x400274E")]
		[FieldOffset(Offset = "0x20")]
		public GameDateTime DueTime;

		// Token: 0x0400274F RID: 10063
		[Token(Token = "0x400274F")]
		[FieldOffset(Offset = "0x28")]
		public CartelDealInfo.EStatus Status;

		// Token: 0x0200080B RID: 2059
		[Token(Token = "0x200080B")]
		public enum EStatus
		{
			// Token: 0x04002751 RID: 10065
			[Token(Token = "0x4002751")]
			Pending,
			// Token: 0x04002752 RID: 10066
			[Token(Token = "0x4002752")]
			Overdue
		}
	}
}
