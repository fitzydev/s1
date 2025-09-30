using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	[RequireComponent(typeof(Rigidbody))]
	public class CombatNPCDetector : MonoBehaviour
	{
		// Token: 0x06003F65 RID: 16229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x85F000", Offset = "0x85DA00", VA = "0x18085F000")]
		private void Awake()
		{
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x85F0C0", Offset = "0x85DAC0", VA = "0x18085F0C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x85F120", Offset = "0x85DB20", VA = "0x18085F120")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F68")]
		[Address(RVA = "0x85F2A0", Offset = "0x85DCA0", VA = "0x18085F2A0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x85F380", Offset = "0x85DD80", VA = "0x18085F380")]
		public CombatNPCDetector()
		{
		}

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x20")]
		public bool DetectOnlyInCombat;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDetected;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[FieldOffset(Offset = "0x30")]
		public float ContactTimeForDetection;

		// Token: 0x04002C6C RID: 11372
		[Token(Token = "0x4002C6C")]
		[FieldOffset(Offset = "0x34")]
		private bool inContact;

		// Token: 0x04002C6D RID: 11373
		[Token(Token = "0x4002C6D")]
		[FieldOffset(Offset = "0x38")]
		private NPC npcInContact;

		// Token: 0x04002C6E RID: 11374
		[Token(Token = "0x4002C6E")]
		[FieldOffset(Offset = "0x40")]
		private float contactTime;
	}
}
