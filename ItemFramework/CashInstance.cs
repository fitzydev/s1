using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009DE RID: 2526
	[Token(Token = "0x20009DE")]
	[Serializable]
	public class CashInstance : StorableItemInstance
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x00012300 File Offset: 0x00010500
		// (set) Token: 0x06004547 RID: 17735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A8")]
		public float Balance
		{
			[Token(Token = "0x6004546")]
			[Address(RVA = "0x4F2920", Offset = "0x4F1320", VA = "0x1804F2920")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004547")]
			[Address(RVA = "0x507410", Offset = "0x505E10", VA = "0x180507410")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004548")]
		[Address(RVA = "0x7CCB00", Offset = "0x7CB500", VA = "0x1807CCB00")]
		public CashInstance()
		{
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004549")]
		[Address(RVA = "0x8B1650", Offset = "0x8B0050", VA = "0x1808B1650")]
		public CashInstance(ItemDefinition definition, int quantity)
		{
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x8B14D0", Offset = "0x8AFED0", VA = "0x1808B14D0", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x8B1450", Offset = "0x8AFE50", VA = "0x1808B1450")]
		public void ChangeBalance(float amount)
		{
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454C")]
		[Address(RVA = "0x8B15D0", Offset = "0x8AFFD0", VA = "0x1808B15D0")]
		public void SetBalance(float newBalance, bool blockClear = false)
		{
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454D")]
		[Address(RVA = "0x8B1550", Offset = "0x8AFF50", VA = "0x1808B1550", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x600454E")]
		[Address(RVA = "0x4F2920", Offset = "0x4F1320", VA = "0x1804F2920", Slot = "15")]
		public override float GetMonetaryValue()
		{
			return 0f;
		}

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		public const float MAX_BALANCE = 1E+09f;
	}
}
