using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A68 RID: 2664
	[Token(Token = "0x2000A68")]
	public class SpottedTremolo : MonoBehaviour
	{
		// Token: 0x06004896 RID: 18582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004896")]
		[Address(RVA = "0x90DCB0", Offset = "0x90C6B0", VA = "0x18090DCB0")]
		public void Update()
		{
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004897")]
		[Address(RVA = "0x90DF50", Offset = "0x90C950", VA = "0x18090DF50")]
		public SpottedTremolo()
		{
		}

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float Intensity;

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[FieldOffset(Offset = "0x28")]
		public AudioSourceController Loop;

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[FieldOffset(Offset = "0x30")]
		public EntityVisibility PlayerVisibility;

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public float MinVolume;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x3C")]
		public float MaxVolume;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[FieldOffset(Offset = "0x40")]
		public float MinPitch;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[FieldOffset(Offset = "0x44")]
		public float MaxPitch;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[FieldOffset(Offset = "0x48")]
		public float SmoothTime;

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float smoothedIntensity;
	}
}
