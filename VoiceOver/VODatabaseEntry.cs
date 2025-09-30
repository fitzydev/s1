using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000296")]
	[Serializable]
	public class VODatabaseEntry
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0xAB7710", Offset = "0xAB6110", VA = "0x180AB7710")]
		public AudioClip GetRandomClip()
		{
			return null;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0xAB7820", Offset = "0xAB6220", VA = "0x180AB7820")]
		public VODatabaseEntry()
		{
		}

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x10")]
		public EVOLineType LineType;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] Clips;

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x20")]
		private AudioClip lastClip;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		[FieldOffset(Offset = "0x28")]
		public float VolumeMultiplier;
	}
}
