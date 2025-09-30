using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Money
{
	// Token: 0x02000C5C RID: 3164
	[Token(Token = "0x2000C5C")]
	public class CashSlot : HotbarSlot
	{
		// Token: 0x060054E3 RID: 21731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E3")]
		[Address(RVA = "0x9C4880", Offset = "0x9C3280", VA = "0x1809C4880", Slot = "7")]
		public override void ClearStoredInstance(bool _internal = false)
		{
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x000151F8 File Offset: 0x000133F8
		[Token(Token = "0x60054E4")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "13")]
		public override bool CanSlotAcceptCash()
		{
			return default(bool);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x8B1F10", Offset = "0x8B0910", VA = "0x1808B1F10")]
		public CashSlot()
		{
		}

		// Token: 0x04003F05 RID: 16133
		[Token(Token = "0x4003F05")]
		public const float MAX_CASH_PER_SLOT = 1000f;
	}
}
