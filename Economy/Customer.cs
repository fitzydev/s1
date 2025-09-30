using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI.Handover;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x020005C9 RID: 1481
	[Token(Token = "0x20005C9")]
	[RequireComponent(typeof(NPC))]
	[DisallowMultipleComponent]
	public class Customer : NetworkBehaviour, ISaveable
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0000B1C0 File Offset: 0x000093C0
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FE")]
		public float CurrentAddiction
		{
			[Token(Token = "0x6002352")]
			[Address(RVA = "0x5ADF10", Offset = "0x5AC910", VA = "0x1805ADF10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002353")]
			[Address(RVA = "0x6CAEA0", Offset = "0x6C98A0", VA = "0x1806CAEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FF")]
		public ContractInfo OfferedContractInfo
		{
			[Token(Token = "0x6002354")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002355")]
			[Address(RVA = "0x630490", Offset = "0x62EE90", VA = "0x180630490")]
			protected set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x0000B1D8 File Offset: 0x000093D8
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000600")]
		public GameDateTime OfferedContractTime
		{
			[Token(Token = "0x6002356")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			[CompilerGenerated]
			get
			{
				return default(GameDateTime);
			}
			[Token(Token = "0x6002357")]
			[Address(RVA = "0x6CB020", Offset = "0x6C9A20", VA = "0x1806CB020")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000601")]
		public Contract CurrentContract
		{
			[Token(Token = "0x6002358")]
			[Address(RVA = "0x672D40", Offset = "0x671740", VA = "0x180672D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002359")]
			[Address(RVA = "0x672DD0", Offset = "0x6717D0", VA = "0x180672DD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x0000B1F0 File Offset: 0x000093F0
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000602")]
		public bool IsAwaitingDelivery
		{
			[Token(Token = "0x600235A")]
			[Address(RVA = "0x538220", Offset = "0x536C20", VA = "0x180538220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600235B")]
			[Address(RVA = "0x6CAFD0", Offset = "0x6C99D0", VA = "0x1806CAFD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x0000B208 File Offset: 0x00009408
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000603")]
		public int TimeSinceLastDealCompleted
		{
			[Token(Token = "0x600235C")]
			[Address(RVA = "0x6CAE50", Offset = "0x6C9850", VA = "0x1806CAE50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600235D")]
			[Address(RVA = "0x6CB050", Offset = "0x6C9A50", VA = "0x1806CB050")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x0000B220 File Offset: 0x00009420
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000604")]
		public int TimeSinceLastDealOffered
		{
			[Token(Token = "0x600235E")]
			[Address(RVA = "0x6CAE60", Offset = "0x6C9860", VA = "0x1806CAE60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600235F")]
			[Address(RVA = "0x6CB060", Offset = "0x6C9A60", VA = "0x1806CB060")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x0000B238 File Offset: 0x00009438
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000605")]
		public int TimeSincePlayerApproached
		{
			[Token(Token = "0x6002360")]
			[Address(RVA = "0x5385F0", Offset = "0x536FF0", VA = "0x1805385F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002361")]
			[Address(RVA = "0x6CB070", Offset = "0x6C9A70", VA = "0x1806CB070")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0000B250 File Offset: 0x00009450
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000606")]
		public int TimeSinceInstantDealOffered
		{
			[Token(Token = "0x6002362")]
			[Address(RVA = "0x6CAE40", Offset = "0x6C9840", VA = "0x1806CAE40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002363")]
			[Address(RVA = "0x6CB040", Offset = "0x6C9A40", VA = "0x1806CB040")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x0000B268 File Offset: 0x00009468
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000607")]
		public int OfferedDeals
		{
			[Token(Token = "0x6002364")]
			[Address(RVA = "0x6CADD0", Offset = "0x6C97D0", VA = "0x1806CADD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002365")]
			[Address(RVA = "0x6CB030", Offset = "0x6C9A30", VA = "0x1806CB030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x0000B280 File Offset: 0x00009480
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000608")]
		public int CompletedDeliveries
		{
			[Token(Token = "0x6002366")]
			[Address(RVA = "0x659850", Offset = "0x658250", VA = "0x180659850")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002367")]
			[Address(RVA = "0x659B00", Offset = "0x658500", VA = "0x180659B00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0000B298 File Offset: 0x00009498
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000609")]
		public bool HasBeenRecommended
		{
			[Token(Token = "0x6002368")]
			[Address(RVA = "0x5386C0", Offset = "0x5370C0", VA = "0x1805386C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002369")]
			[Address(RVA = "0x6CAF30", Offset = "0x6C9930", VA = "0x1806CAF30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060A")]
		public NPC NPC
		{
			[Token(Token = "0x600236A")]
			[Address(RVA = "0x63D960", Offset = "0x63C360", VA = "0x18063D960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600236B")]
			[Address(RVA = "0x63DA60", Offset = "0x63C460", VA = "0x18063DA60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600236D RID: 9069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060B")]
		public Dealer AssignedDealer
		{
			[Token(Token = "0x600236C")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600236D")]
			[Address(RVA = "0x63DA80", Offset = "0x63C480", VA = "0x18063DA80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060C")]
		public CustomerData CustomerData
		{
			[Token(Token = "0x600236E")]
			[Address(RVA = "0x6CAD90", Offset = "0x6C9790", VA = "0x1806CAD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060D")]
		private DialogueDatabase dialogueDatabase
		{
			[Token(Token = "0x600236F")]
			[Address(RVA = "0x6CAE70", Offset = "0x6C9870", VA = "0x1806CAE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060E")]
		public NPCPoI potentialCustomerPoI
		{
			[Token(Token = "0x6002370")]
			[Address(RVA = "0x69CBD0", Offset = "0x69B5D0", VA = "0x18069CBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002371")]
			[Address(RVA = "0x69CBF0", Offset = "0x69B5F0", VA = "0x18069CBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060F")]
		public string SaveFolderName
		{
			[Token(Token = "0x6002372")]
			[Address(RVA = "0x6CAE10", Offset = "0x6C9810", VA = "0x1806CAE10", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000610")]
		public string SaveFileName
		{
			[Token(Token = "0x6002373")]
			[Address(RVA = "0x6CADE0", Offset = "0x6C97E0", VA = "0x1806CADE0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000611")]
		public Loader Loader
		{
			[Token(Token = "0x6002374")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x17000612")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6002375")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000613")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6002376")]
			[Address(RVA = "0x6CADB0", Offset = "0x6C97B0", VA = "0x1806CADB0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002377")]
			[Address(RVA = "0x6CAFE0", Offset = "0x6C99E0", VA = "0x1806CAFE0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000614")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6002378")]
			[Address(RVA = "0x6CADC0", Offset = "0x6C97C0", VA = "0x1806CADC0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002379")]
			[Address(RVA = "0x6CB000", Offset = "0x6C9A00", VA = "0x1806CB000", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x0000B2C8 File Offset: 0x000094C8
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000615")]
		public bool HasChanged
		{
			[Token(Token = "0x600237A")]
			[Address(RVA = "0x6CADA0", Offset = "0x6C97A0", VA = "0x1806CADA0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600237B")]
			[Address(RVA = "0x6CAFC0", Offset = "0x6C99C0", VA = "0x1806CAFC0", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237C")]
		[Address(RVA = "0x6B6680", Offset = "0x6B5080", VA = "0x1806B6680", Slot = "42")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237D")]
		[Address(RVA = "0x6BD860", Offset = "0x6BC260", VA = "0x1806BD860", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x6C8820", Offset = "0x6C7220", VA = "0x1806C8820")]
		private void Start()
		{
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237F")]
		[Address(RVA = "0x6BD840", Offset = "0x6BC240", VA = "0x1806BD840", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002380")]
		[Address(RVA = "0x6BD6A0", Offset = "0x6BC0A0", VA = "0x1806BD6A0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x6BD600", Offset = "0x6BC000", VA = "0x1806BD600")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x6C71C0", Offset = "0x6C5BC0", VA = "0x1806C71C0")]
		private void SetUpDialogue()
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x6C7AE0", Offset = "0x6C64E0", VA = "0x1806C7AE0")]
		private void SetupPoI()
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x6BAAE0", Offset = "0x6B94E0", VA = "0x1806BAAE0", Slot = "43")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x6BB820", Offset = "0x6BA220", VA = "0x1806BB820", Slot = "44")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x6BCBC0", Offset = "0x6BB5C0", VA = "0x1806BCBC0")]
		private void OfferContractToDealer(ContractInfo info, Dealer dealer)
		{
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x6B7B60", Offset = "0x6B6560", VA = "0x1806B7B60", Slot = "45")]
		protected virtual void DayPass()
		{
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x6C9F40", Offset = "0x6C8940", VA = "0x1806C9F40")]
		private void UpdateDealAttendance()
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x6B6810", Offset = "0x6B5210", VA = "0x1806B6810")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ConfigureDealSignal(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x6CA660", Offset = "0x6C9060", VA = "0x1806CA660")]
		private void UpdateOfferExpiry()
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x6B8C50", Offset = "0x6B7650", VA = "0x1806B8C50")]
		public void ForceDealOffer()
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x6B98A0", Offset = "0x6B82A0", VA = "0x1806B98A0")]
		private List<ProductDefinition> GetOrderableProducts(Dealer dealer)
		{
			return null;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x6C8E30", Offset = "0x6C7830", VA = "0x1806C8E30")]
		private ContractInfo TryGenerateContract(Dealer dealer)
		{
			return null;
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x6BA490", Offset = "0x6B8E90", VA = "0x1806BA490")]
		private ProductDefinition GetWeightedRandomProduct(Dealer dealer, out float appeal)
		{
			return null;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x6BD370", Offset = "0x6BBD70", VA = "0x1806BD370", Slot = "46")]
		protected virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x6C6EB0", Offset = "0x6C58B0", VA = "0x1806C6EB0")]
		public void SetHasBeenRecommended()
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x6BCCE0", Offset = "0x6BB6E0", VA = "0x1806BCCE0", Slot = "47")]
		public virtual void OfferContract(ContractInfo info)
		{
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x6C54B0", Offset = "0x6C3EB0", VA = "0x1806C54B0")]
		[ObserversRpc]
		private void SetOfferedContract(ContractInfo info, GameDateTime offerTime)
		{
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x6B8B40", Offset = "0x6B7540", VA = "0x1806B8B40", Slot = "48")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void ExpireOffer()
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x6B6170", Offset = "0x6B4B70", VA = "0x1806B6170", Slot = "49")]
		public virtual void AssignContract(Contract contract)
		{
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x6BC860", Offset = "0x6BB260", VA = "0x1806BC860", Slot = "50")]
		protected virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x6C6C70", Offset = "0x6C5670", VA = "0x1806C6C70")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendSetUpResponseCallbacks()
		{
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x6C79C0", Offset = "0x6C63C0", VA = "0x1806C79C0")]
		[ObserversRpc(RunLocally = true)]
		private void SetUpResponseCallbacks()
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002398")]
		[Address(RVA = "0x6B5EB0", Offset = "0x6B48B0", VA = "0x1806B5EB0", Slot = "51")]
		protected virtual void AcceptContractClicked()
		{
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x6B73F0", Offset = "0x6B5DF0", VA = "0x1806B73F0", Slot = "52")]
		protected virtual void CounterOfferClicked()
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x6C6840", Offset = "0x6C5240", VA = "0x1806C6840", Slot = "53")]
		protected virtual void SendCounteroffer(ProductDefinition product, int quantity, float price)
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x6BE550", Offset = "0x6BCF50", VA = "0x1806BE550")]
		[ServerRpc(RequireOwnership = false)]
		private void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x6C6D80", Offset = "0x6C5780", VA = "0x1806C6D80")]
		[ObserversRpc(RunLocally = true)]
		private void SetContractIsCounterOffer()
		{
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x6BDD60", Offset = "0x6BC760", VA = "0x1806BDD60", Slot = "54")]
		protected virtual void PlayerAcceptedContract(EDealWindow window)
		{
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x6C5980", Offset = "0x6C4380", VA = "0x1806C5980")]
		[ServerRpc(RequireOwnership = false)]
		private void SendContractAccepted(EDealWindow window, bool trackContract)
		{
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x6B6BF0", Offset = "0x6B55F0", VA = "0x1806B6BF0")]
		public Contract ContractAccepted(EDealWindow window, bool trackContract, Dealer dealer)
		{
			return null;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x6BFCD0", Offset = "0x6BE6D0", VA = "0x1806BFCD0")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveContractAccepted()
		{
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x6BDBC0", Offset = "0x6BC5C0", VA = "0x1806BDBC0", Slot = "55")]
		protected virtual void PlayContractAcceptedReaction()
		{
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x6B7F10", Offset = "0x6B6910", VA = "0x1806B7F10", Slot = "56")]
		protected virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price)
		{
			return default(bool);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x6BA430", Offset = "0x6B8E30", VA = "0x1806BA430")]
		public static float GetValueProposition(ProductDefinition product, float price)
		{
			return 0f;
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x6B6F30", Offset = "0x6B5930", VA = "0x1806B6F30", Slot = "57")]
		protected virtual void ContractRejected()
		{
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x6BFE10", Offset = "0x6BE810", VA = "0x1806BFE10")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveContractRejected()
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x6BDC90", Offset = "0x6BC690", VA = "0x1806BDC90", Slot = "58")]
		protected virtual void PlayContractRejectedReaction()
		{
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x6C6ED0", Offset = "0x6C58D0", VA = "0x1806C6ED0", Slot = "59")]
		public virtual void SetIsAwaitingDelivery(bool awaiting)
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x6BAE60", Offset = "0x6B9860", VA = "0x1806BAE60")]
		public bool IsAtDealLocation()
		{
			return default(bool);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x6CA8B0", Offset = "0x6C92B0", VA = "0x1806CA8B0")]
		private void UpdatePotentialCustomerPoI()
		{
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x6C7130", Offset = "0x6C5B30", VA = "0x1806C7130")]
		public void SetPotentialCustomerPoIEnabled(bool enabled)
		{
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x6C81E0", Offset = "0x6C6BE0", VA = "0x1806C81E0", Slot = "60")]
		protected virtual bool ShouldTryGenerateDeal()
		{
			return default(bool);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x6BAFE0", Offset = "0x6B99E0", VA = "0x1806BAFE0")]
		private bool IsDealTime()
		{
			return default(bool);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x6BD130", Offset = "0x6BBB30", VA = "0x1806BD130", Slot = "61")]
		public virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x6B7740", Offset = "0x6B6140", VA = "0x1806B7740", Slot = "62")]
		public virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x6BE9D0", Offset = "0x6BD3D0", VA = "0x1806BE9D0", Slot = "63")]
		public virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x6BE830", Offset = "0x6BD230", VA = "0x1806BE830")]
		[ServerRpc(RequireOwnership = false)]
		private void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x6BE6C0", Offset = "0x6BD0C0", VA = "0x1806BE6C0")]
		[ObserversRpc]
		private void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x6B7100", Offset = "0x6B5B00", VA = "0x1806B7100")]
		public void ContractWellReceived(string npcToRecommend)
		{
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x6C0640", Offset = "0x6BF040", VA = "0x1806C0640")]
		private void RecommendDealer(Dealer dealer)
		{
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x6C0BC0", Offset = "0x6BF5C0", VA = "0x1806C0BC0")]
		private void RecommendSupplier(Supplier supplier)
		{
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x6C00B0", Offset = "0x6BEAB0", VA = "0x1806C00B0")]
		private void RecommendCustomer(Customer friend)
		{
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x6B7660", Offset = "0x6B6060", VA = "0x1806B7660", Slot = "64")]
		public virtual void CurrentContractEnded(EQuestState outcome)
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x6B8420", Offset = "0x6B6E20", VA = "0x1806B8420", Slot = "65")]
		public virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount, out float qualityDifference)
		{
			return 0f;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x6B66D0", Offset = "0x6B50D0", VA = "0x1806B66D0")]
		[ServerRpc(RequireOwnership = false)]
		public void ChangeAddiction(float change)
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x6B6AF0", Offset = "0x6B54F0", VA = "0x1806B6AF0")]
		private void ConsumeProduct(ItemInstance item)
		{
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x6C86A0", Offset = "0x6C70A0", VA = "0x1806C86A0", Slot = "66")]
		protected virtual bool ShowOfferDealOption(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x6BD280", Offset = "0x6BBC80", VA = "0x1806BD280", Slot = "67")]
		protected virtual bool OfferDealValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x6BAB70", Offset = "0x6B9570", VA = "0x1806BAB70", Slot = "68")]
		protected virtual void InstantDealOffered()
		{
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x6B9020", Offset = "0x6B7A20", VA = "0x1806B9020")]
		public float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice)
		{
			return 0f;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x6C7E40", Offset = "0x6C6840", VA = "0x1806C7E40", Slot = "69")]
		protected virtual bool ShouldTryApproachPlayer()
		{
			return default(bool);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x6C12B0", Offset = "0x6BFCB0", VA = "0x1806C12B0")]
		[Button]
		public void RequestProduct()
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x6C1310", Offset = "0x6BFD10", VA = "0x1806C1310")]
		public void RequestProduct(Player target)
		{
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x6BE240", Offset = "0x6BCC40", VA = "0x1806BE240")]
		public void PlayerRejectedProductRequest()
		{
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x6C11A0", Offset = "0x6BFBA0", VA = "0x1806C11A0")]
		[ServerRpc(RequireOwnership = false)]
		public void RejectProductRequestOffer()
		{
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x6C1080", Offset = "0x6BFA80", VA = "0x1806C1080")]
		[ObserversRpc(RunLocally = true)]
		private void RejectProductRequestOffer_Local()
		{
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x63DA80", Offset = "0x63C480", VA = "0x18063DA80")]
		public void AssignDealer(Dealer dealer)
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x6BA3F0", Offset = "0x6B8DF0", VA = "0x1806BA3F0", Slot = "70")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x6B8DB0", Offset = "0x6B77B0", VA = "0x1806B8DB0")]
		public CustomerData GetCustomerData()
		{
			return null;
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x6CA970", Offset = "0x6C9370", VA = "0x1806CA970", Slot = "71")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x6BFF50", Offset = "0x6BE950", VA = "0x1806BFF50")]
		[TargetRpc]
		private void ReceiveCustomerData(NetworkConnection conn, CustomerData data)
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x6BB5C0", Offset = "0x6B9FC0", VA = "0x1806BB5C0", Slot = "72")]
		public virtual void Load(CustomerData data)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x6BB3A0", Offset = "0x6B9DA0", VA = "0x1806BB3A0", Slot = "73")]
		protected virtual bool IsReadyForHandover(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x6BB240", Offset = "0x6B9C40", VA = "0x1806BB240", Slot = "74")]
		protected virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x6BA9A0", Offset = "0x6B93A0", VA = "0x1806BA9A0")]
		public void HandoverChosen()
		{
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x60023CD")]
		[Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570", Slot = "75")]
		protected virtual bool ShowDirectApproachOption(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x6BB490", Offset = "0x6B9E90", VA = "0x1806BB490", Slot = "76")]
		public virtual bool IsUnlockable()
		{
			return default(bool);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x6C6630", Offset = "0x6C5030", VA = "0x1806C6630", Slot = "77")]
		protected virtual bool SampleOptionValid(out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x6BB4E0", Offset = "0x6B9EE0", VA = "0x1806BB4E0")]
		public bool KnownAndRecommended()
		{
			return default(bool);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x6C65A0", Offset = "0x6C4FA0", VA = "0x1806C65A0")]
		public void SampleOffered()
		{
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x6B9E90", Offset = "0x6B8890", VA = "0x1806B9E90", Slot = "78")]
		protected virtual float GetSampleRequestSuccessChance()
		{
			return 0f;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x6C5D60", Offset = "0x6C4760", VA = "0x1806C5D60", Slot = "79")]
		protected virtual void SampleAccepted()
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x6B9FE0", Offset = "0x6B89E0", VA = "0x1806B9FE0")]
		private float GetSampleSuccess(List<ItemInstance> items, float price)
		{
			return 0f;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x6BF910", Offset = "0x6BE310", VA = "0x1806BF910")]
		private void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x6BF7E0", Offset = "0x6BE1E0", VA = "0x1806BF7E0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ProcessSampleServerSide(List<ItemInstance> items)
		{
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x6BF6C0", Offset = "0x6BE0C0", VA = "0x1806BF6C0")]
		[ObserversRpc(RunLocally = true)]
		private void ProcessSampleClient()
		{
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x6C5F00", Offset = "0x6C4900", VA = "0x1806C5F00")]
		private void SampleConsumed()
		{
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x6B7DF0", Offset = "0x6B67F0", VA = "0x1806B7DF0")]
		private void EndWait()
		{
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x6B7BC0", Offset = "0x6B65C0", VA = "0x1806B7BC0", Slot = "80")]
		protected virtual void DirectApproachRejected()
		{
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x6C5270", Offset = "0x6C3C70", VA = "0x1806C5270")]
		[ObserversRpc]
		private void SampleWasSufficient()
		{
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x6C5150", Offset = "0x6C3B50", VA = "0x1806C5150")]
		[ObserversRpc]
		private void SampleWasInsufficient()
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x6B9B30", Offset = "0x6B8530", VA = "0x1806B9B30")]
		public float GetProductEnjoyment(ProductDefinition product, EQuality quality)
		{
			return 0f;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x6B9950", Offset = "0x6B8350", VA = "0x1806B9950")]
		public List<EDrugType> GetOrderedDrugTypes()
		{
			return null;
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x6B6010", Offset = "0x6B4A10", VA = "0x1806B6010")]
		[ServerRpc(RequireOwnership = false)]
		public void AdjustAffinity(EDrugType drugType, float change)
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x6B6290", Offset = "0x6B4C90", VA = "0x1806B6290")]
		[Button]
		public void AutocreateCustomerSettings()
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x6CACA0", Offset = "0x6C96A0", VA = "0x1806CACA0")]
		public Customer()
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x6C9D50", Offset = "0x6C8750", VA = "0x1806C9D50")]
		[CompilerGenerated]
		private void <Start>g__RegisterLoadEvent|134_0()
		{
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x6C9860", Offset = "0x6C8260", VA = "0x1806C9860")]
		[CompilerGenerated]
		private void <InstantDealOffered>g__HandoverClosed|196_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x6BC060", Offset = "0x6BAA60", VA = "0x1806BC060", Slot = "81")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x6BBFF0", Offset = "0x6BA9F0", VA = "0x1806BBFF0", Slot = "82")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x6BBFB0", Offset = "0x6BA9B0", VA = "0x1806BBFB0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x6C4B60", Offset = "0x6C3560", VA = "0x1806C4B60")]
		private void RpcWriter___Observers_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x6C15D0", Offset = "0x6BFFD0", VA = "0x1806C15D0")]
		private void RpcLogic___ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x6C3EE0", Offset = "0x6C28E0", VA = "0x1806C3EE0")]
		private void RpcReader___Observers_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x6C5BF0", Offset = "0x6C45F0", VA = "0x1806C5BF0")]
		private void RpcWriter___Target_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x6C4A10", Offset = "0x6C3410", VA = "0x1806C4A10")]
		private void RpcReader___Target_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x6C54B0", Offset = "0x6C3EB0", VA = "0x1806C54B0")]
		private void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x6C3AB0", Offset = "0x6C24B0", VA = "0x1806C3AB0")]
		private void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x6C4390", Offset = "0x6C2D90", VA = "0x1806C4390")]
		private void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x6C5740", Offset = "0x6C4140", VA = "0x1806C5740")]
		private void RpcWriter___Server_ExpireOffer_2166136261()
		{
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x6C1640", Offset = "0x6C0040", VA = "0x1806C1640", Slot = "83")]
		public virtual void RpcLogic___ExpireOffer_2166136261()
		{
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x6C4650", Offset = "0x6C3050", VA = "0x1806C4650")]
		private void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x6C5AE0", Offset = "0x6C44E0", VA = "0x1806C5AE0")]
		private void RpcWriter___Server_SendSetUpResponseCallbacks_2166136261()
		{
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x6C3A80", Offset = "0x6C2480", VA = "0x1806C3A80")]
		private void RpcLogic___SendSetUpResponseCallbacks_2166136261()
		{
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x6C49C0", Offset = "0x6C33C0", VA = "0x1806C49C0")]
		private void RpcReader___Server_SendSetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x6C5620", Offset = "0x6C4020", VA = "0x1806C5620")]
		private void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x6C3AF0", Offset = "0x6C24F0", VA = "0x1806C3AF0")]
		private void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x6C4410", Offset = "0x6C2E10", VA = "0x1806C4410")]
		private void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x6BE550", Offset = "0x6BCF50", VA = "0x1806BE550")]
		private void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x6C1740", Offset = "0x6C0140", VA = "0x1806C1740")]
		private void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x6C46A0", Offset = "0x6C30A0", VA = "0x1806C46A0")]
		private void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x6C5390", Offset = "0x6C3D90", VA = "0x1806C5390")]
		private void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
		{
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x6C3A90", Offset = "0x6C2490", VA = "0x1806C3A90")]
		private void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x6C4350", Offset = "0x6C2D50", VA = "0x1806C4350")]
		private void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x6C5980", Offset = "0x6C4380", VA = "0x1806C5980")]
		private void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x6C3A60", Offset = "0x6C2460", VA = "0x1806C3A60")]
		private void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x6C4920", Offset = "0x6C3320", VA = "0x1806C4920")]
		private void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x6C4DF0", Offset = "0x6C37F0", VA = "0x1806C4DF0")]
		private void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x6C3200", Offset = "0x6C1C00", VA = "0x1806C3200")]
		private void RpcLogic___ReceiveContractAccepted_2166136261()
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x6C40F0", Offset = "0x6C2AF0", VA = "0x1806C40F0")]
		private void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x6C4F10", Offset = "0x6C3910", VA = "0x1806C4F10")]
		private void RpcWriter___Observers_ReceiveContractRejected_2166136261()
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x6C3200", Offset = "0x6C1C00", VA = "0x1806C3200")]
		private void RpcLogic___ReceiveContractRejected_2166136261()
		{
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x6C40F0", Offset = "0x6C2AF0", VA = "0x1806C40F0")]
		private void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x6BE830", Offset = "0x6BD230", VA = "0x1806BE830")]
		private void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x6C1E20", Offset = "0x6C0820", VA = "0x1806C1E20")]
		private void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x6C4740", Offset = "0x6C3140", VA = "0x1806C4740")]
		private void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x6BE6C0", Offset = "0x6BD0C0", VA = "0x1806BE6C0")]
		private void RpcWriter___Observers_ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x6C1D90", Offset = "0x6C0790", VA = "0x1806C1D90")]
		private void RpcLogic___ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x6C3FA0", Offset = "0x6C29A0", VA = "0x1806C3FA0")]
		private void RpcReader___Observers_ProcessHandoverClient_537707335(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x6B66D0", Offset = "0x6B50D0", VA = "0x1806B66D0")]
		private void RpcWriter___Server_ChangeAddiction_431000436(float change)
		{
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x6C1570", Offset = "0x6BFF70", VA = "0x1806C1570")]
		public void RpcLogic___ChangeAddiction_431000436(float change)
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x6C45C0", Offset = "0x6C2FC0", VA = "0x1806C45C0")]
		private void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x6C11A0", Offset = "0x6BFBA0", VA = "0x1806C11A0")]
		private void RpcWriter___Server_RejectProductRequestOffer_2166136261()
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x6C3240", Offset = "0x6C1C40", VA = "0x1806C3240")]
		public void RpcLogic___RejectProductRequestOffer_2166136261()
		{
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x6C48F0", Offset = "0x6C32F0", VA = "0x1806C48F0")]
		private void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x6C5030", Offset = "0x6C3A30", VA = "0x1806C5030")]
		private void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x6C3550", Offset = "0x6C1F50", VA = "0x1806C3550")]
		private void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x6C4140", Offset = "0x6C2B40", VA = "0x1806C4140")]
		private void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x6BFF50", Offset = "0x6BE950", VA = "0x1806BFF50")]
		private void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x6C3220", Offset = "0x6C1C20", VA = "0x1806C3220")]
		private void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x6C4B00", Offset = "0x6C3500", VA = "0x1806C4B00")]
		private void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x6C5850", Offset = "0x6C4250", VA = "0x1806C5850")]
		private void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x6C2F20", Offset = "0x6C1920", VA = "0x1806C2F20")]
		private void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x6C4880", Offset = "0x6C3280", VA = "0x1806C4880")]
		private void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x6C4CD0", Offset = "0x6C36D0", VA = "0x1806C4CD0")]
		private void RpcWriter___Observers_ProcessSampleClient_2166136261()
		{
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x6C2DF0", Offset = "0x6C17F0", VA = "0x1806C2DF0")]
		private void RpcLogic___ProcessSampleClient_2166136261()
		{
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x6C40B0", Offset = "0x6C2AB0", VA = "0x1806C40B0")]
		private void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x6C5270", Offset = "0x6C3C70", VA = "0x1806C5270")]
		private void RpcWriter___Observers_SampleWasSufficient_2166136261()
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x6C38D0", Offset = "0x6C22D0", VA = "0x1806C38D0")]
		private void RpcLogic___SampleWasSufficient_2166136261()
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x6C41B0", Offset = "0x6C2BB0", VA = "0x1806C41B0")]
		private void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x6C5150", Offset = "0x6C3B50", VA = "0x1806C5150")]
		private void RpcWriter___Observers_SampleWasInsufficient_2166136261()
		{
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x6C3680", Offset = "0x6C2080", VA = "0x1806C3680")]
		private void RpcLogic___SampleWasInsufficient_2166136261()
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x6C4180", Offset = "0x6C2B80", VA = "0x1806C4180")]
		private void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x6B6010", Offset = "0x6B4A10", VA = "0x1806B6010")]
		private void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x6C1440", Offset = "0x6BFE40", VA = "0x1806C1440")]
		public void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x6C4450", Offset = "0x6C2E50", VA = "0x1806C4450")]
		private void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0000B4C0 File Offset: 0x000096C0
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000616")]
		public float SyncAccessor_<CurrentAddiction>k__BackingField
		{
			[Token(Token = "0x600242D")]
			[Address(RVA = "0x5ADF10", Offset = "0x5AC910", VA = "0x1805ADF10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600242E")]
			[Address(RVA = "0x6CB080", Offset = "0x6C9A80", VA = "0x1806CB080")]
			set
			{
			}
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x6BFB30", Offset = "0x6BE530", VA = "0x1806BFB30", Slot = "84")]
		public virtual bool ReadSyncVar___ScheduleOne.Economy.Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x0000B4F0 File Offset: 0x000096F0
		// (set) Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000617")]
		public bool SyncAccessor_<HasBeenRecommended>k__BackingField
		{
			[Token(Token = "0x6002430")]
			[Address(RVA = "0x5386C0", Offset = "0x5370C0", VA = "0x1805386C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002431")]
			[Address(RVA = "0x6CB140", Offset = "0x6C9B40", VA = "0x1806CB140")]
			set
			{
			}
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x6B6330", Offset = "0x6B4D30", VA = "0x1806B6330", Slot = "85")]
		protected virtual void Awake_UserLogic_ScheduleOne.Economy.Customer_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001BD9 RID: 7129
		[Token(Token = "0x4001BD9")]
		[FieldOffset(Offset = "0x0")]
		public static Action<Customer> onCustomerUnlocked;

		// Token: 0x04001BDA RID: 7130
		[Token(Token = "0x4001BDA")]
		[FieldOffset(Offset = "0x8")]
		public static List<Customer> LockedCustomers;

		// Token: 0x04001BDB RID: 7131
		[Token(Token = "0x4001BDB")]
		[FieldOffset(Offset = "0x10")]
		public static List<Customer> UnlockedCustomers;

		// Token: 0x04001BDC RID: 7132
		[Token(Token = "0x4001BDC")]
		public const float AFFINITY_MAX_EFFECT = 0.3f;

		// Token: 0x04001BDD RID: 7133
		[Token(Token = "0x4001BDD")]
		public const float PROPERTY_MAX_EFFECT = 0.4f;

		// Token: 0x04001BDE RID: 7134
		[Token(Token = "0x4001BDE")]
		public const float QUALITY_MAX_EFFECT = 0.3f;

		// Token: 0x04001BDF RID: 7135
		[Token(Token = "0x4001BDF")]
		public const float DEAL_REJECTED_RELATIONSHIP_CHANGE = -0.5f;

		// Token: 0x04001BE0 RID: 7136
		[Token(Token = "0x4001BE0")]
		public const int ATTACK_DEAL_COOLDOWN = 48;

		// Token: 0x04001BE1 RID: 7137
		[Token(Token = "0x4001BE1")]
		public const float RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL = 0.25f;

		// Token: 0x04001BE2 RID: 7138
		[Token(Token = "0x4001BE2")]
		public const float CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE = -0.05f;

		// Token: 0x04001BE3 RID: 7139
		[Token(Token = "0x4001BE3")]
		[FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x04001BE4 RID: 7140
		[Token(Token = "0x4001BE4")]
		public const float APPROACH_MIN_ADDICTION = 0.33f;

		// Token: 0x04001BE5 RID: 7141
		[Token(Token = "0x4001BE5")]
		public const float APPROACH_CHANCE_PER_DAY_MAX = 0.5f;

		// Token: 0x04001BE6 RID: 7142
		[Token(Token = "0x4001BE6")]
		public const float APPROACH_MIN_COOLDOWN = 2160f;

		// Token: 0x04001BE7 RID: 7143
		[Token(Token = "0x4001BE7")]
		public const float APPROACH_MAX_COOLDOWN = 4320f;

		// Token: 0x04001BE8 RID: 7144
		[Token(Token = "0x4001BE8")]
		public const int DEAL_COOLDOWN = 600;

		// Token: 0x04001BE9 RID: 7145
		[Token(Token = "0x4001BE9")]
		[FieldOffset(Offset = "0x18")]
		public static string[] PlayerAcceptMessages;

		// Token: 0x04001BEA RID: 7146
		[Token(Token = "0x4001BEA")]
		[FieldOffset(Offset = "0x20")]
		public static string[] PlayerRejectMessages;

		// Token: 0x04001BEB RID: 7147
		[Token(Token = "0x4001BEB")]
		public const int DEAL_ATTENDANCE_TOLERANCE = 10;

		// Token: 0x04001BEC RID: 7148
		[Token(Token = "0x4001BEC")]
		public const int MIN_TRAVEL_TIME = 15;

		// Token: 0x04001BED RID: 7149
		[Token(Token = "0x4001BED")]
		public const int MAX_TRAVEL_TIME = 360;

		// Token: 0x04001BEE RID: 7150
		[Token(Token = "0x4001BEE")]
		public const int OFFER_EXPIRY_TIME_MINS = 600;

		// Token: 0x04001BEF RID: 7151
		[Token(Token = "0x4001BEF")]
		public const float MIN_ORDER_APPEAL = 0.05f;

		// Token: 0x04001BF0 RID: 7152
		[Token(Token = "0x4001BF0")]
		public const float ADDICTION_DRAIN_PER_DAY = 0.0625f;

		// Token: 0x04001BF1 RID: 7153
		[Token(Token = "0x4001BF1")]
		public const bool SAMPLE_REQUIRES_RECOMMENDATION = false;

		// Token: 0x04001BF2 RID: 7154
		[Token(Token = "0x4001BF2")]
		public const float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = 0.5f;

		// Token: 0x04001BF3 RID: 7155
		[Token(Token = "0x4001BF3")]
		public const float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = 0.6f;

		// Token: 0x04001BF4 RID: 7156
		[Token(Token = "0x4001BF4")]
		public const float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = 0.6f;

		// Token: 0x04001BF6 RID: 7158
		[Token(Token = "0x4001BF6")]
		[FieldOffset(Offset = "0x120")]
		private ContractInfo offeredContractInfo;

		// Token: 0x04001C03 RID: 7171
		[Token(Token = "0x4001C03")]
		[FieldOffset(Offset = "0x168")]
		public NPCSignal_WaitForDelivery DealSignal;

		// Token: 0x04001C04 RID: 7172
		[Token(Token = "0x4001C04")]
		[FieldOffset(Offset = "0x170")]
		[Header("Settings")]
		public bool AvailableInDemo;

		// Token: 0x04001C05 RID: 7173
		[Token(Token = "0x4001C05")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		protected CustomerData customerData;

		// Token: 0x04001C06 RID: 7174
		[Token(Token = "0x4001C06")]
		[FieldOffset(Offset = "0x180")]
		public DeliveryLocation DefaultDeliveryLocation;

		// Token: 0x04001C07 RID: 7175
		[Token(Token = "0x4001C07")]
		[FieldOffset(Offset = "0x188")]
		[Header("Events")]
		public UnityEvent onUnlocked;

		// Token: 0x04001C08 RID: 7176
		[Token(Token = "0x4001C08")]
		[FieldOffset(Offset = "0x190")]
		public UnityEvent onDealCompleted;

		// Token: 0x04001C09 RID: 7177
		[Token(Token = "0x4001C09")]
		[FieldOffset(Offset = "0x198")]
		public UnityEvent<Contract> onContractAssigned;

		// Token: 0x04001C0A RID: 7178
		[Token(Token = "0x4001C0A")]
		[FieldOffset(Offset = "0x1A0")]
		private bool awaitingSample;

		// Token: 0x04001C0B RID: 7179
		[Token(Token = "0x4001C0B")]
		[FieldOffset(Offset = "0x1A8")]
		private DialogueController.DialogueChoice sampleChoice;

		// Token: 0x04001C0C RID: 7180
		[Token(Token = "0x4001C0C")]
		[FieldOffset(Offset = "0x1B0")]
		private DialogueController.DialogueChoice completeContractChoice;

		// Token: 0x04001C0D RID: 7181
		[Token(Token = "0x4001C0D")]
		[FieldOffset(Offset = "0x1B8")]
		private DialogueController.DialogueChoice offerDealChoice;

		// Token: 0x04001C0E RID: 7182
		[Token(Token = "0x4001C0E")]
		[FieldOffset(Offset = "0x1C0")]
		private DialogueController.GreetingOverride awaitingDealGreeting;

		// Token: 0x04001C0F RID: 7183
		[Token(Token = "0x4001C0F")]
		[FieldOffset(Offset = "0x1C8")]
		private int minsSinceUnlocked;

		// Token: 0x04001C10 RID: 7184
		[Token(Token = "0x4001C10")]
		[FieldOffset(Offset = "0x1CC")]
		private bool sampleOfferedToday;

		// Token: 0x04001C12 RID: 7186
		[Token(Token = "0x4001C12")]
		[FieldOffset(Offset = "0x1D8")]
		private CustomerAffinityData currentAffinityData;

		// Token: 0x04001C13 RID: 7187
		[Token(Token = "0x4001C13")]
		[FieldOffset(Offset = "0x1E0")]
		private bool pendingInstantDeal;

		// Token: 0x04001C17 RID: 7191
		[Token(Token = "0x4001C17")]
		[FieldOffset(Offset = "0x200")]
		private ProductItemInstance consumedSample;

		// Token: 0x04001C18 RID: 7192
		[Token(Token = "0x4001C18")]
		[FieldOffset(Offset = "0x208")]
		public SyncVar<float> syncVar___<CurrentAddiction>k__BackingField;

		// Token: 0x04001C19 RID: 7193
		[Token(Token = "0x4001C19")]
		[FieldOffset(Offset = "0x210")]
		public SyncVar<bool> syncVar___<HasBeenRecommended>k__BackingField;

		// Token: 0x04001C1A RID: 7194
		[Token(Token = "0x4001C1A")]
		[FieldOffset(Offset = "0x218")]
		private bool NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001C1B RID: 7195
		[Token(Token = "0x4001C1B")]
		[FieldOffset(Offset = "0x219")]
		private bool NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted;

		// Token: 0x020005CA RID: 1482
		[Token(Token = "0x20005CA")]
		[Serializable]
		public class ScheduleGroupPair
		{
			// Token: 0x06002433 RID: 9267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002433")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ScheduleGroupPair()
			{
			}

			// Token: 0x04001C1C RID: 7196
			[Token(Token = "0x4001C1C")]
			[FieldOffset(Offset = "0x10")]
			public GameObject NormalScheduleGroup;

			// Token: 0x04001C1D RID: 7197
			[Token(Token = "0x4001C1D")]
			[FieldOffset(Offset = "0x18")]
			public GameObject CurfewScheduleGroup;
		}

		// Token: 0x020005CB RID: 1483
		[Token(Token = "0x20005CB")]
		[Serializable]
		public class CustomerPreference
		{
			// Token: 0x06002434 RID: 9268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002434")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public CustomerPreference()
			{
			}

			// Token: 0x04001C1E RID: 7198
			[Token(Token = "0x4001C1E")]
			[FieldOffset(Offset = "0x10")]
			public EDrugType DrugType;

			// Token: 0x04001C1F RID: 7199
			[Token(Token = "0x4001C1F")]
			[FieldOffset(Offset = "0x18")]
			[Header("Optionally, a specific product")]
			public ProductDefinition Definition;

			// Token: 0x04001C20 RID: 7200
			[Token(Token = "0x4001C20")]
			[FieldOffset(Offset = "0x20")]
			public EQuality MinimumQuality;
		}

		// Token: 0x020005CC RID: 1484
		[Token(Token = "0x20005CC")]
		public enum ESampleFeedback
		{
			// Token: 0x04001C22 RID: 7202
			[Token(Token = "0x4001C22")]
			WrongProduct,
			// Token: 0x04001C23 RID: 7203
			[Token(Token = "0x4001C23")]
			WrongQuality,
			// Token: 0x04001C24 RID: 7204
			[Token(Token = "0x4001C24")]
			Correct
		}
	}
}
