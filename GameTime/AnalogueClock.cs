using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public class AnalogueClock : MonoBehaviour
	{
		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0xABAA40", Offset = "0xAB9440", VA = "0x180ABAA40")]
		public void Start()
		{
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0xABA920", Offset = "0xAB9320", VA = "0x180ABA920")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0xABA730", Offset = "0xAB9130", VA = "0x180ABA730")]
		public void MinPass()
		{
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0xABABE0", Offset = "0xAB95E0", VA = "0x180ABABE0")]
		public AnalogueClock()
		{
		}

		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x20")]
		public Transform MinHand;

		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x28")]
		public Transform HourHand;

		// Token: 0x04000EF1 RID: 3825
		[Token(Token = "0x4000EF1")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 RotationAxis;

		// Token: 0x04000EF2 RID: 3826
		[Token(Token = "0x4000EF2")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onNoon;

		// Token: 0x04000EF3 RID: 3827
		[Token(Token = "0x4000EF3")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onMidnight;
	}
}
