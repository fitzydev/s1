using System;
using Il2CppDummyDll;
using ScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x200054A")]
	public class LocalPlayerFootstepGenerator : MonoBehaviour
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x63E3B0", Offset = "0x63CDB0", VA = "0x18063E3B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x63E730", Offset = "0x63D130", VA = "0x18063E730")]
		public void TriggerStep()
		{
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x63E130", Offset = "0x63CB30", VA = "0x18063E130")]
		public bool IsGrounded(out EMaterialType surfaceType)
		{
			return default(bool);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x63E810", Offset = "0x63D210", VA = "0x18063E810")]
		public LocalPlayerFootstepGenerator()
		{
		}

		// Token: 0x040017A8 RID: 6056
		[Token(Token = "0x40017A8")]
		[FieldOffset(Offset = "0x20")]
		public float DistancePerStep;

		// Token: 0x040017A9 RID: 6057
		[Token(Token = "0x40017A9")]
		[FieldOffset(Offset = "0x28")]
		public Transform ReferencePoint;

		// Token: 0x040017AA RID: 6058
		[Token(Token = "0x40017AA")]
		[FieldOffset(Offset = "0x30")]
		public LayerMask GroundDetectionMask;

		// Token: 0x040017AB RID: 6059
		[Token(Token = "0x40017AB")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<EMaterialType, float> onStep;

		// Token: 0x040017AC RID: 6060
		[Token(Token = "0x40017AC")]
		[FieldOffset(Offset = "0x40")]
		private float currentDistance;

		// Token: 0x040017AD RID: 6061
		[Token(Token = "0x40017AD")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 lastFramePosition;
	}
}
