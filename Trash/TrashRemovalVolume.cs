using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	[RequireComponent(typeof(BoxCollider))]
	public class TrashRemovalVolume : MonoBehaviour
	{
		// Token: 0x06003F01 RID: 16129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F01")]
		[Address(RVA = "0x875BA0", Offset = "0x8745A0", VA = "0x180875BA0")]
		public void Awake()
		{
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F02")]
		[Address(RVA = "0x876070", Offset = "0x874A70", VA = "0x180876070")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F03")]
		[Address(RVA = "0x8761E0", Offset = "0x874BE0", VA = "0x1808761E0")]
		private void SleepStart()
		{
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F04")]
		[Address(RVA = "0x875CF0", Offset = "0x8746F0", VA = "0x180875CF0")]
		private TrashItem[] GetTrash()
		{
			return null;
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x876270", Offset = "0x874C70", VA = "0x180876270")]
		public TrashRemovalVolume()
		{
		}

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider Collider;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x28")]
		public float RemovalChance;
	}
}
