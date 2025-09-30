using System;
using Il2CppDummyDll;

namespace ScheduleOne.Money
{
	// Token: 0x02000C61 RID: 3169
	[Token(Token = "0x2000C61")]
	public class Transaction
	{
		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06005532 RID: 21810 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x17000BB5")]
		public float total_Amount
		{
			[Token(Token = "0x6005532")]
			[Address(RVA = "0x9DAF50", Offset = "0x9D9950", VA = "0x1809DAF50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005533")]
		[Address(RVA = "0x9DAE80", Offset = "0x9D9880", VA = "0x1809DAE80")]
		public Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x04003F2C RID: 16172
		[Token(Token = "0x4003F2C")]
		[FieldOffset(Offset = "0x10")]
		public string transaction_Name;

		// Token: 0x04003F2D RID: 16173
		[Token(Token = "0x4003F2D")]
		[FieldOffset(Offset = "0x18")]
		public float unit_Amount;

		// Token: 0x04003F2E RID: 16174
		[Token(Token = "0x4003F2E")]
		[FieldOffset(Offset = "0x1C")]
		public float quantity;

		// Token: 0x04003F2F RID: 16175
		[Token(Token = "0x4003F2F")]
		[FieldOffset(Offset = "0x20")]
		public string transaction_Note;
	}
}
