using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x2000543")]
	public class HotbarSlot : ItemSlot
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00009768 File Offset: 0x00007968
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D9")]
		public bool IsEquipped
		{
			[Token(Token = "0x6001B91")]
			[Address(RVA = "0x506B90", Offset = "0x505590", VA = "0x180506B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B92")]
			[Address(RVA = "0x507050", Offset = "0x505A50", VA = "0x180507050")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x634FB0", Offset = "0x6339B0", VA = "0x180634FB0", Slot = "4")]
		public override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x634C90", Offset = "0x633690", VA = "0x180634C90", Slot = "7")]
		public override void ClearStoredInstance(bool _internal = false)
		{
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x634D60", Offset = "0x633760", VA = "0x180634D60", Slot = "14")]
		public virtual void Equip()
		{
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x635220", Offset = "0x633C20", VA = "0x180635220", Slot = "15")]
		public virtual void Unequip()
		{
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "13")]
		public override bool CanSlotAcceptCash()
		{
			return default(bool);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x635350", Offset = "0x633D50", VA = "0x180635350")]
		public HotbarSlot()
		{
		}

		// Token: 0x04001799 RID: 6041
		[Token(Token = "0x4001799")]
		[FieldOffset(Offset = "0x80")]
		public Equippable Equippable;

		// Token: 0x0400179A RID: 6042
		[Token(Token = "0x400179A")]
		[FieldOffset(Offset = "0x88")]
		public HotbarSlot.EquipEvent onEquipChanged;

		// Token: 0x02000544 RID: 1348
		// (Invoke) Token: 0x06001B9A RID: 7066
		[Token(Token = "0x2000544")]
		public delegate void EquipEvent(bool equipped);
	}
}
