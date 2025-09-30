using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000630 RID: 1584
	[Token(Token = "0x2000630")]
	[Serializable]
	public struct Entry
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026FA")]
		[Address(RVA = "0x6FD1A0", Offset = "0x6FBBA0", VA = "0x1806FD1A0")]
		public DialogueChain GetRandomChain()
		{
			return null;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026FB")]
		[Address(RVA = "0x6FD200", Offset = "0x6FBC00", VA = "0x1806FD200")]
		public string GetRandomLine()
		{
			return null;
		}

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		[FieldOffset(Offset = "0x0")]
		public string Key;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		[FieldOffset(Offset = "0x8")]
		public DialogueChain[] Chains;
	}
}
