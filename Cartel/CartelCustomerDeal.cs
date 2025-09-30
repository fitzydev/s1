using System;
using Il2CppDummyDll;
using ScheduleOne.Map;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	public class CartelCustomerDeal : CartelActivity
	{
		// Token: 0x0600381A RID: 14362 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x7DEDB0", Offset = "0x7DD7B0", VA = "0x1807DEDB0", Slot = "8")]
		public override bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x7DEA90", Offset = "0x7DD490", VA = "0x1807DEA90", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381C")]
		[Address(RVA = "0x7DEEE0", Offset = "0x7DD8E0", VA = "0x1807DEEE0", Slot = "5")]
		protected override void MinPassed()
		{
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381D")]
		[Address(RVA = "0x7DEC50", Offset = "0x7DD650", VA = "0x1807DEC50", Slot = "7")]
		protected override void Deactivate()
		{
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CartelCustomerDeal()
		{
		}

		// Token: 0x04002718 RID: 10008
		[Token(Token = "0x4002718")]
		public const int TIMEOUT_MINUTES = 720;

		// Token: 0x04002719 RID: 10009
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x40")]
		private CartelDealer dealer;
	}
}
