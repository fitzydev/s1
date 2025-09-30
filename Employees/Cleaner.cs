using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x020005B9 RID: 1465
	[Token(Token = "0x20005B9")]
	public class Cleaner : Employee, IConfigurable
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D6")]
		public TrashGrabberInstance trashGrabberInstance
		{
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x68D410", Offset = "0x68BE10", VA = "0x18068D410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D7")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x68D3E0", Offset = "0x68BDE0", VA = "0x18068D3E0", Slot = "125")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D8")]
		protected CleanerConfiguration configuration
		{
			[Token(Token = "0x600225C")]
			[Address(RVA = "0x68D3E0", Offset = "0x68BDE0", VA = "0x18068D3E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x68D3F0", Offset = "0x68BDF0", VA = "0x18068D3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D9")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x600225E")]
			[Address(RVA = "0x689EC0", Offset = "0x6888C0", VA = "0x180689EC0", Slot = "126")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x170005DA")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x600225F")]
			[Address(RVA = "0x68F690", Offset = "0x68E090", VA = "0x18068F690", Slot = "127")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DB")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6002260")]
			[Address(RVA = "0x689F10", Offset = "0x688910", VA = "0x180689F10", Slot = "128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002261")]
			[Address(RVA = "0x68F6B0", Offset = "0x68E0B0", VA = "0x18068F6B0", Slot = "129")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DC")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6002262")]
			[Address(RVA = "0x68F6A0", Offset = "0x68E0A0", VA = "0x18068F6A0", Slot = "130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002263")]
			[Address(RVA = "0x68E740", Offset = "0x68D140", VA = "0x18068E740", Slot = "131")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x68EAF0", Offset = "0x68D4F0", VA = "0x18068EAF0", Slot = "145")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DD")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6002265")]
			[Address(RVA = "0x689F00", Offset = "0x688900", VA = "0x180689F00", Slot = "133")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DE")]
		public Transform Transform
		{
			[Token(Token = "0x6002266")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "134")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DF")]
		public Transform UIPoint
		{
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x68D3D0", Offset = "0x68BDD0", VA = "0x18068D3D0", Slot = "135")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x170005E0")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E1")]
		public Property ParentProperty
		{
			[Token(Token = "0x6002269")]
			[Address(RVA = "0x689EF0", Offset = "0x6888F0", VA = "0x180689EF0", Slot = "138")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x68D580", Offset = "0x68BF80", VA = "0x18068D580", Slot = "109")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x688890", Offset = "0x687290", VA = "0x180688890", Slot = "110")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226C")]
		[Address(RVA = "0x68E710", Offset = "0x68D110", VA = "0x18068E710", Slot = "115")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x68DA50", Offset = "0x68C450", VA = "0x18068DA50", Slot = "116")]
		protected override void Fire()
		{
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x68E4F0", Offset = "0x68CEF0", VA = "0x18068E4F0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x68E990", Offset = "0x68D390", VA = "0x18068E990", Slot = "146")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x68E060", Offset = "0x68CA60", VA = "0x18068E060", Slot = "72")]
		protected override void MinPass()
		{
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x68ECE0", Offset = "0x68D6E0", VA = "0x18068ECE0")]
		private void TryStartNewTask()
		{
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x68DB70", Offset = "0x68C570", VA = "0x18068DB70")]
		private TrashContainerItem GetFirstNonFullBin(TrashContainerItem[] bins)
		{
			return null;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002273")]
		[Address(RVA = "0x68EC20", Offset = "0x68D620", VA = "0x18068EC20", Slot = "121")]
		public override void SetIdle(bool idle)
		{
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x68DF60", Offset = "0x68C960", VA = "0x18068DF60")]
		private TrashContainerItem[] GetTrashContainersOrderedByDistance()
		{
			return null;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x68DC80", Offset = "0x68C680", VA = "0x18068DC80", Slot = "119")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002276")]
		[Address(RVA = "0x68D900", Offset = "0x68C300", VA = "0x18068D900")]
		private void EnsureTrashGrabberInInventory()
		{
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x6002277")]
		[Address(RVA = "0x68D4F0", Offset = "0x68BEF0", VA = "0x18068D4F0")]
		private bool AnyWorkInProgress()
		{
			return default(bool);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x6002278")]
		[Address(RVA = "0x68E030", Offset = "0x68CA30", VA = "0x18068E030")]
		private int GetTrashGrabberAmount()
		{
			return 0;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002279")]
		[Address(RVA = "0x68D640", Offset = "0x68C040", VA = "0x18068D640", Slot = "139")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x68D870", Offset = "0x68C270", VA = "0x18068D870", Slot = "140")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x68DCA0", Offset = "0x68C6A0", VA = "0x18068DCA0", Slot = "94")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x68DED0", Offset = "0x68C8D0", VA = "0x18068DED0", Slot = "95")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227D")]
		[Address(RVA = "0x68F630", Offset = "0x68E030", VA = "0x18068F630", Slot = "96")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227E")]
		[Address(RVA = "0x68D380", Offset = "0x68BD80", VA = "0x18068D380")]
		public Cleaner()
		{
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x68E340", Offset = "0x68CD40", VA = "0x18068E340", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002281")]
		[Address(RVA = "0x68E2C0", Offset = "0x68CCC0", VA = "0x18068E2C0", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002283")]
		[Address(RVA = "0x68E860", Offset = "0x68D260", VA = "0x18068E860")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002284")]
		[Address(RVA = "0x68E740", Offset = "0x68D140", VA = "0x18068E740", Slot = "147")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002285")]
		[Address(RVA = "0x68E7E0", Offset = "0x68D1E0", VA = "0x18068E7E0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002287 RID: 8839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E2")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6002286")]
			[Address(RVA = "0x68F6A0", Offset = "0x68E0A0", VA = "0x18068F6A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x68F6D0", Offset = "0x68E0D0", VA = "0x18068F6D0")]
			set
			{
			}
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x6002288")]
		[Address(RVA = "0x68E650", Offset = "0x68D050", VA = "0x18068E650", Slot = "148")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Cleaner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002289")]
		[Address(RVA = "0x6859C0", Offset = "0x6843C0", VA = "0x1806859C0", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x04001B62 RID: 7010
		[Token(Token = "0x4001B62")]
		public const int MAX_ASSIGNED_BINS = 3;

		// Token: 0x04001B63 RID: 7011
		[Token(Token = "0x4001B63")]
		[FieldOffset(Offset = "0x380")]
		public TrashGrabberDefinition TrashGrabberDef;

		// Token: 0x04001B64 RID: 7012
		[Token(Token = "0x4001B64")]
		[FieldOffset(Offset = "0x388")]
		[Header("References")]
		public PickUpTrashBehaviour PickUpTrashBehaviour;

		// Token: 0x04001B65 RID: 7013
		[Token(Token = "0x4001B65")]
		[FieldOffset(Offset = "0x390")]
		public EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour;

		// Token: 0x04001B66 RID: 7014
		[Token(Token = "0x4001B66")]
		[FieldOffset(Offset = "0x398")]
		public BagTrashCanBehaviour BagTrashCanBehaviour;

		// Token: 0x04001B67 RID: 7015
		[Token(Token = "0x4001B67")]
		[FieldOffset(Offset = "0x3A0")]
		public DisposeTrashBagBehaviour DisposeTrashBagBehaviour;

		// Token: 0x04001B68 RID: 7016
		[Token(Token = "0x4001B68")]
		[FieldOffset(Offset = "0x3A8")]
		public Sprite typeIcon;

		// Token: 0x04001B69 RID: 7017
		[Token(Token = "0x4001B69")]
		[FieldOffset(Offset = "0x3B0")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001B6A RID: 7018
		[Token(Token = "0x4001B6A")]
		[FieldOffset(Offset = "0x3B8")]
		[Header("UI")]
		public CleanerUIElement WorldspaceUIPrefab;

		// Token: 0x04001B6B RID: 7019
		[Token(Token = "0x4001B6B")]
		[FieldOffset(Offset = "0x3C0")]
		public Transform uiPoint;

		// Token: 0x04001B70 RID: 7024
		[Token(Token = "0x4001B70")]
		[FieldOffset(Offset = "0x3E8")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001B71 RID: 7025
		[Token(Token = "0x4001B71")]
		[FieldOffset(Offset = "0x3F0")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B72 RID: 7026
		[Token(Token = "0x4001B72")]
		[FieldOffset(Offset = "0x3F1")]
		private bool NetworkInitialize__LateScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted;
	}
}
