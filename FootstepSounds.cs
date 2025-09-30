using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Materials;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	public class FootstepSounds : MonoBehaviour
	{
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x0000F948 File Offset: 0x0000DB48
		// (set) Token: 0x06003A1C RID: 14876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000837")]
		public float VolumeMultiplier
		{
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A1C")]
			[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x80D3F0", Offset = "0x80BDF0", VA = "0x18080D3F0")]
		private void Start()
		{
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1E")]
		[Address(RVA = "0x80DED0", Offset = "0x80C8D0", VA = "0x18080DED0")]
		private void Update()
		{
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x80DB00", Offset = "0x80C500", VA = "0x18080DB00")]
		public void Step(EMaterialType materialType, float hardness)
		{
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x80D2D0", Offset = "0x80BCD0", VA = "0x18080D2D0")]
		public AudioSourceController GetFreeSource()
		{
			return null;
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A21")]
		[Address(RVA = "0x80DF00", Offset = "0x80C900", VA = "0x18080DF00")]
		public FootstepSounds()
		{
		}

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		public const float COOLDOWN_TIME = 0.15f;

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x28")]
		public List<AudioSourceController> sources;

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x30")]
		public List<FootstepSounds.FootstepSoundGroup> soundGroups;

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup> materialFootstepSounds;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x40")]
		private float lastStepTime;

		// Token: 0x02000847 RID: 2119
		[Token(Token = "0x2000847")]
		[Serializable]
		public class FootstepSoundGroup
		{
			// Token: 0x06003A22 RID: 14882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A22")]
			[Address(RVA = "0x80D1F0", Offset = "0x80BBF0", VA = "0x18080D1F0")]
			public FootstepSoundGroup()
			{
			}

			// Token: 0x0400287C RID: 10364
			[Token(Token = "0x400287C")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0400287D RID: 10365
			[Token(Token = "0x400287D")]
			[FieldOffset(Offset = "0x18")]
			public List<AudioClip> clips;

			// Token: 0x0400287E RID: 10366
			[Token(Token = "0x400287E")]
			[FieldOffset(Offset = "0x20")]
			public List<FootstepSounds.FootstepSoundGroup.MaterialType> appliesTo;

			// Token: 0x0400287F RID: 10367
			[Token(Token = "0x400287F")]
			[FieldOffset(Offset = "0x28")]
			public float PitchMin;

			// Token: 0x04002880 RID: 10368
			[Token(Token = "0x4002880")]
			[FieldOffset(Offset = "0x2C")]
			public float PitchMax;

			// Token: 0x04002881 RID: 10369
			[Token(Token = "0x4002881")]
			[FieldOffset(Offset = "0x30")]
			public float Volume;

			// Token: 0x02000848 RID: 2120
			[Token(Token = "0x2000848")]
			[Serializable]
			public class MaterialType
			{
				// Token: 0x06003A23 RID: 14883 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003A23")]
				[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
				public MaterialType()
				{
				}

				// Token: 0x04002882 RID: 10370
				[Token(Token = "0x4002882")]
				[FieldOffset(Offset = "0x10")]
				public EMaterialType type;
			}
		}
	}
}
