using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200090D RID: 2317
	[Token(Token = "0x200090D")]
	public class OnlineBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x06003FC4 RID: 16324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x867B00", Offset = "0x866500", VA = "0x180867B00")]
		private void Awake()
		{
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x867CC0", Offset = "0x8666C0", VA = "0x180867CC0")]
		private void UpdateCollider()
		{
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x867B80", Offset = "0x866580", VA = "0x180867B80")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x867D90", Offset = "0x866790", VA = "0x180867D90")]
		public OnlineBalanceActivationZone()
		{
		}

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		public const float ActivationDistance = 20f;

		// Token: 0x04002CAF RID: 11439
		[Token(Token = "0x4002CAF")]
		[FieldOffset(Offset = "0x20")]
		private List<Collider> exclude;

		// Token: 0x04002CB0 RID: 11440
		[Token(Token = "0x4002CB0")]
		[FieldOffset(Offset = "0x28")]
		private Collider collider;
	}
}
