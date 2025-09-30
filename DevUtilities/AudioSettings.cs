using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	[Serializable]
	public class AudioSettings
	{
		// Token: 0x0600338C RID: 13196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338C")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public AudioSettings()
		{
		}

		// Token: 0x040023C2 RID: 9154
		[Token(Token = "0x40023C2")]
		[FieldOffset(Offset = "0x10")]
		public float MasterVolume;

		// Token: 0x040023C3 RID: 9155
		[Token(Token = "0x40023C3")]
		[FieldOffset(Offset = "0x14")]
		public float AmbientVolume;

		// Token: 0x040023C4 RID: 9156
		[Token(Token = "0x40023C4")]
		[FieldOffset(Offset = "0x18")]
		public float MusicVolume;

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0x1C")]
		public float SFXVolume;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0x20")]
		public float UIVolume;

		// Token: 0x040023C7 RID: 9159
		[Token(Token = "0x40023C7")]
		[FieldOffset(Offset = "0x24")]
		public float DialogueVolume;

		// Token: 0x040023C8 RID: 9160
		[Token(Token = "0x40023C8")]
		[FieldOffset(Offset = "0x28")]
		public float FootstepsVolume;
	}
}
