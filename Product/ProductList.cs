using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Product
{
	// Token: 0x0200099D RID: 2461
	[Token(Token = "0x200099D")]
	[Serializable]
	public class ProductList
	{
		// Token: 0x0600431F RID: 17183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431F")]
		[Address(RVA = "0x897020", Offset = "0x895A20", VA = "0x180897020")]
		public ProductList()
		{
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004320")]
		[Address(RVA = "0x8968C0", Offset = "0x8952C0", VA = "0x1808968C0")]
		public string GetCommaSeperatedString()
		{
			return null;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004321")]
		[Address(RVA = "0x896B20", Offset = "0x895520", VA = "0x180896B20")]
		public string GetLineSeperatedString()
		{
			return null;
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004322")]
		[Address(RVA = "0x896D30", Offset = "0x895730", VA = "0x180896D30")]
		public string GetQualityString()
		{
			return null;
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x6004323")]
		[Address(RVA = "0x896F00", Offset = "0x895900", VA = "0x180896F00")]
		public int GetTotalQuantity()
		{
			return 0;
		}

		// Token: 0x04002F1F RID: 12063
		[Token(Token = "0x4002F1F")]
		[FieldOffset(Offset = "0x10")]
		public List<ProductList.Entry> entries;

		// Token: 0x0200099E RID: 2462
		[Token(Token = "0x200099E")]
		[Serializable]
		public class Entry
		{
			// Token: 0x06004324 RID: 17188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004324")]
			[Address(RVA = "0x789B90", Offset = "0x788590", VA = "0x180789B90")]
			public Entry(string productID, EQuality quality, int quantity)
			{
			}

			// Token: 0x06004325 RID: 17189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004325")]
			[Address(RVA = "0x892EF0", Offset = "0x8918F0", VA = "0x180892EF0")]
			public Entry()
			{
			}

			// Token: 0x04002F20 RID: 12064
			[Token(Token = "0x4002F20")]
			[FieldOffset(Offset = "0x10")]
			public string ProductID;

			// Token: 0x04002F21 RID: 12065
			[Token(Token = "0x4002F21")]
			[FieldOffset(Offset = "0x18")]
			public EQuality Quality;

			// Token: 0x04002F22 RID: 12066
			[Token(Token = "0x4002F22")]
			[FieldOffset(Offset = "0x1C")]
			public int Quantity;
		}
	}
}
