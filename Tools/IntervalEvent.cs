using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000909 RID: 2313
	[Token(Token = "0x2000909")]
	public class IntervalEvent : MonoBehaviour
	{
		// Token: 0x06003FB7 RID: 16311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x865940", Offset = "0x864340", VA = "0x180865940")]
		public void Start()
		{
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x5D52A0", Offset = "0x5D3CA0", VA = "0x1805D52A0")]
		private void Execute()
		{
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x583E00", Offset = "0x582800", VA = "0x180583E00")]
		public IntervalEvent()
		{
		}

		// Token: 0x04002CA6 RID: 11430
		[Token(Token = "0x4002CA6")]
		[FieldOffset(Offset = "0x20")]
		public float Interval;

		// Token: 0x04002CA7 RID: 11431
		[Token(Token = "0x4002CA7")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent Event;
	}
}
