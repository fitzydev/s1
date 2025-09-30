using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000838 RID: 2104
	[Token(Token = "0x2000838")]
	[RequireComponent(typeof(AudioSourceController))]
	public class AmbientLoop : MonoBehaviour
	{
		// Token: 0x060039B6 RID: 14774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x7F1930", Offset = "0x7F0330", VA = "0x1807F1930")]
		private void Start()
		{
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B7")]
		[Address(RVA = "0x7F19A0", Offset = "0x7F03A0", VA = "0x1807F19A0")]
		private void Update()
		{
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B8")]
		[Address(RVA = "0x7F1B10", Offset = "0x7F0510", VA = "0x1807F1B10")]
		public AmbientLoop()
		{
		}

		// Token: 0x04002809 RID: 10249
		[Token(Token = "0x4002809")]
		public const float MUSIC_FADE_MULTIPLIER = 0.3f;

		// Token: 0x0400280A RID: 10250
		[Token(Token = "0x400280A")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve VolumeCurve;

		// Token: 0x0400280B RID: 10251
		[Token(Token = "0x400280B")]
		[FieldOffset(Offset = "0x28")]
		public bool FadeDuringMusic;

		// Token: 0x0400280C RID: 10252
		[Token(Token = "0x400280C")]
		[FieldOffset(Offset = "0x30")]
		private AudioSourceController audioSourceController;

		// Token: 0x0400280D RID: 10253
		[Token(Token = "0x400280D")]
		[FieldOffset(Offset = "0x38")]
		private float musicScale;
	}
}
