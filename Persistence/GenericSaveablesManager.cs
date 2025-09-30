using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	public class GenericSaveablesManager : Singleton<GenericSaveablesManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C8")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001433")]
			[Address(RVA = "0x5AE810", Offset = "0x5AD210", VA = "0x1805AE810", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C9")]
		public string SaveFileName
		{
			[Token(Token = "0x6001434")]
			[Address(RVA = "0x5AE7E0", Offset = "0x5AD1E0", VA = "0x1805AE7E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		public Loader Loader
		{
			[Token(Token = "0x6001435")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x170003CB")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001436")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CC")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001437")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001438")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CD")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x000083A0 File Offset: 0x000065A0
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CE")]
		public bool HasChanged
		{
			[Token(Token = "0x600143B")]
			[Address(RVA = "0x4FA8A0", Offset = "0x4F92A0", VA = "0x1804FA8A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x4FAC50", Offset = "0x4F9650", VA = "0x1804FAC50", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x170003CF")]
		public int LoadOrder
		{
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x4FA890", Offset = "0x4F9290", VA = "0x1804FA890", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x5AE0D0", Offset = "0x5ACAD0", VA = "0x1805AE0D0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x5AE2D0", Offset = "0x5ACCD0", VA = "0x1805AE2D0", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x5AE5C0", Offset = "0x5ACFC0", VA = "0x1805AE5C0")]
		public void RegisterSaveable(IGenericSaveable saveable)
		{
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x5AE120", Offset = "0x5ACB20", VA = "0x1805AE120", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x5AE360", Offset = "0x5ACD60", VA = "0x1805AE360")]
		public void LoadSaveable(GenericSaveData data)
		{
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x5AE6A0", Offset = "0x5AD0A0", VA = "0x1805AE6A0")]
		public GenericSaveablesManager()
		{
		}

		// Token: 0x04001306 RID: 4870
		[Token(Token = "0x4001306")]
		[FieldOffset(Offset = "0x28")]
		protected List<IGenericSaveable> Saveables;

		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		[FieldOffset(Offset = "0x30")]
		private GenericSaveablesLoader loader;
	}
}
