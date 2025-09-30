using System;
using Il2CppDummyDll;

namespace ScheduleOne.Messaging
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public interface IMessageEntity
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001758 RID: 5976
		// (set) Token: 0x06001759 RID: 5977
		[Token(Token = "0x17000436")]
		MSGConversation MsgConversation
		{
			[Token(Token = "0x6001758")]
			get;
			[Token(Token = "0x6001759")]
			set;
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600175A RID: 5978
		// (remove) Token: 0x0600175B RID: 5979
		[Token(Token = "0x14000007")]
		event ResponseCallback onResponseChosen;
	}
}
