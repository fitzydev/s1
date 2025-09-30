using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000839 RID: 2105
	[Token(Token = "0x2000839")]
	[RequireComponent(typeof(AudioSourceController))]
	public class AmbientLoopJukebox : MonoBehaviour
	{
		// Token: 0x060039B9 RID: 14777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B9")]
		[Address(RVA = "0x7F1660", Offset = "0x7F0060", VA = "0x1807F1660")]
		private void Start()
		{
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BA")]
		[Address(RVA = "0x7F17F0", Offset = "0x7F01F0", VA = "0x1807F17F0")]
		private void Update()
		{
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x7F14F0", Offset = "0x7EFEF0", VA = "0x1807F14F0")]
		private void MinPass()
		{
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BC")]
		[Address(RVA = "0x7F18B0", Offset = "0x7F02B0", VA = "0x1807F18B0")]
		public AmbientLoopJukebox()
		{
		}

		// Token: 0x0400280E RID: 10254
		[Token(Token = "0x400280E")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve VolumeCurve;

		// Token: 0x0400280F RID: 10255
		[Token(Token = "0x400280F")]
		[FieldOffset(Offset = "0x28")]
		public List<AudioClip> Clips;

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0x30")]
		private AudioSourceController audioSourceController;

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		[FieldOffset(Offset = "0x38")]
		private int currentClipIndex;

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0x3C")]
		private float musicScale;
	}
}
