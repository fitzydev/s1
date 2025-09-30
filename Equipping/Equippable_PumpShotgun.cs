using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009CE RID: 2510
	[Token(Token = "0x20009CE")]
	public class Equippable_PumpShotgun : Equippable_RangedWeapon
	{
		// Token: 0x06004489 RID: 17545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004489")]
		[Address(RVA = "0x8BA1D0", Offset = "0x8B8BD0", VA = "0x1808BA1D0", Slot = "12")]
		protected override Vector3[] GetBulletDirections()
		{
			return null;
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448A")]
		[Address(RVA = "0x8BA380", Offset = "0x8B8D80", VA = "0x1808BA380")]
		public Equippable_PumpShotgun()
		{
		}

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x1A8")]
		[Header("Shotgun Settings")]
		public int PelletCount;
	}
}
