using System;
using System.Collections.Generic;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200083C RID: 2108
	[Token(Token = "0x200083C")]
	public class AmbientTrack : MonoBehaviour
	{
		// Token: 0x060039C2 RID: 14786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x7F2040", Offset = "0x7F0A40", VA = "0x1807F2040")]
		private void Awake()
		{
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x7F23D0", Offset = "0x7F0DD0", VA = "0x1807F23D0")]
		[Button]
		public void ForcePlay()
		{
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x7F2570", Offset = "0x7F0F70", VA = "0x1807F2570")]
		public void Stop()
		{
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C5")]
		[Address(RVA = "0x7F2600", Offset = "0x7F1000", VA = "0x1807F2600")]
		private void Update()
		{
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x7F2160", Offset = "0x7F0B60", VA = "0x1807F2160", Slot = "4")]
		protected virtual bool CanStartAmbientTrack()
		{
			return default(bool);
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x7F2BD0", Offset = "0x7F15D0", VA = "0x1807F2BD0")]
		public AmbientTrack()
		{
		}

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		public const float MIN_TIME_BETWEEN_AMBIENT_TRACKS = 540f;

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[FieldOffset(Offset = "0x0")]
		public static AmbientTrack LastPlayedTrack;

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[FieldOffset(Offset = "0x8")]
		public static bool TrackQueued;

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[FieldOffset(Offset = "0x20")]
		public List<MusicTrack> Tracks;

		// Token: 0x04002823 RID: 10275
		[Token(Token = "0x4002823")]
		[FieldOffset(Offset = "0x28")]
		public int MinTime;

		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		[FieldOffset(Offset = "0x2C")]
		public int MaxTime;

		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		[FieldOffset(Offset = "0x30")]
		public float Chance;

		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		[FieldOffset(Offset = "0x34")]
		private int startTime;

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		[FieldOffset(Offset = "0x38")]
		private bool playTrack;

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x39")]
		private bool trackRandomized;
	}
}
