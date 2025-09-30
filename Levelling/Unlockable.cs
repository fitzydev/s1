using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	public class Unlockable
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x64FB50", Offset = "0x64E550", VA = "0x18064FB50")]
		public Unlockable(FullRank rank, string title, Sprite icon)
		{
		}

		// Token: 0x04001716 RID: 5910
		[Token(Token = "0x4001716")]
		[FieldOffset(Offset = "0x10")]
		public FullRank Rank;

		// Token: 0x04001717 RID: 5911
		[Token(Token = "0x4001717")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x04001718 RID: 5912
		[Token(Token = "0x4001718")]
		[FieldOffset(Offset = "0x20")]
		public Sprite Icon;
	}
}
