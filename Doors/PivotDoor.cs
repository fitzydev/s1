using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	public class PivotDoor : MonoBehaviour
	{
		// Token: 0x06002628 RID: 9768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x6FD490", Offset = "0x6FBE90", VA = "0x1806FD490")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x6FD580", Offset = "0x6FBF80", VA = "0x1806FD580", Slot = "5")]
		public virtual void Opened(EDoorSide openSide)
		{
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x6FD480", Offset = "0x6FBE80", VA = "0x1806FD480", Slot = "6")]
		public virtual void Closed()
		{
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x6FD5C0", Offset = "0x6FBFC0", VA = "0x1806FD5C0")]
		public PivotDoor()
		{
		}

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public Transform DoorTransform;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x4001D66")]
		[FieldOffset(Offset = "0x28")]
		public bool FlipSide;

		// Token: 0x04001D67 RID: 7527
		[Token(Token = "0x4001D67")]
		[FieldOffset(Offset = "0x2C")]
		public float OpenInwardsAngle;

		// Token: 0x04001D68 RID: 7528
		[Token(Token = "0x4001D68")]
		[FieldOffset(Offset = "0x30")]
		public float OpenOutwardsAngle;

		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		[FieldOffset(Offset = "0x34")]
		public float SwingSpeed;

		// Token: 0x04001D6A RID: 7530
		[Token(Token = "0x4001D6A")]
		[FieldOffset(Offset = "0x38")]
		private float targetDoorAngle;
	}
}
