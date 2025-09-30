using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.ItemLoaders;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI.MainMenu;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	public class LoadManager : PersistentSingleton<LoadManager>
	{
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D9")]
		public string DefaultTutorialSaveFolder
		{
			[Token(Token = "0x6001466")]
			[Address(RVA = "0x5CD950", Offset = "0x5CC350", VA = "0x1805CD950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00008418 File Offset: 0x00006618
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DA")]
		public bool IsGameLoaded
		{
			[Token(Token = "0x6001467")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001468")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00008430 File Offset: 0x00006630
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DB")]
		public bool IsLoading
		{
			[Token(Token = "0x6001469")]
			[Address(RVA = "0x5CD9E0", Offset = "0x5CC3E0", VA = "0x1805CD9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600146A")]
			[Address(RVA = "0x5CD9F0", Offset = "0x5CC3F0", VA = "0x1805CD9F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x00008448 File Offset: 0x00006648
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DC")]
		public float TimeSinceGameLoaded
		{
			[Token(Token = "0x600146B")]
			[Address(RVA = "0x4A3730", Offset = "0x4A2130", VA = "0x1804A3730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600146C")]
			[Address(RVA = "0x5CDA10", Offset = "0x5CC410", VA = "0x1805CDA10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x00008460 File Offset: 0x00006660
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DD")]
		public bool DebugMode
		{
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00008478 File Offset: 0x00006678
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DE")]
		public LoadManager.ELoadStatus LoadStatus
		{
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x487490", Offset = "0x485E90", VA = "0x180487490")]
			[CompilerGenerated]
			get
			{
				return LoadManager.ELoadStatus.None;
			}
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x487610", Offset = "0x486010", VA = "0x180487610")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DF")]
		public string LoadedGameFolderPath
		{
			[Token(Token = "0x6001471")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001472")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E0")]
		public SaveInfo ActiveSaveInfo
		{
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001474")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E1")]
		public SaveInfo StoredSaveInfo
		{
			[Token(Token = "0x6001475")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001476")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x5C9EF0", Offset = "0x5C88F0", VA = "0x1805C9EF0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x5CC4A0", Offset = "0x5CAEA0", VA = "0x1805CC4A0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x5C9F30", Offset = "0x5C8930", VA = "0x1805C9F30")]
		private void Bananas()
		{
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x5CB280", Offset = "0x5C9C80", VA = "0x1805CB280")]
		private void InitializeItemLoaders()
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x5CB5E0", Offset = "0x5C9FE0", VA = "0x1805CB5E0")]
		private void InitializeObjectLoaders()
		{
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x5CB420", Offset = "0x5C9E20", VA = "0x1805CB420")]
		private void InitializeNPCLoaders()
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x5CD640", Offset = "0x5CC040", VA = "0x1805CD640")]
		public void Update()
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x5CBBD0", Offset = "0x5CA5D0", VA = "0x1805CBBD0")]
		public void QueueLoadRequest(LoadRequest request)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x5CA820", Offset = "0x5C9220", VA = "0x1805CA820")]
		public void DequeueLoadRequest(LoadRequest request)
		{
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x5CACA0", Offset = "0x5C96A0", VA = "0x1805CACA0")]
		public ItemLoader GetItemLoader(string itemType)
		{
			return null;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x5CB140", Offset = "0x5C9B40", VA = "0x1805CB140")]
		public BuildableItemLoader GetObjectLoader(string objectType)
		{
			return null;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x5CADE0", Offset = "0x5C97E0", VA = "0x1805CADE0")]
		public LegacyNPCLoader GetLegacyNPCLoader(string npcType)
		{
			return null;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x5CB000", Offset = "0x5C9A00", VA = "0x1805CB000")]
		public NPCLoader GetNPCLoader(string npcType)
		{
			return null;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x5CAF20", Offset = "0x5C9920", VA = "0x1805CAF20")]
		public string GetLoadStatusText()
		{
			return null;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x5CC120", Offset = "0x5CAB20", VA = "0x1805CC120")]
		public void StartGame(SaveInfo info, bool allowLoadStacking = false, bool allowSaveBackup = true)
		{
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x5CBA90", Offset = "0x5CA490", VA = "0x1805CBA90")]
		public void LoadTutorialAsClient()
		{
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x5CB8B0", Offset = "0x5CA2B0", VA = "0x1805CB8B0")]
		public void LoadAsClient(string steamId64)
		{
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x5CC420", Offset = "0x5CAE20", VA = "0x1805CC420")]
		private void StartLoadErrorAutosubmit()
		{
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x5CC110", Offset = "0x5CAB10", VA = "0x1805CC110")]
		public void SetWaitingForHostLoad()
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x5CBA00", Offset = "0x5CA400", VA = "0x1805CBA00")]
		public void LoadLastSave()
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x5CA340", Offset = "0x5C8D40", VA = "0x1805CA340")]
		private void CleanUp()
		{
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x5CA880", Offset = "0x5C9280", VA = "0x1805CA880")]
		public void ExitToMenu([Optional] SaveInfo autoLoadSave, [Optional] MainMenuPopup.Data mainMenuPopup, bool preventLeaveLobby = false)
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x5CCA90", Offset = "0x5CB490", VA = "0x1805CCA90")]
		public static bool TryLoadSaveInfo(string saveFolderPath, int saveSlotIndex, out SaveInfo saveInfo, bool requireGameFile = false)
		{
			return default(bool);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x5CBC80", Offset = "0x5CA680", VA = "0x1805CBC80")]
		public void RefreshSaveInfo()
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x5CD780", Offset = "0x5CC180", VA = "0x1805CD780")]
		public LoadManager()
		{
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x5CD460", Offset = "0x5CBE60", VA = "0x1805CD460")]
		[CompilerGenerated]
		internal static void <LoadAsClient>g__PlayerSpawned|67_5()
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x5CD5D0", Offset = "0x5CBFD0", VA = "0x1805CD5D0")]
		[CompilerGenerated]
		private IEnumerator <StartLoadErrorAutosubmit>g__Wait|68_0()
		{
			return null;
		}

		// Token: 0x0400130E RID: 4878
		[Token(Token = "0x400130E")]
		public const int LOADS_PER_FRAME = 50;

		// Token: 0x0400130F RID: 4879
		[Token(Token = "0x400130F")]
		public const bool DEBUG = false;

		// Token: 0x04001310 RID: 4880
		[Token(Token = "0x4001310")]
		public const float LOAD_ERROR_TIMEOUT = 90f;

		// Token: 0x04001311 RID: 4881
		[Token(Token = "0x4001311")]
		public const float NETWORK_TIMEOUT = 30f;

		// Token: 0x04001312 RID: 4882
		[Token(Token = "0x4001312")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LoadHistory;

		// Token: 0x04001313 RID: 4883
		[Token(Token = "0x4001313")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static SaveInfo[] SaveGames;

		// Token: 0x04001314 RID: 4884
		[Token(Token = "0x4001314")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static SaveInfo LastPlayedGame;

		// Token: 0x0400131D RID: 4893
		[Token(Token = "0x400131D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<LoadRequest> loadRequests;

		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<ItemLoader> ItemLoaders;

		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x400131F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<BuildableItemLoader> ObjectLoaders;

		// Token: 0x04001320 RID: 4896
		[Token(Token = "0x4001320")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<LegacyNPCLoader> LegacyNPCLoaders;

		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x4001321")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<NPCLoader> NPCLoaders;

		// Token: 0x04001322 RID: 4898
		[Token(Token = "0x4001322")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent onPreSceneChange;

		// Token: 0x04001323 RID: 4899
		[Token(Token = "0x4001323")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent onPreLoad;

		// Token: 0x04001324 RID: 4900
		[Token(Token = "0x4001324")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent onLoadComplete;

		// Token: 0x04001325 RID: 4901
		[Token(Token = "0x4001325")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent onSaveInfoLoaded;

		// Token: 0x0200038F RID: 911
		[Token(Token = "0x200038F")]
		public enum ELoadStatus
		{
			// Token: 0x04001327 RID: 4903
			[Token(Token = "0x4001327")]
			None,
			// Token: 0x04001328 RID: 4904
			[Token(Token = "0x4001328")]
			LoadingScene,
			// Token: 0x04001329 RID: 4905
			[Token(Token = "0x4001329")]
			Initializing,
			// Token: 0x0400132A RID: 4906
			[Token(Token = "0x400132A")]
			LoadingData,
			// Token: 0x0400132B RID: 4907
			[Token(Token = "0x400132B")]
			SpawningPlayer,
			// Token: 0x0400132C RID: 4908
			[Token(Token = "0x400132C")]
			WaitingForHost
		}
	}
}
