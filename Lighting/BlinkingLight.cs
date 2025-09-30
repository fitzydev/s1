using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	[RequireComponent(typeof(ToggleableLight))]
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x630E60", Offset = "0x62F860", VA = "0x180630E60")]
		private void Awake()
		{
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x630F20", Offset = "0x62F920", VA = "0x180630F20")]
		private void Update()
		{
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x630EB0", Offset = "0x62F8B0", VA = "0x180630EB0")]
		private IEnumerator Blink()
		{
			return null;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x630FB0", Offset = "0x62F9B0", VA = "0x180630FB0")]
		public BlinkingLight()
		{
		}

		// Token: 0x040016BB RID: 5819
		[Token(Token = "0x40016BB")]
		[FieldOffset(Offset = "0x20")]
		public bool IsOn;

		// Token: 0x040016BC RID: 5820
		[Token(Token = "0x40016BC")]
		[FieldOffset(Offset = "0x24")]
		public float OnTime;

		// Token: 0x040016BD RID: 5821
		[Token(Token = "0x40016BD")]
		[FieldOffset(Offset = "0x28")]
		public float OffTime;

		// Token: 0x040016BE RID: 5822
		[Token(Token = "0x40016BE")]
		[FieldOffset(Offset = "0x30")]
		private ToggleableLight light;

		// Token: 0x040016BF RID: 5823
		[Token(Token = "0x40016BF")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine blinkRoutine;
	}
}
