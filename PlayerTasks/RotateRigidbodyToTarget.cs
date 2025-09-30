using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	public class RotateRigidbodyToTarget : MonoBehaviour
	{
		// Token: 0x060012B8 RID: 4792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x5A1220", Offset = "0x59FC20", VA = "0x1805A1220")]
		public void FixedUpdate()
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x5A1570", Offset = "0x59FF70", VA = "0x1805A1570")]
		public RotateRigidbodyToTarget()
		{
		}

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody Rigidbody;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 TargetRotation;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x34")]
		public float RotationForce;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x38")]
		public Transform Bitch;
	}
}
