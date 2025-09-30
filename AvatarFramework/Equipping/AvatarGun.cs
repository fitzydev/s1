using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A44 RID: 2628
	[Token(Token = "0x2000A44")]
	public class AvatarGun : AvatarRangedWeapon
	{
		// Token: 0x060047E9 RID: 18409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E9")]
		[Address(RVA = "0x8EE400", Offset = "0x8ECE00", VA = "0x1808EE400", Slot = "12")]
		protected override void Shoot(Vector3 endPoint)
		{
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047EA")]
		[Address(RVA = "0x8EE370", Offset = "0x8ECD70", VA = "0x1808EE370")]
		private IEnumerator Flash(Vector3 endPoint)
		{
			return null;
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047EB")]
		[Address(RVA = "0x8EE7F0", Offset = "0x8ED1F0", VA = "0x1808EE7F0")]
		public AvatarGun()
		{
		}

		// Token: 0x040032D9 RID: 13017
		[Token(Token = "0x40032D9")]
		[FieldOffset(Offset = "0x100")]
		[Header("References")]
		public Animation Anim;

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x108")]
		public ParticleSystem ShellParticles;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x110")]
		public ParticleSystem SmokeParticles;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[FieldOffset(Offset = "0x118")]
		public Transform FlashObject;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[FieldOffset(Offset = "0x120")]
		[Header("Prefabs")]
		public GameObject RayPrefab;

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x128")]
		private Coroutine flashRoutine;
	}
}
