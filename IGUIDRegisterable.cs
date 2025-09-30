using System;
using Il2CppDummyDll;

namespace ScheduleOne
{
	// Token: 0x02000287 RID: 647
	[Token(Token = "0x2000287")]
	public interface IGUIDRegisterable
	{
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000D7C RID: 3452
		[Token(Token = "0x170002FB")]
		Guid GUID
		{
			[Token(Token = "0x6000D7C")]
			get;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0xAA8ED0", Offset = "0xAA78D0", VA = "0x180AA8ED0", Slot = "1")]
		void SetGUID(string guid)
		{
		}

		// Token: 0x06000D7E RID: 3454
		[Token(Token = "0x6000D7E")]
		void SetGUID(Guid guid);
	}
}
