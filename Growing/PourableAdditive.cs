using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x0200092D RID: 2349
	[Token(Token = "0x200092D")]
	public class PourableAdditive : Pourable
	{
		// Token: 0x06004048 RID: 16456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004048")]
		[Address(RVA = "0x8737C0", Offset = "0x8721C0", VA = "0x1808737C0", Slot = "16")]
		protected override void PourAmount(float amount)
		{
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004049")]
		[Address(RVA = "0x8737D0", Offset = "0x8721D0", VA = "0x1808737D0")]
		public PourableAdditive()
		{
		}

		// Token: 0x04002D2C RID: 11564
		[Token(Token = "0x4002D2C")]
		public const float NormalizedAmountForSuccess = 0.8f;

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x138")]
		public AdditiveDefinition AdditiveDefinition;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x140")]
		public Color LiquidColor;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x150")]
		private float pouredAmount;
	}
}
