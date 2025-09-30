using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000911 RID: 2321
	[Token(Token = "0x2000911")]
	public class PhysicsEvents : MonoBehaviour
	{
		// Token: 0x06003FDA RID: 16346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x870AA0", Offset = "0x86F4A0", VA = "0x180870AA0")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x870B90", Offset = "0x86F590", VA = "0x180870B90")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0x870880", Offset = "0x86F280", VA = "0x180870880")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x870990", Offset = "0x86F390", VA = "0x180870990")]
		public void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x870710", Offset = "0x86F110", VA = "0x180870710")]
		private static string GetHierarchyString(Transform transform)
		{
			return null;
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PhysicsEvents()
		{
		}

		// Token: 0x04002CB8 RID: 11448
		[Token(Token = "0x4002CB8")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04002CB9 RID: 11449
		[Token(Token = "0x4002CB9")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<Collider> OnTriggerEnterEvent;

		// Token: 0x04002CBA RID: 11450
		[Token(Token = "0x4002CBA")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<Collider> OnTriggerExitEvent;

		// Token: 0x04002CBB RID: 11451
		[Token(Token = "0x4002CBB")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<Collision> OnCollisionEnterEvent;

		// Token: 0x04002CBC RID: 11452
		[Token(Token = "0x4002CBC")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent<Collision> OnCollisionExitEvent;
	}
}
