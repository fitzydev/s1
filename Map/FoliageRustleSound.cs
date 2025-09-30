using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CF3 RID: 3315
	[Token(Token = "0x2000CF3")]
	public class FoliageRustleSound : MonoBehaviour
	{
		// Token: 0x06005DCE RID: 24014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCE")]
		[Address(RVA = "0xA5B990", Offset = "0xA5A390", VA = "0x180A5B990")]
		private void Awake()
		{
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCF")]
		[Address(RVA = "0xA5BA10", Offset = "0xA5A410", VA = "0x180A5BA10")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD0")]
		[Address(RVA = "0xA5BCA0", Offset = "0xA5A6A0", VA = "0x180A5BCA0")]
		private void UpdateActive()
		{
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD1")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public FoliageRustleSound()
		{
		}

		// Token: 0x0400442A RID: 17450
		[Token(Token = "0x400442A")]
		public const float ACTIVATION_RANGE_SQUARED = 900f;

		// Token: 0x0400442B RID: 17451
		[Token(Token = "0x400442B")]
		public const float COOLDOWN = 1f;

		// Token: 0x0400442C RID: 17452
		[Token(Token = "0x400442C")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController Sound;

		// Token: 0x0400442D RID: 17453
		[Token(Token = "0x400442D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Container;

		// Token: 0x0400442E RID: 17454
		[Token(Token = "0x400442E")]
		[FieldOffset(Offset = "0x30")]
		private float timeOnLastHit;
	}
}
