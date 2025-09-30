using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009CF RID: 2511
	[Token(Token = "0x20009CF")]
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x00011F58 File Offset: 0x00010158
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000986")]
		public float Aim
		{
			[Token(Token = "0x600448B")]
			[Address(RVA = "0x8BD300", Offset = "0x8BBD00", VA = "0x1808BD300")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600448C")]
			[Address(RVA = "0x8BD3F0", Offset = "0x8BBDF0", VA = "0x1808BD3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x00011F70 File Offset: 0x00010170
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000987")]
		public float Accuracy
		{
			[Token(Token = "0x600448D")]
			[Address(RVA = "0x6644D0", Offset = "0x662ED0", VA = "0x1806644D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600448E")]
			[Address(RVA = "0x664600", Offset = "0x663000", VA = "0x180664600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x00011F88 File Offset: 0x00010188
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000988")]
		public float TimeSinceFire
		{
			[Token(Token = "0x600448F")]
			[Address(RVA = "0x8BD350", Offset = "0x8BBD50", VA = "0x1808BD350")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004490")]
			[Address(RVA = "0x8BD420", Offset = "0x8BBE20", VA = "0x1808BD420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x00011FA0 File Offset: 0x000101A0
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000989")]
		public bool IsReloading
		{
			[Token(Token = "0x6004491")]
			[Address(RVA = "0x506E90", Offset = "0x505890", VA = "0x180506E90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004492")]
			[Address(RVA = "0x5072D0", Offset = "0x505CD0", VA = "0x1805072D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x00011FB8 File Offset: 0x000101B8
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098A")]
		public bool IsCocked
		{
			[Token(Token = "0x6004493")]
			[Address(RVA = "0x8BD330", Offset = "0x8BBD30", VA = "0x1808BD330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004494")]
			[Address(RVA = "0x8BD400", Offset = "0x8BBE00", VA = "0x1808BD400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x00011FD0 File Offset: 0x000101D0
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098B")]
		public bool IsCocking
		{
			[Token(Token = "0x6004495")]
			[Address(RVA = "0x8BD340", Offset = "0x8BBD40", VA = "0x1808BD340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004496")]
			[Address(RVA = "0x8BD410", Offset = "0x8BBE10", VA = "0x1808BD410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Token(Token = "0x1700098C")]
		public int Ammo
		{
			[Token(Token = "0x6004497")]
			[Address(RVA = "0x8BD310", Offset = "0x8BBD10", VA = "0x1808BD310")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x1700098D")]
		private float aimFov
		{
			[Token(Token = "0x6004498")]
			[Address(RVA = "0x8BD360", Offset = "0x8BBD60", VA = "0x1808BD360")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004499")]
		[Address(RVA = "0x8BA9F0", Offset = "0x8B93F0", VA = "0x1808BA9F0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x8BC280", Offset = "0x8BAC80", VA = "0x1808BC280", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449B")]
		[Address(RVA = "0x8BCFD0", Offset = "0x8BB9D0", VA = "0x1808BCFD0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x8BC530", Offset = "0x8BAF30", VA = "0x1808BC530")]
		private void UpdateInput()
		{
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449D")]
		[Address(RVA = "0x8BC480", Offset = "0x8BAE80", VA = "0x1808BC480")]
		private void UpdateAnim()
		{
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x600449E")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0")]
		private bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449F")]
		[Address(RVA = "0x8BABF0", Offset = "0x8B95F0", VA = "0x1808BABF0", Slot = "11")]
		public virtual void Fire()
		{
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A0")]
		[Address(RVA = "0x8BB900", Offset = "0x8BA300", VA = "0x1808BB900", Slot = "12")]
		protected virtual Vector3[] GetBulletDirections()
		{
			return null;
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x60044A1")]
		[Address(RVA = "0x8BBF20", Offset = "0x8BA920", VA = "0x1808BBF20")]
		protected static Vector3 SpreadDirection(Vector3 direction, float maxAngle)
		{
			return default(Vector3);
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A2")]
		[Address(RVA = "0x8BBE20", Offset = "0x8BA820", VA = "0x1808BBE20", Slot = "13")]
		public virtual void Reload()
		{
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A3")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "14")]
		protected virtual void NotifyIncrementalReload()
		{
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x00012048 File Offset: 0x00010248
		[Token(Token = "0x60044A4")]
		[Address(RVA = "0x8BBD50", Offset = "0x8BA750", VA = "0x1808BBD50")]
		private bool IsReloadReady(bool ignoreTiming)
		{
			return default(bool);
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x60044A5")]
		[Address(RVA = "0x8BBA50", Offset = "0x8BA450", VA = "0x1808BBA50", Slot = "15")]
		protected virtual bool GetMagazine(out StorableItemInstance mag)
		{
			return default(bool);
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x60044A6")]
		[Address(RVA = "0x8BA410", Offset = "0x8B8E10", VA = "0x1808BA410")]
		private bool CanFire(bool checkAmmo = true)
		{
			return default(bool);
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x60044A7")]
		[Address(RVA = "0x8BA3A0", Offset = "0x8B8DA0", VA = "0x1808BA3A0")]
		private bool CanCock()
		{
			return default(bool);
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A8")]
		[Address(RVA = "0x8BA920", Offset = "0x8B9320", VA = "0x1808BA920")]
		private void Cock()
		{
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x000120A8 File Offset: 0x000102A8
		[Token(Token = "0x60044A9")]
		[Address(RVA = "0x8BBD00", Offset = "0x8BA700", VA = "0x1808BBD00")]
		protected float GetSpreadAngle()
		{
			return 0f;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AA")]
		[Address(RVA = "0x8BA480", Offset = "0x8B8E80", VA = "0x1808BA480")]
		private void CheckAimingAtNPC()
		{
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AB")]
		[Address(RVA = "0x8BD180", Offset = "0x8BBB80", VA = "0x1808BD180")]
		public Equippable_RangedWeapon()
		{
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AC")]
		[Address(RVA = "0x8BC210", Offset = "0x8BAC10", VA = "0x1808BC210")]
		[CompilerGenerated]
		private IEnumerator <Reload>g__ReloadRoutine|83_0()
		{
			return null;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AD")]
		[Address(RVA = "0x8BC1A0", Offset = "0x8BABA0", VA = "0x1808BC1A0")]
		[CompilerGenerated]
		private IEnumerator <Cock>g__CockRoutine|89_0()
		{
			return null;
		}

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		public const float NPC_AIM_DETECTION_RANGE = 10f;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0xB0")]
		public int MagazineSize;

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0xB4")]
		[Header("Aim Settings")]
		public float AimDuration;

		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0xB8")]
		public float AimFOVReduction;

		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Firing")]
		public AudioSourceController FireSound;

		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		[FieldOffset(Offset = "0xC8")]
		public AudioSourceController EmptySound;

		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		[FieldOffset(Offset = "0xD0")]
		public float FireCooldown;

		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		[FieldOffset(Offset = "0xD8")]
		public string[] FireAnimTriggers;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0xE0")]
		public float AccuracyChangeDuration;

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[FieldOffset(Offset = "0xE4")]
		[Header("Raycasting")]
		public float Range;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0xE8")]
		public float RayRadius;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0xEC")]
		[Header("Spread")]
		public float MinSpread;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0xF0")]
		public float MaxSpread;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0xF4")]
		[Header("Damage")]
		public float Damage;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0xF8")]
		public float ImpactForce;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0xFC")]
		[Header("Reloading")]
		public bool CanReload;

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0x100")]
		public Equippable_RangedWeapon.EReloadType ReloadType;

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0x108")]
		public StorableItemDefinition Magazine;

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x110")]
		public float ReloadStartTime;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x114")]
		public float ReloadIndividalTime;

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0x118")]
		public float ReloadEndTime;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0x120")]
		public string ReloadStartAnimTrigger;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x128")]
		public string ReloadIndividualAnimTrigger;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x130")]
		public string ReloadEndAnimTrigger;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x138")]
		public TrashItem ReloadTrash;

		// Token: 0x04003026 RID: 12326
		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x140")]
		[Header("Cocking")]
		public bool MustBeCocked;

		// Token: 0x04003027 RID: 12327
		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x141")]
		public bool CockedByDefault;

		// Token: 0x04003028 RID: 12328
		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x142")]
		public bool AutoCockAfterReload;

		// Token: 0x04003029 RID: 12329
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x144")]
		public float CockTime;

		// Token: 0x0400302A RID: 12330
		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x148")]
		public string CockAnimTrigger;

		// Token: 0x0400302B RID: 12331
		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0x150")]
		[Header("Effects")]
		public float TracerSpeed;

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onFire;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent onReloadStart;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x168")]
		public UnityEvent onReloadIndividual;

		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onReloadEnd;

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onCockStart;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x180")]
		protected IntegerItemInstance weaponItem;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x188")]
		private bool fovOverridden;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x18C")]
		private float aimVelocity;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x190")]
		private Coroutine reloadRoutine;

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x198")]
		private bool shotQueued;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x199")]
		private bool reloadQueued;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x19C")]
		private float timeSincePrimaryClick;

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x1A0")]
		private float timeSinceReloadStart;

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x1A4")]
		private bool interruptReload;

		// Token: 0x020009D0 RID: 2512
		[Token(Token = "0x20009D0")]
		public enum EReloadType
		{
			// Token: 0x0400303B RID: 12347
			[Token(Token = "0x400303B")]
			Magazine,
			// Token: 0x0400303C RID: 12348
			[Token(Token = "0x400303C")]
			Incremental
		}
	}
}
