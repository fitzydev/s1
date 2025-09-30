using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C0 RID: 2496
	[Token(Token = "0x20009C0")]
	public class LiquidMeth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600443D RID: 17469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443D")]
		[Address(RVA = "0x894D00", Offset = "0x893700", VA = "0x180894D00", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443E")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public LiquidMeth_Equippable()
		{
		}

		// Token: 0x04002FC1 RID: 12225
		[Token(Token = "0x4002FC1")]
		[FieldOffset(Offset = "0x68")]
		public LiquidMethVisuals Visuals;
	}
}
