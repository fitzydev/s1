using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	public interface IBaseSaveable : ISaveable
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001446 RID: 5190
		[Token(Token = "0x170003D0")]
		int LoadOrder
		{
			[Token(Token = "0x6001446")]
			get;
		}
	}
}
