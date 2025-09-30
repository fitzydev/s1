using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	public class AmbientOneShot : MonoBehaviour
	{
		// Token: 0x060039BD RID: 14781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x7F1F10", Offset = "0x7F0910", VA = "0x1807F1F10")]
		private void Start()
		{
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x7F1DE0", Offset = "0x7F07E0", VA = "0x1807F1DE0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BF")]
		[Address(RVA = "0x7F1B30", Offset = "0x7F0530", VA = "0x1807F1B30")]
		private void MinPass()
		{
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C0")]
		[Address(RVA = "0x7F1EC0", Offset = "0x7F08C0", VA = "0x1807F1EC0")]
		private void Play()
		{
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0A10", VA = "0x1807F2010")]
		public AmbientOneShot()
		{
		}

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController Audio;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		[Range(0f, 1f)]
		public float Volume;

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float ChancePerHour;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0x30")]
		public int CooldownTime;

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0x34")]
		public AmbientOneShot.EPlayTime PlayTime;

		// Token: 0x04002818 RID: 10264
		[Token(Token = "0x4002818")]
		[FieldOffset(Offset = "0x38")]
		public float MinDistance;

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0x3C")]
		public float MaxDistance;

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0x40")]
		private int timeSinceLastPlay;

		// Token: 0x0200083B RID: 2107
		[Token(Token = "0x200083B")]
		public enum EPlayTime
		{
			// Token: 0x0400281C RID: 10268
			[Token(Token = "0x400281C")]
			All,
			// Token: 0x0400281D RID: 10269
			[Token(Token = "0x400281D")]
			Day,
			// Token: 0x0400281E RID: 10270
			[Token(Token = "0x400281E")]
			Night
		}
	}
}
