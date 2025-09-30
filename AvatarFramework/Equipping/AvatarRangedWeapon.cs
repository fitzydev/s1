using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	public class AvatarRangedWeapon : AvatarWeapon
	{
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x00012E28 File Offset: 0x00011028
		// (set) Token: 0x06004800 RID: 18432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A25")]
		public bool IsRaised
		{
			[Token(Token = "0x60047FF")]
			[Address(RVA = "0x5360C0", Offset = "0x534AC0", VA = "0x1805360C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004800")]
			[Address(RVA = "0x8F2D00", Offset = "0x8F1700", VA = "0x1808F2D00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004801")]
		[Address(RVA = "0x8F2150", Offset = "0x8F0B50", VA = "0x1808F2150", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004802")]
		[Address(RVA = "0x8F2A60", Offset = "0x8F1460", VA = "0x1808F2A60", Slot = "11")]
		public virtual void SetIsRaised(bool raised)
		{
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004803")]
		[Address(RVA = "0x8F2C80", Offset = "0x8F1680", VA = "0x1808F2C80")]
		private void Update()
		{
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004804")]
		[Address(RVA = "0x8F28B0", Offset = "0x8F12B0", VA = "0x1808F28B0", Slot = "8")]
		public override void ReceiveMessage(string message, object data)
		{
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x00012E40 File Offset: 0x00011040
		[Token(Token = "0x6004805")]
		[Address(RVA = "0x8F20F0", Offset = "0x8F0AF0", VA = "0x1808F20F0")]
		public bool CanShoot()
		{
			return default(bool);
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004806")]
		[Address(RVA = "0x8F2AE0", Offset = "0x8F14E0", VA = "0x1808F2AE0", Slot = "12")]
		protected virtual void Shoot(Vector3 endPoint)
		{
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004807")]
		[Address(RVA = "0x8F1EE0", Offset = "0x8F08E0", VA = "0x1808F1EE0", Slot = "13")]
		public virtual void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint)
		{
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004808")]
		[Address(RVA = "0x8F29F0", Offset = "0x8F13F0", VA = "0x1808F29F0")]
		private IEnumerator Reload()
		{
			return null;
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x00012E58 File Offset: 0x00011058
		[Token(Token = "0x6004809")]
		[Address(RVA = "0x8F2280", Offset = "0x8F0C80", VA = "0x1808F2280")]
		public bool IsTargetInLoS(ICombatTargetable target)
		{
			return default(bool);
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x600480A")]
		[Address(RVA = "0x8F2260", Offset = "0x8F0C60", VA = "0x1808F2260", Slot = "14")]
		public virtual float GetIdealUseRange()
		{
			return 0f;
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600480B")]
		[Address(RVA = "0x8EE7F0", Offset = "0x8ED1F0", VA = "0x1808EE7F0")]
		public AvatarRangedWeapon()
		{
		}

		// Token: 0x040032FA RID: 13050
		[Token(Token = "0x40032FA")]
		[FieldOffset(Offset = "0x80")]
		[Header("Weapon Settings")]
		public int MagazineSize;

		// Token: 0x040032FB RID: 13051
		[Token(Token = "0x40032FB")]
		[FieldOffset(Offset = "0x84")]
		public float ReloadTime;

		// Token: 0x040032FC RID: 13052
		[Token(Token = "0x40032FC")]
		[FieldOffset(Offset = "0x88")]
		public float MaxFireRate;

		// Token: 0x040032FD RID: 13053
		[Token(Token = "0x40032FD")]
		[FieldOffset(Offset = "0x8C")]
		public float EquipTime;

		// Token: 0x040032FE RID: 13054
		[Token(Token = "0x40032FE")]
		[FieldOffset(Offset = "0x90")]
		public float RaiseTime;

		// Token: 0x040032FF RID: 13055
		[Token(Token = "0x40032FF")]
		[FieldOffset(Offset = "0x94")]
		public float Damage;

		// Token: 0x04003300 RID: 13056
		[Token(Token = "0x4003300")]
		[FieldOffset(Offset = "0x98")]
		public float ImpactForce;

		// Token: 0x04003301 RID: 13057
		[Token(Token = "0x4003301")]
		[FieldOffset(Offset = "0x9C")]
		public bool CanShootWhileMoving;

		// Token: 0x04003302 RID: 13058
		[Token(Token = "0x4003302")]
		[FieldOffset(Offset = "0xA0")]
		public int MaxMovingShotsBeforeReposition;

		// Token: 0x04003303 RID: 13059
		[Token(Token = "0x4003303")]
		[FieldOffset(Offset = "0xA4")]
		public int MaxStationaryShotsBeforeReposition;

		// Token: 0x04003304 RID: 13060
		[Token(Token = "0x4003304")]
		[FieldOffset(Offset = "0xA8")]
		public bool RepositionAfterHit;

		// Token: 0x04003305 RID: 13061
		[Token(Token = "0x4003305")]
		[FieldOffset(Offset = "0xAC")]
		[Header("Accuracy")]
		public float HitChance_MinRange;

		// Token: 0x04003306 RID: 13062
		[Token(Token = "0x4003306")]
		[FieldOffset(Offset = "0xB0")]
		public float HitChance_MaxRange;

		// Token: 0x04003307 RID: 13063
		[Token(Token = "0x4003307")]
		[FieldOffset(Offset = "0xB4")]
		[Header("Aiming")]
		public float AimTime_Min;

		// Token: 0x04003308 RID: 13064
		[Token(Token = "0x4003308")]
		[FieldOffset(Offset = "0xB8")]
		public float AimTime_Max;

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[FieldOffset(Offset = "0xC0")]
		[Header("References")]
		public Transform MuzzlePoint;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[FieldOffset(Offset = "0xC8")]
		public AudioSourceController FireSound;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Animation Settings")]
		public string LoweredAnimationTrigger;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[FieldOffset(Offset = "0xD8")]
		public string RaisedAnimationTrigger;

		// Token: 0x0400330D RID: 13069
		[Token(Token = "0x400330D")]
		[FieldOffset(Offset = "0xE0")]
		public string RecoilAnimationTrigger;

		// Token: 0x0400330F RID: 13071
		[Token(Token = "0x400330F")]
		[FieldOffset(Offset = "0xE9")]
		private bool isReloading;

		// Token: 0x04003310 RID: 13072
		[Token(Token = "0x4003310")]
		[FieldOffset(Offset = "0xEC")]
		private float timeEquipped;

		// Token: 0x04003311 RID: 13073
		[Token(Token = "0x4003311")]
		[FieldOffset(Offset = "0xF0")]
		private float timeRaised;

		// Token: 0x04003312 RID: 13074
		[Token(Token = "0x4003312")]
		[FieldOffset(Offset = "0xF4")]
		private float timeSinceLastShot;

		// Token: 0x04003313 RID: 13075
		[Token(Token = "0x4003313")]
		[FieldOffset(Offset = "0xF8")]
		private int currentAmmo;
	}
}
