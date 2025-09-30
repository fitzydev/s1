using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	public class PoliceChatterVO : VOEmitter
	{
		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0xAAD1E0", Offset = "0xAABBE0", VA = "0x180AAD1E0", Slot = "5")]
		public override void Play(EVOLineType lineType)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0xAAD140", Offset = "0xAABB40", VA = "0x180AAD140")]
		private void PlayChatter()
		{
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0xAAD340", Offset = "0xAABD40", VA = "0x180AAD340")]
		public PoliceChatterVO()
		{
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0xAAD2C0", Offset = "0xAABCC0", VA = "0x180AAD2C0")]
		[CompilerGenerated]
		private IEnumerator <PlayChatter>g__Play|5_0()
		{
			return null;
		}

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController StartBeep;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController StartEndBeep;

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController Static;

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine chatterRoutine;
	}
}
