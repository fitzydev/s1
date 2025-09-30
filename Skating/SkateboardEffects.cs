using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002DE RID: 734
	[Token(Token = "0x20002DE")]
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardEffects : MonoBehaviour
	{
		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0xAE7C30", Offset = "0xAE6630", VA = "0x180AE7C30")]
		private void Awake()
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0xAE7CC0", Offset = "0xAE66C0", VA = "0x180AE7CC0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SkateboardEffects()
		{
		}

		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		[FieldOffset(Offset = "0x20")]
		private Skateboard skateboard;

		// Token: 0x0400103D RID: 4157
		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TrailRenderer[] Trails;

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x30")]
		private float trailsOpacity;
	}
}
