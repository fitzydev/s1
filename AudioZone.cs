using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000841 RID: 2113
	[Token(Token = "0x2000841")]
	public class AudioZone : Zone
	{
		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		// (set) Token: 0x060039FF RID: 14847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000835")]
		public float LocalPlayerDistance
		{
			[Token(Token = "0x60039FE")]
			[Address(RVA = "0x4AAA60", Offset = "0x4A9460", VA = "0x1804AAA60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039FF")]
			[Address(RVA = "0x7F4360", Offset = "0x7F2D60", VA = "0x1807F4360")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x0000F900 File Offset: 0x0000DB00
		// (set) Token: 0x06003A01 RID: 14849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000836")]
		public float VolumeModifier
		{
			[Token(Token = "0x6003A00")]
			[Address(RVA = "0x4DAF50", Offset = "0x4D9950", VA = "0x1804DAF50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A01")]
			[Address(RVA = "0x7F4FF0", Offset = "0x7F39F0", VA = "0x1807F4FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x7F4440", Offset = "0x7F2E40", VA = "0x1807F4440", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A03")]
		[Address(RVA = "0x7F4B10", Offset = "0x7F3510", VA = "0x1807F4B10")]
		private void Start()
		{
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A04")]
		[Address(RVA = "0x7F4790", Offset = "0x7F3190", VA = "0x1807F4790")]
		public void Recalculate()
		{
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A05")]
		[Address(RVA = "0x7F4D00", Offset = "0x7F3700", VA = "0x1807F4D00")]
		private void Update()
		{
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x7F44D0", Offset = "0x7F2ED0", VA = "0x1807F44D0")]
		private float GetTotalVolumeMultiplier()
		{
			return 0f;
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A07")]
		[Address(RVA = "0x7F4620", Offset = "0x7F3020", VA = "0x1807F4620")]
		private void MinPass()
		{
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x7F4380", Offset = "0x7F2D80", VA = "0x1807F4380")]
		public void AddModifier(AudioZoneModifierVolume modifier, float value)
		{
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A09")]
		[Address(RVA = "0x7F4A90", Offset = "0x7F3490", VA = "0x1807F4A90")]
		public void RemoveModifier(AudioZoneModifierVolume modifier)
		{
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x6003A0A")]
		[Address(RVA = "0x7F44A0", Offset = "0x7F2EA0", VA = "0x1807F44A0")]
		private float GetFalloffFactor(float distance)
		{
			return 0f;
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x7F4F20", Offset = "0x7F3920", VA = "0x1807F4F20")]
		public AudioZone()
		{
		}

		// Token: 0x04002854 RID: 10324
		[Token(Token = "0x4002854")]
		public const float VOLUME_CHANGE_RATE = 1f;

		// Token: 0x04002855 RID: 10325
		[Token(Token = "0x4002855")]
		public const float ROLLOFF_SCALE = 0.5f;

		// Token: 0x04002857 RID: 10327
		[Token(Token = "0x4002857")]
		[FieldOffset(Offset = "0x4C")]
		[Range(1f, 200f)]
		[Header("Settings")]
		public float MaxDistance;

		// Token: 0x04002858 RID: 10328
		[Token(Token = "0x4002858")]
		[FieldOffset(Offset = "0x50")]
		public List<AudioZone.Track> Tracks;

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<AudioZoneModifierVolume, float> Modifiers;

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		[FieldOffset(Offset = "0x64")]
		protected float CurrentVolumeMultiplier;

		// Token: 0x02000842 RID: 2114
		[Token(Token = "0x2000842")]
		[Serializable]
		public class Track
		{
			// Token: 0x06003A0C RID: 14860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A0C")]
			[Address(RVA = "0x820540", Offset = "0x81EF40", VA = "0x180820540")]
			public void Init()
			{
			}

			// Token: 0x06003A0D RID: 14861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A0D")]
			[Address(RVA = "0x8206E0", Offset = "0x81F0E0", VA = "0x1808206E0")]
			public void Update(float multiplier)
			{
			}

			// Token: 0x06003A0E RID: 14862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A0E")]
			[Address(RVA = "0x8205F0", Offset = "0x81EFF0", VA = "0x1808205F0")]
			public void UpdateTimeMultiplier(int time)
			{
			}

			// Token: 0x06003A0F RID: 14863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A0F")]
			[Address(RVA = "0x820780", Offset = "0x81F180", VA = "0x180820780")]
			public Track()
			{
			}

			// Token: 0x0400285C RID: 10332
			[Token(Token = "0x400285C")]
			[FieldOffset(Offset = "0x10")]
			public AudioSourceController Source;

			// Token: 0x0400285D RID: 10333
			[Token(Token = "0x400285D")]
			[FieldOffset(Offset = "0x18")]
			[Range(0.01f, 2f)]
			public float Volume;

			// Token: 0x0400285E RID: 10334
			[Token(Token = "0x400285E")]
			[FieldOffset(Offset = "0x1C")]
			public int StartTime;

			// Token: 0x0400285F RID: 10335
			[Token(Token = "0x400285F")]
			[FieldOffset(Offset = "0x20")]
			public int EndTime;

			// Token: 0x04002860 RID: 10336
			[Token(Token = "0x4002860")]
			[FieldOffset(Offset = "0x24")]
			public int FadeTime;

			// Token: 0x04002861 RID: 10337
			[Token(Token = "0x4002861")]
			[FieldOffset(Offset = "0x28")]
			private float timeVolMultiplier;

			// Token: 0x04002862 RID: 10338
			[Token(Token = "0x4002862")]
			[FieldOffset(Offset = "0x2C")]
			private int fadeInStart;

			// Token: 0x04002863 RID: 10339
			[Token(Token = "0x4002863")]
			[FieldOffset(Offset = "0x30")]
			private int fadeInEnd;

			// Token: 0x04002864 RID: 10340
			[Token(Token = "0x4002864")]
			[FieldOffset(Offset = "0x34")]
			private int fadeOutStart;

			// Token: 0x04002865 RID: 10341
			[Token(Token = "0x4002865")]
			[FieldOffset(Offset = "0x38")]
			private int fadeOutEnd;

			// Token: 0x04002866 RID: 10342
			[Token(Token = "0x4002866")]
			[FieldOffset(Offset = "0x3C")]
			private int fadeInStartMinSum;

			// Token: 0x04002867 RID: 10343
			[Token(Token = "0x4002867")]
			[FieldOffset(Offset = "0x40")]
			private int fadeInEndMinSum;

			// Token: 0x04002868 RID: 10344
			[Token(Token = "0x4002868")]
			[FieldOffset(Offset = "0x44")]
			private int fadeOutStartMinSum;

			// Token: 0x04002869 RID: 10345
			[Token(Token = "0x4002869")]
			[FieldOffset(Offset = "0x48")]
			private int fadeOutEndMinSum;
		}
	}
}
