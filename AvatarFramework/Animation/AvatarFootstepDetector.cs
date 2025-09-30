using System;
using Il2CppDummyDll;
using ScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000A39 RID: 2617
	[Token(Token = "0x2000A39")]
	public class AvatarFootstepDetector : MonoBehaviour
	{
		// Token: 0x060047B3 RID: 18355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B3")]
		[Address(RVA = "0x8EDF70", Offset = "0x8EC970", VA = "0x1808EDF70")]
		private void LateUpdate()
		{
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B4")]
		[Address(RVA = "0x8EE270", Offset = "0x8ECC70", VA = "0x1808EE270")]
		public void TriggerStep()
		{
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x60047B5")]
		[Address(RVA = "0x8EDCF0", Offset = "0x8EC6F0", VA = "0x1808EDCF0")]
		public bool IsGrounded(out EMaterialType surfaceType)
		{
			return default(bool);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B6")]
		[Address(RVA = "0x8EE2F0", Offset = "0x8ECCF0", VA = "0x1808EE2F0")]
		public AvatarFootstepDetector()
		{
		}

		// Token: 0x04003295 RID: 12949
		[Token(Token = "0x4003295")]
		public const float MAX_DETECTION_RANGE = 20f;

		// Token: 0x04003296 RID: 12950
		[Token(Token = "0x4003296")]
		public const float GROUND_DETECTION_RANGE = 0.25f;

		// Token: 0x04003297 RID: 12951
		[Token(Token = "0x4003297")]
		[FieldOffset(Offset = "0x20")]
		public Avatar Avatar;

		// Token: 0x04003298 RID: 12952
		[Token(Token = "0x4003298")]
		[FieldOffset(Offset = "0x28")]
		public Transform ReferencePoint;

		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x30")]
		public Transform LeftBone;

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x38")]
		public Transform RightBone;

		// Token: 0x0400329B RID: 12955
		[Token(Token = "0x400329B")]
		[FieldOffset(Offset = "0x40")]
		public float StepThreshold;

		// Token: 0x0400329C RID: 12956
		[Token(Token = "0x400329C")]
		[FieldOffset(Offset = "0x44")]
		public LayerMask GroundDetectionMask;

		// Token: 0x0400329D RID: 12957
		[Token(Token = "0x400329D")]
		[FieldOffset(Offset = "0x48")]
		private bool leftDown;

		// Token: 0x0400329E RID: 12958
		[Token(Token = "0x400329E")]
		[FieldOffset(Offset = "0x49")]
		private bool rightDown;

		// Token: 0x0400329F RID: 12959
		[Token(Token = "0x400329F")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent<EMaterialType, float> onStep;
	}
}
