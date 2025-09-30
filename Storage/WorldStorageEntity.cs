using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000961 RID: 2401
	[Token(Token = "0x2000961")]
	public class WorldStorageEntity : StorageEntity, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x00011508 File Offset: 0x0000F708
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000935")]
		public Guid GUID
		{
			[Token(Token = "0x60041EC")]
			[Address(RVA = "0x892D60", Offset = "0x891760", VA = "0x180892D60", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60041ED")]
			[Address(RVA = "0x892E90", Offset = "0x891890", VA = "0x180892E90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EE")]
		[Address(RVA = "0x892A50", Offset = "0x891450", VA = "0x180892A50")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000936")]
		public string SaveFolderName
		{
			[Token(Token = "0x60041EF")]
			[Address(RVA = "0x892E10", Offset = "0x891810", VA = "0x180892E10", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000937")]
		public string SaveFileName
		{
			[Token(Token = "0x60041F0")]
			[Address(RVA = "0x892D90", Offset = "0x891790", VA = "0x180892D90", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000938")]
		public Loader Loader
		{
			[Token(Token = "0x60041F1")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x00011520 File Offset: 0x0000F720
		[Token(Token = "0x17000939")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60041F2")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041F4 RID: 16884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093A")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60041F3")]
			[Address(RVA = "0x81BF90", Offset = "0x81A990", VA = "0x18081BF90", Slot = "50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F4")]
			[Address(RVA = "0x892EB0", Offset = "0x8918B0", VA = "0x180892EB0", Slot = "51")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093B")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60041F5")]
			[Address(RVA = "0x892D80", Offset = "0x891780", VA = "0x180892D80", Slot = "52")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F6")]
			[Address(RVA = "0x892ED0", Offset = "0x8918D0", VA = "0x180892ED0", Slot = "53")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x00011538 File Offset: 0x0000F738
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093C")]
		public bool HasChanged
		{
			[Token(Token = "0x60041F7")]
			[Address(RVA = "0x892D70", Offset = "0x891770", VA = "0x180892D70", Slot = "54")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041F8")]
			[Address(RVA = "0x892EA0", Offset = "0x8918A0", VA = "0x180892EA0", Slot = "55")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x892690", Offset = "0x891090", VA = "0x180892690", Slot = "28")]
		public override void Awake()
		{
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FA")]
		[Address(RVA = "0x8929C0", Offset = "0x8913C0", VA = "0x1808929C0", Slot = "30")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FB")]
		[Address(RVA = "0x892890", Offset = "0x891290", VA = "0x180892890", Slot = "69")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FC")]
		[Address(RVA = "0x892AA0", Offset = "0x8914A0", VA = "0x180892AA0", Slot = "45")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x60041FD")]
		[Address(RVA = "0x892B10", Offset = "0x891510", VA = "0x180892B10", Slot = "70")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041FE")]
		[Address(RVA = "0x892790", Offset = "0x891190", VA = "0x180892790")]
		public WorldStorageEntityData GetSaveData()
		{
			return null;
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041FF")]
		[Address(RVA = "0x892850", Offset = "0x891250", VA = "0x180892850", Slot = "71")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004200")]
		[Address(RVA = "0x892920", Offset = "0x891320", VA = "0x180892920", Slot = "72")]
		public virtual void Load(WorldStorageEntityData data)
		{
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004201")]
		[Address(RVA = "0x8926E0", Offset = "0x8910E0", VA = "0x1808926E0", Slot = "32")]
		protected override void ContentsChanged()
		{
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004202")]
		[Address(RVA = "0x892BC0", Offset = "0x8915C0", VA = "0x180892BC0")]
		public WorldStorageEntity()
		{
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004204")]
		[Address(RVA = "0x8929A0", Offset = "0x8913A0", VA = "0x1808929A0", Slot = "36")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004205")]
		[Address(RVA = "0x892970", Offset = "0x891370", VA = "0x180892970", Slot = "37")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004206")]
		[Address(RVA = "0x85FED0", Offset = "0x85E8D0", VA = "0x18085FED0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004207")]
		[Address(RVA = "0x8923F0", Offset = "0x890DF0", VA = "0x1808923F0", Slot = "73")]
		protected virtual void Awake_UserLogic_ScheduleOne.Storage.WorldStorageEntity_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x0")]
		public static List<WorldStorageEntity> All;

		// Token: 0x04002E27 RID: 11815
		[Token(Token = "0x4002E27")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04002E2B RID: 11819
		[Token(Token = "0x4002E2B")]
		[FieldOffset(Offset = "0x19C")]
		public GameDateTime LastContentChangeTime;

		// Token: 0x04002E2C RID: 11820
		[Token(Token = "0x4002E2C")]
		[FieldOffset(Offset = "0x1A4")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x1A5")]
		private bool NetworkInitialize__LateScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted;
	}
}
