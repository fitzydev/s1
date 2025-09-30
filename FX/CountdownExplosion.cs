using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x02000591 RID: 1425
	[Token(Token = "0x2000591")]
	public class CountdownExplosion : MonoBehaviour
	{
		// Token: 0x06002064 RID: 8292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x66F280", Offset = "0x66DC80", VA = "0x18066F280")]
		public void Trigger()
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x433290", Offset = "0x431C90", VA = "0x180433290")]
		public void StopCountdown()
		{
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CountdownExplosion()
		{
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x66F380", Offset = "0x66DD80", VA = "0x18066F380")]
		[CompilerGenerated]
		private IEnumerator <Trigger>g__Routine|5_0()
		{
			return null;
		}

		// Token: 0x04001A66 RID: 6758
		[Token(Token = "0x4001A66")]
		public const float COUNTDOWN = 30f;

		// Token: 0x04001A67 RID: 6759
		[Token(Token = "0x4001A67")]
		public const float TICK_SPACING_MAX = 1f;

		// Token: 0x04001A68 RID: 6760
		[Token(Token = "0x4001A68")]
		public const float TICK_SPACING_MIN = 0.1f;

		// Token: 0x04001A69 RID: 6761
		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController TickSound;

		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine countdownRoutine;
	}
}
