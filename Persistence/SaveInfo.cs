using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class SaveInfo
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x5D2630", Offset = "0x5D1030", VA = "0x1805D2630")]
		public SaveInfo(string savePath, int saveSlotNumber, string organisationName, DateTime dateCreated, DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData)
		{
		}

		// Token: 0x0400136E RID: 4974
		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0x10")]
		public string SavePath;

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x18")]
		public int SaveSlotNumber;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x20")]
		public string OrganisationName;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0x28")]
		public DateTime DateCreated;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0x30")]
		public DateTime DateLastPlayed;

		// Token: 0x04001373 RID: 4979
		[Token(Token = "0x4001373")]
		[FieldOffset(Offset = "0x38")]
		public float Networth;

		// Token: 0x04001374 RID: 4980
		[Token(Token = "0x4001374")]
		[FieldOffset(Offset = "0x40")]
		public string SaveVersion;

		// Token: 0x04001375 RID: 4981
		[Token(Token = "0x4001375")]
		[FieldOffset(Offset = "0x48")]
		public MetaData MetaData;
	}
}
