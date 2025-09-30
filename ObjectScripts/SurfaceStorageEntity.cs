using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CCB RID: 3275
	[Token(Token = "0x2000CCB")]
	public class SurfaceStorageEntity : SurfaceItem, IStorageEntity, IUsable
	{
		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFF")]
		public Transform storedItemContainer
		{
			[Token(Token = "0x6005CDE")]
			[Address(RVA = "0x62FFB0", Offset = "0x62E9B0", VA = "0x18062FFB0", Slot = "70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06005CDF RID: 23775 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005CE0 RID: 23776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D00")]
		public Dictionary<StoredItem, Employee> reservedItems
		{
			[Token(Token = "0x6005CDF")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40", Slot = "71")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CE0")]
			[Address(RVA = "0x8A6D70", Offset = "0x8A5770", VA = "0x1808A6D70")]
			set
			{
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005CE2 RID: 23778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D01")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6005CE1")]
			[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190", Slot = "84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CE2")]
			[Address(RVA = "0xA52B50", Offset = "0xA51550", VA = "0x180A52B50", Slot = "85")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06005CE3 RID: 23779 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005CE4 RID: 23780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D02")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005CE3")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0", Slot = "86")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CE4")]
			[Address(RVA = "0xA52BF0", Offset = "0xA515F0", VA = "0x180A52BF0", Slot = "87")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x000166F8 File Offset: 0x000148F8
		[Token(Token = "0x17000D03")]
		public bool Selectable
		{
			[Token(Token = "0x6005CE5")]
			[Address(RVA = "0xA53800", Offset = "0xA52200", VA = "0x180A53800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x00016710 File Offset: 0x00014910
		// (set) Token: 0x06005CE7 RID: 23783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D04")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005CE6")]
			[Address(RVA = "0xA537F0", Offset = "0xA521F0", VA = "0x180A537F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005CE7")]
			[Address(RVA = "0xA53810", Offset = "0xA52210", VA = "0x180A53810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005CE8 RID: 23784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE8")]
		[Address(RVA = "0xA536C0", Offset = "0xA520C0", VA = "0x180A536C0", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06005CE9 RID: 23785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE9")]
		[Address(RVA = "0xA52030", Offset = "0xA50A30", VA = "0x180A52030", Slot = "72")]
		public List<StoredItem> GetStoredItems()
		{
			return null;
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0", Slot = "73")]
		public List<StorageGrid> GetStorageGrids()
		{
			return null;
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEB")]
		[Address(RVA = "0xA51CC0", Offset = "0xA506C0", VA = "0x180A51CC0")]
		[ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0xA51B50", Offset = "0xA50550", VA = "0x180A51B50")]
		[ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CED")]
		[Address(RVA = "0xA53590", Offset = "0xA51F90", VA = "0x180A53590", Slot = "88")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0xA53460", Offset = "0xA51E60", VA = "0x180A53460", Slot = "89")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06005CEF RID: 23791 RVA: 0x00016728 File Offset: 0x00014928
		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0xA51A50", Offset = "0xA50450", VA = "0x180A51A50", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0xA51E80", Offset = "0xA50880", VA = "0x180A51E80", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF1")]
		[Address(RVA = "0xA536D0", Offset = "0xA520D0", VA = "0x180A536D0")]
		public SurfaceStorageEntity()
		{
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF2")]
		[Address(RVA = "0xA52140", Offset = "0xA50B40", VA = "0x180A52140", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF3")]
		[Address(RVA = "0xA520D0", Offset = "0xA50AD0", VA = "0x180A520D0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF4")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF5")]
		[Address(RVA = "0xA53070", Offset = "0xA51A70", VA = "0x180A53070")]
		private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0xA52590", Offset = "0xA50F90", VA = "0x180A52590")]
		public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0xA52C90", Offset = "0xA51690", VA = "0x180A52C90")]
		private void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF8")]
		[Address(RVA = "0xA51B50", Offset = "0xA50550", VA = "0x180A51B50")]
		private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0xA529A0", Offset = "0xA513A0", VA = "0x180A529A0")]
		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0xA52D70", Offset = "0xA51770", VA = "0x180A52D70")]
		private void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0xA53330", Offset = "0xA51D30", VA = "0x180A53330")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0xA52BF0", Offset = "0xA515F0", VA = "0x180A52BF0", Slot = "90")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0xA52FF0", Offset = "0xA519F0", VA = "0x180A52FF0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0xA53200", Offset = "0xA51C00", VA = "0x180A53200")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0xA52B50", Offset = "0xA51550", VA = "0x180A52B50", Slot = "91")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D00")]
		[Address(RVA = "0xA52F70", Offset = "0xA51970", VA = "0x180A52F70")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06005D01 RID: 23809 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005D02 RID: 23810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D05")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6005D01")]
			[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005D02")]
			[Address(RVA = "0xA53820", Offset = "0xA52220", VA = "0x180A53820")]
			set
			{
			}
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x00016740 File Offset: 0x00014940
		[Token(Token = "0x6005D03")]
		[Address(RVA = "0xA52460", Offset = "0xA50E60", VA = "0x180A52460", Slot = "92")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.SurfaceStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06005D04 RID: 23812 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005D05 RID: 23813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D06")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005D04")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005D05")]
			[Address(RVA = "0xA538E0", Offset = "0xA522E0", VA = "0x180A538E0")]
			set
			{
			}
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D06")]
		[Address(RVA = "0xA51A00", Offset = "0xA50400", VA = "0x180A51A00", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04004368 RID: 17256
		[Token(Token = "0x4004368")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Header("Reference")]
		protected Transform _storedItemContainer;

		// Token: 0x04004369 RID: 17257
		[Token(Token = "0x4004369")]
		[FieldOffset(Offset = "0x210")]
		public StorageEntity StorageEntity;

		// Token: 0x0400436A RID: 17258
		[Token(Token = "0x400436A")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		protected List<StorageGrid> storageGrids;

		// Token: 0x0400436B RID: 17259
		[Token(Token = "0x400436B")]
		[FieldOffset(Offset = "0x220")]
		protected Dictionary<StoredItem, Employee> _reservedItems;

		// Token: 0x04004370 RID: 17264
		[Token(Token = "0x4004370")]
		[FieldOffset(Offset = "0x240")]
		private List<string> completedJobs;

		// Token: 0x04004371 RID: 17265
		[Token(Token = "0x4004371")]
		[FieldOffset(Offset = "0x248")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04004372 RID: 17266
		[Token(Token = "0x4004372")]
		[FieldOffset(Offset = "0x250")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04004373 RID: 17267
		[Token(Token = "0x4004373")]
		[FieldOffset(Offset = "0x258")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x04004374 RID: 17268
		[Token(Token = "0x4004374")]
		[FieldOffset(Offset = "0x259")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted;
	}
}
