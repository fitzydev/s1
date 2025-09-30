using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	public class ItemRemover : MonoBehaviour
	{
		// Token: 0x060045C1 RID: 17857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x8C1ED0", Offset = "0x8C08D0", VA = "0x1808C1ED0")]
		public void Remove()
		{
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ItemRemover()
		{
		}

		// Token: 0x040030F1 RID: 12529
		[Token(Token = "0x40030F1")]
		[FieldOffset(Offset = "0x20")]
		public ItemDefinition Item;

		// Token: 0x040030F2 RID: 12530
		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x28")]
		public int Quantity;
	}
}
