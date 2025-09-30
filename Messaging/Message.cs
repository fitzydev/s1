using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Messaging
{
	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	[Serializable]
	public class Message
	{
		// Token: 0x0600175C RID: 5980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x5EB720", Offset = "0x5EA120", VA = "0x1805EB720")]
		public Message()
		{
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x5EB6A0", Offset = "0x5EA0A0", VA = "0x1805EB6A0")]
		public Message(string _text, Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1)
		{
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x5EB730", Offset = "0x5EA130", VA = "0x1805EB730")]
		public Message(TextMessageData data)
		{
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175F")]
		[Address(RVA = "0x5EB600", Offset = "0x5EA000", VA = "0x1805EB600")]
		public TextMessageData GetSaveData()
		{
			return null;
		}

		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x10")]
		public int messageId;

		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x20")]
		public Message.ESenderType sender;

		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		[FieldOffset(Offset = "0x24")]
		public bool endOfGroup;

		// Token: 0x020004AD RID: 1197
		[Token(Token = "0x20004AD")]
		public enum ESenderType
		{
			// Token: 0x04001557 RID: 5463
			[Token(Token = "0x4001557")]
			Player,
			// Token: 0x04001558 RID: 5464
			[Token(Token = "0x4001558")]
			Other
		}
	}
}
