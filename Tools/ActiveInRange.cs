using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	public class ActiveInRange : MonoBehaviour
	{
		// Token: 0x06003F33 RID: 16179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x85D590", Offset = "0x85BF90", VA = "0x18085D590")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x85D830", Offset = "0x85C230", VA = "0x18085D830")]
		public ActiveInRange()
		{
		}

		// Token: 0x04002C3E RID: 11326
		[Token(Token = "0x4002C3E")]
		[FieldOffset(Offset = "0x20")]
		public float Distance;

		// Token: 0x04002C3F RID: 11327
		[Token(Token = "0x4002C3F")]
		[FieldOffset(Offset = "0x24")]
		public bool ScaleByLODBias;

		// Token: 0x04002C40 RID: 11328
		[Token(Token = "0x4002C40")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] ObjectsToActivate;

		// Token: 0x04002C41 RID: 11329
		[Token(Token = "0x4002C41")]
		[FieldOffset(Offset = "0x30")]
		public bool Reverse;

		// Token: 0x04002C42 RID: 11330
		[Token(Token = "0x4002C42")]
		[FieldOffset(Offset = "0x31")]
		private bool isVisible;
	}
}
