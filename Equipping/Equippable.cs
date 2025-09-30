using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C6 RID: 2502
	[Token(Token = "0x20009C6")]
	public class Equippable : MonoBehaviour
	{
		// Token: 0x0600445D RID: 17501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445D")]
		[Address(RVA = "0x8B84D0", Offset = "0x8B6ED0", VA = "0x1808B84D0", Slot = "4")]
		public virtual void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445E")]
		[Address(RVA = "0x8BE040", Offset = "0x8BCA40", VA = "0x1808BE040", Slot = "5")]
		public virtual void Unequip()
		{
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445F")]
		[Address(RVA = "0x8B84C0", Offset = "0x8B6EC0", VA = "0x1808B84C0")]
		public Equippable()
		{
		}

		// Token: 0x04002FDB RID: 12251
		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0x20")]
		protected ItemInstance itemInstance;

		// Token: 0x04002FDC RID: 12252
		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x28")]
		public bool CanInteractWhenEquipped;

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x29")]
		public bool CanPickUpWhenEquipped;
	}
}
