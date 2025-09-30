using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000856 RID: 2134
	[Token(Token = "0x2000856")]
	public class SFXManager : Singleton<SFXManager>
	{
		// Token: 0x06003A58 RID: 14936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A58")]
		[Address(RVA = "0x81F520", Offset = "0x81DF20", VA = "0x18081F520")]
		public void PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum)
		{
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x81F370", Offset = "0x81DD70", VA = "0x18081F370")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x81F470", Offset = "0x81DE70", VA = "0x18081F470")]
		private AudioSourceController GetSource()
		{
			return null;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x81FAF0", Offset = "0x81E4F0", VA = "0x18081FAF0")]
		public SFXManager()
		{
		}

		// Token: 0x040028B0 RID: 10416
		[Token(Token = "0x40028B0")]
		public const float MAX_PLAYER_DISTANCE = 40f;

		// Token: 0x040028B1 RID: 10417
		[Token(Token = "0x40028B1")]
		public const float SQR_MAX_PLAYER_DISTANCE = 1600f;

		// Token: 0x040028B2 RID: 10418
		[Token(Token = "0x40028B2")]
		[FieldOffset(Offset = "0x28")]
		public List<SFXManager.ImpactType> ImpactTypes;

		// Token: 0x040028B3 RID: 10419
		[Token(Token = "0x40028B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<AudioSourceController> soundPool;

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x38")]
		private List<AudioSourceController> soundsInUse;

		// Token: 0x02000857 RID: 2135
		[Token(Token = "0x2000857")]
		[Serializable]
		public class ImpactType
		{
			// Token: 0x06003A5C RID: 14940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A5C")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ImpactType()
			{
			}

			// Token: 0x040028B5 RID: 10421
			[Token(Token = "0x40028B5")]
			[FieldOffset(Offset = "0x10")]
			public ImpactSoundEntity.EMaterial Material;

			// Token: 0x040028B6 RID: 10422
			[Token(Token = "0x40028B6")]
			[FieldOffset(Offset = "0x14")]
			public float MinVolume;

			// Token: 0x040028B7 RID: 10423
			[Token(Token = "0x40028B7")]
			[FieldOffset(Offset = "0x18")]
			public float MaxVolume;

			// Token: 0x040028B8 RID: 10424
			[Token(Token = "0x40028B8")]
			[FieldOffset(Offset = "0x1C")]
			public float MinPitch;

			// Token: 0x040028B9 RID: 10425
			[Token(Token = "0x40028B9")]
			[FieldOffset(Offset = "0x20")]
			public float MaxPitch;

			// Token: 0x040028BA RID: 10426
			[Token(Token = "0x40028BA")]
			[FieldOffset(Offset = "0x28")]
			public AudioClip[] Clips;
		}
	}
}
