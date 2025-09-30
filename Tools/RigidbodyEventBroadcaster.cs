using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000918 RID: 2328
	[Token(Token = "0x2000918")]
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		// Token: 0x06003FF9 RID: 16377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x8739F0", Offset = "0x8723F0", VA = "0x1808739F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public RigidbodyEventBroadcaster()
		{
		}

		// Token: 0x04002CD0 RID: 11472
		[Token(Token = "0x4002CD0")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<Collider> onTriggerEnter;
	}
}
