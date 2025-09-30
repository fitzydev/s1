using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000908 RID: 2312
	[Token(Token = "0x2000908")]
	public class ImpactDetector : MonoBehaviour
	{
		// Token: 0x06003FB5 RID: 16309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x865400", Offset = "0x863E00", VA = "0x180865400")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x865470", Offset = "0x863E70", VA = "0x180865470")]
		public ImpactDetector()
		{
		}

		// Token: 0x04002CA4 RID: 11428
		[Token(Token = "0x4002CA4")]
		[FieldOffset(Offset = "0x20")]
		public bool DestroyScriptOnImpact;

		// Token: 0x04002CA5 RID: 11429
		[Token(Token = "0x4002CA5")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onImpact;
	}
}
