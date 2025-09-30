using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.Map;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007FF RID: 2047
	[Token(Token = "0x20007FF")]
	public class RobDealer : CartelActivity
	{
		// Token: 0x0600381F RID: 14367 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x600381F")]
		[Address(RVA = "0x7EF990", Offset = "0x7EE390", VA = "0x1807EF990", Slot = "8")]
		public override bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003820")]
		[Address(RVA = "0x7EF7E0", Offset = "0x7EE1E0", VA = "0x1807EF7E0")]
		private Dealer GetDealerToRob(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x7EF730", Offset = "0x7EE130", VA = "0x1807EF730", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public RobDealer()
		{
		}
	}
}
