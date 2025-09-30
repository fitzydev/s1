using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200085B RID: 2139
	[Token(Token = "0x200085B")]
	public class StartLoopStopAudio : MonoBehaviour
	{
		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x0000FA20 File Offset: 0x0000DC20
		// (set) Token: 0x06003A6B RID: 14955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083E")]
		public bool Runnning
		{
			[Token(Token = "0x6003A6A")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A6B")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x820380", Offset = "0x81ED80", VA = "0x180820380")]
		private void Update()
		{
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x8202A0", Offset = "0x81ECA0", VA = "0x1808202A0")]
		[Button]
		public void StartAudio()
		{
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0x820320", Offset = "0x81ED20", VA = "0x180820320")]
		[Button]
		public void StopAudio()
		{
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public StartLoopStopAudio()
		{
		}

		// Token: 0x040028C1 RID: 10433
		[Token(Token = "0x40028C1")]
		[FieldOffset(Offset = "0x28")]
		public AudioSourceController StartSound;

		// Token: 0x040028C2 RID: 10434
		[Token(Token = "0x40028C2")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController LoopSound;

		// Token: 0x040028C3 RID: 10435
		[Token(Token = "0x40028C3")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController StopSound;

		// Token: 0x040028C4 RID: 10436
		[Token(Token = "0x40028C4")]
		[FieldOffset(Offset = "0x40")]
		public bool FadeLoopIn;

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		[FieldOffset(Offset = "0x41")]
		public bool FadeLoopOut;

		// Token: 0x040028C6 RID: 10438
		[Token(Token = "0x40028C6")]
		[FieldOffset(Offset = "0x44")]
		private float timeSinceStart;

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		[FieldOffset(Offset = "0x48")]
		private float timeSinceStop;
	}
}
