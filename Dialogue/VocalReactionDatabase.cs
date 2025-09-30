using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2000652")]
	[Serializable]
	public class VocalReactionDatabase
	{
		// Token: 0x0600277F RID: 10111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x700D90", Offset = "0x6FF790", VA = "0x180700D90")]
		public VocalReactionDatabase.Entry GetEntry(string key)
		{
			return null;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x700EE0", Offset = "0x6FF8E0", VA = "0x180700EE0")]
		public VocalReactionDatabase()
		{
		}

		// Token: 0x04001E47 RID: 7751
		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x10")]
		public List<VocalReactionDatabase.Entry> Entries;

		// Token: 0x02000653 RID: 1619
		[Token(Token = "0x2000653")]
		[Serializable]
		public class Entry
		{
			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x06002781 RID: 10113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000659")]
			public string name
			{
				[Token(Token = "0x6002781")]
				[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002782 RID: 10114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002782")]
			[Address(RVA = "0x6FD270", Offset = "0x6FBC70", VA = "0x1806FD270")]
			public string GetRandomReaction()
			{
				return null;
			}

			// Token: 0x06002783 RID: 10115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002783")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Entry()
			{
			}

			// Token: 0x04001E48 RID: 7752
			[Token(Token = "0x4001E48")]
			[FieldOffset(Offset = "0x10")]
			public string Key;

			// Token: 0x04001E49 RID: 7753
			[Token(Token = "0x4001E49")]
			[FieldOffset(Offset = "0x18")]
			public string[] Reactions;
		}
	}
}
