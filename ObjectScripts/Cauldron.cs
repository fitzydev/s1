using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Misc;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C94 RID: 3220
	[Token(Token = "0x2000C94")]
	public class Cauldron : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060057F1 RID: 22513 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x17000C27")]
		public bool isOpen
		{
			[Token(Token = "0x60057F1")]
			[Address(RVA = "0xA14780", Offset = "0xA13180", VA = "0x180A14780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057F3 RID: 22515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C28")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60057F2")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057F3")]
			[Address(RVA = "0x630500", Offset = "0x62EF00", VA = "0x180630500", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060057F4 RID: 22516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057F5 RID: 22517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C29")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60057F4")]
			[Address(RVA = "0xA14720", Offset = "0xA13120", VA = "0x180A14720", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057F5")]
			[Address(RVA = "0xA0FC60", Offset = "0xA0E660", VA = "0x180A0FC60", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057F7 RID: 22519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C2A")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60057F6")]
			[Address(RVA = "0xA14740", Offset = "0xA13140", VA = "0x180A14740", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057F7")]
			[Address(RVA = "0xA0FD00", Offset = "0xA0E700", VA = "0x180A0FD00", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2B")]
		public string Name
		{
			[Token(Token = "0x60057F8")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060057F9 RID: 22521 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057FA RID: 22522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C2C")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60057F9")]
			[Address(RVA = "0xA14700", Offset = "0xA13100", VA = "0x180A14700", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057FA")]
			[Address(RVA = "0xA14890", Offset = "0xA13290", VA = "0x180A14890", Slot = "89")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060057FB RID: 22523 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057FC RID: 22524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C2D")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60057FB")]
			[Address(RVA = "0xA14730", Offset = "0xA13130", VA = "0x180A14730", Slot = "90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057FC")]
			[Address(RVA = "0xA148C0", Offset = "0xA132C0", VA = "0x180A148C0", Slot = "91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060057FD RID: 22525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2E")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x60057FD")]
			[Address(RVA = "0x716B70", Offset = "0x715570", VA = "0x180716B70", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060057FE RID: 22526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2F")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x60057FE")]
			[Address(RVA = "0x716CC0", Offset = "0x7156C0", VA = "0x180716CC0", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060057FF RID: 22527 RVA: 0x00015B58 File Offset: 0x00013D58
		[Token(Token = "0x17000C30")]
		public bool Selectable
		{
			[Token(Token = "0x60057FF")]
			[Address(RVA = "0xA14750", Offset = "0xA13150", VA = "0x180A14750", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06005800 RID: 22528 RVA: 0x00015B70 File Offset: 0x00013D70
		// (set) Token: 0x06005801 RID: 22529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C31")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005800")]
			[Address(RVA = "0xA14710", Offset = "0xA13110", VA = "0x180A14710", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005801")]
			[Address(RVA = "0xA148B0", Offset = "0xA132B0", VA = "0x180A148B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C32")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6005802")]
			[Address(RVA = "0xA146E0", Offset = "0xA130E0", VA = "0x180A146E0", Slot = "109")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06005803 RID: 22531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005804 RID: 22532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C33")]
		protected CauldronConfiguration cauldronConfiguration
		{
			[Token(Token = "0x6005803")]
			[Address(RVA = "0xA146E0", Offset = "0xA130E0", VA = "0x180A146E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005804")]
			[Address(RVA = "0xA14900", Offset = "0xA13300", VA = "0x180A14900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06005805 RID: 22533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C34")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6005805")]
			[Address(RVA = "0x62FE10", Offset = "0x62E810", VA = "0x18062FE10", Slot = "110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x17000C35")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6005806")]
			[Address(RVA = "0xA146D0", Offset = "0xA130D0", VA = "0x180A146D0", Slot = "111")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06005807 RID: 22535 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005808 RID: 22536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C36")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6005807")]
			[Address(RVA = "0xA14760", Offset = "0xA13160", VA = "0x180A14760", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005808")]
			[Address(RVA = "0xA148E0", Offset = "0xA132E0", VA = "0x180A148E0", Slot = "113")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06005809 RID: 22537 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600580A RID: 22538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C37")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6005809")]
			[Address(RVA = "0xA146F0", Offset = "0xA130F0", VA = "0x180A146F0", Slot = "114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600580A")]
			[Address(RVA = "0xA0FB30", Offset = "0xA0E530", VA = "0x180A0FB30", Slot = "115")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580B")]
		[Address(RVA = "0xA12890", Offset = "0xA11290", VA = "0x180A12890", Slot = "129")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C38")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x600580C")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0", Slot = "117")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600580D RID: 22541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C39")]
		public Transform Transform
		{
			[Token(Token = "0x600580D")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "118")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3A")]
		public Transform UIPoint
		{
			[Token(Token = "0x600580E")]
			[Address(RVA = "0x716B70", Offset = "0x715570", VA = "0x180716B70", Slot = "119")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600580F RID: 22543 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[Token(Token = "0x17000C3B")]
		public bool CanBeSelected
		{
			[Token(Token = "0x600580F")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x00015BB8 File Offset: 0x00013DB8
		[Token(Token = "0x17000C3C")]
		private bool isCooking
		{
			[Token(Token = "0x6005810")]
			[Address(RVA = "0xA14770", Offset = "0xA13170", VA = "0x180A14770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005811")]
		[Address(RVA = "0xA0C400", Offset = "0xA0AE00", VA = "0x180A0C400", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005812")]
		[Address(RVA = "0xA0E450", Offset = "0xA0CE50", VA = "0x180A0E450", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005813")]
		[Address(RVA = "0xA13FE0", Offset = "0xA129E0", VA = "0x180A13FE0", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005814")]
		[Address(RVA = "0xA0F0D0", Offset = "0xA0DAD0", VA = "0x180A0F0D0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005815")]
		[Address(RVA = "0xA12730", Offset = "0xA11130", VA = "0x180A12730", Slot = "130")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005816")]
		[Address(RVA = "0xA0CF90", Offset = "0xA0B990", VA = "0x180A0CF90", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005817")]
		[Address(RVA = "0xA0E690", Offset = "0xA0D090", VA = "0x180A0E690")]
		private void MinPass()
		{
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005818")]
		[Address(RVA = "0xA14280", Offset = "0xA12C80", VA = "0x180A14280")]
		private void TimeSkipped(int minsPassed)
		{
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005819")]
		[Address(RVA = "0xA0D360", Offset = "0xA0BD60", VA = "0x180A0D360")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581A")]
		[Address(RVA = "0xA0E310", Offset = "0xA0CD10", VA = "0x180A0E310")]
		public void Hovered()
		{
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581B")]
		[Address(RVA = "0xA0E5E0", Offset = "0xA0CFE0", VA = "0x180A0E5E0")]
		public void Interacted()
		{
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581C")]
		[Address(RVA = "0xA0F260", Offset = "0xA0DC60", VA = "0x180A0F260")]
		public void Open()
		{
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581D")]
		[Address(RVA = "0xA0C570", Offset = "0xA0AF70", VA = "0x180A0C570")]
		public void Close()
		{
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x00015BD0 File Offset: 0x00013DD0
		[Token(Token = "0x600581E")]
		[Address(RVA = "0xA0C470", Offset = "0xA0AE70", VA = "0x180A0C470", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581F")]
		[Address(RVA = "0xA144F0", Offset = "0xA12EF0", VA = "0x180A144F0")]
		private void UpdateIngredientVisuals()
		{
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005820")]
		[Address(RVA = "0xA0D8E0", Offset = "0xA0C2E0", VA = "0x180A0D8E0")]
		public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x00015BE8 File Offset: 0x00013DE8
		[Token(Token = "0x6005821")]
		[Address(RVA = "0xA0E080", Offset = "0xA0CA80", VA = "0x180A0E080")]
		public Cauldron.EState GetState()
		{
			return Cauldron.EState.MissingIngredients;
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x6005822")]
		[Address(RVA = "0xA0E2A0", Offset = "0xA0CCA0", VA = "0x180A0E2A0")]
		public bool HasOutputSpace()
		{
			return default(bool);
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x00015C18 File Offset: 0x00013E18
		[Token(Token = "0x6005823")]
		[Address(RVA = "0xA0F800", Offset = "0xA0E200", VA = "0x180A0F800")]
		public EQuality RemoveIngredients()
		{
			return EQuality.Trash;
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x00015C30 File Offset: 0x00013E30
		[Token(Token = "0x6005824")]
		[Address(RVA = "0xA0E1D0", Offset = "0xA0CBD0", VA = "0x180A0E1D0")]
		public bool HasIngredients()
		{
			return default(bool);
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005825")]
		[Address(RVA = "0xA11660", Offset = "0xA10060", VA = "0x180A11660")]
		[ServerRpc(RequireOwnership = false)]
		public void SendCookOperation(int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005826")]
		[Address(RVA = "0xA13D20", Offset = "0xA12720", VA = "0x180A13D20")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void StartCookOperation(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005827")]
		[Address(RVA = "0xA0D4B0", Offset = "0xA0BEB0", VA = "0x180A0D4B0")]
		[ObserversRpc]
		public void FinishCookOperation()
		{
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005828")]
		[Address(RVA = "0xA0C450", Offset = "0xA0AE50", VA = "0x180A0C450")]
		private void ButtonClicked(RaycastHit hit)
		{
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005829")]
		[Address(RVA = "0xA0C8C0", Offset = "0xA0B2C0", VA = "0x180A0C8C0")]
		public void CreateTrash(List<StationItem> mixerItems)
		{
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582A")]
		[Address(RVA = "0xA12E10", Offset = "0xA11810", VA = "0x180A12E10", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582B")]
		[Address(RVA = "0xA12CE0", Offset = "0xA116E0", VA = "0x180A12CE0", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582C")]
		[Address(RVA = "0xA13B80", Offset = "0xA12580", VA = "0x180A13B80", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582D")]
		[Address(RVA = "0xA138C0", Offset = "0xA122C0", VA = "0x180A138C0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582E")]
		[Address(RVA = "0xA12B70", Offset = "0xA11570", VA = "0x180A12B70", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582F")]
		[Address(RVA = "0xA129C0", Offset = "0xA113C0", VA = "0x180A129C0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005830")]
		[Address(RVA = "0xA136D0", Offset = "0xA120D0", VA = "0x180A136D0", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005831")]
		[Address(RVA = "0xA133A0", Offset = "0xA11DA0", VA = "0x180A133A0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005832")]
		[Address(RVA = "0xA13200", Offset = "0xA11C00", VA = "0x180A13200", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005833")]
		[Address(RVA = "0xA12F40", Offset = "0xA11940", VA = "0x180A12F40")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005834")]
		[Address(RVA = "0xA0CD60", Offset = "0xA0B760", VA = "0x180A0CD60", Slot = "123")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005835")]
		[Address(RVA = "0xA0D2D0", Offset = "0xA0BCD0", VA = "0x180A0D2D0", Slot = "124")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005836")]
		[Address(RVA = "0xA0D5D0", Offset = "0xA0BFD0", VA = "0x180A0D5D0", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005837")]
		[Address(RVA = "0xA0DFD0", Offset = "0xA0C9D0", VA = "0x180A0DFD0", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005838")]
		[Address(RVA = "0xA145C0", Offset = "0xA12FC0", VA = "0x180A145C0")]
		public Cauldron()
		{
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005839")]
		[Address(RVA = "0xA0E970", Offset = "0xA0D370", VA = "0x180A0E970", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583A")]
		[Address(RVA = "0xA0E8E0", Offset = "0xA0D2E0", VA = "0x180A0E8E0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583B")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583C")]
		[Address(RVA = "0xA117D0", Offset = "0xA101D0", VA = "0x180A117D0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583D")]
		[Address(RVA = "0xA0FB30", Offset = "0xA0E530", VA = "0x180A0FB30", Slot = "131")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583E")]
		[Address(RVA = "0xA106A0", Offset = "0xA0F0A0", VA = "0x180A106A0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583F")]
		[Address(RVA = "0xA11660", Offset = "0xA10060", VA = "0x180A11660")]
		private void RpcWriter___Server_SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005840")]
		[Address(RVA = "0xA0FB10", Offset = "0xA0E510", VA = "0x180A0FB10")]
		public void RpcLogic___SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005841")]
		[Address(RVA = "0xA10620", Offset = "0xA0F020", VA = "0x180A10620")]
		private void RpcReader___Server_SendCookOperation_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005842")]
		[Address(RVA = "0xA114F0", Offset = "0xA0FEF0", VA = "0x180A114F0")]
		private void RpcWriter___Observers_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005843")]
		[Address(RVA = "0xA10110", Offset = "0xA0EB10", VA = "0x180A10110")]
		public void RpcLogic___StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005844")]
		[Address(RVA = "0xA10590", Offset = "0xA0EF90", VA = "0x180A10590")]
		private void RpcReader___Observers_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005845")]
		[Address(RVA = "0xA125C0", Offset = "0xA10FC0", VA = "0x180A125C0")]
		private void RpcWriter___Target_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005846")]
		[Address(RVA = "0xA10E40", Offset = "0xA0F840", VA = "0x180A10E40")]
		private void RpcReader___Target_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005847")]
		[Address(RVA = "0xA0D4B0", Offset = "0xA0BEB0", VA = "0x180A0D4B0")]
		private void RpcWriter___Observers_FinishCookOperation_2166136261()
		{
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005848")]
		[Address(RVA = "0xA0FA00", Offset = "0xA0E400", VA = "0x180A0FA00")]
		public void RpcLogic___FinishCookOperation_2166136261()
		{
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005849")]
		[Address(RVA = "0xA101C0", Offset = "0xA0EBC0", VA = "0x180A101C0")]
		private void RpcReader___Observers_FinishCookOperation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584A")]
		[Address(RVA = "0xA11BB0", Offset = "0xA105B0", VA = "0x180A11BB0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584B")]
		[Address(RVA = "0xA0FD00", Offset = "0xA0E700", VA = "0x180A0FD00", Slot = "132")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584C")]
		[Address(RVA = "0xA10850", Offset = "0xA0F250", VA = "0x180A10850")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584D")]
		[Address(RVA = "0xA11A80", Offset = "0xA10480", VA = "0x180A11A80")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584E")]
		[Address(RVA = "0xA0FC60", Offset = "0xA0E660", VA = "0x180A0FC60", Slot = "133")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584F")]
		[Address(RVA = "0xA107D0", Offset = "0xA0F1D0", VA = "0x180A107D0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005850")]
		[Address(RVA = "0xA11FE0", Offset = "0xA109E0", VA = "0x180A11FE0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005851")]
		[Address(RVA = "0xA0FFD0", Offset = "0xA0E9D0", VA = "0x180A0FFD0", Slot = "134")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005852")]
		[Address(RVA = "0xA10B10", Offset = "0xA0F510", VA = "0x180A10B10")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005853")]
		[Address(RVA = "0xA11370", Offset = "0xA0FD70", VA = "0x180A11370")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005854")]
		[Address(RVA = "0xA10050", Offset = "0xA0EA50", VA = "0x180A10050")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005855")]
		[Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005856")]
		[Address(RVA = "0xA12450", Offset = "0xA10E50", VA = "0x180A12450")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005857")]
		[Address(RVA = "0xA10DA0", Offset = "0xA0F7A0", VA = "0x180A10DA0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005858")]
		[Address(RVA = "0xA11900", Offset = "0xA10300", VA = "0x180A11900")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005859")]
		[Address(RVA = "0xA0FBD0", Offset = "0xA0E5D0", VA = "0x180A0FBD0", Slot = "135")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585A")]
		[Address(RVA = "0xA10720", Offset = "0xA0F120", VA = "0x180A10720")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585B")]
		[Address(RVA = "0xA10ED0", Offset = "0xA0F8D0", VA = "0x180A10ED0")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585C")]
		[Address(RVA = "0xA0FBE0", Offset = "0xA0E5E0", VA = "0x180A0FBE0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585D")]
		[Address(RVA = "0xA102E0", Offset = "0xA0ECE0", VA = "0x180A102E0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585E")]
		[Address(RVA = "0xA11E50", Offset = "0xA10850", VA = "0x180A11E50")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585F")]
		[Address(RVA = "0xA0FEA0", Offset = "0xA0E8A0", VA = "0x180A0FEA0", Slot = "136")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005860")]
		[Address(RVA = "0xA109C0", Offset = "0xA0F3C0", VA = "0x180A109C0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005861")]
		[Address(RVA = "0xA122C0", Offset = "0xA10CC0", VA = "0x180A122C0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005862")]
		[Address(RVA = "0xA0FF20", Offset = "0xA0E920", VA = "0x180A0FF20")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005863")]
		[Address(RVA = "0xA10CA0", Offset = "0xA0F6A0", VA = "0x180A10CA0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005864")]
		[Address(RVA = "0xA111D0", Offset = "0xA0FBD0", VA = "0x180A111D0")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005865")]
		[Address(RVA = "0xA10410", Offset = "0xA0EE10", VA = "0x180A10410")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005866")]
		[Address(RVA = "0xA11CE0", Offset = "0xA106E0", VA = "0x180A11CE0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005867")]
		[Address(RVA = "0xA0FDA0", Offset = "0xA0E7A0", VA = "0x180A0FDA0", Slot = "137")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005868 RID: 22632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005868")]
		[Address(RVA = "0xA108D0", Offset = "0xA0F2D0", VA = "0x180A108D0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005869")]
		[Address(RVA = "0xA11050", Offset = "0xA0FA50", VA = "0x180A11050")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586A")]
		[Address(RVA = "0xA0FE20", Offset = "0xA0E820", VA = "0x180A0FE20")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586B")]
		[Address(RVA = "0xA10380", Offset = "0xA0ED80", VA = "0x180A10380")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586C")]
		[Address(RVA = "0xA12150", Offset = "0xA10B50", VA = "0x180A12150")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586D")]
		[Address(RVA = "0xA10C00", Offset = "0xA0F600", VA = "0x180A10C00")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x0600586E RID: 22638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600586F RID: 22639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C3D")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x600586E")]
			[Address(RVA = "0xA14720", Offset = "0xA13120", VA = "0x180A14720")]
			get
			{
				return null;
			}
			[Token(Token = "0x600586F")]
			[Address(RVA = "0xA149E0", Offset = "0xA133E0", VA = "0x180A149E0")]
			set
			{
			}
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x00015C48 File Offset: 0x00013E48
		[Token(Token = "0x6005870")]
		[Address(RVA = "0xA0F660", Offset = "0xA0E060", VA = "0x180A0F660", Slot = "138")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.Cauldron(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06005871 RID: 22641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005872 RID: 22642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C3E")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005871")]
			[Address(RVA = "0xA14740", Offset = "0xA13140", VA = "0x180A14740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005872")]
			[Address(RVA = "0xA14AA0", Offset = "0xA134A0", VA = "0x180A14AA0")]
			set
			{
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06005873 RID: 22643 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005874 RID: 22644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C3F")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6005873")]
			[Address(RVA = "0xA146F0", Offset = "0xA130F0", VA = "0x180A146F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005874")]
			[Address(RVA = "0xA14920", Offset = "0xA13320", VA = "0x180A14920")]
			set
			{
			}
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005875")]
		[Address(RVA = "0xA0BD30", Offset = "0xA0A730", VA = "0x180A0BD30", Slot = "139")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.Cauldron_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040040DF RID: 16607
		[Token(Token = "0x40040DF")]
		public const int INGREDIENT_SLOT_COUNT = 4;

		// Token: 0x040040E0 RID: 16608
		[Token(Token = "0x40040E0")]
		public const int COCA_LEAF_REQUIRED = 20;

		// Token: 0x040040E1 RID: 16609
		[Token(Token = "0x40040E1")]
		[FieldOffset(Offset = "0x218")]
		public ItemSlot[] IngredientSlots;

		// Token: 0x040040E2 RID: 16610
		[Token(Token = "0x40040E2")]
		[FieldOffset(Offset = "0x220")]
		public ItemSlot LiquidSlot;

		// Token: 0x040040E3 RID: 16611
		[Token(Token = "0x40040E3")]
		[FieldOffset(Offset = "0x228")]
		public ItemSlot OutputSlot;

		// Token: 0x040040E5 RID: 16613
		[Token(Token = "0x40040E5")]
		[FieldOffset(Offset = "0x238")]
		public int CookTime;

		// Token: 0x040040E6 RID: 16614
		[Token(Token = "0x40040E6")]
		[FieldOffset(Offset = "0x240")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x040040E7 RID: 16615
		[Token(Token = "0x40040E7")]
		[FieldOffset(Offset = "0x248")]
		public Transform CameraPosition_CombineIngredients;

		// Token: 0x040040E8 RID: 16616
		[Token(Token = "0x40040E8")]
		[FieldOffset(Offset = "0x250")]
		public Transform CameraPosition_StartMachine;

		// Token: 0x040040E9 RID: 16617
		[Token(Token = "0x40040E9")]
		[FieldOffset(Offset = "0x258")]
		public InteractableObject IntObj;

		// Token: 0x040040EA RID: 16618
		[Token(Token = "0x40040EA")]
		[FieldOffset(Offset = "0x260")]
		public Transform[] accessPoints;

		// Token: 0x040040EB RID: 16619
		[Token(Token = "0x40040EB")]
		[FieldOffset(Offset = "0x268")]
		public Transform StandPoint;

		// Token: 0x040040EC RID: 16620
		[Token(Token = "0x40040EC")]
		[FieldOffset(Offset = "0x270")]
		public Transform uiPoint;

		// Token: 0x040040ED RID: 16621
		[Token(Token = "0x40040ED")]
		[FieldOffset(Offset = "0x278")]
		public StorageVisualizer LiquidVisuals;

		// Token: 0x040040EE RID: 16622
		[Token(Token = "0x40040EE")]
		[FieldOffset(Offset = "0x280")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040040EF RID: 16623
		[Token(Token = "0x40040EF")]
		[FieldOffset(Offset = "0x288")]
		public CauldronDisplayTub PrimaryTub;

		// Token: 0x040040F0 RID: 16624
		[Token(Token = "0x40040F0")]
		[FieldOffset(Offset = "0x290")]
		public CauldronDisplayTub SecondaryTub;

		// Token: 0x040040F1 RID: 16625
		[Token(Token = "0x40040F1")]
		[FieldOffset(Offset = "0x298")]
		public Transform ItemContainer;

		// Token: 0x040040F2 RID: 16626
		[Token(Token = "0x40040F2")]
		[FieldOffset(Offset = "0x2A0")]
		public Transform GasolineSpawnPoint;

		// Token: 0x040040F3 RID: 16627
		[Token(Token = "0x40040F3")]
		[FieldOffset(Offset = "0x2A8")]
		public Transform TubSpawnPoint;

		// Token: 0x040040F4 RID: 16628
		[Token(Token = "0x40040F4")]
		[FieldOffset(Offset = "0x2B0")]
		public Transform[] LeafSpawns;

		// Token: 0x040040F5 RID: 16629
		[Token(Token = "0x40040F5")]
		[FieldOffset(Offset = "0x2B8")]
		public Light OverheadLight;

		// Token: 0x040040F6 RID: 16630
		[Token(Token = "0x40040F6")]
		[FieldOffset(Offset = "0x2C0")]
		public Fillable CauldronFillable;

		// Token: 0x040040F7 RID: 16631
		[Token(Token = "0x40040F7")]
		[FieldOffset(Offset = "0x2C8")]
		public Clickable StartButtonClickable;

		// Token: 0x040040F8 RID: 16632
		[Token(Token = "0x40040F8")]
		[FieldOffset(Offset = "0x2D0")]
		public DigitalAlarm Alarm;

		// Token: 0x040040F9 RID: 16633
		[Token(Token = "0x40040F9")]
		[FieldOffset(Offset = "0x2D8")]
		public ToggleableLight Light;

		// Token: 0x040040FA RID: 16634
		[Token(Token = "0x40040FA")]
		[FieldOffset(Offset = "0x2E0")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x040040FB RID: 16635
		[Token(Token = "0x40040FB")]
		[FieldOffset(Offset = "0x2E8")]
		public BoxCollider TrashSpawnVolume;

		// Token: 0x040040FC RID: 16636
		[Token(Token = "0x40040FC")]
		[FieldOffset(Offset = "0x2F0")]
		[Header("Prefabs")]
		public StationItem CocaLeafPrefab;

		// Token: 0x040040FD RID: 16637
		[Token(Token = "0x40040FD")]
		[FieldOffset(Offset = "0x2F8")]
		public StationItem GasolinePrefab;

		// Token: 0x040040FE RID: 16638
		[Token(Token = "0x40040FE")]
		[FieldOffset(Offset = "0x300")]
		public Draggable TubPrefab;

		// Token: 0x040040FF RID: 16639
		[Token(Token = "0x40040FF")]
		[FieldOffset(Offset = "0x308")]
		public QualityItemDefinition CocaineBaseDefinition;

		// Token: 0x04004100 RID: 16640
		[Token(Token = "0x4004100")]
		[FieldOffset(Offset = "0x310")]
		[Header("UI")]
		public CauldronUIElement WorldspaceUIPrefab;

		// Token: 0x04004101 RID: 16641
		[Token(Token = "0x4004101")]
		[FieldOffset(Offset = "0x318")]
		public Sprite typeIcon;

		// Token: 0x04004102 RID: 16642
		[Token(Token = "0x4004102")]
		[FieldOffset(Offset = "0x320")]
		public UnityEvent onStartButtonClicked;

		// Token: 0x04004103 RID: 16643
		[Token(Token = "0x4004103")]
		[FieldOffset(Offset = "0x328")]
		public UnityEvent onCookStart;

		// Token: 0x04004104 RID: 16644
		[Token(Token = "0x4004104")]
		[FieldOffset(Offset = "0x330")]
		public UnityEvent onCookEnd;

		// Token: 0x04004105 RID: 16645
		[Token(Token = "0x4004105")]
		[FieldOffset(Offset = "0x338")]
		public int RemainingCookTime;

		// Token: 0x04004106 RID: 16646
		[Token(Token = "0x4004106")]
		[FieldOffset(Offset = "0x33C")]
		public EQuality InputQuality;

		// Token: 0x04004110 RID: 16656
		[Token(Token = "0x4004110")]
		[FieldOffset(Offset = "0x380")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04004111 RID: 16657
		[Token(Token = "0x4004111")]
		[FieldOffset(Offset = "0x388")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04004112 RID: 16658
		[Token(Token = "0x4004112")]
		[FieldOffset(Offset = "0x390")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04004113 RID: 16659
		[Token(Token = "0x4004113")]
		[FieldOffset(Offset = "0x398")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted;

		// Token: 0x04004114 RID: 16660
		[Token(Token = "0x4004114")]
		[FieldOffset(Offset = "0x399")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted;

		// Token: 0x02000C95 RID: 3221
		[Token(Token = "0x2000C95")]
		public enum EState
		{
			// Token: 0x04004116 RID: 16662
			[Token(Token = "0x4004116")]
			MissingIngredients,
			// Token: 0x04004117 RID: 16663
			[Token(Token = "0x4004117")]
			Ready,
			// Token: 0x04004118 RID: 16664
			[Token(Token = "0x4004118")]
			Cooking,
			// Token: 0x04004119 RID: 16665
			[Token(Token = "0x4004119")]
			OutputFull
		}
	}
}
