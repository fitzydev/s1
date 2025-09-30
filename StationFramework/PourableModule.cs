using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000977 RID: 2423
	[Token(Token = "0x2000977")]
	public class PourableModule : ItemModule
	{
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06004269 RID: 17001 RVA: 0x00011700 File Offset: 0x0000F900
		// (set) Token: 0x0600426A RID: 17002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094B")]
		public bool IsPouring
		{
			[Token(Token = "0x6004269")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600426A")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x00011718 File Offset: 0x0000F918
		// (set) Token: 0x0600426C RID: 17004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094C")]
		public float NormalizedPourRate
		{
			[Token(Token = "0x600426B")]
			[Address(RVA = "0x4A37C0", Offset = "0x4A21C0", VA = "0x1804A37C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600426C")]
			[Address(RVA = "0x882010", Offset = "0x880A10", VA = "0x180882010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x00011730 File Offset: 0x0000F930
		// (set) Token: 0x0600426E RID: 17006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094D")]
		public float LiquidLevel
		{
			[Token(Token = "0x600426D")]
			[Address(RVA = "0x4F2920", Offset = "0x4F1320", VA = "0x1804F2920")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600426E")]
			[Address(RVA = "0x507410", Offset = "0x505E10", VA = "0x180507410")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x1700094E")]
		public float NormalizedLiquidLevel
		{
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x882000", Offset = "0x880A00", VA = "0x180882000")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004270")]
		[Address(RVA = "0x8814D0", Offset = "0x87FED0", VA = "0x1808814D0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004271")]
		[Address(RVA = "0x880E00", Offset = "0x87F800", VA = "0x180880E00", Slot = "4")]
		public override void ActivateModule(StationItem item)
		{
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004272")]
		[Address(RVA = "0x880FC0", Offset = "0x87F9C0", VA = "0x180880FC0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004273")]
		[Address(RVA = "0x8819A0", Offset = "0x8803A0", VA = "0x1808819A0", Slot = "7")]
		protected virtual void UpdatePouring()
		{
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004274")]
		[Address(RVA = "0x8818B0", Offset = "0x8802B0", VA = "0x1808818B0")]
		private void UpdatePourSound()
		{
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x880F00", Offset = "0x87F900", VA = "0x180880F00", Slot = "8")]
		public virtual void ChangeLiquidLevel(float change)
		{
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x881410", Offset = "0x87FE10", VA = "0x180881410", Slot = "9")]
		public virtual void SetLiquidLevel(float level)
		{
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004277")]
		[Address(RVA = "0x8811E0", Offset = "0x87FBE0", VA = "0x1808811E0", Slot = "10")]
		protected virtual void PourAmount(float amount)
		{
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x881120", Offset = "0x87FB20", VA = "0x180881120")]
		private void ParticleCollision(GameObject other)
		{
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "11")]
		protected virtual bool CanPour()
		{
			return default(bool);
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427A")]
		[Address(RVA = "0x881F60", Offset = "0x880960", VA = "0x180881F60")]
		public PourableModule()
		{
		}

		// Token: 0x04002E8D RID: 11917
		[Token(Token = "0x4002E8D")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public string LiquidType;

		// Token: 0x04002E8E RID: 11918
		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x48")]
		public float PourRate;

		// Token: 0x04002E8F RID: 11919
		[Token(Token = "0x4002E8F")]
		[FieldOffset(Offset = "0x4C")]
		public float AngleFromUpToPour;

		// Token: 0x04002E90 RID: 11920
		[Token(Token = "0x4002E90")]
		[FieldOffset(Offset = "0x50")]
		public bool OnlyEmptyOverFillable;

		// Token: 0x04002E91 RID: 11921
		[Token(Token = "0x4002E91")]
		[FieldOffset(Offset = "0x54")]
		public float LiquidCapacity_L;

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x58")]
		public Color LiquidColor;

		// Token: 0x04002E93 RID: 11923
		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0x68")]
		public float DefaultLiquid_L;

		// Token: 0x04002E94 RID: 11924
		[Token(Token = "0x4002E94")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public ParticleSystem[] PourParticles;

		// Token: 0x04002E95 RID: 11925
		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0x78")]
		public Transform PourPoint;

		// Token: 0x04002E96 RID: 11926
		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0x80")]
		public LiquidContainer LiquidContainer;

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0x88")]
		public Draggable Draggable;

		// Token: 0x04002E98 RID: 11928
		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0x90")]
		public DraggableConstraint DraggableConstraint;

		// Token: 0x04002E99 RID: 11929
		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0x98")]
		public AudioSourceController PourSound;

		// Token: 0x04002E9A RID: 11930
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Particles")]
		public Color PourParticlesColor;

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0xB0")]
		public float ParticleMinMultiplier;

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0xB4")]
		public float ParticleMaxMultiplier;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0xB8")]
		private float[] particleMinSizes;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0xC0")]
		private float[] particleMaxSizes;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0xC8")]
		private Fillable activeFillable;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0xD0")]
		private float timeSinceFillableHit;
	}
}
