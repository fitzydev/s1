using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Tools
{
	// Token: 0x02000915 RID: 2325
	[Token(Token = "0x2000915")]
	public class PlayerSmoothedVelocityCalculator : SmoothedVelocityCalculator
	{
		// Token: 0x06003FF1 RID: 16369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x8735E0", Offset = "0x871FE0", VA = "0x1808735E0", Slot = "4")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0x8736C0", Offset = "0x8720C0", VA = "0x1808736C0")]
		public PlayerSmoothedVelocityCalculator()
		{
		}

		// Token: 0x04002CCA RID: 11466
		[Token(Token = "0x4002CCA")]
		[FieldOffset(Offset = "0x60")]
		public Player Player;
	}
}
