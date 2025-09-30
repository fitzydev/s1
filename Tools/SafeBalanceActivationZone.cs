using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200091A RID: 2330
	[Token(Token = "0x200091A")]
	public class SafeBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x06003FFD RID: 16381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFD")]
		[Address(RVA = "0x873BF0", Offset = "0x8725F0", VA = "0x180873BF0")]
		private void Awake()
		{
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x873E30", Offset = "0x872830", VA = "0x180873E30")]
		private void UpdateCollider()
		{
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x873BE0", Offset = "0x8725E0", VA = "0x180873BE0")]
		private void Activate()
		{
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x873CA0", Offset = "0x8726A0", VA = "0x180873CA0")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x873F30", Offset = "0x872930", VA = "0x180873F30")]
		public SafeBalanceActivationZone()
		{
		}

		// Token: 0x04002CD4 RID: 11476
		[Token(Token = "0x4002CD4")]
		public const float ActivationDistance = 30f;

		// Token: 0x04002CD5 RID: 11477
		[Token(Token = "0x4002CD5")]
		[FieldOffset(Offset = "0x20")]
		public Safe Safe;

		// Token: 0x04002CD6 RID: 11478
		[Token(Token = "0x4002CD6")]
		[FieldOffset(Offset = "0x28")]
		private List<Collider> exclude;

		// Token: 0x04002CD7 RID: 11479
		[Token(Token = "0x4002CD7")]
		[FieldOffset(Offset = "0x30")]
		private Collider[] colliders;

		// Token: 0x04002CD8 RID: 11480
		[Token(Token = "0x4002CD8")]
		[FieldOffset(Offset = "0x38")]
		private bool active;
	}
}
