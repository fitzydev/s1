using System;
using Il2CppDummyDll;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	public class HeartbeatSoundController : MonoBehaviour
	{
		// Token: 0x06003A31 RID: 14897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A31")]
		[Address(RVA = "0x80FAB0", Offset = "0x80E4B0", VA = "0x18080FAB0")]
		private void Awake()
		{
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A32")]
		[Address(RVA = "0x80FB20", Offset = "0x80E520", VA = "0x18080FB20")]
		private void Update()
		{
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A33")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public HeartbeatSoundController()
		{
		}

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController sound;

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		[FieldOffset(Offset = "0x28")]
		public FloatSmoother VolumeController;

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		[FieldOffset(Offset = "0x30")]
		public FloatSmoother PitchController;
	}
}
