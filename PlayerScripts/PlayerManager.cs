using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using Unity.AI.Navigation;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x2000568")]
	public class PlayerManager : Singleton<PlayerManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054A")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x6603D0", Offset = "0x65EDD0", VA = "0x1806603D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054B")]
		public string SaveFileName
		{
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x6603A0", Offset = "0x65EDA0", VA = "0x1806603A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054C")]
		public Loader Loader
		{
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x1700054D")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054E")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EB3")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054F")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001EB4")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0000A158 File Offset: 0x00008358
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000550")]
		public bool HasChanged
		{
			[Token(Token = "0x6001EB6")]
			[Address(RVA = "0x4BE2F0", Offset = "0x4BCCF0", VA = "0x1804BE2F0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EB7")]
			[Address(RVA = "0x4BE370", Offset = "0x4BCD70", VA = "0x1804BE370", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x17000551")]
		public int LoadOrder
		{
			[Token(Token = "0x6001EB8")]
			[Address(RVA = "0x660390", Offset = "0x65ED90", VA = "0x180660390", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x65EAB0", Offset = "0x65D4B0", VA = "0x18065EAB0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x65EB40", Offset = "0x65D540", VA = "0x18065EB40", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x65EB00", Offset = "0x65D500", VA = "0x18065EB00", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x65FC90", Offset = "0x65E690", VA = "0x18065FC90", Slot = "33")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x65EFA0", Offset = "0x65D9A0", VA = "0x18065EFA0")]
		public void SavePlayer(Player player)
		{
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x65EBD0", Offset = "0x65D5D0", VA = "0x18065EBD0")]
		public void LoadPlayer(PlayerData data, string containerPath)
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x65E730", Offset = "0x65D130", VA = "0x18065E730")]
		public void AllPlayerFilesLoaded()
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x65F430", Offset = "0x65DE30", VA = "0x18065F430")]
		public bool TryGetPlayerData(string playerCode, out PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out VariableData[] variables)
		{
			return default(bool);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x660200", Offset = "0x65EC00", VA = "0x180660200")]
		public PlayerManager()
		{
		}

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0x28")]
		private PlayersLoader loader;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected List<PlayerData> loadedPlayerData;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x50")]
		protected List<string> loadedPlayerDataPaths;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x58")]
		protected List<string> loadedPlayerFileNames;

		// Token: 0x04001908 RID: 6408
		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0x60")]
		public NavMeshSurface PlayerRecoverySurface;
	}
}
