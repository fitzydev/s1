using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000902 RID: 2306
	[Token(Token = "0x2000902")]
	public class GameVersionEvents : MonoBehaviour
	{
		// Token: 0x06003F9E RID: 16286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x5C9DE0", Offset = "0x5C87E0", VA = "0x1805C9DE0")]
		private void Start()
		{
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public GameVersionEvents()
		{
		}

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onFullGame;

		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDemoGame;
	}
}
