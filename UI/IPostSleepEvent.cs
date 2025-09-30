using System;
using Il2CppDummyDll;

namespace ScheduleOne.UI
{
	// Token: 0x02000AE5 RID: 2789
	[Token(Token = "0x2000AE5")]
	public interface IPostSleepEvent
	{
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06004BCC RID: 19404
		[Token(Token = "0x17000AA8")]
		bool IsRunning
		{
			[Token(Token = "0x6004BCC")]
			get;
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06004BCD RID: 19405
		[Token(Token = "0x17000AA9")]
		int Order
		{
			[Token(Token = "0x6004BCD")]
			get;
		}

		// Token: 0x06004BCE RID: 19406
		[Token(Token = "0x6004BCE")]
		void StartEvent();
	}
}
