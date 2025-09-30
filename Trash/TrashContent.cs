using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence;

namespace ScheduleOne.Trash
{
	// Token: 0x020008CE RID: 2254
	[Token(Token = "0x20008CE")]
	[Serializable]
	public class TrashContent
	{
		// Token: 0x06003E5F RID: 15967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x8529C0", Offset = "0x8513C0", VA = "0x1808529C0")]
		public void AddTrash(string trashID, int quantity)
		{
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x853160", Offset = "0x851B60", VA = "0x180853160")]
		public void RemoveTrash(string trashID, int quantity)
		{
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x852FD0", Offset = "0x8519D0", VA = "0x180852FD0")]
		public int GetTrashQuantity(string trashID)
		{
			return 0;
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x852C80", Offset = "0x851680", VA = "0x180852C80")]
		public void Clear()
		{
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x852EB0", Offset = "0x8518B0", VA = "0x180852EB0")]
		public int GetTotalSize()
		{
			return 0;
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x852CE0", Offset = "0x8516E0", VA = "0x180852CE0")]
		public TrashContentData GetData()
		{
			return null;
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x8530C0", Offset = "0x851AC0", VA = "0x1808530C0")]
		public void LoadFromData(TrashContentData data)
		{
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x853290", Offset = "0x851C90", VA = "0x180853290")]
		public TrashContent()
		{
		}

		// Token: 0x04002BCE RID: 11214
		[Token(Token = "0x4002BCE")]
		[FieldOffset(Offset = "0x10")]
		public List<TrashContent.Entry> Entries;

		// Token: 0x020008CF RID: 2255
		[Token(Token = "0x20008CF")]
		[Serializable]
		public class Entry
		{
			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x06003E67 RID: 15975 RVA: 0x00010BD8 File Offset: 0x0000EDD8
			// (set) Token: 0x06003E68 RID: 15976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008CC")]
			public int UnitSize
			{
				[Token(Token = "0x6003E67")]
				[Address(RVA = "0x4C7D00", Offset = "0x4C6700", VA = "0x1804C7D00")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003E68")]
				[Address(RVA = "0x4C7D10", Offset = "0x4C6710", VA = "0x1804C7D10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x06003E69 RID: 15977 RVA: 0x00010BF0 File Offset: 0x0000EDF0
			// (set) Token: 0x06003E6A RID: 15978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008CD")]
			public int UnitValue
			{
				[Token(Token = "0x6003E69")]
				[Address(RVA = "0x47D5C0", Offset = "0x47BFC0", VA = "0x18047D5C0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003E6A")]
				[Address(RVA = "0x47D790", Offset = "0x47C190", VA = "0x18047D790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003E6B RID: 15979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E6B")]
			[Address(RVA = "0x83F290", Offset = "0x83DC90", VA = "0x18083F290")]
			public Entry(string id, int quantity)
			{
			}

			// Token: 0x04002BCF RID: 11215
			[Token(Token = "0x4002BCF")]
			[FieldOffset(Offset = "0x10")]
			public string TrashID;

			// Token: 0x04002BD0 RID: 11216
			[Token(Token = "0x4002BD0")]
			[FieldOffset(Offset = "0x18")]
			public int Quantity;
		}
	}
}
