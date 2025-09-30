using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CBB RID: 3259
	[Token(Token = "0x2000CBB")]
	public class OldMixingStation : GridItem, IUsable, IItemSlotOwner
	{
		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06005B6F RID: 23407 RVA: 0x00016488 File Offset: 0x00014688
		// (set) Token: 0x06005B70 RID: 23408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC7")]
		public bool IsOpen
		{
			[Token(Token = "0x6005B6F")]
			[Address(RVA = "0x84A220", Offset = "0x848C20", VA = "0x18084A220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B70")]
			[Address(RVA = "0x84A260", Offset = "0x848C60", VA = "0x18084A260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06005B71 RID: 23409 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B72 RID: 23410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC8")]
		public MixOperation CurrentMixOperation
		{
			[Token(Token = "0x6005B71")]
			[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B72")]
			[Address(RVA = "0xA447D0", Offset = "0xA431D0", VA = "0x180A447D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B74 RID: 23412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC9")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6005B73")]
			[Address(RVA = "0x9DC5F0", Offset = "0x9DAFF0", VA = "0x1809DC5F0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B74")]
			[Address(RVA = "0x9DC610", Offset = "0x9DB010", VA = "0x1809DC610", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06005B75 RID: 23413 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B76 RID: 23414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCA")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6005B75")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B76")]
			[Address(RVA = "0xA40D00", Offset = "0xA3F700", VA = "0x180A40D00", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06005B77 RID: 23415 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B78 RID: 23416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCB")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005B77")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B78")]
			[Address(RVA = "0xA40DA0", Offset = "0xA3F7A0", VA = "0x180A40DA0", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B79")]
		[Address(RVA = "0xA3F360", Offset = "0xA3DD60", VA = "0x180A3F360", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0xA44610", Offset = "0xA43010", VA = "0x180A44610", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0xA405E0", Offset = "0xA3EFE0", VA = "0x180A405E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0xA3F690", Offset = "0xA3E090", VA = "0x180A3F690", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0xA3FF50", Offset = "0xA3E950", VA = "0x180A3FF50")]
		private void MinPass()
		{
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0xA43390", Offset = "0xA41D90", VA = "0x180A43390")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetMixOperation(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0xA3F900", Offset = "0xA3E300", VA = "0x180A3F900")]
		private void EnableScreen()
		{
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B80")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void UpdateScreen()
		{
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B81")]
		[Address(RVA = "0xA3F7B0", Offset = "0xA3E1B0", VA = "0x180A3F7B0")]
		private void DisableScreen()
		{
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B82")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void CompleteMixOperation()
		{
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x000164A0 File Offset: 0x000146A0
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0xA3F7E0", Offset = "0xA3E1E0", VA = "0x180A3F7E0")]
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0xA3FC90", Offset = "0xA3E690", VA = "0x180A3FC90")]
		public List<ItemInstance> GetIngredients()
		{
			return null;
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0xA40640", Offset = "0xA3F040", VA = "0x180A40640")]
		public void Open()
		{
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B86")]
		[Address(RVA = "0xA3F3B0", Offset = "0xA3DDB0", VA = "0x180A3F3B0")]
		public void Close()
		{
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B87")]
		[Address(RVA = "0xA3FD60", Offset = "0xA3E760", VA = "0x180A3FD60")]
		public void Hovered()
		{
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B88")]
		[Address(RVA = "0xA3FEA0", Offset = "0xA3E8A0", VA = "0x180A3FEA0")]
		public void Interacted()
		{
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B89")]
		[Address(RVA = "0xA44480", Offset = "0xA42E80", VA = "0x180A44480", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0xA441C0", Offset = "0xA42BC0", VA = "0x180A441C0")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0xA43220", Offset = "0xA41C20", VA = "0x180A43220", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0xA43070", Offset = "0xA41A70", VA = "0x180A43070")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8D")]
		[Address(RVA = "0xA43FE0", Offset = "0xA429E0", VA = "0x180A43FE0", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0xA43CB0", Offset = "0xA426B0", VA = "0x180A43CB0")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0xA43B10", Offset = "0xA42510", VA = "0x180A43B10", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B90")]
		[Address(RVA = "0xA43850", Offset = "0xA42250", VA = "0x180A43850")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0xA43720", Offset = "0xA42120", VA = "0x180A43720", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B92")]
		[Address(RVA = "0xA435F0", Offset = "0xA41FF0", VA = "0x180A435F0", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B93")]
		[Address(RVA = "0xA3F930", Offset = "0xA3E330", VA = "0x180A3F930", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B94")]
		[Address(RVA = "0xA44730", Offset = "0xA43130", VA = "0x180A44730")]
		public OldMixingStation()
		{
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B98")]
		[Address(RVA = "0xA3FFD0", Offset = "0xA3E9D0", VA = "0x180A3FFD0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B99")]
		[Address(RVA = "0xA3FF60", Offset = "0xA3E960", VA = "0x180A3FF60", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0xA41C70", Offset = "0xA40670", VA = "0x180A41C70")]
		private void RpcWriter___Observers_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0xA40BA0", Offset = "0xA3F5A0", VA = "0x180A40BA0")]
		public void RpcLogic___SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0xA41170", Offset = "0xA3FB70", VA = "0x180A41170")]
		private void RpcReader___Observers_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0xA42AA0", Offset = "0xA414A0", VA = "0x180A42AA0")]
		private void RpcWriter___Target_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
		{
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0xA41850", Offset = "0xA40250", VA = "0x180A41850")]
		private void RpcReader___Target_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA0")]
		[Address(RVA = "0xA42930", Offset = "0xA41330", VA = "0x180A42930")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0xA41000", Offset = "0xA3FA00", VA = "0x180A41000", Slot = "87")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0xA41790", Offset = "0xA40190", VA = "0x180A41790")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0xA42F00", Offset = "0xA41900", VA = "0x180A42F00")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0xA41010", Offset = "0xA3FA10", VA = "0x180A41010")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0xA41A50", Offset = "0xA40450", VA = "0x180A41A50")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0xA420D0", Offset = "0xA40AD0", VA = "0x180A420D0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0xA41350", Offset = "0xA3FD50", VA = "0x180A41350")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0xA42250", Offset = "0xA40C50", VA = "0x180A42250")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0xA40B10", Offset = "0xA3F510", VA = "0x180A40B10", Slot = "88")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0xA413E0", Offset = "0xA3FDE0", VA = "0x180A413E0")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0xA41AF0", Offset = "0xA404F0", VA = "0x180A41AF0")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0xA40B20", Offset = "0xA3F520", VA = "0x180A40B20")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0xA410D0", Offset = "0xA3FAD0", VA = "0x180A410D0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0xA427A0", Offset = "0xA411A0", VA = "0x180A427A0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0xA40F40", Offset = "0xA3F940", VA = "0x180A40F40", Slot = "89")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005BB0 RID: 23472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0xA41680", Offset = "0xA40080", VA = "0x180A41680")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0xA42D70", Offset = "0xA41770", VA = "0x180A42D70")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB2")]
		[Address(RVA = "0xA40F50", Offset = "0xA3F950", VA = "0x180A40F50")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0xA41950", Offset = "0xA40350", VA = "0x180A41950")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0xA41F30", Offset = "0xA40930", VA = "0x180A41F30")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0xA41260", Offset = "0xA3FC60", VA = "0x180A41260")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0xA42630", Offset = "0xA41030", VA = "0x180A42630")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0xA40E40", Offset = "0xA3F840", VA = "0x180A40E40", Slot = "90")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0xA41590", Offset = "0xA3FF90", VA = "0x180A41590")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0xA41DB0", Offset = "0xA407B0", VA = "0x180A41DB0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBA")]
		[Address(RVA = "0xA40EC0", Offset = "0xA3F8C0", VA = "0x180A40EC0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0xA411D0", Offset = "0xA3FBD0", VA = "0x180A411D0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0xA42C00", Offset = "0xA41600", VA = "0x180A42C00")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0xA418B0", Offset = "0xA402B0", VA = "0x180A418B0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBE")]
		[Address(RVA = "0xA42500", Offset = "0xA40F00", VA = "0x180A42500")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0xA40DA0", Offset = "0xA3F7A0", VA = "0x180A40DA0", Slot = "91")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0xA41510", Offset = "0xA3FF10", VA = "0x180A41510")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC1")]
		[Address(RVA = "0xA423D0", Offset = "0xA40DD0", VA = "0x180A423D0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC2")]
		[Address(RVA = "0xA40D00", Offset = "0xA3F700", VA = "0x180A40D00", Slot = "92")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC3")]
		[Address(RVA = "0xA41490", Offset = "0xA3FE90", VA = "0x180A41490")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06005BC4 RID: 23492 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BC5 RID: 23493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCC")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6005BC4")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BC5")]
			[Address(RVA = "0xA447F0", Offset = "0xA431F0", VA = "0x180A447F0")]
			set
			{
			}
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x000164B8 File Offset: 0x000146B8
		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0xA409E0", Offset = "0xA3F3E0", VA = "0x180A409E0", Slot = "93")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.OldMixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06005BC7 RID: 23495 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BC8 RID: 23496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCD")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005BC7")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BC8")]
			[Address(RVA = "0xA448B0", Offset = "0xA432B0", VA = "0x180A448B0")]
			set
			{
			}
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC9")]
		[Address(RVA = "0xA3EED0", Offset = "0xA3D8D0", VA = "0x180A3EED0", Slot = "94")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.OldMixingStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040042BD RID: 17085
		[Token(Token = "0x40042BD")]
		[FieldOffset(Offset = "0x218")]
		public int MIX_TIME_PER_ITEM;

		// Token: 0x040042BE RID: 17086
		[Token(Token = "0x40042BE")]
		[FieldOffset(Offset = "0x21C")]
		public int MIN_MIX_TIME;

		// Token: 0x040042C1 RID: 17089
		[Token(Token = "0x40042C1")]
		[FieldOffset(Offset = "0x230")]
		public ItemSlot ProductSlot;

		// Token: 0x040042C2 RID: 17090
		[Token(Token = "0x40042C2")]
		[FieldOffset(Offset = "0x238")]
		public ItemSlot MixerSlot;

		// Token: 0x040042C3 RID: 17091
		[Token(Token = "0x40042C3")]
		[FieldOffset(Offset = "0x240")]
		public ItemSlot OutputSlot;

		// Token: 0x040042C7 RID: 17095
		[Token(Token = "0x40042C7")]
		[FieldOffset(Offset = "0x260")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x040042C8 RID: 17096
		[Token(Token = "0x40042C8")]
		[FieldOffset(Offset = "0x268")]
		public Transform CameraPosition;

		// Token: 0x040042C9 RID: 17097
		[Token(Token = "0x40042C9")]
		[FieldOffset(Offset = "0x270")]
		public StorageVisualizer InputVisuals;

		// Token: 0x040042CA RID: 17098
		[Token(Token = "0x40042CA")]
		[FieldOffset(Offset = "0x278")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040042CB RID: 17099
		[Token(Token = "0x40042CB")]
		[FieldOffset(Offset = "0x280")]
		public Animation Animation;

		// Token: 0x040042CC RID: 17100
		[Token(Token = "0x40042CC")]
		[FieldOffset(Offset = "0x288")]
		[Header("Screen")]
		public Canvas ScreenCanvas;

		// Token: 0x040042CD RID: 17101
		[Token(Token = "0x40042CD")]
		[FieldOffset(Offset = "0x290")]
		public Image OutputIcon;

		// Token: 0x040042CE RID: 17102
		[Token(Token = "0x40042CE")]
		[FieldOffset(Offset = "0x298")]
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x040042CF RID: 17103
		[Token(Token = "0x40042CF")]
		[FieldOffset(Offset = "0x2A0")]
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x040042D0 RID: 17104
		[Token(Token = "0x40042D0")]
		[FieldOffset(Offset = "0x2A8")]
		[Header("Sounds")]
		public StartLoopStopAudio MachineSound;

		// Token: 0x040042D1 RID: 17105
		[Token(Token = "0x40042D1")]
		[FieldOffset(Offset = "0x2B0")]
		public AudioSourceController StartSound;

		// Token: 0x040042D2 RID: 17106
		[Token(Token = "0x40042D2")]
		[FieldOffset(Offset = "0x2B8")]
		public AudioSourceController StopSound;

		// Token: 0x040042D3 RID: 17107
		[Token(Token = "0x40042D3")]
		[FieldOffset(Offset = "0x2C0")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x040042D4 RID: 17108
		[Token(Token = "0x40042D4")]
		[FieldOffset(Offset = "0x2C8")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x040042D5 RID: 17109
		[Token(Token = "0x40042D5")]
		[FieldOffset(Offset = "0x2D0")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x040042D6 RID: 17110
		[Token(Token = "0x40042D6")]
		[FieldOffset(Offset = "0x2D1")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted;
	}
}
