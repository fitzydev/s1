using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x2000A69")]
	public class OpenSteamOverlay : MonoBehaviour
	{
		// Token: 0x06004898 RID: 18584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004898")]
		[Address(RVA = "0x90D9C0", Offset = "0x90C3C0", VA = "0x18090D9C0")]
		public void OpenOverlay()
		{
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004899")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public OpenSteamOverlay()
		{
		}

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		public const uint APP_ID = 3164500U;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x20")]
		public OpenSteamOverlay.EType Type;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x28")]
		public string CustomLink;

		// Token: 0x02000A6A RID: 2666
		[Token(Token = "0x2000A6A")]
		public enum EType
		{
			// Token: 0x04003393 RID: 13203
			[Token(Token = "0x4003393")]
			Store,
			// Token: 0x04003394 RID: 13204
			[Token(Token = "0x4003394")]
			CustomLink
		}
	}
}
