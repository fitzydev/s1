using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000A04 RID: 2564
	[Token(Token = "0x2000A04")]
	[Serializable]
	public class QualityItemInstance : StorableItemInstance
	{
		// Token: 0x06004623 RID: 17955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004623")]
		[Address(RVA = "0x8C8B60", Offset = "0x8C7560", VA = "0x1808C8B60")]
		public QualityItemInstance()
		{
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004624")]
		[Address(RVA = "0x8C8B70", Offset = "0x8C7570", VA = "0x1808C8B70")]
		public QualityItemInstance(ItemDefinition definition, int quantity, EQuality quality)
		{
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x6004625")]
		[Address(RVA = "0x8C8900", Offset = "0x8C7300", VA = "0x1808C8900", Slot = "11")]
		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return default(bool);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004626")]
		[Address(RVA = "0x8C89E0", Offset = "0x8C73E0", VA = "0x1808C89E0", Slot = "12")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004627")]
		[Address(RVA = "0x8C8AA0", Offset = "0x8C74A0", VA = "0x1808C8AA0", Slot = "14")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004628")]
		[Address(RVA = "0x8BF5A0", Offset = "0x8BDFA0", VA = "0x1808BF5A0")]
		public void SetQuality(EQuality quality)
		{
		}

		// Token: 0x04003107 RID: 12551
		[Token(Token = "0x4003107")]
		[FieldOffset(Offset = "0x38")]
		public EQuality Quality;
	}
}
