using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace ScheduleOne.Audio
{
	// Token: 0x0200083D RID: 2109
	[Token(Token = "0x200083D")]
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x17000821")]
		public float MasterVolume
		{
			[Token(Token = "0x60039C8")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x17000822")]
		public float AmbientVolume
		{
			[Token(Token = "0x60039C9")]
			[Address(RVA = "0x7F3520", Offset = "0x7F1F20", VA = "0x1807F3520")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x17000823")]
		public float UnscaledAmbientVolume
		{
			[Token(Token = "0x60039CA")]
			[Address(RVA = "0x4A3730", Offset = "0x4A2130", VA = "0x1804A3730")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060039CB RID: 14795 RVA: 0x0000F738 File Offset: 0x0000D938
		[Token(Token = "0x17000824")]
		public float FootstepsVolume
		{
			[Token(Token = "0x60039CB")]
			[Address(RVA = "0x7F3540", Offset = "0x7F1F40", VA = "0x1807F3540")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x0000F750 File Offset: 0x0000D950
		[Token(Token = "0x17000825")]
		public float UnscaledFootstepsVolume
		{
			[Token(Token = "0x60039CC")]
			[Address(RVA = "0x4A37D0", Offset = "0x4A21D0", VA = "0x1804A37D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060039CD RID: 14797 RVA: 0x0000F768 File Offset: 0x0000D968
		[Token(Token = "0x17000826")]
		public float FXVolume
		{
			[Token(Token = "0x60039CD")]
			[Address(RVA = "0x7F3530", Offset = "0x7F1F30", VA = "0x1807F3530")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x0000F780 File Offset: 0x0000D980
		[Token(Token = "0x17000827")]
		public float UnscaledFXVolume
		{
			[Token(Token = "0x60039CE")]
			[Address(RVA = "0x4A37C0", Offset = "0x4A21C0", VA = "0x1804A37C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x0000F798 File Offset: 0x0000D998
		[Token(Token = "0x17000828")]
		public float UIVolume
		{
			[Token(Token = "0x60039CF")]
			[Address(RVA = "0x7F3570", Offset = "0x7F1F70", VA = "0x1807F3570")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[Token(Token = "0x17000829")]
		public float UnscaledUIVolume
		{
			[Token(Token = "0x60039D0")]
			[Address(RVA = "0x4F2920", Offset = "0x4F1320", VA = "0x1804F2920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		[Token(Token = "0x1700082A")]
		public float MusicVolume
		{
			[Token(Token = "0x60039D1")]
			[Address(RVA = "0x7F3550", Offset = "0x7F1F50", VA = "0x1807F3550")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[Token(Token = "0x1700082B")]
		public float UnscaledMusicVolume
		{
			[Token(Token = "0x60039D2")]
			[Address(RVA = "0x507400", Offset = "0x505E00", VA = "0x180507400")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x1700082C")]
		public float VoiceVolume
		{
			[Token(Token = "0x60039D3")]
			[Address(RVA = "0x7F3580", Offset = "0x7F1F80", VA = "0x1807F3580")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x1700082D")]
		public float UnscaledVoiceVolume
		{
			[Token(Token = "0x60039D4")]
			[Address(RVA = "0x4A4C50", Offset = "0x4A3650", VA = "0x1804A4C50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x0000F828 File Offset: 0x0000DA28
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082E")]
		public float WorldMusicVolumeMultiplier
		{
			[Token(Token = "0x60039D5")]
			[Address(RVA = "0x7BAA30", Offset = "0x7B9430", VA = "0x1807BAA30")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039D6")]
			[Address(RVA = "0x7F35A0", Offset = "0x7F1FA0", VA = "0x1807F35A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x7F2D90", Offset = "0x7F1790", VA = "0x1807F2D90")]
		public float GetScaledMusicVolumeMultiplier(float min)
		{
			return 0f;
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x7F2C50", Offset = "0x7F1650", VA = "0x1807F2C50", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x7F3010", Offset = "0x7F1A10", VA = "0x1807F3010", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x7F3230", Offset = "0x7F1C30", VA = "0x1807F3230")]
		protected void Update()
		{
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x7F2EF0", Offset = "0x7F18F0", VA = "0x1807F2EF0")]
		public void SetGameVolumeMultipler(float value)
		{
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DC")]
		[Address(RVA = "0x7F2EB0", Offset = "0x7F18B0", VA = "0x1807F2EB0")]
		public void SetDistorted(bool distorted, float transition = 5f)
		{
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DD")]
		[Address(RVA = "0x7F2F10", Offset = "0x7F1910", VA = "0x1807F2F10")]
		private void SetGameVolume(float value)
		{
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x7F2DD0", Offset = "0x7F17D0", VA = "0x1807F2DD0")]
		public float GetVolume(EAudioType audioType, bool scaled = true)
		{
			return 0f;
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
		public void SetMasterVolume(float volume)
		{
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x7F2FB0", Offset = "0x7F19B0", VA = "0x1807F2FB0")]
		public void SetVolume(EAudioType type, float volume)
		{
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x7F3460", Offset = "0x7F1E60", VA = "0x1807F3460")]
		public AudioManager()
		{
		}

		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		public const float MIN_WORLD_MUSIC_VOLUME_MULTIPLIER = 0f;

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		public const float MUSIC_FADE_TIME = 4f;

		// Token: 0x0400282B RID: 10283
		[Token(Token = "0x400282B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 2f)]
		protected float masterVolume;

		// Token: 0x0400282C RID: 10284
		[Token(Token = "0x400282C")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 2f)]
		[SerializeField]
		protected float ambientVolume;

		// Token: 0x0400282D RID: 10285
		[Token(Token = "0x400282D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 2f)]
		protected float footstepsVolume;

		// Token: 0x0400282E RID: 10286
		[Token(Token = "0x400282E")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 2f)]
		[SerializeField]
		protected float fxVolume;

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 2f)]
		[SerializeField]
		protected float uiVolume;

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 2f)]
		[SerializeField]
		protected float musicVolume;

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 2f)]
		protected float voiceVolume;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onSettingsChanged;

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x50")]
		[Header("Generic Door Sounds")]
		public AudioSourceController DoorOpen;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController DoorClose;

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x60")]
		[Header("Mixers")]
		public AudioMixerGroup MainGameMixer;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x68")]
		public AudioMixerGroup MenuMixer;

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0x70")]
		public AudioMixerGroup MusicMixer;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0x78")]
		private float currentGameVolume;

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		private const float minGameVolume = 0.0001f;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		private const float maxGameVolume = 0.0001f;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		[FieldOffset(Offset = "0x7C")]
		private float gameVolumeMultiplier;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x88")]
		public AudioMixerSnapshot DefaultSnapshot;

		// Token: 0x0400283E RID: 10302
		[Token(Token = "0x400283E")]
		[FieldOffset(Offset = "0x90")]
		public AudioMixerSnapshot DistortedSnapshot;
	}
}
