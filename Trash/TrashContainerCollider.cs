using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020008CC RID: 2252
	[Token(Token = "0x20008CC")]
	[RequireComponent(typeof(Rigidbody))]
	public class TrashContainerCollider : MonoBehaviour
	{
		// Token: 0x06003E5A RID: 15962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x850640", Offset = "0x84F040", VA = "0x180850640")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TrashContainerCollider()
		{
		}

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x20")]
		public TrashContainer Container;
	}
}
