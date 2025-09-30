using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000CDE RID: 3294
	[Token(Token = "0x2000CDE")]
	public class ManholeCover : MonoBehaviour
	{
		// Token: 0x06005D5B RID: 23899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0xA5D7F0", Offset = "0xA5C1F0", VA = "0x180A5D7F0")]
		private void Start()
		{
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0xA5D670", Offset = "0xA5C070", VA = "0x180A5D670")]
		private void MinPass()
		{
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ManholeCover()
		{
		}

		// Token: 0x040043BD RID: 17341
		[Token(Token = "0x40043BD")]
		[FieldOffset(Offset = "0x20")]
		public ParticleSystem SteamParticles;

		// Token: 0x040043BE RID: 17342
		[Token(Token = "0x40043BE")]
		[FieldOffset(Offset = "0x28")]
		public Gradient SteamColor;

		// Token: 0x040043BF RID: 17343
		[Token(Token = "0x40043BF")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve SteamAlpha;
	}
}
