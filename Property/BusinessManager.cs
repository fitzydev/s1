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
	// Token: 0x020008AD RID: 2221
	[Token(Token = "0x20008AD")]
	public class BusinessManager : Singleton<BusinessManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000898")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003CDD")]
			[Address(RVA = "0x83F060", Offset = "0x83DA60", VA = "0x18083F060", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06003CDE RID: 15582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000899")]
		public string SaveFileName
		{
			[Token(Token = "0x6003CDE")]
			[Address(RVA = "0x83F030", Offset = "0x83DA30", VA = "0x18083F030", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089A")]
		public Loader Loader
		{
			[Token(Token = "0x6003CDF")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x00010680 File Offset: 0x0000E880
		[Token(Token = "0x1700089B")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003CE0")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089C")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003CE1")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CE2")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003CE4 RID: 15588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089D")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003CE3")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CE4")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x00010698 File Offset: 0x0000E898
		// (set) Token: 0x06003CE6 RID: 15590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089E")]
		public bool HasChanged
		{
			[Token(Token = "0x6003CE5")]
			[Address(RVA = "0x4BE2F0", Offset = "0x4BCCF0", VA = "0x1804BE2F0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003CE6")]
			[Address(RVA = "0x4BE370", Offset = "0x4BCD70", VA = "0x1804BE370", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x1700089F")]
		public int LoadOrder
		{
			[Token(Token = "0x6003CE7")]
			[Address(RVA = "0x660390", Offset = "0x65ED90", VA = "0x180660390", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x83E7B0", Offset = "0x83D1B0", VA = "0x18083E7B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x83E920", Offset = "0x83D320", VA = "0x18083E920", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x83E8E0", Offset = "0x83D2E0", VA = "0x18083E8E0", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x83EBC0", Offset = "0x83D5C0", VA = "0x18083EBC0", Slot = "33")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0x83E800", Offset = "0x83D200", VA = "0x18083E800", Slot = "34")]
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x83E9B0", Offset = "0x83D3B0", VA = "0x18083E9B0")]
		public void LoadBusiness(BusinessData businessData, string dataString)
		{
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x83EF40", Offset = "0x83D940", VA = "0x18083EF40")]
		public BusinessManager()
		{
		}

		// Token: 0x04002B0E RID: 11022
		[Token(Token = "0x4002B0E")]
		[FieldOffset(Offset = "0x28")]
		private BusinessesLoader loader;
	}
}
