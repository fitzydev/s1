using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200091E RID: 2334
	[Token(Token = "0x200091E")]
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x00011010 File Offset: 0x0000F210
		// (set) Token: 0x06004009 RID: 16393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F8")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6004008")]
			[Address(RVA = "0x4FAB40", Offset = "0x4F9540", VA = "0x1804FAB40")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004009")]
			[Address(RVA = "0x4FADF0", Offset = "0x4F97F0", VA = "0x1804FADF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600400A RID: 16394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600400B RID: 16395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F9")]
		public Transform Target
		{
			[Token(Token = "0x600400A")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600400B")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400C")]
		[Address(RVA = "0x8754C0", Offset = "0x873EC0", VA = "0x1808754C0")]
		private void Start()
		{
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400D")]
		[Address(RVA = "0x874F70", Offset = "0x873970", VA = "0x180874F70", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x600400E")]
		[Address(RVA = "0x875380", Offset = "0x873D80", VA = "0x180875380")]
		private Vector3 GetAverageVelocity()
		{
			return default(Vector3);
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600400F")]
		[Address(RVA = "0x875290", Offset = "0x873C90", VA = "0x180875290")]
		public void FlushBuffer()
		{
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004010")]
		[Address(RVA = "0x875570", Offset = "0x873F70", VA = "0x180875570")]
		public void ZeroOut(float duration)
		{
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004011")]
		[Address(RVA = "0x8753C0", Offset = "0x873DC0", VA = "0x1808753C0")]
		public void SetTarget(Transform target)
		{
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004012")]
		[Address(RVA = "0x8736C0", Offset = "0x8720C0", VA = "0x1808736C0")]
		public SmoothedVelocityCalculator()
		{
		}

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		private const int sampleCount = 20;

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04002CE6 RID: 11494
		[Token(Token = "0x4002CE6")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public float SampleLength;

		// Token: 0x04002CE7 RID: 11495
		[Token(Token = "0x4002CE7")]
		[FieldOffset(Offset = "0x3C")]
		public float MaxReasonableVelocity;

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x40")]
		private CircularQueue<Vector3> velocityHistory;

		// Token: 0x04002CE9 RID: 11497
		[Token(Token = "0x4002CE9")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 lastSamplePosition;

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x54")]
		private float timeOnLastSample;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		[FieldOffset(Offset = "0x58")]
		private float timeSinceLastSample;

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		[FieldOffset(Offset = "0x5C")]
		private bool zeroOut;
	}
}
