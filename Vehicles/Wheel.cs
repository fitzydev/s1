using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200087D RID: 2173
	[Token(Token = "0x200087D")]
	public class Wheel : MonoBehaviour
	{
		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x000100C8 File Offset: 0x0000E2C8
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087E")]
		public bool isStatic
		{
			[Token(Token = "0x6003BED")]
			[Address(RVA = "0x506B90", Offset = "0x505590", VA = "0x180506B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0x507050", Offset = "0x505A50", VA = "0x180507050")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x000100E0 File Offset: 0x0000E2E0
		// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087F")]
		public bool IsDrifting
		{
			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0x83E780", Offset = "0x83D180", VA = "0x18083E780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BF0")]
			[Address(RVA = "0x83E7A0", Offset = "0x83D1A0", VA = "0x18083E7A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x17000880")]
		public bool IsDrifting_Smoothed
		{
			[Token(Token = "0x6003BF1")]
			[Address(RVA = "0x83E770", Offset = "0x83D170", VA = "0x18083E770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x00010110 File Offset: 0x0000E310
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000881")]
		public float DriftTime
		{
			[Token(Token = "0x6003BF2")]
			[Address(RVA = "0x83E760", Offset = "0x83D160", VA = "0x18083E760")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003BF3")]
			[Address(RVA = "0x83E790", Offset = "0x83D190", VA = "0x18083E790")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x00010128 File Offset: 0x0000E328
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000882")]
		public float DriftIntensity
		{
			[Token(Token = "0x6003BF4")]
			[Address(RVA = "0x7BAA30", Offset = "0x7B9430", VA = "0x1807BAA30")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003BF5")]
			[Address(RVA = "0x7F35A0", Offset = "0x7F1FA0", VA = "0x1807F35A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BF6")]
		[Address(RVA = "0x83E440", Offset = "0x83CE40", VA = "0x18083E440", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0x83DA60", Offset = "0x83C460", VA = "0x18083DA60")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BF8")]
		[Address(RVA = "0x83D760", Offset = "0x83C160", VA = "0x18083D760")]
		private void CheckDrifting()
		{
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x83E660", Offset = "0x83D060", VA = "0x18083E660")]
		private void UpdateDriftEffects()
		{
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFA")]
		[Address(RVA = "0x83E570", Offset = "0x83CF70", VA = "0x18083E570")]
		private void UpdateDriftAudio()
		{
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFB")]
		[Address(RVA = "0x83D600", Offset = "0x83C000", VA = "0x18083D600")]
		private void ApplyFriction()
		{
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFC")]
		[Address(RVA = "0x83E270", Offset = "0x83CC70", VA = "0x18083E270", Slot = "5")]
		public virtual void SetIsStatic(bool s)
		{
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFD")]
		[Address(RVA = "0x83E1B0", Offset = "0x83CBB0", VA = "0x18083E1B0")]
		private void GroundWheelModel()
		{
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x6003BFE")]
		[Address(RVA = "0x83E220", Offset = "0x83CC20", VA = "0x18083E220")]
		public bool IsWheelGrounded()
		{
			return default(bool);
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x83E6E0", Offset = "0x83D0E0", VA = "0x18083E6E0")]
		public Wheel()
		{
		}

		// Token: 0x040029C7 RID: 10695
		[Token(Token = "0x40029C7")]
		public const float SIDEWAY_SLIP_THRESHOLD = 0.2f;

		// Token: 0x040029C8 RID: 10696
		[Token(Token = "0x40029C8")]
		public const float FORWARD_SLIP_THRESHOLD = 0.8f;

		// Token: 0x040029C9 RID: 10697
		[Token(Token = "0x40029C9")]
		public const float DRIFT_AUDIO_THRESHOLD = 0.2f;

		// Token: 0x040029CA RID: 10698
		[Token(Token = "0x40029CA")]
		public const float MIN_SPEED_FOR_DRIFT = 8f;

		// Token: 0x040029CB RID: 10699
		[Token(Token = "0x40029CB")]
		public const float WHEEL_ANIMATION_DISTANCE = 40f;

		// Token: 0x040029CC RID: 10700
		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG_MODE;

		// Token: 0x040029CD RID: 10701
		[Token(Token = "0x40029CD")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform wheelModel;

		// Token: 0x040029CE RID: 10702
		[Token(Token = "0x40029CE")]
		[FieldOffset(Offset = "0x30")]
		public Transform modelContainer;

		// Token: 0x040029CF RID: 10703
		[Token(Token = "0x40029CF")]
		[FieldOffset(Offset = "0x38")]
		public WheelCollider wheelCollider;

		// Token: 0x040029D0 RID: 10704
		[Token(Token = "0x40029D0")]
		[FieldOffset(Offset = "0x40")]
		public Transform axleConnectionPoint;

		// Token: 0x040029D1 RID: 10705
		[Token(Token = "0x40029D1")]
		[FieldOffset(Offset = "0x48")]
		public Collider staticCollider;

		// Token: 0x040029D2 RID: 10706
		[Token(Token = "0x40029D2")]
		[FieldOffset(Offset = "0x50")]
		public ParticleSystem DriftParticles;

		// Token: 0x040029D3 RID: 10707
		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public bool DriftParticlesEnabled;

		// Token: 0x040029D4 RID: 10708
		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x5C")]
		public float ForwardStiffnessMultiplier_Handbrake;

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		[FieldOffset(Offset = "0x60")]
		public float SidewayStiffnessMultiplier_Handbrake;

		// Token: 0x040029D6 RID: 10710
		[Token(Token = "0x40029D6")]
		[FieldOffset(Offset = "0x64")]
		[Header("Drift Audio")]
		public bool DriftAudioEnabled;

		// Token: 0x040029D7 RID: 10711
		[Token(Token = "0x40029D7")]
		[FieldOffset(Offset = "0x68")]
		public AudioSourceController DriftAudioSource;

		// Token: 0x040029D8 RID: 10712
		[Token(Token = "0x40029D8")]
		[FieldOffset(Offset = "0x70")]
		private float defaultForwardStiffness;

		// Token: 0x040029D9 RID: 10713
		[Token(Token = "0x40029D9")]
		[FieldOffset(Offset = "0x74")]
		private float defaultSidewaysStiffness;

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x88")]
		private LandVehicle vehicle;

		// Token: 0x040029DF RID: 10719
		[Token(Token = "0x40029DF")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastFixedUpdatePosition;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0xA0")]
		private WheelHit wheelData;

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		[FieldOffset(Offset = "0xE8")]
		private WheelFrictionCurve forwardCurve;

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0xFC")]
		private WheelFrictionCurve sidewaysCurve;

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x110")]
		private Transform wheelTransform;
	}
}
