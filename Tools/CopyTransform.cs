using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008E1 RID: 2273
	[Token(Token = "0x20008E1")]
	public class CopyTransform : MonoBehaviour
	{
		// Token: 0x06003F28 RID: 16168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x85F720", Offset = "0x85E120", VA = "0x18085F720")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x85F740", Offset = "0x85E140", VA = "0x18085F740")]
		private void Update()
		{
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x85F730", Offset = "0x85E130", VA = "0x18085F730")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x85F390", Offset = "0x85DD90", VA = "0x18085F390")]
		private void Copy()
		{
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x85F750", Offset = "0x85E150", VA = "0x18085F750")]
		public CopyTransform()
		{
		}

		// Token: 0x04002C30 RID: 11312
		[Token(Token = "0x4002C30")]
		[FieldOffset(Offset = "0x20")]
		public Transform Target;

		// Token: 0x04002C31 RID: 11313
		[Token(Token = "0x4002C31")]
		[FieldOffset(Offset = "0x28")]
		public CopyTransform.EUpdateMode UpdateMode;

		// Token: 0x04002C32 RID: 11314
		[Token(Token = "0x4002C32")]
		[FieldOffset(Offset = "0x2C")]
		public bool CopyPosition;

		// Token: 0x04002C33 RID: 11315
		[Token(Token = "0x4002C33")]
		[FieldOffset(Offset = "0x2D")]
		public bool CopyRotation;

		// Token: 0x04002C34 RID: 11316
		[Token(Token = "0x4002C34")]
		[FieldOffset(Offset = "0x2E")]
		public bool CopyScale;

		// Token: 0x04002C35 RID: 11317
		[Token(Token = "0x4002C35")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 GlobalPositionOffset;

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 LocalPositionOffset;

		// Token: 0x04002C37 RID: 11319
		[Token(Token = "0x4002C37")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 RotationOffset;

		// Token: 0x020008E2 RID: 2274
		[Token(Token = "0x20008E2")]
		public enum EUpdateMode
		{
			// Token: 0x04002C39 RID: 11321
			[Token(Token = "0x4002C39")]
			Update,
			// Token: 0x04002C3A RID: 11322
			[Token(Token = "0x4002C3A")]
			LateUpdate,
			// Token: 0x04002C3B RID: 11323
			[Token(Token = "0x4002C3B")]
			FixedUpdate
		}
	}
}
