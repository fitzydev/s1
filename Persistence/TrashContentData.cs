using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Trash;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	[Serializable]
	public class TrashContentData
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x5D6890", Offset = "0x5D5290", VA = "0x1805D6890")]
		public TrashContentData()
		{
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x5D6910", Offset = "0x5D5310", VA = "0x1805D6910")]
		public TrashContentData(string[] trashIDs, int[] trashQuantities)
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x5D6470", Offset = "0x5D4E70", VA = "0x1805D6470")]
		public TrashContentData(List<TrashItem> trashItems)
		{
		}

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x400136C")]
		[FieldOffset(Offset = "0x10")]
		public string[] TrashIDs;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0x18")]
		public int[] TrashQuantities;
	}
}
