using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000921 RID: 2337
	[Token(Token = "0x2000921")]
	public class SmoothRotate : MonoBehaviour
	{
		// Token: 0x0600401B RID: 16411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401B")]
		[Address(RVA = "0x874DB0", Offset = "0x8737B0", VA = "0x180874DB0")]
		private void Update()
		{
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401C")]
		[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600401D")]
		[Address(RVA = "0x874F00", Offset = "0x873900", VA = "0x180874F00")]
		public SmoothRotate()
		{
		}

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x20")]
		public bool Active;

		// Token: 0x04002CF3 RID: 11507
		[Token(Token = "0x4002CF3")]
		[FieldOffset(Offset = "0x24")]
		public float Speed;

		// Token: 0x04002CF4 RID: 11508
		[Token(Token = "0x4002CF4")]
		[FieldOffset(Offset = "0x28")]
		public float Aceleration;

		// Token: 0x04002CF5 RID: 11509
		[Token(Token = "0x4002CF5")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 Axis;

		// Token: 0x04002CF6 RID: 11510
		[Token(Token = "0x4002CF6")]
		[FieldOffset(Offset = "0x38")]
		private float currentSpeed;
	}
}
