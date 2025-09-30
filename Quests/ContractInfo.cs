using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Economy;
using ScheduleOne.Product;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	[Serializable]
	public class ContractInfo
	{
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000355")]
		public DeliveryLocation DeliveryLocation
		{
			[Token(Token = "0x600102D")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600102E")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600102F")]
		[Address(RVA = "0xAD1290", Offset = "0xACFC90", VA = "0x180AD1290")]
		public ContractInfo(float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer)
		{
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public ContractInfo()
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001031")]
		[Address(RVA = "0xAD0E00", Offset = "0xACF800", VA = "0x180AD0E00")]
		public DialogueChain ProcessMessage(DialogueChain messageChain)
		{
			return null;
		}

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x10")]
		public float Payment;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x18")]
		public ProductList Products;

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x20")]
		public string DeliveryLocationGUID;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x28")]
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x30")]
		public bool Expires;

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x34")]
		public int ExpiresAfter;

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x38")]
		public int PickupScheduleIndex;

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[FieldOffset(Offset = "0x3C")]
		public bool IsCounterOffer;
	}
}
