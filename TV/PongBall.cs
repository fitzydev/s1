using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	public class PongBall : MonoBehaviour
	{
		// Token: 0x06000E38 RID: 3640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0xABD260", Offset = "0xABBC60", VA = "0x180ABD260")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x54D470", Offset = "0x54BE70", VA = "0x18054D470")]
		public PongBall()
		{
		}

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x20")]
		public Pong Game;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Rect;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x30")]
		public Rigidbody RB;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x38")]
		public float RandomForce;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onHit;
	}
}
