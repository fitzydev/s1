using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	public class Dealer : NPC, IItemSlotOwner
	{
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x0000B6E8 File Offset: 0x000098E8
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000621")]
		public bool IsRecruited
		{
			[Token(Token = "0x6002485")]
			[Address(RVA = "0x6DFF10", Offset = "0x6DE910", VA = "0x1806DFF10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002486")]
			[Address(RVA = "0x6E0030", Offset = "0x6DEA30", VA = "0x1806E0030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000622")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6002487")]
			[Address(RVA = "0x689EF0", Offset = "0x6888F0", VA = "0x180689EF0", Slot = "108")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002488")]
			[Address(RVA = "0x6941C0", Offset = "0x692BC0", VA = "0x1806941C0", Slot = "109")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000623")]
		public NPCPoI PotentialDealerPoI
		{
			[Token(Token = "0x6002489")]
			[Address(RVA = "0x6DFF20", Offset = "0x6DE920", VA = "0x1806DFF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600248A")]
			[Address(RVA = "0x6E0040", Offset = "0x6DEA40", VA = "0x1806E0040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000624")]
		public NPCPoI DealerPoI
		{
			[Token(Token = "0x600248B")]
			[Address(RVA = "0x6DFEF0", Offset = "0x6DE8F0", VA = "0x1806DFEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600248C")]
			[Address(RVA = "0x6E0000", Offset = "0x6DEA00", VA = "0x1806E0000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x0000B700 File Offset: 0x00009900
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000625")]
		public float Cash
		{
			[Token(Token = "0x600248D")]
			[Address(RVA = "0x6DFEE0", Offset = "0x6DE8E0", VA = "0x1806DFEE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600248E")]
			[Address(RVA = "0x6DFF70", Offset = "0x6DE970", VA = "0x1806DFF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000626")]
		public List<Customer> AssignedCustomers
		{
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002490")]
			[Address(RVA = "0x6DFF50", Offset = "0x6DE950", VA = "0x1806DFF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000627")]
		public List<Contract> ActiveContracts
		{
			[Token(Token = "0x6002491")]
			[Address(RVA = "0x6DFEC0", Offset = "0x6DE8C0", VA = "0x1806DFEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002492")]
			[Address(RVA = "0x6DFF30", Offset = "0x6DE930", VA = "0x1806DFF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0000B718 File Offset: 0x00009918
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000628")]
		public bool HasBeenRecommended
		{
			[Token(Token = "0x6002493")]
			[Address(RVA = "0x6DFF00", Offset = "0x6DE900", VA = "0x1806DFF00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002494")]
			[Address(RVA = "0x6E0020", Offset = "0x6DEA20", VA = "0x1806E0020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x6D3570", Offset = "0x6D1F70", VA = "0x1806D3570", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x6D7B50", Offset = "0x6D6550", VA = "0x1806D7B50", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x6D7930", Offset = "0x6D6330", VA = "0x1806D7930", Slot = "71")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x6DE4B0", Offset = "0x6DCEB0", VA = "0x1806DE4B0", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x6D79C0", Offset = "0x6D63C0", VA = "0x1806D79C0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x6DDA90", Offset = "0x6DC490", VA = "0x1806DDA90")]
		private void SetupPoI()
		{
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x6DD850", Offset = "0x6DC250", VA = "0x1806DD850")]
		private void SetUpDialogue()
		{
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x6D6E10", Offset = "0x6D5810", VA = "0x1806D6E10", Slot = "72")]
		protected override void MinPass()
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x6D6D00", Offset = "0x6D5700", VA = "0x1806D6D00")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkAsRecommended()
		{
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x6D8500", Offset = "0x6D6F00", VA = "0x1806D8500")]
		[ObserversRpc(RunLocally = true)]
		private void SetRecommended()
		{
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x6D61E0", Offset = "0x6D4BE0", VA = "0x1806D61E0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void InitialRecruitment()
		{
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x6DC500", Offset = "0x6DAF00", VA = "0x1806DC500", Slot = "117")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void SetIsRecruited(NetworkConnection conn)
		{
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A1")]
		[Address(RVA = "0x6D7830", Offset = "0x6D6230", VA = "0x1806D7830", Slot = "118")]
		protected virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x6DFB90", Offset = "0x6DE590", VA = "0x1806DFB90", Slot = "119")]
		protected virtual void UpdatePotentialDealerPoI()
		{
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x6D4020", Offset = "0x6D2A20", VA = "0x1806D4020")]
		private void DealerUnconscious()
		{
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x6DE7C0", Offset = "0x6DD1C0", VA = "0x1806DE7C0")]
		private void TradeItems()
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x6DE640", Offset = "0x6DD040", VA = "0x1806DE640")]
		private void TradeItemsDone()
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x6D35C0", Offset = "0x6D1FC0", VA = "0x1806D35C0")]
		private bool CanCollectCash(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x6DFA80", Offset = "0x6DE480", VA = "0x1806DFA80")]
		private void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x6D3B60", Offset = "0x6D2560", VA = "0x1806D3B60")]
		private void CollectCash()
		{
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x6DFB10", Offset = "0x6DE510", VA = "0x1806DFB10")]
		private void UpdateCurrentDeal()
		{
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x6D3620", Offset = "0x6D2020", VA = "0x1806D3620")]
		private bool CanOfferRecruitment(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x6D3730", Offset = "0x6D2130", VA = "0x1806D3730")]
		private void CheckAttendStart()
		{
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x6DDF90", Offset = "0x6DC990", VA = "0x1806DDF90", Slot = "120")]
		public virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			return default(bool);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x6D3D20", Offset = "0x6D2720", VA = "0x1806D3D20", Slot = "121")]
		public virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x6DC2A0", Offset = "0x6DACA0", VA = "0x1806DC2A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendAddCustomer(string npcID)
		{
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AF")]
		[Address(RVA = "0x6D2DE0", Offset = "0x6D17E0", VA = "0x1806D2DE0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void AddCustomer(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x6D2CF0", Offset = "0x6D16F0", VA = "0x1806D2CF0", Slot = "122")]
		protected virtual void AddCustomer(Customer customer)
		{
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x6DC3D0", Offset = "0x6DADD0", VA = "0x1806DC3D0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRemoveCustomer(string npcID)
		{
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x6D8070", Offset = "0x6D6A70", VA = "0x1806D8070")]
		[ObserversRpc(RunLocally = true)]
		private void RemoveCustomer(string npcID)
		{
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x6D7FD0", Offset = "0x6D69D0", VA = "0x1806D7FD0", Slot = "123")]
		public virtual void RemoveCustomer(Customer customer)
		{
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x6D3720", Offset = "0x6D2120", VA = "0x1806D3720")]
		public void ChangeCash(float change)
		{
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x6DB330", Offset = "0x6D9D30", VA = "0x1806DB330")]
		[ServerRpc(RequireOwnership = false)]
		public void SetCash(float cash)
		{
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x6D3C10", Offset = "0x6D2610", VA = "0x1806D3C10", Slot = "124")]
		[ServerRpc(RequireOwnership = false)]
		public virtual void CompletedDeal()
		{
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x6DBA60", Offset = "0x6DA460", VA = "0x1806DBA60")]
		[ServerRpc(RequireOwnership = false)]
		public void SubmitPayment(float payment)
		{
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x6DEAB0", Offset = "0x6DD4B0", VA = "0x1806DEAB0")]
		public void TryRobDealer()
		{
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x6D58E0", Offset = "0x6D42E0", VA = "0x1806D58E0")]
		public List<ProductDefinition> GetOrderableProducts()
		{
			return null;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x6D5EB0", Offset = "0x6D48B0", VA = "0x1806D5EB0")]
		public int GetProductCount(string productID, EQuality minQuality, EQuality maxQuality)
		{
			return 0;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x60024BB")]
		[Address(RVA = "0x6D4330", Offset = "0x6D2D30", VA = "0x1806D4330")]
		private EDealWindow GetDealWindow()
		{
			return EDealWindow.Morning;
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x6D41A0", Offset = "0x6D2BA0", VA = "0x1806D41A0")]
		private int GetContractCountInWindow(EDealWindow window)
		{
			return 0;
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x6D2B00", Offset = "0x6D1500", VA = "0x1806D2B00")]
		private void AddContract(Contract contract)
		{
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x6D3EC0", Offset = "0x6D28C0", VA = "0x1806D3EC0")]
		private void CustomerContractEnded(Contract contract)
		{
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x6DE360", Offset = "0x6DCD60", VA = "0x1806DE360")]
		private void SortContracts()
		{
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "125")]
		protected virtual void RecruitmentRequested()
		{
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x6D7CF0", Offset = "0x6D66F0", VA = "0x1806D7CF0")]
		public bool RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
			return default(bool);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x6D4760", Offset = "0x6D3160", VA = "0x1806D4760")]
		private List<ItemInstance> GetItems(string ID, int requiredQuantity, Func<ProductItemInstance, bool> qualityCheck, out int returnedQuantity)
		{
			return null;
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C3")]
		[Address(RVA = "0x6D40F0", Offset = "0x6D2AF0", VA = "0x1806D40F0")]
		public List<ItemSlot> GetAllSlots()
		{
			return null;
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C4")]
		[Address(RVA = "0x6D3040", Offset = "0x6D1A40", VA = "0x1806D3040")]
		public void AddItemToInventory(ItemInstance item)
		{
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x6DE990", Offset = "0x6DD390", VA = "0x1806DE990")]
		public void TryMoveOverflowItems()
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x6D60B0", Offset = "0x6D4AB0", VA = "0x1806D60B0")]
		public int GetTotalInventoryItemCount()
		{
			return 0;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x6D5CA0", Offset = "0x6D46A0", VA = "0x1806D5CA0")]
		public int GetPackagedProductAmount()
		{
			return 0;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x6DD6B0", Offset = "0x6DC0B0", VA = "0x1806DD6B0", Slot = "110")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x6DD3F0", Offset = "0x6DBDF0", VA = "0x1806DD3F0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x6DC900", Offset = "0x6DB300", VA = "0x1806DC900", Slot = "111")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x6DC750", Offset = "0x6DB150", VA = "0x1806DC750")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x6DD200", Offset = "0x6DBC00", VA = "0x1806DD200", Slot = "112")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x6DCED0", Offset = "0x6DB8D0", VA = "0x1806DCED0")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x6DCD30", Offset = "0x6DB730", VA = "0x1806DCD30", Slot = "113")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x6DCA70", Offset = "0x6DB470", VA = "0x1806DCA70")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x6D55F0", Offset = "0x6D3FF0", VA = "0x1806D55F0", Slot = "94")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x6D6300", Offset = "0x6D4D00", VA = "0x1806D6300", Slot = "98")]
		public override void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x6D6790", Offset = "0x6D5190", VA = "0x1806D6790", Slot = "97")]
		public override void Load(NPCData data, string containerPath)
		{
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x6DFCF0", Offset = "0x6DE6F0", VA = "0x1806DFCF0")]
		public Dealer()
		{
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x6DF490", Offset = "0x6DDE90", VA = "0x1806DF490")]
		[CompilerGenerated]
		private void <TryRobDealer>g__SummariseLosses|99_0(List<ItemInstance> items, float cash)
		{
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x6D7000", Offset = "0x6D5A00", VA = "0x1806D7000", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x6D6FA0", Offset = "0x6D59A0", VA = "0x1806D6FA0", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x6DAFC0", Offset = "0x6D99C0", VA = "0x1806DAFC0")]
		private void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x6D8500", Offset = "0x6D6F00", VA = "0x1806D8500")]
		public void RpcLogic___MarkAsRecommended_2166136261()
		{
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x6D98A0", Offset = "0x6D82A0", VA = "0x1806D98A0")]
		private void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x6DA8F0", Offset = "0x6D92F0", VA = "0x1806DA8F0")]
		private void RpcWriter___Observers_SetRecommended_2166136261()
		{
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x6D8E70", Offset = "0x6D7870", VA = "0x1806D8E70")]
		private void RpcLogic___SetRecommended_2166136261()
		{
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x6D95A0", Offset = "0x6D7FA0", VA = "0x1806D95A0")]
		private void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private void RpcWriter___Server_InitialRecruitment_2166136261()
		{
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x6D84E0", Offset = "0x6D6EE0", VA = "0x1806D84E0")]
		public void RpcLogic___InitialRecruitment_2166136261()
		{
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x6D9840", Offset = "0x6D8240", VA = "0x1806D9840")]
		private void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x6DA650", Offset = "0x6D9050", VA = "0x1806DA650")]
		private void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x6D88D0", Offset = "0x6D72D0", VA = "0x1806D88D0", Slot = "126")]
		public virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x6D94C0", Offset = "0x6D7EC0", VA = "0x1806D94C0")]
		private void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E6")]
		[Address(RVA = "0x6DBD00", Offset = "0x6DA700", VA = "0x1806DBD00")]
		private void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E7")]
		[Address(RVA = "0x6DA150", Offset = "0x6D8B50", VA = "0x1806DA150")]
		private void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x6DB0D0", Offset = "0x6D9AD0", VA = "0x1806DB0D0")]
		private void RpcWriter___Server_SendAddCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x6D87E0", Offset = "0x6D71E0", VA = "0x1806D87E0")]
		public void RpcLogic___SendAddCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x6D98F0", Offset = "0x6D82F0", VA = "0x1806D98F0")]
		private void RpcReader___Server_SendAddCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x6DA3D0", Offset = "0x6D8DD0", VA = "0x1806DA3D0")]
		private void RpcWriter___Observers_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x6D81B0", Offset = "0x6D6BB0", VA = "0x1806D81B0")]
		private void RpcLogic___AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x6D9400", Offset = "0x6D7E00", VA = "0x1806D9400")]
		private void RpcReader___Observers_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x6DBBA0", Offset = "0x6DA5A0", VA = "0x1806DBBA0")]
		private void RpcWriter___Target_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EF")]
		[Address(RVA = "0x6DA0F0", Offset = "0x6D8AF0", VA = "0x1806DA0F0")]
		private void RpcReader___Target_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F0")]
		[Address(RVA = "0x6DB200", Offset = "0x6D9C00", VA = "0x1806DB200")]
		private void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F1")]
		[Address(RVA = "0x6D8070", Offset = "0x6D6A70", VA = "0x1806D8070")]
		public void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x6D9970", Offset = "0x6D8370", VA = "0x1806D9970")]
		private void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x6DA510", Offset = "0x6D8F10", VA = "0x1806DA510")]
		private void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x6D8640", Offset = "0x6D7040", VA = "0x1806D8640")]
		private void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x6D9460", Offset = "0x6D7E60", VA = "0x1806D9460")]
		private void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x6DB330", Offset = "0x6D9D30", VA = "0x1806DB330")]
		private void RpcWriter___Server_SetCash_431000436(float cash)
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x6D87F0", Offset = "0x6D71F0", VA = "0x1806D87F0")]
		public void RpcLogic___SetCash_431000436(float cash)
		{
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x6D99E0", Offset = "0x6D83E0", VA = "0x1806D99E0")]
		private void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x6D3C10", Offset = "0x6D2610", VA = "0x1806D3C10")]
		private void RpcWriter___Server_CompletedDeal_2166136261()
		{
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x6D8350", Offset = "0x6D6D50", VA = "0x1806D8350", Slot = "127")]
		public virtual void RpcLogic___CompletedDeal_2166136261()
		{
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FB")]
		[Address(RVA = "0x6D9810", Offset = "0x6D8210", VA = "0x1806D9810")]
		private void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x6DBA60", Offset = "0x6DA460", VA = "0x1806DBA60")]
		private void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x6D9210", Offset = "0x6D7C10", VA = "0x1806D9210")]
		public void RpcLogic___SubmitPayment_431000436(float payment)
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FE")]
		[Address(RVA = "0x6D9ED0", Offset = "0x6D88D0", VA = "0x1806D9ED0")]
		private void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FF")]
		[Address(RVA = "0x6DB8F0", Offset = "0x6DA2F0", VA = "0x1806DB8F0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002500")]
		[Address(RVA = "0x6D90D0", Offset = "0x6D7AD0", VA = "0x1806D90D0", Slot = "128")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002501")]
		[Address(RVA = "0x6D9DE0", Offset = "0x6D87E0", VA = "0x1806D9DE0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002502")]
		[Address(RVA = "0x6DAD30", Offset = "0x6D9730", VA = "0x1806DAD30")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002503")]
		[Address(RVA = "0x6D9150", Offset = "0x6D7B50", VA = "0x1806D9150")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002504")]
		[Address(RVA = "0x6D9780", Offset = "0x6D8180", VA = "0x1806D9780")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002505")]
		[Address(RVA = "0x6DC130", Offset = "0x6DAB30", VA = "0x1806DC130")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x6DA330", Offset = "0x6D8D30", VA = "0x1806DA330")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x6DB470", Offset = "0x6D9E70", VA = "0x1806DB470")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x6D8DE0", Offset = "0x6D77E0", VA = "0x1806D8DE0", Slot = "129")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x6D9AF0", Offset = "0x6D84F0", VA = "0x1806D9AF0")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x6DA770", Offset = "0x6D9170", VA = "0x1806DA770")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x6D8DF0", Offset = "0x6D77F0", VA = "0x1806D8DF0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x6D9500", Offset = "0x6D7F00", VA = "0x1806D9500")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x6DB760", Offset = "0x6DA160", VA = "0x1806DB760")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x6D8FA0", Offset = "0x6D79A0", VA = "0x1806D8FA0", Slot = "130")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x6D9C90", Offset = "0x6D8690", VA = "0x1806D9C90")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002510")]
		[Address(RVA = "0x6DBFA0", Offset = "0x6DA9A0", VA = "0x1806DBFA0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002511")]
		[Address(RVA = "0x6D9020", Offset = "0x6D7A20", VA = "0x1806D9020")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002512")]
		[Address(RVA = "0x6DA230", Offset = "0x6D8C30", VA = "0x1806DA230")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002513")]
		[Address(RVA = "0x6DAB90", Offset = "0x6D9590", VA = "0x1806DAB90")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002514")]
		[Address(RVA = "0x6D9690", Offset = "0x6D8090", VA = "0x1806D9690")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002515")]
		[Address(RVA = "0x6DB5F0", Offset = "0x6D9FF0", VA = "0x1806DB5F0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002516")]
		[Address(RVA = "0x6D8EA0", Offset = "0x6D78A0", VA = "0x1806D8EA0", Slot = "131")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002517")]
		[Address(RVA = "0x6D9BA0", Offset = "0x6D85A0", VA = "0x1806D9BA0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002518")]
		[Address(RVA = "0x6DAA10", Offset = "0x6D9410", VA = "0x1806DAA10")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002519")]
		[Address(RVA = "0x6D8F20", Offset = "0x6D7920", VA = "0x1806D8F20")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251A")]
		[Address(RVA = "0x6D9600", Offset = "0x6D8000", VA = "0x1806D9600")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251B")]
		[Address(RVA = "0x6DBE30", Offset = "0x6DA830", VA = "0x1806DBE30")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x6DA190", Offset = "0x6D8B90", VA = "0x1806DA190")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x0000B808 File Offset: 0x00009A08
		// (set) Token: 0x0600251E RID: 9502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000629")]
		public float SyncAccessor_<Cash>k__BackingField
		{
			[Token(Token = "0x600251D")]
			[Address(RVA = "0x6DFEE0", Offset = "0x6DE8E0", VA = "0x1806DFEE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600251E")]
			[Address(RVA = "0x6E0060", Offset = "0x6DEA60", VA = "0x1806E0060")]
			set
			{
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x6D7BA0", Offset = "0x6D65A0", VA = "0x1806D7BA0", Slot = "132")]
		public virtual bool ReadSyncVar___ScheduleOne.Economy.Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x6D31E0", Offset = "0x6D1BE0", VA = "0x1806D31E0", Slot = "133")]
		protected virtual void Awake_UserLogic_ScheduleOne.Economy.Dealer_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001C66 RID: 7270
		[Token(Token = "0x4001C66")]
		public const int MAX_CUSTOMERS = 8;

		// Token: 0x04001C67 RID: 7271
		[Token(Token = "0x4001C67")]
		public const int DEAL_ARRIVAL_DELAY = 30;

		// Token: 0x04001C68 RID: 7272
		[Token(Token = "0x4001C68")]
		public const int MIN_TRAVEL_TIME = 15;

		// Token: 0x04001C69 RID: 7273
		[Token(Token = "0x4001C69")]
		public const int MAX_TRAVEL_TIME = 360;

		// Token: 0x04001C6A RID: 7274
		[Token(Token = "0x4001C6A")]
		public const int OVERFLOW_SLOT_COUNT = 10;

		// Token: 0x04001C6B RID: 7275
		[Token(Token = "0x4001C6B")]
		public const float CASH_REMINDER_THRESHOLD = 500f;

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		public const float RELATIONSHIP_CHANGE_PER_DEAL = 0.05f;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 DealerLabelColor;

		// Token: 0x04001C6E RID: 7278
		[Token(Token = "0x4001C6E")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Dealer> onDealerRecruited;

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		[FieldOffset(Offset = "0x10")]
		public static List<Dealer> AllPlayerDealers;

		// Token: 0x04001C78 RID: 7288
		[Token(Token = "0x4001C78")]
		[FieldOffset(Offset = "0x330")]
		public Action onContractAccepted;

		// Token: 0x04001C79 RID: 7289
		[Token(Token = "0x4001C79")]
		[FieldOffset(Offset = "0x338")]
		[Header("Dealer References")]
		public NPCEnterableBuilding Home;

		// Token: 0x04001C7A RID: 7290
		[Token(Token = "0x4001C7A")]
		[FieldOffset(Offset = "0x340")]
		public NPCSignal_HandleDeal DealSignal;

		// Token: 0x04001C7B RID: 7291
		[Token(Token = "0x4001C7B")]
		[FieldOffset(Offset = "0x348")]
		public NPCEvent_StayInBuilding HomeEvent;

		// Token: 0x04001C7C RID: 7292
		[Token(Token = "0x4001C7C")]
		[FieldOffset(Offset = "0x350")]
		public DialogueController_Dealer DialogueController;

		// Token: 0x04001C7D RID: 7293
		[Token(Token = "0x4001C7D")]
		[FieldOffset(Offset = "0x358")]
		[Header("Dialogue stuff")]
		public DialogueContainer RecruitDialogue;

		// Token: 0x04001C7E RID: 7294
		[Token(Token = "0x4001C7E")]
		[FieldOffset(Offset = "0x360")]
		public DialogueContainer CollectCashDialogue;

		// Token: 0x04001C7F RID: 7295
		[Token(Token = "0x4001C7F")]
		[FieldOffset(Offset = "0x368")]
		public DialogueContainer AssignCustomersDialogue;

		// Token: 0x04001C80 RID: 7296
		[Token(Token = "0x4001C80")]
		[FieldOffset(Offset = "0x370")]
		[Header("Dealer Settings")]
		public EDealerType DealerType;

		// Token: 0x04001C81 RID: 7297
		[Token(Token = "0x4001C81")]
		[FieldOffset(Offset = "0x378")]
		public string HomeName;

		// Token: 0x04001C82 RID: 7298
		[Token(Token = "0x4001C82")]
		[FieldOffset(Offset = "0x380")]
		public float SigningFee;

		// Token: 0x04001C83 RID: 7299
		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x384")]
		public float Cut;

		// Token: 0x04001C84 RID: 7300
		[Token(Token = "0x4001C84")]
		[FieldOffset(Offset = "0x388")]
		public bool SellInsufficientQualityItems;

		// Token: 0x04001C85 RID: 7301
		[Token(Token = "0x4001C85")]
		[FieldOffset(Offset = "0x389")]
		public bool SellExcessQualityItems;

		// Token: 0x04001C86 RID: 7302
		[Token(Token = "0x4001C86")]
		[FieldOffset(Offset = "0x390")]
		[Header("Variables")]
		public string CompletedDealsVariable;

		// Token: 0x04001C87 RID: 7303
		[Token(Token = "0x4001C87")]
		[FieldOffset(Offset = "0x398")]
		[Header("UnityEvents")]
		public UnityEvent onRecommended;

		// Token: 0x04001C88 RID: 7304
		[Token(Token = "0x4001C88")]
		[FieldOffset(Offset = "0x3A0")]
		private ItemSlot[] overflowSlots;

		// Token: 0x04001C89 RID: 7305
		[Token(Token = "0x4001C89")]
		[FieldOffset(Offset = "0x3A8")]
		private Contract currentContract;

		// Token: 0x04001C8A RID: 7306
		[Token(Token = "0x4001C8A")]
		[FieldOffset(Offset = "0x3B0")]
		private DialogueController.DialogueChoice recruitChoice;

		// Token: 0x04001C8B RID: 7307
		[Token(Token = "0x4001C8B")]
		[FieldOffset(Offset = "0x3B8")]
		private DialogueController.DialogueChoice collectCashChoice;

		// Token: 0x04001C8C RID: 7308
		[Token(Token = "0x4001C8C")]
		[FieldOffset(Offset = "0x3C0")]
		private DialogueController.DialogueChoice assignCustomersChoice;

		// Token: 0x04001C8D RID: 7309
		[Token(Token = "0x4001C8D")]
		[FieldOffset(Offset = "0x3C8")]
		private int itemCountOnTradeStart;

		// Token: 0x04001C8E RID: 7310
		[Token(Token = "0x4001C8E")]
		[FieldOffset(Offset = "0x3D0")]
		public SyncVar<float> syncVar___<Cash>k__BackingField;

		// Token: 0x04001C8F RID: 7311
		[Token(Token = "0x4001C8F")]
		[FieldOffset(Offset = "0x3D8")]
		private bool NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001C90 RID: 7312
		[Token(Token = "0x4001C90")]
		[FieldOffset(Offset = "0x3D9")]
		private bool NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted;
	}
}
