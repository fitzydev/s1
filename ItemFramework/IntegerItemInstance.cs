using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F4 RID: 2548
	[Token(Token = "0x20009F4")]
	public class IntegerItemInstance : StorableItemInstance
	{
		// Token: 0x06004587 RID: 17799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004587")]
		[Address(RVA = "0x7CCB00", Offset = "0x7CB500", VA = "0x1807CCB00")]
		public IntegerItemInstance()
		{
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x7CCAD0", Offset = "0x7CB4D0", VA = "0x1807CCAD0")]
		public IntegerItemInstance(ItemDefinition definition, int quantity, int value)
		{
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004589")]
		[Address(RVA = "0x8BF490", Offset = "0x8BDE90", VA = "0x1808BF490", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458A")]
		[Address(RVA = "0x8BF470", Offset = "0x8BDE70", VA = "0x1808BF470")]
		public void ChangeValue(int change)
		{
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x8BF5A0", Offset = "0x8BDFA0", VA = "0x1808BF5A0")]
		public void SetValue(int value)
		{
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x8BF520", Offset = "0x8BDF20", VA = "0x1808BF520", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x040030B7 RID: 12471
		[Token(Token = "0x40030B7")]
		[FieldOffset(Offset = "0x38")]
		public int Value;
	}
}
