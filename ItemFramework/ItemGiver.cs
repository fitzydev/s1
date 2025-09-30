using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F7 RID: 2551
	[Token(Token = "0x20009F7")]
	public class ItemGiver : MonoBehaviour
	{
		// Token: 0x0600458F RID: 17807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x8C02F0", Offset = "0x8BECF0", VA = "0x1808C02F0")]
		public void Give()
		{
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004590")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ItemGiver()
		{
		}

		// Token: 0x040030CD RID: 12493
		[Token(Token = "0x40030CD")]
		[FieldOffset(Offset = "0x20")]
		public ItemDefinition Item;

		// Token: 0x040030CE RID: 12494
		[Token(Token = "0x40030CE")]
		[FieldOffset(Offset = "0x28")]
		public int Quantity;
	}
}
