using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Audio
{
	// Token: 0x02000859 RID: 2137
	[Token(Token = "0x2000859")]
	public class StartLoopMusicTrack : MusicTrack
	{
		// Token: 0x06003A5F RID: 14943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0x820000", Offset = "0x81EA00", VA = "0x180820000", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x8201C0", Offset = "0x81EBC0", VA = "0x1808201C0", Slot = "5")]
		public override void Update()
		{
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A61")]
		[Address(RVA = "0x820040", Offset = "0x81EA40", VA = "0x180820040", Slot = "6")]
		public override void Play()
		{
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x81DB00", Offset = "0x81C500", VA = "0x18081DB00")]
		public StartLoopMusicTrack()
		{
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x820150", Offset = "0x81EB50", VA = "0x180820150")]
		[CompilerGenerated]
		private IEnumerator <Play>g__WaitForStart|3_0()
		{
			return null;
		}

		// Token: 0x040028BC RID: 10428
		[Token(Token = "0x40028BC")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController LoopSound;
	}
}
