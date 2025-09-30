using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	public interface IGenericSaveable
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001447 RID: 5191
		[Token(Token = "0x170003D1")]
		Guid GUID
		{
			[Token(Token = "0x6001447")]
			get;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x5AE840", Offset = "0x5AD240", VA = "0x1805AE840", Slot = "1")]
		void InitializeSaveable()
		{
		}

		// Token: 0x06001449 RID: 5193
		[Token(Token = "0x6001449")]
		void Load(GenericSaveData data);

		// Token: 0x0600144A RID: 5194
		[Token(Token = "0x600144A")]
		GenericSaveData GetSaveData();
	}
}
