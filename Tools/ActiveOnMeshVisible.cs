using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008E6 RID: 2278
	[Token(Token = "0x20008E6")]
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		// Token: 0x06003F35 RID: 16181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x85D850", Offset = "0x85C250", VA = "0x18085D850")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x85D940", Offset = "0x85C340", VA = "0x18085D940")]
		public ActiveOnMeshVisible()
		{
		}

		// Token: 0x04002C43 RID: 11331
		[Token(Token = "0x4002C43")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer Mesh;

		// Token: 0x04002C44 RID: 11332
		[Token(Token = "0x4002C44")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] ObjectsToActivate;

		// Token: 0x04002C45 RID: 11333
		[Token(Token = "0x4002C45")]
		[FieldOffset(Offset = "0x30")]
		public bool Reverse;

		// Token: 0x04002C46 RID: 11334
		[Token(Token = "0x4002C46")]
		[FieldOffset(Offset = "0x31")]
		private bool isVisible;
	}
}
