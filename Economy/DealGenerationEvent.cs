using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.GameTime;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005E8 RID: 1512
	[Token(Token = "0x20005E8")]
	[Serializable]
	public class DealGenerationEvent
	{
		// Token: 0x0600252C RID: 9516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252C")]
		[Address(RVA = "0x6D1F50", Offset = "0x6D0950", VA = "0x1806D1F50")]
		public ContractInfo GenerateContractInfo(Customer customer)
		{
			return null;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x600252D")]
		[Address(RVA = "0x6D25D0", Offset = "0x6D0FD0", VA = "0x1806D25D0")]
		public bool ShouldGenerate(Customer customer)
		{
			return default(bool);
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252E")]
		[Address(RVA = "0x6D2100", Offset = "0x6D0B00", VA = "0x1806D2100")]
		public MessageChain GetRandomRequestMessage()
		{
			return null;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252F")]
		[Address(RVA = "0x6D21C0", Offset = "0x6D0BC0", VA = "0x1806D21C0")]
		public MessageChain ProcessMessage(MessageChain messageChain)
		{
			return null;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x6D2160", Offset = "0x6D0B60", VA = "0x1806D2160")]
		public MessageChain GetRejectionMessage()
		{
			return null;
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x6D2060", Offset = "0x6D0A60", VA = "0x1806D2060")]
		public MessageChain GetAcceptanceMessage()
		{
			return null;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x6D20C0", Offset = "0x6D0AC0", VA = "0x1806D20C0")]
		public string GetProductStringList()
		{
			return null;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x6D20E0", Offset = "0x6D0AE0", VA = "0x1806D20E0")]
		public string GetQualityString()
		{
			return null;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x6D2780", Offset = "0x6D1180", VA = "0x1806D2780")]
		public DealGenerationEvent()
		{
		}

		// Token: 0x04001C9A RID: 7322
		[Token(Token = "0x4001C9A")]
		[FieldOffset(Offset = "0x10")]
		[Header("Settings")]
		public bool Enabled;

		// Token: 0x04001C9B RID: 7323
		[Token(Token = "0x4001C9B")]
		[FieldOffset(Offset = "0x11")]
		public bool CanBeAccepted;

		// Token: 0x04001C9C RID: 7324
		[Token(Token = "0x4001C9C")]
		[FieldOffset(Offset = "0x12")]
		public bool CanBeRejected;

		// Token: 0x04001C9D RID: 7325
		[Token(Token = "0x4001C9D")]
		[FieldOffset(Offset = "0x18")]
		[Header("Timing Settings")]
		public List<DealGenerationEvent.DayContainer> ApplicableDays;

		// Token: 0x04001C9E RID: 7326
		[Token(Token = "0x4001C9E")]
		[FieldOffset(Offset = "0x20")]
		public int GenerationTime;

		// Token: 0x04001C9F RID: 7327
		[Token(Token = "0x4001C9F")]
		[FieldOffset(Offset = "0x24")]
		public int GenerationWindowDuration;

		// Token: 0x04001CA0 RID: 7328
		[Token(Token = "0x4001CA0")]
		[FieldOffset(Offset = "0x28")]
		[Header("Products and payment")]
		public ProductList ProductList;

		// Token: 0x04001CA1 RID: 7329
		[Token(Token = "0x4001CA1")]
		[FieldOffset(Offset = "0x30")]
		public float Payment;

		// Token: 0x04001CA2 RID: 7330
		[Token(Token = "0x4001CA2")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 5f)]
		public float RelationshipRequirement;

		// Token: 0x04001CA3 RID: 7331
		[Token(Token = "0x4001CA3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Messages")]
		private MessageChain[] RequestMessageChains;

		// Token: 0x04001CA4 RID: 7332
		[Token(Token = "0x4001CA4")]
		[FieldOffset(Offset = "0x40")]
		public MessageChain[] ContractAcceptedResponses;

		// Token: 0x04001CA5 RID: 7333
		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0x48")]
		public MessageChain[] ContractRejectedResponses;

		// Token: 0x04001CA6 RID: 7334
		[Token(Token = "0x4001CA6")]
		[FieldOffset(Offset = "0x50")]
		[Header("Location settings")]
		public DeliveryLocation DeliveryLocation;

		// Token: 0x04001CA7 RID: 7335
		[Token(Token = "0x4001CA7")]
		[FieldOffset(Offset = "0x58")]
		public int PickupScheduleGroup;

		// Token: 0x04001CA8 RID: 7336
		[Token(Token = "0x4001CA8")]
		[FieldOffset(Offset = "0x60")]
		[Header("Window/expiry settings")]
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x04001CA9 RID: 7337
		[Token(Token = "0x4001CA9")]
		[FieldOffset(Offset = "0x68")]
		public bool Expires;

		// Token: 0x04001CAA RID: 7338
		[Token(Token = "0x4001CAA")]
		[FieldOffset(Offset = "0x6C")]
		[Range(1f, 7f)]
		[Tooltip("How many days after being accepted does this contract expire? Exact expiry is adjusted to match window end")]
		public int ExpiresAfter;

		// Token: 0x020005E9 RID: 1513
		[Token(Token = "0x20005E9")]
		[Serializable]
		public class DayContainer
		{
			// Token: 0x06002535 RID: 9525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002535")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public DayContainer()
			{
			}

			// Token: 0x04001CAB RID: 7339
			[Token(Token = "0x4001CAB")]
			[FieldOffset(Offset = "0x10")]
			public EDay Day;
		}
	}
}
