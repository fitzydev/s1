using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000604 RID: 1540
	[Token(Token = "0x2000604")]
	[RequireComponent(typeof(Rigidbody))]
	public class DoorSensor : MonoBehaviour
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x6F7820", Offset = "0x6F6220", VA = "0x1806F7820")]
		private void Awake()
		{
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x6F7E30", Offset = "0x6F6830", VA = "0x1806F7E30")]
		private void UpdateCollider()
		{
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x6F7940", Offset = "0x6F6340", VA = "0x1806F7940")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x6F7C60", Offset = "0x6F6660", VA = "0x1806F7C60")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002623")]
		[Address(RVA = "0x6F78A0", Offset = "0x6F62A0", VA = "0x1806F78A0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002624")]
		[Address(RVA = "0x6F8100", Offset = "0x6F6B00", VA = "0x1806F8100")]
		public DoorSensor()
		{
		}

		// Token: 0x04001D5B RID: 7515
		[Token(Token = "0x4001D5B")]
		public const float ActivationDistance = 30f;

		// Token: 0x04001D5C RID: 7516
		[Token(Token = "0x4001D5C")]
		[FieldOffset(Offset = "0x20")]
		public EDoorSide DetectorSide;

		// Token: 0x04001D5D RID: 7517
		[Token(Token = "0x4001D5D")]
		[FieldOffset(Offset = "0x28")]
		public DoorController Door;

		// Token: 0x04001D5E RID: 7518
		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0x30")]
		private Collider collider;

		// Token: 0x04001D5F RID: 7519
		[Token(Token = "0x4001D5F")]
		[FieldOffset(Offset = "0x38")]
		private List<Collider> exclude;

		// Token: 0x04001D60 RID: 7520
		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0x40")]
		private List<NPC> npcsInContact;

		// Token: 0x04001D61 RID: 7521
		[Token(Token = "0x4001D61")]
		[FieldOffset(Offset = "0x48")]
		private List<Player> playersInContact;
	}
}
