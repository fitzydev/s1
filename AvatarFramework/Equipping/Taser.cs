using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A4D RID: 2637
	[Token(Token = "0x2000A4D")]
	public class Taser : AvatarRangedWeapon
	{
		// Token: 0x06004818 RID: 18456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004818")]
		[Address(RVA = "0x90E1F0", Offset = "0x90CBF0", VA = "0x18090E1F0", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004819")]
		[Address(RVA = "0x90E330", Offset = "0x90CD30", VA = "0x18090E330", Slot = "12")]
		protected override void Shoot(Vector3 endPoint)
		{
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481A")]
		[Address(RVA = "0x90E140", Offset = "0x90CB40", VA = "0x18090E140", Slot = "13")]
		public override void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint)
		{
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481B")]
		[Address(RVA = "0x90E2D0", Offset = "0x90CCD0", VA = "0x18090E2D0", Slot = "11")]
		public override void SetIsRaised(bool raised)
		{
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600481C")]
		[Address(RVA = "0x90E240", Offset = "0x90CC40", VA = "0x18090E240")]
		private IEnumerator Flash(Vector3 endPoint)
		{
			return null;
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x600481D")]
		[Address(RVA = "0x4E8A80", Offset = "0x4E7480", VA = "0x1804E8A80", Slot = "14")]
		public override float GetIdealUseRange()
		{
			return 0f;
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481E")]
		[Address(RVA = "0x90E430", Offset = "0x90CE30", VA = "0x18090E430")]
		public Taser()
		{
		}

		// Token: 0x0400331E RID: 13086
		[Token(Token = "0x400331E")]
		public const float TaseDuration = 2f;

		// Token: 0x0400331F RID: 13087
		[Token(Token = "0x400331F")]
		public const float TaseMoveSpeedMultiplier = 0.5f;

		// Token: 0x04003320 RID: 13088
		[Token(Token = "0x4003320")]
		[FieldOffset(Offset = "0x100")]
		[Header("References")]
		public GameObject FlashObject;

		// Token: 0x04003321 RID: 13089
		[Token(Token = "0x4003321")]
		[FieldOffset(Offset = "0x108")]
		public AudioSourceController ChargeSound;

		// Token: 0x04003322 RID: 13090
		[Token(Token = "0x4003322")]
		[FieldOffset(Offset = "0x110")]
		[Header("Prefabs")]
		public GameObject RayPrefab;

		// Token: 0x04003323 RID: 13091
		[Token(Token = "0x4003323")]
		[FieldOffset(Offset = "0x118")]
		private Coroutine flashRoutine;
	}
}
