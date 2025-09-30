using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;

namespace ScheduleOne.Economy
{
	// Token: 0x020005C8 RID: 1480
	[Token(Token = "0x20005C8")]
	[Serializable]
	public class ContractReceipt
	{
		// Token: 0x06002350 RID: 9040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x6B5E30", Offset = "0x6B4830", VA = "0x1806B5E30")]
		public ContractReceipt(int receiptId, EContractParty completedBy, string customerID, GameDateTime completionTime, StringIntPair[] items, float amountPaid)
		{
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x6B5D70", Offset = "0x6B4770", VA = "0x1806B5D70")]
		public ContractReceipt()
		{
		}

		// Token: 0x04001BD3 RID: 7123
		[Token(Token = "0x4001BD3")]
		[FieldOffset(Offset = "0x10")]
		public int ReceiptId;

		// Token: 0x04001BD4 RID: 7124
		[Token(Token = "0x4001BD4")]
		[FieldOffset(Offset = "0x14")]
		public EContractParty CompletedBy;

		// Token: 0x04001BD5 RID: 7125
		[Token(Token = "0x4001BD5")]
		[FieldOffset(Offset = "0x18")]
		public string CustomerId;

		// Token: 0x04001BD6 RID: 7126
		[Token(Token = "0x4001BD6")]
		[FieldOffset(Offset = "0x20")]
		public GameDateTime CompletionTime;

		// Token: 0x04001BD7 RID: 7127
		[Token(Token = "0x4001BD7")]
		[FieldOffset(Offset = "0x28")]
		public StringIntPair[] Items;

		// Token: 0x04001BD8 RID: 7128
		[Token(Token = "0x4001BD8")]
		[FieldOffset(Offset = "0x30")]
		public float AmountPaid;
	}
}
