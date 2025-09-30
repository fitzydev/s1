using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	public class DelayedUnityEvent : MonoBehaviour
	{
		// Token: 0x06003F6F RID: 16239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x85FB60", Offset = "0x85E560", VA = "0x18085FB60")]
		[Button]
		public void Execute()
		{
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x583E00", Offset = "0x582800", VA = "0x180583E00")]
		public DelayedUnityEvent()
		{
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x85FBE0", Offset = "0x85E5E0", VA = "0x18085FBE0")]
		[CompilerGenerated]
		private IEnumerator <Execute>g__Wait|3_0()
		{
			return null;
		}

		// Token: 0x04002C77 RID: 11383
		[Token(Token = "0x4002C77")]
		[FieldOffset(Offset = "0x20")]
		public float Delay;

		// Token: 0x04002C78 RID: 11384
		[Token(Token = "0x4002C78")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDelayStart;

		// Token: 0x04002C79 RID: 11385
		[Token(Token = "0x4002C79")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onDelayedExecute;
	}
}
