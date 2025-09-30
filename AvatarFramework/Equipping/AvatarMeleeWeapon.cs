using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		// Token: 0x060047F2 RID: 18418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F2")]
		[Address(RVA = "0x8F1DE0", Offset = "0x8F07E0", VA = "0x1808F1DE0", Slot = "7")]
		public override void Unequip()
		{
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x60047F3")]
		[Address(RVA = "0x8F1D90", Offset = "0x8F0790", VA = "0x1808F1D90", Slot = "10")]
		public override bool IsReadyToAttack()
		{
			return default(bool);
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F4")]
		[Address(RVA = "0x8F1BB0", Offset = "0x8F05B0", VA = "0x1808F1BB0", Slot = "9")]
		public override void Attack()
		{
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F5")]
		[Address(RVA = "0x8F1EA0", Offset = "0x8F08A0", VA = "0x1808F1EA0")]
		public AvatarMeleeWeapon()
		{
		}

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		public const float GruntChance = 0.4f;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x80")]
		[Header("References")]
		public AudioSourceController AttackSound;

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0x88")]
		public AudioSourceController HitSound;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0x90")]
		[Header("Melee Weapon settings")]
		public EImpactType ImpactType;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0x94")]
		public float AttackRange;

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0x98")]
		public float AttackRadius;

		// Token: 0x040032E9 RID: 13033
		[Token(Token = "0x40032E9")]
		[FieldOffset(Offset = "0x9C")]
		public float Damage;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0xA0")]
		public float ImpactForce;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0xA8")]
		public AvatarMeleeWeapon.MeleeAttack[] Attacks;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine attackRoutine;

		// Token: 0x02000A47 RID: 2631
		[Token(Token = "0x2000A47")]
		[Serializable]
		public class MeleeAttack
		{
			// Token: 0x060047F6 RID: 18422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047F6")]
			[Address(RVA = "0x8F7C00", Offset = "0x8F6600", VA = "0x1808F7C00")]
			public MeleeAttack()
			{
			}

			// Token: 0x040032ED RID: 13037
			[Token(Token = "0x40032ED")]
			[FieldOffset(Offset = "0x10")]
			public float RangeMultiplier;

			// Token: 0x040032EE RID: 13038
			[Token(Token = "0x40032EE")]
			[FieldOffset(Offset = "0x14")]
			public float DamageMultiplier;

			// Token: 0x040032EF RID: 13039
			[Token(Token = "0x40032EF")]
			[FieldOffset(Offset = "0x18")]
			public string AnimationTrigger;

			// Token: 0x040032F0 RID: 13040
			[Token(Token = "0x40032F0")]
			[FieldOffset(Offset = "0x20")]
			public float DamageDelay;

			// Token: 0x040032F1 RID: 13041
			[Token(Token = "0x40032F1")]
			[FieldOffset(Offset = "0x24")]
			public float AttackSoundDelay;

			// Token: 0x040032F2 RID: 13042
			[Token(Token = "0x40032F2")]
			[FieldOffset(Offset = "0x28")]
			public AudioClip[] AttackClips;

			// Token: 0x040032F3 RID: 13043
			[Token(Token = "0x40032F3")]
			[FieldOffset(Offset = "0x30")]
			public AudioClip[] HitClips;
		}
	}
}
