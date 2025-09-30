using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000926 RID: 2342
	[Token(Token = "0x2000926")]
	public class FunctionalSeed : MonoBehaviour
	{
		// Token: 0x06004028 RID: 16424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x863C70", Offset = "0x862670", VA = "0x180863C70")]
		public void TriggerExit(Collider other)
		{
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public FunctionalSeed()
		{
		}

		// Token: 0x04002D06 RID: 11526
		[Token(Token = "0x4002D06")]
		[FieldOffset(Offset = "0x20")]
		public Action onSeedExitVial;

		// Token: 0x04002D07 RID: 11527
		[Token(Token = "0x4002D07")]
		[FieldOffset(Offset = "0x28")]
		public Draggable Vial;

		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0x30")]
		public Collider SeedBlocker;

		// Token: 0x04002D09 RID: 11529
		[Token(Token = "0x4002D09")]
		[FieldOffset(Offset = "0x38")]
		public VialCap Cap;

		// Token: 0x04002D0A RID: 11530
		[Token(Token = "0x4002D0A")]
		[FieldOffset(Offset = "0x40")]
		public Collider SeedCollider;

		// Token: 0x04002D0B RID: 11531
		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0x48")]
		public Rigidbody SeedRigidbody;

		// Token: 0x04002D0C RID: 11532
		[Token(Token = "0x4002D0C")]
		[FieldOffset(Offset = "0x50")]
		public TrashItem TrashPrefab;
	}
}
