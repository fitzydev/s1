using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	public class TrashSpawnVolume : MonoBehaviour
	{
		// Token: 0x06003F06 RID: 16134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F06")]
		[Address(RVA = "0x876280", Offset = "0x874C80", VA = "0x180876280")]
		public void Awake()
		{
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F07")]
		[Address(RVA = "0x8763D0", Offset = "0x874DD0", VA = "0x1808763D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x876540", Offset = "0x874F40", VA = "0x180876540")]
		public void SleepStart()
		{
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x876B90", Offset = "0x875590", VA = "0x180876B90")]
		public TrashSpawnVolume()
		{
		}

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider CreatonVolume;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x28")]
		public BoxCollider DetectionVolume;

		// Token: 0x04002C10 RID: 11280
		[Token(Token = "0x4002C10")]
		[FieldOffset(Offset = "0x30")]
		public int TrashLimit;

		// Token: 0x04002C11 RID: 11281
		[Token(Token = "0x4002C11")]
		[FieldOffset(Offset = "0x34")]
		public float TrashSpawnChance;
	}
}
