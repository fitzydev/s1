using System;
using Il2CppDummyDll;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009D6 RID: 2518
	[Token(Token = "0x20009D6")]
	public class Equippable_SurfaceItem : Equippable_StorableItem
	{
		// Token: 0x060044C9 RID: 17609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x8BDB00", Offset = "0x8BC500", VA = "0x1808BDB00", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x8BDA70", Offset = "0x8BC470", VA = "0x1808BDA70", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x8B84C0", Offset = "0x8B6EC0", VA = "0x1808B84C0")]
		public Equippable_SurfaceItem()
		{
		}

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x38")]
		protected bool isBuilding;
	}
}
