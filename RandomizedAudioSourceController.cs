using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000855 RID: 2133
	[Token(Token = "0x2000855")]
	public class RandomizedAudioSourceController : AudioSourceController
	{
		// Token: 0x06003A55 RID: 14933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A55")]
		[Address(RVA = "0x81F2A0", Offset = "0x81DCA0", VA = "0x18081F2A0", Slot = "4")]
		public override void Play()
		{
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A56")]
		[Address(RVA = "0x81F1C0", Offset = "0x81DBC0", VA = "0x18081F1C0", Slot = "5")]
		public override void PlayOneShot(bool duplicateAudioSource = false)
		{
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A57")]
		[Address(RVA = "0x81F360", Offset = "0x81DD60", VA = "0x18081F360")]
		public RandomizedAudioSourceController()
		{
		}

		// Token: 0x040028AF RID: 10415
		[Token(Token = "0x40028AF")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip[] Clips;
	}
}
