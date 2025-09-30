using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000804 RID: 2052
	[Token(Token = "0x2000804")]
	public class Cartel : NetworkSingleton<Cartel>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x0000F300 File Offset: 0x0000D500
		// (set) Token: 0x0600382F RID: 14383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000800")]
		public ECartelStatus Status
		{
			[Token(Token = "0x600382E")]
			[Address(RVA = "0x548860", Offset = "0x547260", VA = "0x180548860")]
			[CompilerGenerated]
			get
			{
				return ECartelStatus.Unknown;
			}
			[Token(Token = "0x600382F")]
			[Address(RVA = "0x63DAA0", Offset = "0x63C4A0", VA = "0x18063DAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x0000F318 File Offset: 0x0000D518
		// (set) Token: 0x06003831 RID: 14385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000801")]
		public int HoursSinceStatusChange
		{
			[Token(Token = "0x6003830")]
			[Address(RVA = "0x703460", Offset = "0x701E60", VA = "0x180703460")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003831")]
			[Address(RVA = "0x703500", Offset = "0x701F00", VA = "0x180703500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000802")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003832")]
			[Address(RVA = "0x7E3FA0", Offset = "0x7E29A0", VA = "0x1807E3FA0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000803")]
		public string SaveFileName
		{
			[Token(Token = "0x6003833")]
			[Address(RVA = "0x7E3F70", Offset = "0x7E2970", VA = "0x1807E3F70", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000804")]
		public Loader Loader
		{
			[Token(Token = "0x6003834")]
			[Address(RVA = "0x63D960", Offset = "0x63C360", VA = "0x18063D960", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x17000805")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003835")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003837 RID: 14391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000806")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003836")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003837")]
			[Address(RVA = "0x63DA80", Offset = "0x63C480", VA = "0x18063DA80", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003839 RID: 14393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000807")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003838")]
			[Address(RVA = "0x708B20", Offset = "0x707520", VA = "0x180708B20", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003839")]
			[Address(RVA = "0x708B30", Offset = "0x707530", VA = "0x180708B30", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x0000F348 File Offset: 0x0000D548
		// (set) Token: 0x0600383B RID: 14395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000808")]
		public bool HasChanged
		{
			[Token(Token = "0x600383A")]
			[Address(RVA = "0x659820", Offset = "0x658220", VA = "0x180659820", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600383B")]
			[Address(RVA = "0x659A20", Offset = "0x658420", VA = "0x180659A20", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x17000809")]
		public int LoadOrder
		{
			[Token(Token = "0x600383C")]
			[Address(RVA = "0x752390", Offset = "0x750D90", VA = "0x180752390", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383D")]
		[Address(RVA = "0x7E3C60", Offset = "0x7E2660", VA = "0x1807E3C60", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x7E3210", Offset = "0x7E1C10", VA = "0x1807E3210", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x702C00", Offset = "0x701600", VA = "0x180702C00")]
		private void HourPass()
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x7E2DB0", Offset = "0x7E17B0", VA = "0x1807E2DB0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x7E2A50", Offset = "0x7E1450", VA = "0x1807E2A50", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x7E2E40", Offset = "0x7E1840", VA = "0x1807E2E40")]
		public void Load(CartelData data)
		{
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x7E3700", Offset = "0x7E2100", VA = "0x1807E3700")]
		[ServerRpc(RequireOwnership = false)]
		public void SetStatus_Server(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x7E39C0", Offset = "0x7E23C0", VA = "0x1807E39C0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetStatus(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x7E3E50", Offset = "0x7E2850", VA = "0x1807E3E50")]
		public Cartel()
		{
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003846")]
		[Address(RVA = "0x7E30D0", Offset = "0x7E1AD0", VA = "0x1807E30D0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003847")]
		[Address(RVA = "0x7E3080", Offset = "0x7E1A80", VA = "0x1807E3080", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x7E3700", Offset = "0x7E2100", VA = "0x1807E3700")]
		private void RpcWriter___Server_SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x7E3390", Offset = "0x7E1D90", VA = "0x1807E3390")]
		public void RpcLogic___SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x7E3450", Offset = "0x7E1E50", VA = "0x1807E3450")]
		private void RpcReader___Server_SetStatus_Server_2366206100(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x7E3590", Offset = "0x7E1F90", VA = "0x1807E3590")]
		private void RpcWriter___Observers_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x7E3270", Offset = "0x7E1C70", VA = "0x1807E3270")]
		public void RpcLogic___SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384E")]
		[Address(RVA = "0x7E33B0", Offset = "0x7E1DB0", VA = "0x1807E33B0")]
		private void RpcReader___Observers_SetStatus_3666943613(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384F")]
		[Address(RVA = "0x7E3860", Offset = "0x7E2260", VA = "0x1807E3860")]
		private void RpcWriter___Target_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003850")]
		[Address(RVA = "0x7E34F0", Offset = "0x7E1EF0", VA = "0x1807E34F0")]
		private void RpcReader___Target_SetStatus_3666943613(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003851")]
		[Address(RVA = "0x7E29E0", Offset = "0x7E13E0", VA = "0x1807E29E0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04002722 RID: 10018
		[Token(Token = "0x4002722")]
		[FieldOffset(Offset = "0x128")]
		public bool TEST_MODE;

		// Token: 0x04002723 RID: 10019
		[Token(Token = "0x4002723")]
		[FieldOffset(Offset = "0x130")]
		[Header("References")]
		public CartelActivities Activities;

		// Token: 0x04002724 RID: 10020
		[Token(Token = "0x4002724")]
		[FieldOffset(Offset = "0x138")]
		public CartelInfluence Influence;

		// Token: 0x04002725 RID: 10021
		[Token(Token = "0x4002725")]
		[FieldOffset(Offset = "0x140")]
		public GoonPool GoonPool;

		// Token: 0x04002726 RID: 10022
		[Token(Token = "0x4002726")]
		[FieldOffset(Offset = "0x148")]
		public CartelDealManager DealManager;

		// Token: 0x04002727 RID: 10023
		[Token(Token = "0x4002727")]
		[FieldOffset(Offset = "0x150")]
		public Action<ECartelStatus, ECartelStatus> OnStatusChange;

		// Token: 0x04002728 RID: 10024
		[Token(Token = "0x4002728")]
		[FieldOffset(Offset = "0x158")]
		private CartelLoader loader;

		// Token: 0x0400272D RID: 10029
		[Token(Token = "0x400272D")]
		[FieldOffset(Offset = "0x178")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted;

		// Token: 0x0400272E RID: 10030
		[Token(Token = "0x400272E")]
		[FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted;
	}
}
