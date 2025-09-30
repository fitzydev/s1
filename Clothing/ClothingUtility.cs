using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		// Token: 0x0600358E RID: 13710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x7CCBF0", Offset = "0x7CB5F0", VA = "0x1807CCBF0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x7CD150", Offset = "0x7CBB50", VA = "0x1807CD150")]
		private void OnValidate()
		{
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x7CCFB0", Offset = "0x7CB9B0", VA = "0x1807CCFB0")]
		public ClothingUtility.ColorData GetColorData(EClothingColor color)
		{
			return null;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x7CD080", Offset = "0x7CBA80", VA = "0x1807CD080")]
		public ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			return null;
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003592")]
		[Address(RVA = "0x7CD8A0", Offset = "0x7CC2A0", VA = "0x1807CD8A0")]
		public ClothingUtility()
		{
		}

		// Token: 0x04002539 RID: 9529
		[Token(Token = "0x4002539")]
		[FieldOffset(Offset = "0x28")]
		public List<ClothingUtility.ColorData> ColorDataList;

		// Token: 0x0400253A RID: 9530
		[Token(Token = "0x400253A")]
		[FieldOffset(Offset = "0x30")]
		public List<ClothingUtility.ClothingSlotData> ClothingSlotDataList;

		// Token: 0x020007BC RID: 1980
		[Token(Token = "0x20007BC")]
		[Serializable]
		public class ColorData
		{
			// Token: 0x06003593 RID: 13715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003593")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ColorData()
			{
			}

			// Token: 0x0400253B RID: 9531
			[Token(Token = "0x400253B")]
			[FieldOffset(Offset = "0x10")]
			public EClothingColor ColorType;

			// Token: 0x0400253C RID: 9532
			[Token(Token = "0x400253C")]
			[FieldOffset(Offset = "0x14")]
			public Color ActualColor;

			// Token: 0x0400253D RID: 9533
			[Token(Token = "0x400253D")]
			[FieldOffset(Offset = "0x24")]
			public Color LabelColor;
		}

		// Token: 0x020007BD RID: 1981
		[Token(Token = "0x20007BD")]
		[Serializable]
		public class ClothingSlotData
		{
			// Token: 0x06003594 RID: 13716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003594")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ClothingSlotData()
			{
			}

			// Token: 0x0400253E RID: 9534
			[Token(Token = "0x400253E")]
			[FieldOffset(Offset = "0x10")]
			public EClothingSlot Slot;

			// Token: 0x0400253F RID: 9535
			[Token(Token = "0x400253F")]
			[FieldOffset(Offset = "0x18")]
			public string Name;

			// Token: 0x04002540 RID: 9536
			[Token(Token = "0x4002540")]
			[FieldOffset(Offset = "0x20")]
			public Sprite Icon;
		}
	}
}
