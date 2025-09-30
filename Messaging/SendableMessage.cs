using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Messaging
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	public class SendableMessage
	{
		// Token: 0x06001802 RID: 6146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x610A80", Offset = "0x60F480", VA = "0x180610A80")]
		public SendableMessage(string text, MSGConversation conversation)
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x610A60", Offset = "0x60F460", VA = "0x180610A60", Slot = "4")]
		public virtual bool ShouldShow()
		{
			return default(bool);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x6001804")]
		[Address(RVA = "0x610740", Offset = "0x60F140", VA = "0x180610740", Slot = "5")]
		public virtual bool IsValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001805")]
		[Address(RVA = "0x6107D0", Offset = "0x60F1D0", VA = "0x1806107D0", Slot = "6")]
		public virtual void Send(bool network, int id = -1)
		{
		}

		// Token: 0x040015A1 RID: 5537
		[Token(Token = "0x40015A1")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x040015A2 RID: 5538
		[Token(Token = "0x40015A2")]
		[FieldOffset(Offset = "0x18")]
		public SendableMessage.BoolCheck ShouldShowCheck;

		// Token: 0x040015A3 RID: 5539
		[Token(Token = "0x40015A3")]
		[FieldOffset(Offset = "0x20")]
		public SendableMessage.ValidityCheck IsValidCheck;

		// Token: 0x040015A4 RID: 5540
		[Token(Token = "0x40015A4")]
		[FieldOffset(Offset = "0x28")]
		public Action onSelected;

		// Token: 0x040015A5 RID: 5541
		[Token(Token = "0x40015A5")]
		[FieldOffset(Offset = "0x30")]
		public Action onSent;

		// Token: 0x040015A6 RID: 5542
		[Token(Token = "0x40015A6")]
		[FieldOffset(Offset = "0x38")]
		private MSGConversation conversation;

		// Token: 0x040015A7 RID: 5543
		[Token(Token = "0x40015A7")]
		[FieldOffset(Offset = "0x40")]
		public bool disableDefaultSendBehaviour;

		// Token: 0x040015A8 RID: 5544
		[Token(Token = "0x40015A8")]
		[FieldOffset(Offset = "0x48")]
		private List<int> sentIDs;

		// Token: 0x020004BD RID: 1213
		// (Invoke) Token: 0x06001807 RID: 6151
		[Token(Token = "0x20004BD")]
		public delegate bool BoolCheck(SendableMessage message);

		// Token: 0x020004BE RID: 1214
		// (Invoke) Token: 0x0600180B RID: 6155
		[Token(Token = "0x20004BE")]
		public delegate bool ValidityCheck(SendableMessage message, out string invalidReason);
	}
}
