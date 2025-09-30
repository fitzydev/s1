using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200083E RID: 2110
	[Token(Token = "0x200083E")]
	[RequireComponent(typeof(AudioSource))]
	public class AudioSourceController : MonoBehaviour
	{
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060039E3 RID: 14819 RVA: 0x0000F870 File Offset: 0x0000DA70
		// (set) Token: 0x060039E4 RID: 14820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082F")]
		public float Volume
		{
			[Token(Token = "0x60039E3")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039E4")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060039E5 RID: 14821 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x17000830")]
		public bool isPlaying
		{
			[Token(Token = "0x60039E5")]
			[Address(RVA = "0x7F4340", Offset = "0x7F2D40", VA = "0x1807F4340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000831")]
		public float volumeMultiplier
		{
			[Token(Token = "0x60039E6")]
			[Address(RVA = "0x4A4C60", Offset = "0x4A3660", VA = "0x1804A4C60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039E7")]
			[Address(RVA = "0x7F4370", Offset = "0x7F2D70", VA = "0x1807F4370")]
			set
			{
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060039E8 RID: 14824 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		// (set) Token: 0x060039E9 RID: 14825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000832")]
		public float pitchMultiplier
		{
			[Token(Token = "0x60039E8")]
			[Address(RVA = "0x4AAA60", Offset = "0x4A9460", VA = "0x1804AAA60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039E9")]
			[Address(RVA = "0x7F4360", Offset = "0x7F2D60", VA = "0x1807F4360")]
			set
			{
			}
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EA")]
		[Address(RVA = "0x7F39C0", Offset = "0x7F23C0", VA = "0x1807F39C0")]
		private void Awake()
		{
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039EB")]
		[Address(RVA = "0x7F4240", Offset = "0x7F2C40", VA = "0x1807F4240")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EC")]
		[Address(RVA = "0x7F3A10", Offset = "0x7F2410", VA = "0x1807F3A10")]
		private void DoPauseStuff()
		{
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039ED")]
		[Address(RVA = "0x7F3CC0", Offset = "0x7F26C0", VA = "0x1807F3CC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EE")]
		[Address(RVA = "0x7F3E20", Offset = "0x7F2820", VA = "0x1807F3E20")]
		private void OnValidate()
		{
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EF")]
		[Address(RVA = "0x7F3EB0", Offset = "0x7F28B0", VA = "0x1807F3EB0")]
		private void Pause()
		{
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F0")]
		[Address(RVA = "0x7F42D0", Offset = "0x7F2CD0", VA = "0x1807F42D0")]
		private void Unpause()
		{
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F1")]
		[Address(RVA = "0x7F4230", Offset = "0x7F2C30", VA = "0x1807F4230")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F2")]
		[Address(RVA = "0x7F3630", Offset = "0x7F2030", VA = "0x1807F3630")]
		public void ApplyVolume()
		{
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x7F35B0", Offset = "0x7F1FB0", VA = "0x1807F35B0")]
		public void ApplyPitch()
		{
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F4")]
		[Address(RVA = "0x7F4190", Offset = "0x7F2B90", VA = "0x1807F4190", Slot = "4")]
		public virtual void Play()
		{
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F5")]
		[Address(RVA = "0x7F3ED0", Offset = "0x7F28D0", VA = "0x1807F3ED0", Slot = "5")]
		public virtual void PlayOneShot(bool duplicateAudioSource = false)
		{
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F6")]
		[Address(RVA = "0x7F42B0", Offset = "0x7F2CB0", VA = "0x1807F42B0")]
		public void Stop()
		{
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F7")]
		[Address(RVA = "0x7F4300", Offset = "0x7F2D00", VA = "0x1807F4300")]
		public AudioSourceController()
		{
		}

		// Token: 0x0400283F RID: 10303
		[Token(Token = "0x400283F")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04002841 RID: 10305
		[Token(Token = "0x4002841")]
		[FieldOffset(Offset = "0x28")]
		public AudioSource AudioSource;

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public EAudioType AudioType;

		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float DefaultVolume;

		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x38")]
		public bool RandomizePitch;

		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x3C")]
		public float MinPitch;

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x40")]
		public float MaxPitch;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0f, 2f)]
		private float VolumeMultiplier;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Range(0f, 2f)]
		private float PitchMultiplier;

		// Token: 0x04002849 RID: 10313
		[Token(Token = "0x4002849")]
		[FieldOffset(Offset = "0x4C")]
		private float basePitch;
	}
}
