using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	public class GameManager : NetworkSingleton<GameManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x17000755")]
		public static bool IS_TUTORIAL
		{
			[Token(Token = "0x60032AE")]
			[Address(RVA = "0x778090", Offset = "0x776A90", VA = "0x180778090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x0000DF68 File Offset: 0x0000C168
		[Token(Token = "0x17000756")]
		public static int Seed
		{
			[Token(Token = "0x60032AF")]
			[Address(RVA = "0x7781E0", Offset = "0x776BE0", VA = "0x1807781E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000757")]
		public Sprite OrganisationLogo
		{
			[Token(Token = "0x60032B0")]
			[Address(RVA = "0x672D40", Offset = "0x671740", VA = "0x180672D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032B1")]
			[Address(RVA = "0x672DD0", Offset = "0x6717D0", VA = "0x180672DD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x17000758")]
		public bool IsTutorial
		{
			[Token(Token = "0x60032B2")]
			[Address(RVA = "0x778100", Offset = "0x776B00", VA = "0x180778100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000759")]
		public string SaveFolderName
		{
			[Token(Token = "0x60032B3")]
			[Address(RVA = "0x7781B0", Offset = "0x776BB0", VA = "0x1807781B0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075A")]
		public string SaveFileName
		{
			[Token(Token = "0x60032B4")]
			[Address(RVA = "0x778180", Offset = "0x776B80", VA = "0x180778180", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075B")]
		public Loader Loader
		{
			[Token(Token = "0x60032B5")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x1700075C")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60032B6")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060032B7 RID: 12983 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032B8 RID: 12984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075D")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60032B7")]
			[Address(RVA = "0x708B20", Offset = "0x707520", VA = "0x180708B20", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032B8")]
			[Address(RVA = "0x708B30", Offset = "0x707530", VA = "0x180708B30", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032BA RID: 12986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075E")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60032B9")]
			[Address(RVA = "0x73CAF0", Offset = "0x73B4F0", VA = "0x18073CAF0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032BA")]
			[Address(RVA = "0x73CB00", Offset = "0x73B500", VA = "0x18073CB00", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		// (set) Token: 0x060032BC RID: 12988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075F")]
		public bool HasChanged
		{
			[Token(Token = "0x60032BB")]
			[Address(RVA = "0x778080", Offset = "0x776A80", VA = "0x180778080", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x7782E0", Offset = "0x776CE0", VA = "0x1807782E0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x17000760")]
		public int LoadOrder
		{
			[Token(Token = "0x60032BD")]
			[Address(RVA = "0x778170", Offset = "0x776B70", VA = "0x180778170", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032BE")]
		[Address(RVA = "0x777360", Offset = "0x775D60", VA = "0x180777360", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032BF")]
		[Address(RVA = "0x777E10", Offset = "0x776810", VA = "0x180777E10", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x777990", Offset = "0x776390", VA = "0x180777990", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x777CB0", Offset = "0x7766B0", VA = "0x180777CB0")]
		[TargetRpc]
		public void SetGameData(NetworkConnection conn, GameData data)
		{
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x777790", Offset = "0x776190", VA = "0x180777790", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x7776E0", Offset = "0x7760E0", VA = "0x1807776E0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C4")]
		[Address(RVA = "0x777820", Offset = "0x776220", VA = "0x180777820")]
		public void Load(GameData data, string path)
		{
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x7773F0", Offset = "0x775DF0", VA = "0x1807773F0")]
		[Button]
		public void EndTutorial(bool natural)
		{
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x777E50", Offset = "0x776850", VA = "0x180777E50")]
		public GameManager()
		{
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x7778F0", Offset = "0x7762F0", VA = "0x1807778F0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C8")]
		[Address(RVA = "0x7778A0", Offset = "0x7762A0", VA = "0x1807778A0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CA")]
		[Address(RVA = "0x777CB0", Offset = "0x7766B0", VA = "0x180777CB0")]
		private void RpcWriter___Target_SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CB")]
		[Address(RVA = "0x777B90", Offset = "0x776590", VA = "0x180777B90")]
		public void RpcLogic___SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CC")]
		[Address(RVA = "0x777C10", Offset = "0x776610", VA = "0x180777C10")]
		private void RpcReader___Target_SetGameData_3076874643(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x777300", Offset = "0x775D00", VA = "0x180777300", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.DevUtilities.GameManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002328 RID: 9000
		[Token(Token = "0x4002328")]
		public const bool IS_DEMO = false;

		// Token: 0x04002329 RID: 9001
		[Token(Token = "0x4002329")]
		[FieldOffset(Offset = "0x0")]
		public static bool IS_BETA;

		// Token: 0x0400232A RID: 9002
		[Token(Token = "0x400232A")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int seed;

		// Token: 0x0400232B RID: 9003
		[Token(Token = "0x400232B")]
		[FieldOffset(Offset = "0x128")]
		public string OrganisationName;

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0x138")]
		public GameSettings Settings;

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0x140")]
		public Transform SpawnPoint;

		// Token: 0x0400232F RID: 9007
		[Token(Token = "0x400232F")]
		[FieldOffset(Offset = "0x148")]
		public Transform NoHomeRespawnPoint;

		// Token: 0x04002330 RID: 9008
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0x150")]
		public Transform Temp;

		// Token: 0x04002331 RID: 9009
		[Token(Token = "0x4002331")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onSettingsLoaded;

		// Token: 0x04002332 RID: 9010
		[Token(Token = "0x4002332")]
		[FieldOffset(Offset = "0x160")]
		private GameDataLoader loader;

		// Token: 0x04002337 RID: 9015
		[Token(Token = "0x4002337")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002338 RID: 9016
		[Token(Token = "0x4002338")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted;
	}
}
