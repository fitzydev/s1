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
using ScheduleOne.Decoration;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CBC RID: 3260
	[Token(Token = "0x2000CBC")]
	public class PackagingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06005BCA RID: 23498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BCB RID: 23499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCE")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6005BCA")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BCB")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06005BCC RID: 23500 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BCD RID: 23501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CCF")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6005BCC")]
			[Address(RVA = "0xA0B170", Offset = "0xA09B70", VA = "0x180A0B170", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BCD")]
			[Address(RVA = "0xA47920", Offset = "0xA46320", VA = "0x180A47920", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BCF RID: 23503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CD0")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005BCE")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BCF")]
			[Address(RVA = "0xA4C550", Offset = "0xA4AF50", VA = "0x180A4C550", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD1")]
		public string Name
		{
			[Token(Token = "0x6005BD0")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BD2 RID: 23506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CD2")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6005BD1")]
			[Address(RVA = "0xA14730", Offset = "0xA13130", VA = "0x180A14730", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BD2")]
			[Address(RVA = "0xA148C0", Offset = "0xA132C0", VA = "0x180A148C0", Slot = "89")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06005BD3 RID: 23507 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BD4 RID: 23508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CD3")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6005BD3")]
			[Address(RVA = "0xA3BF90", Offset = "0xA3A990", VA = "0x180A3BF90", Slot = "90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BD4")]
			[Address(RVA = "0xA4C530", Offset = "0xA4AF30", VA = "0x180A4C530", Slot = "91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06005BD5 RID: 23509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD4")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6005BD5")]
			[Address(RVA = "0x62FC80", Offset = "0x62E680", VA = "0x18062FC80", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06005BD6 RID: 23510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD5")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6005BD6")]
			[Address(RVA = "0x716F20", Offset = "0x715920", VA = "0x180716F20", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06005BD7 RID: 23511 RVA: 0x000164D0 File Offset: 0x000146D0
		[Token(Token = "0x17000CD6")]
		public bool Selectable
		{
			[Token(Token = "0x6005BD7")]
			[Address(RVA = "0xA4C510", Offset = "0xA4AF10", VA = "0x180A4C510", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06005BD8 RID: 23512 RVA: 0x000164E8 File Offset: 0x000146E8
		// (set) Token: 0x06005BD9 RID: 23513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CD7")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005BD8")]
			[Address(RVA = "0xA4C500", Offset = "0xA4AF00", VA = "0x180A4C500", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005BD9")]
			[Address(RVA = "0xA4C520", Offset = "0xA4AF20", VA = "0x180A4C520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06005BDA RID: 23514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD8")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6005BDA")]
			[Address(RVA = "0xA14760", Offset = "0xA13160", VA = "0x180A14760", Slot = "109")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06005BDB RID: 23515 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BDC RID: 23516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CD9")]
		protected PackagingStationConfiguration stationConfiguration
		{
			[Token(Token = "0x6005BDB")]
			[Address(RVA = "0xA14760", Offset = "0xA13160", VA = "0x180A14760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BDC")]
			[Address(RVA = "0xA148E0", Offset = "0xA132E0", VA = "0x180A148E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06005BDD RID: 23517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDA")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6005BDD")]
			[Address(RVA = "0x8C8800", Offset = "0x8C7200", VA = "0x1808C8800", Slot = "110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x00016500 File Offset: 0x00014700
		[Token(Token = "0x17000CDB")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6005BDE")]
			[Address(RVA = "0x6A4540", Offset = "0x6A2F40", VA = "0x1806A4540", Slot = "111")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06005BDF RID: 23519 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BE0 RID: 23520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CDC")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6005BDF")]
			[Address(RVA = "0xA146F0", Offset = "0xA130F0", VA = "0x180A146F0", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BE0")]
			[Address(RVA = "0xA4C5F0", Offset = "0xA4AFF0", VA = "0x180A4C5F0", Slot = "113")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06005BE1 RID: 23521 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005BE2 RID: 23522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CDD")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6005BE1")]
			[Address(RVA = "0x68D3C0", Offset = "0x68BDC0", VA = "0x18068D3C0", Slot = "114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BE2")]
			[Address(RVA = "0xA477F0", Offset = "0xA461F0", VA = "0x180A477F0", Slot = "115")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0xA4A040", Offset = "0xA48A40", VA = "0x180A4A040", Slot = "129")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDE")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6005BE4")]
			[Address(RVA = "0x62FC60", Offset = "0x62E660", VA = "0x18062FC60", Slot = "117")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06005BE5 RID: 23525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDF")]
		public Transform Transform
		{
			[Token(Token = "0x6005BE5")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "118")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE0")]
		public Transform UIPoint
		{
			[Token(Token = "0x6005BE6")]
			[Address(RVA = "0x62FC80", Offset = "0x62E680", VA = "0x18062FC80", Slot = "119")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06005BE7 RID: 23527 RVA: 0x00016518 File Offset: 0x00014718
		[Token(Token = "0x17000CE1")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6005BE7")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0xA450E0", Offset = "0xA43AE0", VA = "0x180A450E0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0xA463E0", Offset = "0xA44DE0", VA = "0x180A463E0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0xA46D10", Offset = "0xA45710", VA = "0x180A46D10", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0xA49EE0", Offset = "0xA488E0", VA = "0x180A49EE0", Slot = "130")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0xA45A70", Offset = "0xA44470", VA = "0x180A45A70")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x00016530 File Offset: 0x00014730
		[Token(Token = "0x6005BED")]
		[Address(RVA = "0xA45130", Offset = "0xA43B30", VA = "0x180A45130", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEE")]
		[Address(RVA = "0xA45880", Offset = "0xA44280", VA = "0x180A45880", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEF")]
		[Address(RVA = "0xA4A700", Offset = "0xA49100", VA = "0x180A4A700", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF0")]
		[Address(RVA = "0xA4A5D0", Offset = "0xA48FD0", VA = "0x180A4A5D0", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF1")]
		[Address(RVA = "0xA462A0", Offset = "0xA44CA0", VA = "0x180A462A0")]
		public void Hovered()
		{
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF2")]
		[Address(RVA = "0xA46570", Offset = "0xA44F70", VA = "0x180A46570")]
		public void Interacted()
		{
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF3")]
		[Address(RVA = "0xA46EB0", Offset = "0xA458B0", VA = "0x180A46EB0")]
		public void Open()
		{
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF4")]
		[Address(RVA = "0xA45270", Offset = "0xA43C70", VA = "0x180A45270")]
		public void Close()
		{
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0xA45D50", Offset = "0xA44750", VA = "0x180A45D50")]
		public PackagingStation.EState GetState(PackagingStation.EMode mode)
		{
			return PackagingStation.EState.CanBegin;
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0xA4B670", Offset = "0xA4A070", VA = "0x180A4B670")]
		public void Unpack()
		{
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0xA472B0", Offset = "0xA45CB0", VA = "0x180A472B0")]
		public void PackSingleInstance()
		{
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF8")]
		[Address(RVA = "0xA4A170", Offset = "0xA48B70", VA = "0x180A4A170")]
		public void SetHatchOpen(bool open)
		{
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF9")]
		[Address(RVA = "0xA4B870", Offset = "0xA4A270", VA = "0x180A4B870")]
		public void UpdatePackagingVisuals()
		{
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFA")]
		[Address(RVA = "0xA4B610", Offset = "0xA4A010", VA = "0x180A4B610")]
		public void SetVisualsLocked(bool locked)
		{
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0xA4B8B0", Offset = "0xA4A2B0", VA = "0x180A4B8B0")]
		public void UpdatePackagingVisuals(int quantity)
		{
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFC")]
		[Address(RVA = "0xA4BE10", Offset = "0xA4A810", VA = "0x180A4BE10")]
		public void UpdateProductVisuals()
		{
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFD")]
		[Address(RVA = "0xA4BE50", Offset = "0xA4A850", VA = "0x180A4BE50")]
		public void UpdateProductVisuals(int quantity)
		{
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFE")]
		[Address(RVA = "0xA4B620", Offset = "0xA4A020", VA = "0x180A4B620", Slot = "131")]
		public virtual void StartTask()
		{
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0xA4B470", Offset = "0xA49E70", VA = "0x180A4B470", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C00")]
		[Address(RVA = "0xA4B1B0", Offset = "0xA49BB0", VA = "0x180A4B1B0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C01")]
		[Address(RVA = "0xA4A460", Offset = "0xA48E60", VA = "0x180A4A460", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C02")]
		[Address(RVA = "0xA4A2B0", Offset = "0xA48CB0", VA = "0x180A4A2B0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C03")]
		[Address(RVA = "0xA4AFC0", Offset = "0xA499C0", VA = "0x180A4AFC0", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C04")]
		[Address(RVA = "0xA4AC90", Offset = "0xA49690", VA = "0x180A4AC90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C05")]
		[Address(RVA = "0xA4AAF0", Offset = "0xA494F0", VA = "0x180A4AAF0", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C06")]
		[Address(RVA = "0xA4A830", Offset = "0xA49230", VA = "0x180A4A830")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C07")]
		[Address(RVA = "0xA45650", Offset = "0xA44050", VA = "0x180A45650", Slot = "123")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C08")]
		[Address(RVA = "0xA459E0", Offset = "0xA443E0", VA = "0x180A459E0", Slot = "124")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C09")]
		[Address(RVA = "0xA45B80", Offset = "0xA44580", VA = "0x180A45B80", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0xA45CA0", Offset = "0xA446A0", VA = "0x180A45CA0", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0xA4C370", Offset = "0xA4AD70", VA = "0x180A4C370")]
		public PackagingStation()
		{
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0xA466B0", Offset = "0xA450B0", VA = "0x180A466B0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0xA46620", Offset = "0xA45020", VA = "0x180A46620", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0xA490F0", Offset = "0xA47AF0", VA = "0x180A490F0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0xA477F0", Offset = "0xA461F0", VA = "0x180A477F0", Slot = "132")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C11")]
		[Address(RVA = "0xA48330", Offset = "0xA46D30", VA = "0x180A48330")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C12")]
		[Address(RVA = "0xA494D0", Offset = "0xA47ED0", VA = "0x180A494D0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C13")]
		[Address(RVA = "0xA479C0", Offset = "0xA463C0", VA = "0x180A479C0", Slot = "133")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C14")]
		[Address(RVA = "0xA484E0", Offset = "0xA46EE0", VA = "0x180A484E0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C15")]
		[Address(RVA = "0xA493A0", Offset = "0xA47DA0", VA = "0x180A493A0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C16")]
		[Address(RVA = "0xA47920", Offset = "0xA46320", VA = "0x180A47920", Slot = "134")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C17")]
		[Address(RVA = "0xA48460", Offset = "0xA46E60", VA = "0x180A48460")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C18")]
		[Address(RVA = "0xA49900", Offset = "0xA48300", VA = "0x180A49900")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C19")]
		[Address(RVA = "0xA47F40", Offset = "0xA46940", VA = "0x180A47F40", Slot = "135")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0xA487A0", Offset = "0xA471A0", VA = "0x180A487A0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C1B RID: 23579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1B")]
		[Address(RVA = "0xA48F70", Offset = "0xA47970", VA = "0x180A48F70")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1C")]
		[Address(RVA = "0xA47FC0", Offset = "0xA469C0", VA = "0x180A47FC0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1D")]
		[Address(RVA = "0xA482A0", Offset = "0xA46CA0", VA = "0x180A482A0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1E")]
		[Address(RVA = "0xA49D70", Offset = "0xA48770", VA = "0x180A49D70")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005C1F RID: 23583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1F")]
		[Address(RVA = "0xA48A30", Offset = "0xA47430", VA = "0x180A48A30")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C20 RID: 23584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C20")]
		[Address(RVA = "0xA49220", Offset = "0xA47C20", VA = "0x180A49220")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005C21 RID: 23585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C21")]
		[Address(RVA = "0xA47890", Offset = "0xA46290", VA = "0x180A47890", Slot = "136")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C22")]
		[Address(RVA = "0xA483B0", Offset = "0xA46DB0", VA = "0x180A483B0")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C23")]
		[Address(RVA = "0xA48AD0", Offset = "0xA474D0", VA = "0x180A48AD0")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C24")]
		[Address(RVA = "0xA478A0", Offset = "0xA462A0", VA = "0x180A478A0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C25")]
		[Address(RVA = "0xA48080", Offset = "0xA46A80", VA = "0x180A48080")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C26")]
		[Address(RVA = "0xA49770", Offset = "0xA48170", VA = "0x180A49770")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C27")]
		[Address(RVA = "0xA47E10", Offset = "0xA46810", VA = "0x180A47E10", Slot = "137")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C28")]
		[Address(RVA = "0xA48650", Offset = "0xA47050", VA = "0x180A48650")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C29")]
		[Address(RVA = "0xA49BE0", Offset = "0xA485E0", VA = "0x180A49BE0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2A")]
		[Address(RVA = "0xA47E90", Offset = "0xA46890", VA = "0x180A47E90")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0xA48930", Offset = "0xA47330", VA = "0x180A48930")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2C")]
		[Address(RVA = "0xA48DD0", Offset = "0xA477D0", VA = "0x180A48DD0")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0xA481B0", Offset = "0xA46BB0", VA = "0x180A481B0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0xA49600", Offset = "0xA48000", VA = "0x180A49600")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0xA47D10", Offset = "0xA46710", VA = "0x180A47D10", Slot = "138")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C30")]
		[Address(RVA = "0xA48560", Offset = "0xA46F60", VA = "0x180A48560")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C31")]
		[Address(RVA = "0xA48C50", Offset = "0xA47650", VA = "0x180A48C50")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C32")]
		[Address(RVA = "0xA47D90", Offset = "0xA46790", VA = "0x180A47D90")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C33")]
		[Address(RVA = "0xA48120", Offset = "0xA46B20", VA = "0x180A48120")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C34")]
		[Address(RVA = "0xA49A70", Offset = "0xA48470", VA = "0x180A49A70")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C35")]
		[Address(RVA = "0xA48890", Offset = "0xA47290", VA = "0x180A48890")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06005C36 RID: 23606 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C37 RID: 23607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE2")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6005C36")]
			[Address(RVA = "0xA0B170", Offset = "0xA09B70", VA = "0x180A0B170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C37")]
			[Address(RVA = "0xA4C6D0", Offset = "0xA4B0D0", VA = "0x180A4C6D0")]
			set
			{
			}
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00016560 File Offset: 0x00014760
		[Token(Token = "0x6005C38")]
		[Address(RVA = "0xA47650", Offset = "0xA46050", VA = "0x180A47650", Slot = "139")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.PackagingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C3A RID: 23610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE3")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005C39")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C3A")]
			[Address(RVA = "0xA4C790", Offset = "0xA4B190", VA = "0x180A4C790")]
			set
			{
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06005C3B RID: 23611 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C3C RID: 23612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE4")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6005C3B")]
			[Address(RVA = "0x68D3C0", Offset = "0x68BDC0", VA = "0x18068D3C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C3C")]
			[Address(RVA = "0xA4C610", Offset = "0xA4B010", VA = "0x180A4C610")]
			set
			{
			}
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0xA44970", Offset = "0xA43370", VA = "0x180A44970", Slot = "140")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.PackagingStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040042D8 RID: 17112
		[Token(Token = "0x40042D8")]
		[FieldOffset(Offset = "0x220")]
		[Header("References")]
		public Light OverheadLight;

		// Token: 0x040042D9 RID: 17113
		[Token(Token = "0x40042D9")]
		[FieldOffset(Offset = "0x228")]
		public MeshRenderer OverheadLightMeshRend;

		// Token: 0x040042DA RID: 17114
		[Token(Token = "0x40042DA")]
		[FieldOffset(Offset = "0x230")]
		public RockerSwitch Switch;

		// Token: 0x040042DB RID: 17115
		[Token(Token = "0x40042DB")]
		[FieldOffset(Offset = "0x238")]
		public Transform CameraPosition;

		// Token: 0x040042DC RID: 17116
		[Token(Token = "0x40042DC")]
		[FieldOffset(Offset = "0x240")]
		public Transform CameraPosition_Task;

		// Token: 0x040042DD RID: 17117
		[Token(Token = "0x40042DD")]
		[FieldOffset(Offset = "0x248")]
		public InteractableObject IntObj;

		// Token: 0x040042DE RID: 17118
		[Token(Token = "0x40042DE")]
		[FieldOffset(Offset = "0x250")]
		public Transform ActivePackagingAlignent;

		// Token: 0x040042DF RID: 17119
		[Token(Token = "0x40042DF")]
		[FieldOffset(Offset = "0x258")]
		public Transform[] ActiveProductAlignments;

		// Token: 0x040042E0 RID: 17120
		[Token(Token = "0x40042E0")]
		[FieldOffset(Offset = "0x260")]
		public Transform Container;

		// Token: 0x040042E1 RID: 17121
		[Token(Token = "0x40042E1")]
		[FieldOffset(Offset = "0x268")]
		public Collider OutputCollider;

		// Token: 0x040042E2 RID: 17122
		[Token(Token = "0x40042E2")]
		[FieldOffset(Offset = "0x270")]
		public Transform Hatch;

		// Token: 0x040042E3 RID: 17123
		[Token(Token = "0x40042E3")]
		[FieldOffset(Offset = "0x278")]
		public Transform[] PackagingAlignments;

		// Token: 0x040042E4 RID: 17124
		[Token(Token = "0x40042E4")]
		[FieldOffset(Offset = "0x280")]
		public Transform[] ProductAlignments;

		// Token: 0x040042E5 RID: 17125
		[Token(Token = "0x40042E5")]
		[FieldOffset(Offset = "0x288")]
		public Transform uiPoint;

		// Token: 0x040042E6 RID: 17126
		[Token(Token = "0x40042E6")]
		[FieldOffset(Offset = "0x290")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x040042E7 RID: 17127
		[Token(Token = "0x40042E7")]
		[FieldOffset(Offset = "0x298")]
		public Transform StandPoint;

		// Token: 0x040042E8 RID: 17128
		[Token(Token = "0x40042E8")]
		[FieldOffset(Offset = "0x2A0")]
		public Transform[] accessPoints;

		// Token: 0x040042E9 RID: 17129
		[Token(Token = "0x40042E9")]
		[FieldOffset(Offset = "0x2A8")]
		public AudioSourceController HatchOpenSound;

		// Token: 0x040042EA RID: 17130
		[Token(Token = "0x40042EA")]
		[FieldOffset(Offset = "0x2B0")]
		public AudioSourceController HatchCloseSound;

		// Token: 0x040042EB RID: 17131
		[Token(Token = "0x40042EB")]
		[FieldOffset(Offset = "0x2B8")]
		[Header("UI")]
		public PackagingStationUIElement WorldspaceUIPrefab;

		// Token: 0x040042EC RID: 17132
		[Token(Token = "0x40042EC")]
		[FieldOffset(Offset = "0x2C0")]
		public Sprite typeIcon;

		// Token: 0x040042ED RID: 17133
		[Token(Token = "0x40042ED")]
		[FieldOffset(Offset = "0x2C8")]
		[Header("Slot Display Points")]
		public Transform PackagingSlotPosition;

		// Token: 0x040042EE RID: 17134
		[Token(Token = "0x40042EE")]
		[FieldOffset(Offset = "0x2D0")]
		public Transform ProductSlotPosition;

		// Token: 0x040042EF RID: 17135
		[Token(Token = "0x40042EF")]
		[FieldOffset(Offset = "0x2D8")]
		public Transform OutputSlotPosition;

		// Token: 0x040042F0 RID: 17136
		[Token(Token = "0x40042F0")]
		[FieldOffset(Offset = "0x2E0")]
		[Header("Materials")]
		public Material LightMeshOnMat;

		// Token: 0x040042F1 RID: 17137
		[Token(Token = "0x40042F1")]
		[FieldOffset(Offset = "0x2E8")]
		public Material LightMeshOffMat;

		// Token: 0x040042F2 RID: 17138
		[Token(Token = "0x40042F2")]
		[FieldOffset(Offset = "0x2F0")]
		[Header("Settings")]
		public float PackagerEmployeeSpeedMultiplier;

		// Token: 0x040042F3 RID: 17139
		[Token(Token = "0x40042F3")]
		[FieldOffset(Offset = "0x2F4")]
		public Vector3 HatchClosedRotation;

		// Token: 0x040042F4 RID: 17140
		[Token(Token = "0x40042F4")]
		[FieldOffset(Offset = "0x300")]
		public Vector3 HatchOpenRotation;

		// Token: 0x040042F5 RID: 17141
		[Token(Token = "0x40042F5")]
		[FieldOffset(Offset = "0x30C")]
		public float HatchLerpTime;

		// Token: 0x040042F8 RID: 17144
		[Token(Token = "0x40042F8")]
		[FieldOffset(Offset = "0x320")]
		public ItemSlot PackagingSlot;

		// Token: 0x040042F9 RID: 17145
		[Token(Token = "0x40042F9")]
		[FieldOffset(Offset = "0x328")]
		public ItemSlot ProductSlot;

		// Token: 0x040042FA RID: 17146
		[Token(Token = "0x40042FA")]
		[FieldOffset(Offset = "0x330")]
		public ItemSlot OutputSlot;

		// Token: 0x040042FB RID: 17147
		[Token(Token = "0x40042FB")]
		[FieldOffset(Offset = "0x338")]
		private bool hatchOpen;

		// Token: 0x040042FC RID: 17148
		[Token(Token = "0x40042FC")]
		[FieldOffset(Offset = "0x340")]
		private Coroutine hatchRoutine;

		// Token: 0x040042FD RID: 17149
		[Token(Token = "0x40042FD")]
		[FieldOffset(Offset = "0x348")]
		private List<string> PackagingSlotModelID;

		// Token: 0x040042FE RID: 17150
		[Token(Token = "0x40042FE")]
		[FieldOffset(Offset = "0x350")]
		private List<string> ProductSlotModelID;

		// Token: 0x04004306 RID: 17158
		[Token(Token = "0x4004306")]
		[FieldOffset(Offset = "0x388")]
		private bool visualsLocked;

		// Token: 0x04004307 RID: 17159
		[Token(Token = "0x4004307")]
		[FieldOffset(Offset = "0x390")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04004308 RID: 17160
		[Token(Token = "0x4004308")]
		[FieldOffset(Offset = "0x398")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04004309 RID: 17161
		[Token(Token = "0x4004309")]
		[FieldOffset(Offset = "0x3A0")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x0400430A RID: 17162
		[Token(Token = "0x400430A")]
		[FieldOffset(Offset = "0x3A8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x0400430B RID: 17163
		[Token(Token = "0x400430B")]
		[FieldOffset(Offset = "0x3A9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x02000CBD RID: 3261
		[Token(Token = "0x2000CBD")]
		public enum EMode
		{
			// Token: 0x0400430D RID: 17165
			[Token(Token = "0x400430D")]
			Package,
			// Token: 0x0400430E RID: 17166
			[Token(Token = "0x400430E")]
			Unpackage
		}

		// Token: 0x02000CBE RID: 3262
		[Token(Token = "0x2000CBE")]
		public enum EState
		{
			// Token: 0x04004310 RID: 17168
			[Token(Token = "0x4004310")]
			CanBegin,
			// Token: 0x04004311 RID: 17169
			[Token(Token = "0x4004311")]
			MissingItems,
			// Token: 0x04004312 RID: 17170
			[Token(Token = "0x4004312")]
			InsufficentProduct,
			// Token: 0x04004313 RID: 17171
			[Token(Token = "0x4004313")]
			OutputSlotFull,
			// Token: 0x04004314 RID: 17172
			[Token(Token = "0x4004314")]
			Mismatch,
			// Token: 0x04004315 RID: 17173
			[Token(Token = "0x4004315")]
			PackageSlotFull,
			// Token: 0x04004316 RID: 17174
			[Token(Token = "0x4004316")]
			ProductSlotFull
		}
	}
}
