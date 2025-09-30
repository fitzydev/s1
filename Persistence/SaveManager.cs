using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public class SaveManager : PersistentSingleton<SaveManager>
	{
		// Token: 0x060014EA RID: 5354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x5D3F70", Offset = "0x5D2970", VA = "0x1805D3F70")]
		public static void ReportSaveError()
		{
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00008700 File Offset: 0x00006900
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F1")]
		public bool AccessPermissionIssueDetected
		{
			[Token(Token = "0x60014EB")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60014EC")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00008718 File Offset: 0x00006918
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F2")]
		public bool IsSaving
		{
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x5CD9E0", Offset = "0x5CC3E0", VA = "0x1805CD9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x5CD9F0", Offset = "0x5CC3F0", VA = "0x1805CD9F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00008730 File Offset: 0x00006930
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F3")]
		public float SecondsSinceLastSave
		{
			[Token(Token = "0x60014EF")]
			[Address(RVA = "0x4A3730", Offset = "0x4A2130", VA = "0x1804A3730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60014F0")]
			[Address(RVA = "0x5CDA10", Offset = "0x5CC410", VA = "0x1805CDA10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F4")]
		public string PlayersSavePath
		{
			[Token(Token = "0x60014F1")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014F2")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F5")]
		public string IndividualSavesContainerPath
		{
			[Token(Token = "0x60014F3")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014F4")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F6")]
		public string BackupFolderPath
		{
			[Token(Token = "0x60014F5")]
			[Address(RVA = "0x5D4A90", Offset = "0x5D3490", VA = "0x1805D4A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F7")]
		public string SaveName
		{
			[Token(Token = "0x60014F6")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60014F7")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x5D26D0", Offset = "0x5D10D0", VA = "0x1805D26D0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x5D4520", Offset = "0x5D2F20", VA = "0x1805D4520", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x5D29A0", Offset = "0x5D13A0", VA = "0x1805D29A0")]
		public void CheckSaveFolderInitialized()
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x5D3BF0", Offset = "0x5D25F0", VA = "0x1805D3BF0")]
		public static bool HasWritePermissionOnDir(string path)
		{
			return default(bool);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x5D46A0", Offset = "0x5D30A0", VA = "0x1805D46A0")]
		private void Update()
		{
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x5D3790", Offset = "0x5D2190", VA = "0x1805D3790")]
		public void DelayedSave()
		{
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x5D4070", Offset = "0x5D2A70", VA = "0x1805D4070")]
		public void Save()
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x5D4100", Offset = "0x5D2B00", VA = "0x1805D4100")]
		public void Save(string saveFolderPath)
		{
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x5D2D30", Offset = "0x5D1730", VA = "0x1805D2D30")]
		private void ClearBaseLevelOutdatedSaves(string saveFolderPath)
		{
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x5D3270", Offset = "0x5D1C70", VA = "0x1805D3270")]
		public void CompleteSaveable(ISaveable saveable)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x5D3210", Offset = "0x5D1C10", VA = "0x1805D3210")]
		public void ClearCompletedSaveable(ISaveable saveable)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x5D3340", Offset = "0x5D1D40", VA = "0x1805D3340")]
		public void CreateSaveBackup(SaveInfo saveInfo)
		{
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x5D3E20", Offset = "0x5D2820", VA = "0x1805D3E20")]
		public void RegisterSaveable(ISaveable saveable)
		{
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x5D3D70", Offset = "0x5D2770", VA = "0x1805D3D70")]
		public void QueueSaveRequest(SaveRequest request)
		{
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x5D37E0", Offset = "0x5D21E0", VA = "0x1805D37E0")]
		public void DequeueSaveRequest(SaveRequest request)
		{
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x5D4630", Offset = "0x5D3030", VA = "0x1805D4630")]
		public static string StripExtensions(string filePath)
		{
			return null;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x5D3CB0", Offset = "0x5D26B0", VA = "0x1805D3CB0")]
		public static string MakeFileSafe(string fileName)
		{
			return null;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x5D3A30", Offset = "0x5D2430", VA = "0x1805D3A30")]
		public static float GetVersionNumber(string version)
		{
			return 0f;
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x5D2C90", Offset = "0x5D1690", VA = "0x1805D2C90")]
		private void Clean()
		{
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150B")]
		[Address(RVA = "0x5D3840", Offset = "0x5D2240", VA = "0x1805D3840")]
		public void DisablePlayTutorial(SaveInfo info)
		{
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x5D3FB0", Offset = "0x5D29B0", VA = "0x1805D3FB0")]
		public static string SanitizeFileName(string fileName)
		{
			return null;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x5D4890", Offset = "0x5D3290", VA = "0x1805D4890")]
		public SaveManager()
		{
		}

		// Token: 0x04001376 RID: 4982
		[Token(Token = "0x4001376")]
		public const string MAIN_SCENE_NAME = "Main";

		// Token: 0x04001377 RID: 4983
		[Token(Token = "0x4001377")]
		public const string MENU_SCENE_NAME = "Menu";

		// Token: 0x04001378 RID: 4984
		[Token(Token = "0x4001378")]
		public const string TUTORIAL_SCENE_NAME = "Tutorial";

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		public const int SAVES_PER_FRAME = 15;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		public const string SAVE_FILE_EXTENSION = ".json";

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		public const int SAVE_SLOT_COUNT = 5;

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		public const string SAVE_GAME_PREFIX = "SaveGame_";

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		public const bool DEBUG = false;

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		public const bool PRETTY_PRINT = true;

		// Token: 0x0400137F RID: 4991
		[Token(Token = "0x400137F")]
		[FieldOffset(Offset = "0x0")]
		public static bool SaveError;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0x48")]
		public List<ISaveable> Saveables;

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		[FieldOffset(Offset = "0x50")]
		public List<IBaseSaveable> BaseSaveables;

		// Token: 0x04001388 RID: 5000
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public List<string> ApprovedBaseLevelPaths;

		// Token: 0x04001389 RID: 5001
		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0x60")]
		protected List<ISaveable> CompletedSaveables;

		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0x68")]
		protected List<SaveRequest> QueuedSaveRequests;

		// Token: 0x0400138B RID: 5003
		[Token(Token = "0x400138B")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public RectTransform WriteIssueDisplay;

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		[FieldOffset(Offset = "0x78")]
		[Header("Events")]
		public UnityEvent onSaveStart;

		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onSaveComplete;

		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		[FieldOffset(Offset = "0x88")]
		private bool saveFolderInitialized;
	}
}
