using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x020008BA RID: 2234
	[Token(Token = "0x20008BA")]
	public class PropertyDisposalArea : MonoBehaviour
	{
		// Token: 0x06003D81 RID: 15745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D81")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PropertyDisposalArea()
		{
		}

		// Token: 0x04002B66 RID: 11110
		[Token(Token = "0x4002B66")]
		[FieldOffset(Offset = "0x20")]
		public Transform StandPoint;

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4002B67")]
		[FieldOffset(Offset = "0x28")]
		public Transform TrashDropPoint;
	}
}
