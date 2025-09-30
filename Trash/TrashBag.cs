using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Trash
{
	// Token: 0x020008CA RID: 2250
	[Token(Token = "0x20008CA")]
	public class TrashBag : TrashItem
	{
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06003E31 RID: 15921 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E32 RID: 15922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008C8")]
		public TrashContent Content
		{
			[Token(Token = "0x6003E31")]
			[Address(RVA = "0x4DBC30", Offset = "0x4DA630", VA = "0x1804DBC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E32")]
			[Address(RVA = "0x4DC750", Offset = "0x4DB150", VA = "0x1804DC750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x850490", Offset = "0x84EE90", VA = "0x180850490")]
		public void LoadContent(TrashContentData data)
		{
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x850330", Offset = "0x84ED30", VA = "0x180850330", Slot = "32")]
		public override TrashItemData GetData()
		{
			return null;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x8504C0", Offset = "0x84EEC0", VA = "0x1808504C0")]
		public TrashBag()
		{
		}
	}
}
