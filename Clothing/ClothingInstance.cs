using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.Clothing
{
	// Token: 0x020007BA RID: 1978
	[Token(Token = "0x20007BA")]
	[Serializable]
	public class ClothingInstance : StorableItemInstance
	{
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C3")]
		public override string Name
		{
			[Token(Token = "0x6003589")]
			[Address(RVA = "0x7CCB10", Offset = "0x7CB510", VA = "0x1807CCB10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x7CCB00", Offset = "0x7CB500", VA = "0x1807CCB00")]
		public ClothingInstance()
		{
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x7CCAD0", Offset = "0x7CB4D0", VA = "0x1807CCAD0")]
		public ClothingInstance(ItemDefinition definition, int quantity, EClothingColor color)
		{
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x7CC9C0", Offset = "0x7CB3C0", VA = "0x1807CC9C0", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x7CCA50", Offset = "0x7CB450", VA = "0x1807CCA50", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x04002538 RID: 9528
		[Token(Token = "0x4002538")]
		[FieldOffset(Offset = "0x38")]
		public EClothingColor Color;
	}
}
