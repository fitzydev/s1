using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine.Audio;

namespace ScheduleOne.Audio
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	public class MusicPlayer : PersistentSingleton<MusicPlayer>
	{
		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x1700083A")]
		public bool IsPlaying
		{
			[Token(Token = "0x6003A38")]
			[Address(RVA = "0x81D820", Offset = "0x81C220", VA = "0x18081D820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A39")]
		[Address(RVA = "0x81CBC0", Offset = "0x81B5C0", VA = "0x18081CBC0")]
		public void OnValidate()
		{
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3A")]
		[Address(RVA = "0x81CEF0", Offset = "0x81B8F0", VA = "0x18081CEF0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0x81D6D0", Offset = "0x81C0D0", VA = "0x18081D6D0")]
		private void Update()
		{
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x81CD30", Offset = "0x81B730", VA = "0x18081CD30")]
		public void SetMusicDistorted(bool distorted, float transition = 5f)
		{
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x81CD60", Offset = "0x81B760", VA = "0x18081CD60")]
		public void SetTrackEnabled(string trackName, bool enabled)
		{
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3E")]
		[Address(RVA = "0x81D240", Offset = "0x81BC40", VA = "0x18081D240")]
		public void StopTrack(string trackName)
		{
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x81D130", Offset = "0x81BB30", VA = "0x18081D130")]
		public void StopAndDisableTracks()
		{
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x81D400", Offset = "0x81BE00", VA = "0x18081D400")]
		private void UpdateTracks()
		{
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A41")]
		[Address(RVA = "0x81D790", Offset = "0x81C190", VA = "0x18081D790")]
		public MusicPlayer()
		{
		}

		// Token: 0x0400289D RID: 10397
		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0x0")]
		public static float TimeSinceLastAmbientTrack;

		// Token: 0x0400289E RID: 10398
		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0x28")]
		public List<MusicTrack> Tracks;

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0x30")]
		public AudioMixerGroup MusicMixer;

		// Token: 0x040028A0 RID: 10400
		[Token(Token = "0x40028A0")]
		[FieldOffset(Offset = "0x38")]
		public AudioMixerSnapshot DefaultSnapshot;

		// Token: 0x040028A1 RID: 10401
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0x40")]
		public AudioMixerSnapshot DistortedSnapshot;

		// Token: 0x040028A2 RID: 10402
		[Token(Token = "0x40028A2")]
		[FieldOffset(Offset = "0x48")]
		private MusicTrack _currentTrack;
	}
}
