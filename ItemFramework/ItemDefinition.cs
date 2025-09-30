using System;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.UI.Items;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009F6 RID: 2550
	[Token(Token = "0x20009F6")]
	[CreateAssetMenu(fileName = "ItemDefinition", menuName = "ScriptableObjects/ItemDefinition", order = 1)]
	[Serializable]
	public class ItemDefinition : ScriptableObject
	{
		// Token: 0x0600458D RID: 17805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458D")]
		[Address(RVA = "0x8BF5C0", Offset = "0x8BDFC0", VA = "0x1808BF5C0", Slot = "4")]
		public virtual ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x8BF620", Offset = "0x8BE020", VA = "0x1808BF620")]
		public ItemDefinition()
		{
		}

		// Token: 0x040030BE RID: 12478
		[Token(Token = "0x40030BE")]
		public const int DEFAULT_STACK_LIMIT = 10;

		// Token: 0x040030BF RID: 12479
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0x20")]
		[TextArea(3, 10)]
		public string Description;

		// Token: 0x040030C1 RID: 12481
		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0x28")]
		public string ID;

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0x30")]
		public Sprite Icon;

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0x38")]
		public EItemCategory Category;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0x40")]
		public string[] Keywords;

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0x48")]
		public bool AvailableInDemo;

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0x49")]
		public bool UsableInFilters;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0x4C")]
		public Color LabelDisplayColor;

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0x5C")]
		public int StackLimit;

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0x60")]
		public Equippable Equippable;

		// Token: 0x040030CA RID: 12490
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0x68")]
		public ItemUI CustomItemUI;

		// Token: 0x040030CB RID: 12491
		[Token(Token = "0x40030CB")]
		[FieldOffset(Offset = "0x70")]
		public ItemInfoContent CustomInfoContent;

		// Token: 0x040030CC RID: 12492
		[Token(Token = "0x40030CC")]
		[FieldOffset(Offset = "0x78")]
		[Header("Legal Status")]
		public ELegalStatus legalStatus;
	}
}
