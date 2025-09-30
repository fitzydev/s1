using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Storage
{
	// Token: 0x02000957 RID: 2391
	[Token(Token = "0x2000957")]
	public class StorageManager : NetworkSingleton<StorageManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06004199 RID: 16793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091F")]
		public string SaveFolderName
		{
			[Token(Token = "0x6004199")]
			[Address(RVA = "0x88DD10", Offset = "0x88C710", VA = "0x18088DD10", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000920")]
		public string SaveFileName
		{
			[Token(Token = "0x600419A")]
			[Address(RVA = "0x88DCE0", Offset = "0x88C6E0", VA = "0x18088DCE0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000921")]
		public Loader Loader
		{
			[Token(Token = "0x600419B")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x000113E8 File Offset: 0x0000F5E8
		[Token(Token = "0x17000922")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x600419C")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600419E RID: 16798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000923")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x600419D")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600419E")]
			[Address(RVA = "0x5ADF40", Offset = "0x5AC940", VA = "0x1805ADF40", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600419F RID: 16799 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041A0 RID: 16800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000924")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x600419F")]
			[Address(RVA = "0x672D40", Offset = "0x671740", VA = "0x180672D40", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041A0")]
			[Address(RVA = "0x672DD0", Offset = "0x6717D0", VA = "0x180672DD0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x00011400 File Offset: 0x0000F600
		// (set) Token: 0x060041A2 RID: 16802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000925")]
		public bool HasChanged
		{
			[Token(Token = "0x60041A1")]
			[Address(RVA = "0x538220", Offset = "0x536C20", VA = "0x180538220", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041A2")]
			[Address(RVA = "0x6CAFD0", Offset = "0x6C99D0", VA = "0x1806CAFD0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x00011418 File Offset: 0x0000F618
		[Token(Token = "0x17000926")]
		public int LoadOrder
		{
			[Token(Token = "0x60041A3")]
			[Address(RVA = "0x6CAE50", Offset = "0x6C9850", VA = "0x1806CAE50", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x88D810", Offset = "0x88C210", VA = "0x18088D810", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x88DAA0", Offset = "0x88C4A0", VA = "0x18088DAA0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x88D890", Offset = "0x88C290", VA = "0x18088D890", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x88DBD0", Offset = "0x88C5D0", VA = "0x18088DBD0")]
		public StorageManager()
		{
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x88DB80", Offset = "0x88C580", VA = "0x18088DB80", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x88DB30", Offset = "0x88C530", VA = "0x18088DB30", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x88D7C0", Offset = "0x88C1C0", VA = "0x18088D7C0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Storage.StorageManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x120")]
		private StorageLoader loader;

		// Token: 0x04002DFC RID: 11772
		[Token(Token = "0x4002DFC")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002DFD RID: 11773
		[Token(Token = "0x4002DFD")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted;
	}
}
