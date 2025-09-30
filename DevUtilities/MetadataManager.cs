using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	public class MetadataManager : Singleton<MetadataManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x060032E9 RID: 13033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000761")]
		public DateTime CreationDate
		{
			[Token(Token = "0x60032E8")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60032E9")]
			[Address(RVA = "0x5EB350", Offset = "0x5E9D50", VA = "0x1805EB350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000762")]
		public string CreationVersion
		{
			[Token(Token = "0x60032EA")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032EB")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000763")]
		public string SaveFolderName
		{
			[Token(Token = "0x60032EC")]
			[Address(RVA = "0x77A1F0", Offset = "0x778BF0", VA = "0x18077A1F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000764")]
		public string SaveFileName
		{
			[Token(Token = "0x60032ED")]
			[Address(RVA = "0x77A1C0", Offset = "0x778BC0", VA = "0x18077A1C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000765")]
		public Loader Loader
		{
			[Token(Token = "0x60032EE")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x17000766")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60032EF")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000767")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60032F0")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032F1")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000768")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60032F2")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032F3")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x0000E070 File Offset: 0x0000C270
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000769")]
		public bool HasChanged
		{
			[Token(Token = "0x60032F4")]
			[Address(RVA = "0x4A4A60", Offset = "0x4A3460", VA = "0x1804A4A60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032F5")]
			[Address(RVA = "0x4A4A90", Offset = "0x4A3490", VA = "0x1804A4A90", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x0000E088 File Offset: 0x0000C288
		[Token(Token = "0x1700076A")]
		public int LoadOrder
		{
			[Token(Token = "0x60032F6")]
			[Address(RVA = "0x4E8A70", Offset = "0x4E7470", VA = "0x1804E8A70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F7")]
		[Address(RVA = "0x779DB0", Offset = "0x7787B0", VA = "0x180779DB0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032F8")]
		[Address(RVA = "0x779FC0", Offset = "0x7789C0", VA = "0x180779FC0", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F9")]
		[Address(RVA = "0x779E70", Offset = "0x778870", VA = "0x180779E70", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032FA")]
		[Address(RVA = "0x77A050", Offset = "0x778A50", VA = "0x18077A050")]
		public void Load(MetaData data)
		{
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032FB")]
		[Address(RVA = "0x77A0A0", Offset = "0x778AA0", VA = "0x18077A0A0")]
		public MetadataManager()
		{
		}

		// Token: 0x04002351 RID: 9041
		[Token(Token = "0x4002351")]
		[FieldOffset(Offset = "0x38")]
		private MetadataLoader loader;
	}
}
