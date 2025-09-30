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
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CC3 RID: 3267
	[Token(Token = "0x2000CC3")]
	public class PlaceableStorageEntity : GridItem, ITransitEntity, IStorageEntity, IUsable
	{
		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE9")]
		public Transform storedItemContainer
		{
			[Token(Token = "0x6005C4F")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C51 RID: 23633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CEA")]
		public Dictionary<StoredItem, Employee> reservedItems
		{
			[Token(Token = "0x6005C50")]
			[Address(RVA = "0x9DC5E0", Offset = "0x9DAFE0", VA = "0x1809DC5E0", Slot = "94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C51")]
			[Address(RVA = "0xA4E830", Offset = "0xA4D230", VA = "0x180A4E830")]
			set
			{
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEB")]
		public string Name
		{
			[Token(Token = "0x6005C52")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C54 RID: 23636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CEC")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6005C53")]
			[Address(RVA = "0x62FC70", Offset = "0x62E670", VA = "0x18062FC70", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C54")]
			[Address(RVA = "0xA4E800", Offset = "0xA4D200", VA = "0x180A4E800", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06005C55 RID: 23637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C56 RID: 23638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CED")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6005C55")]
			[Address(RVA = "0x9DC5F0", Offset = "0x9DAFF0", VA = "0x1809DC5F0", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C56")]
			[Address(RVA = "0x9DC610", Offset = "0x9DB010", VA = "0x1809DC610", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06005C57 RID: 23639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEE")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6005C57")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "76")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06005C58 RID: 23640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C59 RID: 23641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CEF")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6005C58")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0", Slot = "107")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C59")]
			[Address(RVA = "0xA4D8E0", Offset = "0xA4C2E0", VA = "0x180A4D8E0", Slot = "108")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C5B RID: 23643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF0")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005C5A")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0", Slot = "109")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C5B")]
			[Address(RVA = "0xA4D980", Offset = "0xA4C380", VA = "0x180A4D980", Slot = "110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06005C5C RID: 23644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF1")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6005C5C")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0", Slot = "77")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06005C5D RID: 23645 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x17000CF2")]
		public bool Selectable
		{
			[Token(Token = "0x6005C5D")]
			[Address(RVA = "0xA4E7F0", Offset = "0xA4D1F0", VA = "0x180A4E7F0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06005C5E RID: 23646 RVA: 0x000165D8 File Offset: 0x000147D8
		// (set) Token: 0x06005C5F RID: 23647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF3")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005C5E")]
			[Address(RVA = "0xA4E7E0", Offset = "0xA4D1E0", VA = "0x180A4E7E0", Slot = "79")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C5F")]
			[Address(RVA = "0xA4E820", Offset = "0xA4D220", VA = "0x180A4E820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C60")]
		[Address(RVA = "0xA4E450", Offset = "0xA4CE50", VA = "0x180A4E450", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0xA4CDC0", Offset = "0xA4B7C0", VA = "0x180A4CDC0", Slot = "95")]
		public List<StoredItem> GetStoredItems()
		{
			return null;
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C62")]
		[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190", Slot = "96")]
		public List<StorageGrid> GetStorageGrids()
		{
			return null;
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C63")]
		[Address(RVA = "0xA4CAC0", Offset = "0xA4B4C0", VA = "0x180A4CAC0")]
		[ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C64")]
		[Address(RVA = "0xA4C950", Offset = "0xA4B350", VA = "0x180A4C950")]
		[ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C65")]
		[Address(RVA = "0xA4E320", Offset = "0xA4CD20", VA = "0x180A4E320", Slot = "111")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C66")]
		[Address(RVA = "0xA4E1F0", Offset = "0xA4CBF0", VA = "0x180A4E1F0", Slot = "112")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x000165F0 File Offset: 0x000147F0
		[Token(Token = "0x6005C67")]
		[Address(RVA = "0xA4C850", Offset = "0xA4B250", VA = "0x180A4C850", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C68")]
		[Address(RVA = "0xA4CC80", Offset = "0xA4B680", VA = "0x180A4CC80", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C69")]
		[Address(RVA = "0xA4E640", Offset = "0xA4D040", VA = "0x180A4E640")]
		public PlaceableStorageEntity()
		{
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0xA4CED0", Offset = "0xA4B8D0", VA = "0x180A4CED0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0xA4CE60", Offset = "0xA4B860", VA = "0x180A4CE60", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0xA4DE00", Offset = "0xA4C800", VA = "0x180A4DE00")]
		private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0xA4D320", Offset = "0xA4BD20", VA = "0x180A4D320")]
		public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0xA4DA20", Offset = "0xA4C420", VA = "0x180A4DA20")]
		private void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C70")]
		[Address(RVA = "0xA4C950", Offset = "0xA4B350", VA = "0x180A4C950")]
		private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C71")]
		[Address(RVA = "0xA4D730", Offset = "0xA4C130", VA = "0x180A4D730")]
		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C72")]
		[Address(RVA = "0xA4DB00", Offset = "0xA4C500", VA = "0x180A4DB00")]
		private void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C73")]
		[Address(RVA = "0xA4E0C0", Offset = "0xA4CAC0", VA = "0x180A4E0C0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C74")]
		[Address(RVA = "0xA4D980", Offset = "0xA4C380", VA = "0x180A4D980", Slot = "113")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C75")]
		[Address(RVA = "0xA4DD80", Offset = "0xA4C780", VA = "0x180A4DD80")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C76")]
		[Address(RVA = "0xA4DF90", Offset = "0xA4C990", VA = "0x180A4DF90")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C77")]
		[Address(RVA = "0xA4D8E0", Offset = "0xA4C2E0", VA = "0x180A4D8E0", Slot = "114")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C78")]
		[Address(RVA = "0xA4DD00", Offset = "0xA4C700", VA = "0x180A4DD00")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06005C79 RID: 23673 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C7A RID: 23674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF4")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6005C79")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C7A")]
			[Address(RVA = "0xA4E850", Offset = "0xA4D250", VA = "0x180A4E850")]
			set
			{
			}
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x00016608 File Offset: 0x00014808
		[Token(Token = "0x6005C7B")]
		[Address(RVA = "0xA4D1F0", Offset = "0xA4BBF0", VA = "0x180A4D1F0", Slot = "115")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.PlaceableStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06005C7C RID: 23676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C7D RID: 23677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF5")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005C7C")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C7D")]
			[Address(RVA = "0xA4E910", Offset = "0xA4D310", VA = "0x180A4E910")]
			set
			{
			}
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x9C4910", Offset = "0x9C3310", VA = "0x1809C4910", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04004324 RID: 17188
		[Token(Token = "0x4004324")]
		[FieldOffset(Offset = "0x218")]
		[Header("Reference")]
		[SerializeField]
		protected Transform _storedItemContainer;

		// Token: 0x04004325 RID: 17189
		[Token(Token = "0x4004325")]
		[FieldOffset(Offset = "0x220")]
		public StorageEntity StorageEntity;

		// Token: 0x04004326 RID: 17190
		[Token(Token = "0x4004326")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		protected List<StorageGrid> storageGrids;

		// Token: 0x04004327 RID: 17191
		[Token(Token = "0x4004327")]
		[FieldOffset(Offset = "0x230")]
		public Transform[] accessPoints;

		// Token: 0x04004328 RID: 17192
		[Token(Token = "0x4004328")]
		[FieldOffset(Offset = "0x238")]
		protected Dictionary<StoredItem, Employee> _reservedItems;

		// Token: 0x0400432F RID: 17199
		[Token(Token = "0x400432F")]
		[FieldOffset(Offset = "0x268")]
		private List<string> completedJobs;

		// Token: 0x04004330 RID: 17200
		[Token(Token = "0x4004330")]
		[FieldOffset(Offset = "0x270")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04004331 RID: 17201
		[Token(Token = "0x4004331")]
		[FieldOffset(Offset = "0x278")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04004332 RID: 17202
		[Token(Token = "0x4004332")]
		[FieldOffset(Offset = "0x280")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x04004333 RID: 17203
		[Token(Token = "0x4004333")]
		[FieldOffset(Offset = "0x281")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PlaceableStorageEntityAssembly-CSharp.dll_Excuted;
	}
}
