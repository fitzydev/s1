using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x2000594")]
	public class FXManager : Singleton<FXManager>
	{
		// Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002074")]
		[Address(RVA = "0x6719D0", Offset = "0x6703D0", VA = "0x1806719D0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002075")]
		[Address(RVA = "0x671070", Offset = "0x66FA70", VA = "0x180671070")]
		public void CreateImpactFX(Impact impact, IDamageable target)
		{
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x670CB0", Offset = "0x66F6B0", VA = "0x180670CB0")]
		public void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)
		{
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002077")]
		[Address(RVA = "0x6716E0", Offset = "0x6700E0", VA = "0x1806716E0")]
		private void PlayImpact(AudioClip clip, Vector3 position, float volume)
		{
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002078")]
		[Address(RVA = "0x671920", Offset = "0x670320", VA = "0x180671920")]
		private void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002079")]
		[Address(RVA = "0x671460", Offset = "0x66FE60", VA = "0x180671460")]
		private AudioClip GetImpactSound(Impact impact, IDamageable target)
		{
			return null;
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207A")]
		[Address(RVA = "0x6713B0", Offset = "0x66FDB0", VA = "0x1806713B0")]
		private GameObject GetImpactParticles(Impact impact, IDamageable target)
		{
			return null;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x6715C0", Offset = "0x66FFC0", VA = "0x1806715C0")]
		private AudioSourceController GetSource()
		{
			return null;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x671580", Offset = "0x66FF80", VA = "0x180671580")]
		private static AudioClip GetRandomClip(AudioClip[] clips)
		{
			return null;
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x671A10", Offset = "0x670410", VA = "0x180671A10")]
		public FXManager()
		{
		}

		// Token: 0x04001A8C RID: 6796
		[Token(Token = "0x4001A8C")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip[] PunchImpactsClips;

		// Token: 0x04001A8D RID: 6797
		[Token(Token = "0x4001A8D")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip[] SlashImpactClips;

		// Token: 0x04001A8E RID: 6798
		[Token(Token = "0x4001A8E")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public AudioSourceController[] ImpactSources;

		// Token: 0x04001A8F RID: 6799
		[Token(Token = "0x4001A8F")]
		[FieldOffset(Offset = "0x40")]
		[Header("Particle Prefabs")]
		public GameObject PunchParticlePrefab;

		// Token: 0x04001A90 RID: 6800
		[Token(Token = "0x4001A90")]
		[FieldOffset(Offset = "0x48")]
		[Header("Trails")]
		public TrailRenderer BulletTrail;
	}
}
