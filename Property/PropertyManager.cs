using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Property
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	public class PropertyManager : Singleton<PropertyManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B4")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003D82")]
			[Address(RVA = "0x845F00", Offset = "0x844900", VA = "0x180845F00", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B5")]
		public string SaveFileName
		{
			[Token(Token = "0x6003D83")]
			[Address(RVA = "0x845ED0", Offset = "0x8448D0", VA = "0x180845ED0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B6")]
		public Loader Loader
		{
			[Token(Token = "0x6003D84")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x000108A8 File Offset: 0x0000EAA8
		[Token(Token = "0x170008B7")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003D85")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06003D86 RID: 15750 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003D87 RID: 15751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B8")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003D86")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D87")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06003D88 RID: 15752 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003D89 RID: 15753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B9")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003D88")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D89")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x000108C0 File Offset: 0x0000EAC0
		// (set) Token: 0x06003D8B RID: 15755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008BA")]
		public bool HasChanged
		{
			[Token(Token = "0x6003D8A")]
			[Address(RVA = "0x4BE2F0", Offset = "0x4BCCF0", VA = "0x1804BE2F0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D8B")]
			[Address(RVA = "0x4BE370", Offset = "0x4BCD70", VA = "0x1804BE370", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06003D8C RID: 15756 RVA: 0x000108D8 File Offset: 0x0000EAD8
		[Token(Token = "0x170008BB")]
		public int LoadOrder
		{
			[Token(Token = "0x6003D8C")]
			[Address(RVA = "0x660390", Offset = "0x65ED90", VA = "0x180660390", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8D")]
		[Address(RVA = "0x845110", Offset = "0x843B10", VA = "0x180845110", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x845430", Offset = "0x843E30", VA = "0x180845430", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x8453F0", Offset = "0x843DF0", VA = "0x1808453F0", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x845790", Offset = "0x844190", VA = "0x180845790", Slot = "33")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D91")]
		[Address(RVA = "0x845160", Offset = "0x843B60", VA = "0x180845160", Slot = "34")]
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D92")]
		[Address(RVA = "0x8454C0", Offset = "0x843EC0", VA = "0x1808454C0")]
		public void LoadProperty(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D93")]
		[Address(RVA = "0x845240", Offset = "0x843C40", VA = "0x180845240")]
		public Property GetProperty(string code)
		{
			return null;
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D94")]
		[Address(RVA = "0x845DE0", Offset = "0x8447E0", VA = "0x180845DE0")]
		public PropertyManager()
		{
		}

		// Token: 0x04002B68 RID: 11112
		[Token(Token = "0x4002B68")]
		[FieldOffset(Offset = "0x28")]
		private PropertiesLoader loader;
	}
}
