using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	public class AvatarWeapon : AvatarEquippable
	{
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x00012EA0 File Offset: 0x000110A0
		// (set) Token: 0x06004813 RID: 18451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A28")]
		public float LastUseTime
		{
			[Token(Token = "0x6004812")]
			[Address(RVA = "0x4F2900", Offset = "0x4F1300", VA = "0x1804F2900")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004813")]
			[Address(RVA = "0x507040", Offset = "0x505A40", VA = "0x180507040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004814")]
		[Address(RVA = "0x8F4B80", Offset = "0x8F3580", VA = "0x1808F4B80", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004815")]
		[Address(RVA = "0x8F4B60", Offset = "0x8F3560", VA = "0x1808F4B60", Slot = "9")]
		public virtual void Attack()
		{
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x6004816")]
		[Address(RVA = "0x8F4C80", Offset = "0x8F3680", VA = "0x1808F4C80", Slot = "10")]
		public virtual bool IsReadyToAttack()
		{
			return default(bool);
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004817")]
		[Address(RVA = "0x8F4CB0", Offset = "0x8F36B0", VA = "0x1808F4CB0")]
		public AvatarWeapon()
		{
		}

		// Token: 0x04003317 RID: 13079
		[Token(Token = "0x4003317")]
		[FieldOffset(Offset = "0x50")]
		[Header("Range settings")]
		public float MinUseRange;

		// Token: 0x04003318 RID: 13080
		[Token(Token = "0x4003318")]
		[FieldOffset(Offset = "0x54")]
		public float MaxUseRange;

		// Token: 0x04003319 RID: 13081
		[Token(Token = "0x4003319")]
		[FieldOffset(Offset = "0x58")]
		[Header("Cooldown settings")]
		public float CooldownDuration;

		// Token: 0x0400331A RID: 13082
		[Token(Token = "0x400331A")]
		[FieldOffset(Offset = "0x60")]
		[Header("Equipping")]
		public AudioClip[] EquipClips;

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		[FieldOffset(Offset = "0x68")]
		public AudioSourceController EquipSound;

		// Token: 0x0400331D RID: 13085
		[Token(Token = "0x400331D")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onSuccessfulHit;
	}
}
