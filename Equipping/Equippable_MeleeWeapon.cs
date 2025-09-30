using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009CA RID: 2506
	[Token(Token = "0x20009CA")]
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x17000981")]
		public bool IsLoading
		{
			[Token(Token = "0x600446D")]
			[Address(RVA = "0x8B9C10", Offset = "0x8B8610", VA = "0x1808B9C10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x00011EF8 File Offset: 0x000100F8
		// (set) Token: 0x0600446F RID: 17519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000982")]
		public bool IsAttacking
		{
			[Token(Token = "0x600446E")]
			[Address(RVA = "0x7BA9D0", Offset = "0x7B93D0", VA = "0x1807BA9D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600446F")]
			[Address(RVA = "0x8B9C30", Offset = "0x8B8630", VA = "0x1808B9C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004470")]
		[Address(RVA = "0x8B9A30", Offset = "0x8B8430", VA = "0x1808B9A30", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004471")]
		[Address(RVA = "0x8B8660", Offset = "0x8B7060", VA = "0x1808B8660", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004472")]
		[Address(RVA = "0x8B9530", Offset = "0x8B7F30", VA = "0x1808B9530", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004473")]
		[Address(RVA = "0x8B95E0", Offset = "0x8B7FE0", VA = "0x1808B95E0")]
		private void UpdateCooldown()
		{
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004474")]
		[Address(RVA = "0x8B9660", Offset = "0x8B8060", VA = "0x1808B9660")]
		private void UpdateInput()
		{
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00011F10 File Offset: 0x00010110
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x8B85C0", Offset = "0x8B6FC0", VA = "0x1808B85C0")]
		private bool CanStartLoading()
		{
			return default(bool);
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004476")]
		[Address(RVA = "0x8B9390", Offset = "0x8B7D90", VA = "0x1808B9390")]
		private void StartLoad()
		{
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004477")]
		[Address(RVA = "0x8B8F50", Offset = "0x8B7950", VA = "0x1808B8F50")]
		private void Release()
		{
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004478")]
		[Address(RVA = "0x8B8D90", Offset = "0x8B7790", VA = "0x1808B8D90")]
		private void Hit(float power)
		{
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004479")]
		[Address(RVA = "0x8B8670", Offset = "0x8B7070", VA = "0x1808B8670")]
		private void ExecuteHit(float power)
		{
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x8B9B70", Offset = "0x8B8570", VA = "0x1808B9B70")]
		public Equippable_MeleeWeapon()
		{
		}

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0xA4")]
		[Header("Basic Settings")]
		public EImpactType ImpactType;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0xA8")]
		public float Range;

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0xAC")]
		public float HitRadius;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0xB0")]
		[Header("Timing")]
		public float MaxLoadTime;

		// Token: 0x04002FEB RID: 12267
		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0xB4")]
		public float MinCooldown;

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0xB8")]
		public float MaxCooldown;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0xBC")]
		public float MinHitDelay;

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0xC0")]
		public float MaxHitDelay;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0xC4")]
		[Header("Damage")]
		public float MinDamage;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0xC8")]
		public float MaxDamage;

		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		[FieldOffset(Offset = "0xCC")]
		public float MinForce;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0xD0")]
		public float MaxForce;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0xD4")]
		[Header("Stamina Settings")]
		public float MinStaminaCost;

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0xD8")]
		public float MaxStaminaCost;

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0xE0")]
		[Header("Sound")]
		public AudioSourceController WhooshSound;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0xE8")]
		public float WhooshSoundPitch;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0xF0")]
		public AudioSourceController ImpactSound;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0xF8")]
		[Header("Animation")]
		public string SwingAnimationTrigger;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x100")]
		private float load;

		// Token: 0x04002FFA RID: 12282
		[Token(Token = "0x4002FFA")]
		[FieldOffset(Offset = "0x104")]
		private float remainingCooldown;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0x108")]
		private Coroutine hitRoutine;

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[FieldOffset(Offset = "0x110")]
		private bool loadQueued;

		// Token: 0x04002FFD RID: 12285
		[Token(Token = "0x4002FFD")]
		[FieldOffset(Offset = "0x111")]
		private bool clickReleased;
	}
}
