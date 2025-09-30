using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000A3A RID: 2618
	[Token(Token = "0x2000A3A")]
	public class AvatarIKController : MonoBehaviour
	{
		// Token: 0x060047B7 RID: 18359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B7")]
		[Address(RVA = "0x8EE8A0", Offset = "0x8ED2A0", VA = "0x1808EE8A0")]
		private void Awake()
		{
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B8")]
		[Address(RVA = "0x8EEA50", Offset = "0x8ED450", VA = "0x1808EEA50")]
		private void Start()
		{
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B9")]
		[Address(RVA = "0x8EEA30", Offset = "0x8ED430", VA = "0x1808EEA30")]
		public void SetIKActive(bool active)
		{
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x8EE930", Offset = "0x8ED330", VA = "0x1808EE930")]
		public void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047BB")]
		[Address(RVA = "0x8EE9B0", Offset = "0x8ED3B0", VA = "0x1808EE9B0")]
		public void ResetLegBendTargets()
		{
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047BC")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public AvatarIKController()
		{
		}

		// Token: 0x040032A0 RID: 12960
		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public BipedIK BodyIK;

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x28")]
		private Transform defaultLeftLegBendTarget;

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x30")]
		private Transform defaultRightLegBendTarget;
	}
}
