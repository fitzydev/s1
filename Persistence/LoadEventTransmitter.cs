using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	public class LoadEventTransmitter : MonoBehaviour
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x5C9E00", Offset = "0x5C8800", VA = "0x1805C9E00")]
		private void Start()
		{
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x5C9DE0", Offset = "0x5C87E0", VA = "0x1805C9DE0")]
		private void OnLoadComplete()
		{
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public LoadEventTransmitter()
		{
		}

		// Token: 0x0400130D RID: 4877
		[Token(Token = "0x400130D")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onLoadComplete;
	}
}
