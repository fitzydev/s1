using System;
using Il2CppDummyDll;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C9 RID: 2505
	[Token(Token = "0x20009C9")]
	public class Equippable_BuildableItem : Equippable_StorableItem
	{
		// Token: 0x0600446A RID: 17514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446A")]
		[Address(RVA = "0x8B8390", Offset = "0x8B6D90", VA = "0x1808B8390", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446B")]
		[Address(RVA = "0x8B8300", Offset = "0x8B6D00", VA = "0x1808B8300", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446C")]
		[Address(RVA = "0x8B84C0", Offset = "0x8B6EC0", VA = "0x1808B84C0")]
		public Equippable_BuildableItem()
		{
		}

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x38")]
		protected bool isBuilding;
	}
}
