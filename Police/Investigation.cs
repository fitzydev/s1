using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Police
{
	// Token: 0x020007F2 RID: 2034
	[Token(Token = "0x20007F2")]
	public class Investigation
	{
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x0000F090 File Offset: 0x0000D290
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F1")]
		public float CurrentProgress
		{
			[Token(Token = "0x6003778")]
			[Address(RVA = "0x4657B0", Offset = "0x4641B0", VA = "0x1804657B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003779")]
			[Address(RVA = "0x493FC0", Offset = "0x4929C0", VA = "0x180493FC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F2")]
		public Player Target
		{
			[Token(Token = "0x600377A")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600377B")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377C")]
		[Address(RVA = "0x7E4920", Offset = "0x7E3320", VA = "0x1807E4920")]
		public Investigation(Player target)
		{
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x7E4910", Offset = "0x7E3310", VA = "0x1807E4910")]
		public void ChangeProgress(float progress)
		{
		}
	}
}
