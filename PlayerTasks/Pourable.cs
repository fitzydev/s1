using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034F RID: 847
	[Token(Token = "0x200034F")]
	[RequireComponent(typeof(Accelerometer))]
	public class Pourable : Draggable
	{
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00007F38 File Offset: 0x00006138
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038D")]
		public bool IsPouring
		{
			[Token(Token = "0x60012AB")]
			[Address(RVA = "0x50D9F0", Offset = "0x50C3F0", VA = "0x18050D9F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60012AC")]
			[Address(RVA = "0x50DAB0", Offset = "0x50C4B0", VA = "0x18050DAB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00007F50 File Offset: 0x00006150
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038E")]
		public float NormalizedPourRate
		{
			[Token(Token = "0x60012AD")]
			[Address(RVA = "0x5386A0", Offset = "0x5370A0", VA = "0x1805386A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60012AE")]
			[Address(RVA = "0x59BF40", Offset = "0x59A940", VA = "0x18059BF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x59B4E0", Offset = "0x599EE0", VA = "0x18059B4E0", Slot = "14")]
		protected virtual void Start()
		{
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "10")]
		protected override void Update()
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x59AFD0", Offset = "0x5999D0", VA = "0x18059AFD0", Slot = "9")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x59B7C0", Offset = "0x59A1C0", VA = "0x18059B7C0", Slot = "15")]
		protected virtual void UpdatePouring()
		{
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x59B000", Offset = "0x599A00", VA = "0x18059B000")]
		private float GetShakeBoost()
		{
			return 0f;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x59B220", Offset = "0x599C20", VA = "0x18059B220", Slot = "16")]
		protected virtual void PourAmount(float amount)
		{
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x59B080", Offset = "0x599A80", VA = "0x18059B080")]
		protected bool IsPourPointOverPot()
		{
			return default(bool);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "17")]
		protected virtual bool CanPour()
		{
			return default(bool);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x59BE20", Offset = "0x59A820", VA = "0x18059BE20")]
		public Pourable()
		{
		}

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0xC0")]
		public Action onInitialPour;

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Pourable settings")]
		public bool Unlimited;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0xCC")]
		public float StartQuantity;

		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0xD0")]
		public float PourRate_L;

		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0xD4")]
		public float AngleFromUpToPour;

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("Multiplier for pour rate when pourable is shaken up and down")]
		public float ShakeBoostRate;

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0xDC")]
		public bool AffectsCoverage;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0xE0")]
		[Header("Particles")]
		public float ParticleMinMultiplier;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0xE4")]
		public float ParticleMaxMultiplier;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0xE8")]
		[Header("Pourable References")]
		public ParticleSystem[] PourParticles;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0xF0")]
		public Transform PourPoint;

		// Token: 0x040011DB RID: 4571
		[Token(Token = "0x40011DB")]
		[FieldOffset(Offset = "0xF8")]
		public AudioSourceController PourLoop;

		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x40011DC")]
		[FieldOffset(Offset = "0x100")]
		[Header("Trash")]
		public TrashItem TrashItem;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public Pot TargetPot;

		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x40011DF")]
		[FieldOffset(Offset = "0x114")]
		public float currentQuantity;

		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x40011E0")]
		[FieldOffset(Offset = "0x118")]
		protected bool hasPoured;

		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x119")]
		protected bool autoSetCurrentQuantity;

		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x120")]
		private float[] particleMinSizes;

		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x128")]
		private float[] particleMaxSizes;

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x130")]
		private AverageAcceleration accelerometer;
	}
}
