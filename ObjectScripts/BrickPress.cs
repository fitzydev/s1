using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000C8C")]
	public class BrickPress : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06005753 RID: 22355 RVA: 0x00015990 File Offset: 0x00013B90
		[Token(Token = "0x17000C06")]
		public bool isOpen
		{
			[Token(Token = "0x6005753")]
			[Address(RVA = "0xA0B1B0", Offset = "0xA09BB0", VA = "0x180A0B1B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06005754 RID: 22356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005755 RID: 22357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C07")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6005754")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005755")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C08")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6005756")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005757")]
			[Address(RVA = "0xA07530", Offset = "0xA05F30", VA = "0x180A07530", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005759 RID: 22361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C09")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005758")]
			[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005759")]
			[Address(RVA = "0xA075D0", Offset = "0xA05FD0", VA = "0x180A075D0", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600575B RID: 22363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0A")]
		public ItemSlot[] ProductSlots
		{
			[Token(Token = "0x600575A")]
			[Address(RVA = "0x62FE20", Offset = "0x62E820", VA = "0x18062FE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600575B")]
			[Address(RVA = "0x630540", Offset = "0x62EF40", VA = "0x180630540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600575D RID: 22365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0B")]
		public ItemSlot OutputSlot
		{
			[Token(Token = "0x600575C")]
			[Address(RVA = "0x62FE30", Offset = "0x62E830", VA = "0x18062FE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600575D")]
			[Address(RVA = "0x630560", Offset = "0x62EF60", VA = "0x180630560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600575E RID: 22366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0C")]
		public string Name
		{
			[Token(Token = "0x600575E")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600575F RID: 22367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005760 RID: 22368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0D")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x600575F")]
			[Address(RVA = "0x689EF0", Offset = "0x6888F0", VA = "0x180689EF0", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005760")]
			[Address(RVA = "0x6941C0", Offset = "0x692BC0", VA = "0x1806941C0", Slot = "89")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06005761 RID: 22369 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005762 RID: 22370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0E")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6005761")]
			[Address(RVA = "0x6DFF20", Offset = "0x6DE920", VA = "0x1806DFF20", Slot = "90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005762")]
			[Address(RVA = "0x6E0040", Offset = "0x6DEA40", VA = "0x1806E0040", Slot = "91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06005763 RID: 22371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0F")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6005763")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C10")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6005764")]
			[Address(RVA = "0x716CC0", Offset = "0x7156C0", VA = "0x180716CC0", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x17000C11")]
		public bool Selectable
		{
			[Token(Token = "0x6005765")]
			[Address(RVA = "0xA0B1A0", Offset = "0xA09BA0", VA = "0x180A0B1A0", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x000159C0 File Offset: 0x00013BC0
		// (set) Token: 0x06005767 RID: 22375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C12")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005766")]
			[Address(RVA = "0xA0B180", Offset = "0xA09B80", VA = "0x180A0B180", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005767")]
			[Address(RVA = "0xA0B260", Offset = "0xA09C60", VA = "0x180A0B260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C13")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6005768")]
			[Address(RVA = "0xA0B170", Offset = "0xA09B70", VA = "0x180A0B170", Slot = "109")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06005769 RID: 22377 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600576A RID: 22378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C14")]
		protected BrickPressConfiguration stationConfiguration
		{
			[Token(Token = "0x6005769")]
			[Address(RVA = "0xA0B170", Offset = "0xA09B70", VA = "0x180A0B170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600576A")]
			[Address(RVA = "0xA0B270", Offset = "0xA09C70", VA = "0x180A0B270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600576B RID: 22379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C15")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x600576B")]
			[Address(RVA = "0x62FC40", Offset = "0x62E640", VA = "0x18062FC40", Slot = "110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600576C RID: 22380 RVA: 0x000159D8 File Offset: 0x00013BD8
		[Token(Token = "0x17000C16")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x600576C")]
			[Address(RVA = "0x6AFAF0", Offset = "0x6AE4F0", VA = "0x1806AFAF0", Slot = "111")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600576D RID: 22381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600576E RID: 22382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C17")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x600576D")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600576E")]
			[Address(RVA = "0x6DFF50", Offset = "0x6DE950", VA = "0x1806DFF50", Slot = "113")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600576F RID: 22383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005770 RID: 22384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C18")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x600576F")]
			[Address(RVA = "0x6DFEC0", Offset = "0x6DE8C0", VA = "0x1806DFEC0", Slot = "114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005770")]
			[Address(RVA = "0xA07400", Offset = "0xA05E00", VA = "0x180A07400", Slot = "115")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005771")]
		[Address(RVA = "0xA099A0", Offset = "0xA083A0", VA = "0x180A099A0", Slot = "129")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C19")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6005772")]
			[Address(RVA = "0x62FE10", Offset = "0x62E810", VA = "0x18062FE10", Slot = "117")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06005773 RID: 22387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1A")]
		public Transform Transform
		{
			[Token(Token = "0x6005773")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "118")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1B")]
		public Transform UIPoint
		{
			[Token(Token = "0x6005774")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0", Slot = "119")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06005775 RID: 22389 RVA: 0x000159F0 File Offset: 0x00013BF0
		[Token(Token = "0x17000C1C")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6005775")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005776")]
		[Address(RVA = "0xA03FA0", Offset = "0xA029A0", VA = "0x180A03FA0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005777")]
		[Address(RVA = "0xA061F0", Offset = "0xA04BF0", VA = "0x180A061F0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005778")]
		[Address(RVA = "0xA06430", Offset = "0xA04E30", VA = "0x180A06430", Slot = "131")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005779")]
		[Address(RVA = "0xA06C40", Offset = "0xA05640", VA = "0x180A06C40", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577A")]
		[Address(RVA = "0xA09840", Offset = "0xA08240", VA = "0x180A09840", Slot = "130")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577B")]
		[Address(RVA = "0xA05000", Offset = "0xA03A00", VA = "0x180A05000")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x00015A08 File Offset: 0x00013C08
		[Token(Token = "0x600577C")]
		[Address(RVA = "0xA03FF0", Offset = "0xA029F0", VA = "0x180A03FF0", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577D")]
		[Address(RVA = "0xA04E10", Offset = "0xA03810", VA = "0x180A04E10", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577E")]
		[Address(RVA = "0xA09F20", Offset = "0xA08920", VA = "0x180A09F20", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577F")]
		[Address(RVA = "0xA09DF0", Offset = "0xA087F0", VA = "0x180A09DF0", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x00015A20 File Offset: 0x00013C20
		[Token(Token = "0x6005780")]
		[Address(RVA = "0xA05CC0", Offset = "0xA046C0", VA = "0x180A05CC0")]
		public PackagingStation.EState GetState()
		{
			return PackagingStation.EState.CanBegin;
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005781")]
		[Address(RVA = "0xA0AEA0", Offset = "0xA098A0", VA = "0x180A0AEA0")]
		private void UpdateInputVisuals()
		{
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x00015A38 File Offset: 0x00013C38
		[Token(Token = "0x6005782")]
		[Address(RVA = "0xA05F80", Offset = "0xA04980", VA = "0x180A05F80")]
		public bool HasSufficientProduct(out ProductItemInstance product)
		{
			return default(bool);
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005783")]
		[Address(RVA = "0xA05210", Offset = "0xA03C10", VA = "0x180A05210")]
		public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005784")]
		[Address(RVA = "0xA04660", Offset = "0xA03060", VA = "0x180A04660")]
		public Draggable CreateFunctionalContainer(ProductItemInstance instance, float productScale, out List<FunctionalProduct> products)
		{
			return null;
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005785")]
		[Address(RVA = "0xA071E0", Offset = "0xA05BE0", VA = "0x180A071E0")]
		public void PlayPressAnim()
		{
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005786")]
		[Address(RVA = "0xA04410", Offset = "0xA02E10", VA = "0x180A04410")]
		public void CompletePress(ProductItemInstance product)
		{
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005787")]
		[Address(RVA = "0xA05910", Offset = "0xA04310", VA = "0x180A05910")]
		public List<FunctionalProduct> GetProductInMould()
		{
			return null;
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005788")]
		[Address(RVA = "0xA04BE0", Offset = "0xA035E0", VA = "0x180A04BE0", Slot = "123")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005789")]
		[Address(RVA = "0xA04F70", Offset = "0xA03970", VA = "0x180A04F70", Slot = "124")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578A")]
		[Address(RVA = "0xA060B0", Offset = "0xA04AB0", VA = "0x180A060B0")]
		public void Hovered()
		{
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578B")]
		[Address(RVA = "0xA06380", Offset = "0xA04D80", VA = "0x180A06380")]
		public void Interacted()
		{
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578C")]
		[Address(RVA = "0xA06DE0", Offset = "0xA057E0", VA = "0x180A06DE0")]
		public void Open()
		{
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578D")]
		[Address(RVA = "0xA040C0", Offset = "0xA02AC0", VA = "0x180A040C0")]
		public void Close()
		{
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578E")]
		[Address(RVA = "0xA0AC90", Offset = "0xA09690", VA = "0x180A0AC90", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578F")]
		[Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005790")]
		[Address(RVA = "0xA09C80", Offset = "0xA08680", VA = "0x180A09C80", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005791")]
		[Address(RVA = "0xA09AD0", Offset = "0xA084D0", VA = "0x180A09AD0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005792")]
		[Address(RVA = "0xA0A7E0", Offset = "0xA091E0", VA = "0x180A0A7E0", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005793")]
		[Address(RVA = "0xA0A4B0", Offset = "0xA08EB0", VA = "0x180A0A4B0")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005794")]
		[Address(RVA = "0xA0A310", Offset = "0xA08D10", VA = "0x180A0A310", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005795")]
		[Address(RVA = "0xA0A050", Offset = "0xA08A50", VA = "0x180A0A050")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005796")]
		[Address(RVA = "0xA050F0", Offset = "0xA03AF0", VA = "0x180A050F0", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005797")]
		[Address(RVA = "0xA05C10", Offset = "0xA04610", VA = "0x180A05C10", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005798")]
		[Address(RVA = "0xA0B080", Offset = "0xA09A80", VA = "0x180A0B080")]
		public BrickPress()
		{
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005799")]
		[Address(RVA = "0xA0AE30", Offset = "0xA09830", VA = "0x180A0AE30")]
		[CompilerGenerated]
		private IEnumerator <PlayPressAnim>g__Routine|109_0()
		{
			return null;
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579A")]
		[Address(RVA = "0xA065E0", Offset = "0xA04FE0", VA = "0x180A065E0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579B")]
		[Address(RVA = "0xA06550", Offset = "0xA04F50", VA = "0x180A06550", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579C")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579D")]
		[Address(RVA = "0xA08A50", Offset = "0xA07450", VA = "0x180A08A50")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579E")]
		[Address(RVA = "0xA07400", Offset = "0xA05E00", VA = "0x180A07400", Slot = "132")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579F")]
		[Address(RVA = "0xA07C90", Offset = "0xA06690", VA = "0x180A07C90")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A0")]
		[Address(RVA = "0xA08E30", Offset = "0xA07830", VA = "0x180A08E30")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A1")]
		[Address(RVA = "0xA075D0", Offset = "0xA05FD0", VA = "0x180A075D0", Slot = "133")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A2")]
		[Address(RVA = "0xA07E40", Offset = "0xA06840", VA = "0x180A07E40")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A3")]
		[Address(RVA = "0xA08D00", Offset = "0xA07700", VA = "0x180A08D00")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A4")]
		[Address(RVA = "0xA07530", Offset = "0xA05F30", VA = "0x180A07530", Slot = "134")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A5")]
		[Address(RVA = "0xA07DC0", Offset = "0xA067C0", VA = "0x180A07DC0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A6")]
		[Address(RVA = "0xA09260", Offset = "0xA07C60", VA = "0x180A09260")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A7")]
		[Address(RVA = "0xA078A0", Offset = "0xA062A0", VA = "0x180A078A0", Slot = "135")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A8")]
		[Address(RVA = "0xA08100", Offset = "0xA06B00", VA = "0x180A08100")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A9")]
		[Address(RVA = "0xA088D0", Offset = "0xA072D0", VA = "0x180A088D0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AA")]
		[Address(RVA = "0xA07920", Offset = "0xA06320", VA = "0x180A07920")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AB")]
		[Address(RVA = "0xA07C00", Offset = "0xA06600", VA = "0x180A07C00")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0xA096D0", Offset = "0xA080D0", VA = "0x180A096D0")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AD")]
		[Address(RVA = "0xA08390", Offset = "0xA06D90", VA = "0x180A08390")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AE")]
		[Address(RVA = "0xA08B80", Offset = "0xA07580", VA = "0x180A08B80")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AF")]
		[Address(RVA = "0xA074A0", Offset = "0xA05EA0", VA = "0x180A074A0", Slot = "136")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B0")]
		[Address(RVA = "0xA07D10", Offset = "0xA06710", VA = "0x180A07D10")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B1")]
		[Address(RVA = "0xA08430", Offset = "0xA06E30", VA = "0x180A08430")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B2")]
		[Address(RVA = "0xA074B0", Offset = "0xA05EB0", VA = "0x180A074B0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B3")]
		[Address(RVA = "0xA079E0", Offset = "0xA063E0", VA = "0x180A079E0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B4")]
		[Address(RVA = "0xA090D0", Offset = "0xA07AD0", VA = "0x180A090D0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B5")]
		[Address(RVA = "0xA07770", Offset = "0xA06170", VA = "0x180A07770", Slot = "137")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B6")]
		[Address(RVA = "0xA07FB0", Offset = "0xA069B0", VA = "0x180A07FB0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B7")]
		[Address(RVA = "0xA09540", Offset = "0xA07F40", VA = "0x180A09540")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B8")]
		[Address(RVA = "0xA077F0", Offset = "0xA061F0", VA = "0x180A077F0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B9")]
		[Address(RVA = "0xA08290", Offset = "0xA06C90", VA = "0x180A08290")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BA")]
		[Address(RVA = "0xA08730", Offset = "0xA07130", VA = "0x180A08730")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BB")]
		[Address(RVA = "0xA07B10", Offset = "0xA06510", VA = "0x180A07B10")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BC")]
		[Address(RVA = "0xA08F60", Offset = "0xA07960", VA = "0x180A08F60")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BD")]
		[Address(RVA = "0xA07670", Offset = "0xA06070", VA = "0x180A07670", Slot = "138")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BE")]
		[Address(RVA = "0xA07EC0", Offset = "0xA068C0", VA = "0x180A07EC0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BF")]
		[Address(RVA = "0xA085B0", Offset = "0xA06FB0", VA = "0x180A085B0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C0")]
		[Address(RVA = "0xA076F0", Offset = "0xA060F0", VA = "0x180A076F0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C1")]
		[Address(RVA = "0xA07A80", Offset = "0xA06480", VA = "0x180A07A80")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C2")]
		[Address(RVA = "0xA093D0", Offset = "0xA07DD0", VA = "0x180A093D0")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0xA081F0", Offset = "0xA06BF0", VA = "0x180A081F0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060057C4 RID: 22468 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057C5 RID: 22469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C1D")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x60057C4")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057C5")]
			[Address(RVA = "0xA0B350", Offset = "0xA09D50", VA = "0x180A0B350")]
			set
			{
			}
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00015A50 File Offset: 0x00013C50
		[Token(Token = "0x60057C6")]
		[Address(RVA = "0xA07260", Offset = "0xA05C60", VA = "0x180A07260", Slot = "139")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.BrickPress(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057C8 RID: 22472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C1E")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x60057C7")]
			[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057C8")]
			[Address(RVA = "0xA0B410", Offset = "0xA09E10", VA = "0x180A0B410")]
			set
			{
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060057C9 RID: 22473 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057CA RID: 22474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C1F")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x60057C9")]
			[Address(RVA = "0x6DFEC0", Offset = "0x6DE8C0", VA = "0x1806DFEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057CA")]
			[Address(RVA = "0xA0B290", Offset = "0xA09C90", VA = "0x180A0B290")]
			set
			{
			}
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CB")]
		[Address(RVA = "0xA03B90", Offset = "0xA02590", VA = "0x180A03B90", Slot = "140")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.BrickPress_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04004099 RID: 16537
		[Token(Token = "0x4004099")]
		public const int INPUT_SLOT_COUNT = 2;

		// Token: 0x0400409D RID: 16541
		[Token(Token = "0x400409D")]
		[FieldOffset(Offset = "0x230")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x0400409E RID: 16542
		[Token(Token = "0x400409E")]
		[FieldOffset(Offset = "0x238")]
		public Transform CameraPosition_Pouring;

		// Token: 0x0400409F RID: 16543
		[Token(Token = "0x400409F")]
		[FieldOffset(Offset = "0x240")]
		public Transform CameraPosition_Raising;

		// Token: 0x040040A0 RID: 16544
		[Token(Token = "0x40040A0")]
		[FieldOffset(Offset = "0x248")]
		public InteractableObject IntObj;

		// Token: 0x040040A1 RID: 16545
		[Token(Token = "0x40040A1")]
		[FieldOffset(Offset = "0x250")]
		public Transform uiPoint;

		// Token: 0x040040A2 RID: 16546
		[Token(Token = "0x40040A2")]
		[FieldOffset(Offset = "0x258")]
		public Transform StandPoint;

		// Token: 0x040040A3 RID: 16547
		[Token(Token = "0x40040A3")]
		[FieldOffset(Offset = "0x260")]
		public Transform[] accessPoints;

		// Token: 0x040040A4 RID: 16548
		[Token(Token = "0x40040A4")]
		[FieldOffset(Offset = "0x268")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040040A5 RID: 16549
		[Token(Token = "0x40040A5")]
		[FieldOffset(Offset = "0x270")]
		public BrickPressContainer Container1;

		// Token: 0x040040A6 RID: 16550
		[Token(Token = "0x40040A6")]
		[FieldOffset(Offset = "0x278")]
		public BrickPressContainer Container2;

		// Token: 0x040040A7 RID: 16551
		[Token(Token = "0x40040A7")]
		[FieldOffset(Offset = "0x280")]
		public Transform ContainerSpawnPoint;

		// Token: 0x040040A8 RID: 16552
		[Token(Token = "0x40040A8")]
		[FieldOffset(Offset = "0x288")]
		public PackagingDefinition BrickPackaging;

		// Token: 0x040040A9 RID: 16553
		[Token(Token = "0x40040A9")]
		[FieldOffset(Offset = "0x290")]
		public BoxCollider MouldDetection;

		// Token: 0x040040AA RID: 16554
		[Token(Token = "0x40040AA")]
		[FieldOffset(Offset = "0x298")]
		public BrickPressHandle Handle;

		// Token: 0x040040AB RID: 16555
		[Token(Token = "0x40040AB")]
		[FieldOffset(Offset = "0x2A0")]
		public Transform PressTransform;

		// Token: 0x040040AC RID: 16556
		[Token(Token = "0x40040AC")]
		[FieldOffset(Offset = "0x2A8")]
		public Transform PressTransform_Raised;

		// Token: 0x040040AD RID: 16557
		[Token(Token = "0x40040AD")]
		[FieldOffset(Offset = "0x2B0")]
		public Transform PressTransform_Lowered;

		// Token: 0x040040AE RID: 16558
		[Token(Token = "0x40040AE")]
		[FieldOffset(Offset = "0x2B8")]
		public Transform PressTransform_Compressed;

		// Token: 0x040040AF RID: 16559
		[Token(Token = "0x40040AF")]
		[FieldOffset(Offset = "0x2C0")]
		public AudioSourceController SlamSound;

		// Token: 0x040040B0 RID: 16560
		[Token(Token = "0x40040B0")]
		[FieldOffset(Offset = "0x2C8")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x040040B1 RID: 16561
		[Token(Token = "0x40040B1")]
		[FieldOffset(Offset = "0x2D0")]
		[Header("Prefabs")]
		public Draggable FunctionalContainerPrefab;

		// Token: 0x040040B2 RID: 16562
		[Token(Token = "0x40040B2")]
		[FieldOffset(Offset = "0x2D8")]
		[Header("UI")]
		public BrickPressUIElement WorldspaceUIPrefab;

		// Token: 0x040040B3 RID: 16563
		[Token(Token = "0x40040B3")]
		[FieldOffset(Offset = "0x2E0")]
		public Sprite typeIcon;

		// Token: 0x040040BD RID: 16573
		[Token(Token = "0x40040BD")]
		[FieldOffset(Offset = "0x328")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x040040BE RID: 16574
		[Token(Token = "0x40040BE")]
		[FieldOffset(Offset = "0x330")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x040040BF RID: 16575
		[Token(Token = "0x40040BF")]
		[FieldOffset(Offset = "0x338")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x040040C0 RID: 16576
		[Token(Token = "0x40040C0")]
		[FieldOffset(Offset = "0x340")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted;

		// Token: 0x040040C1 RID: 16577
		[Token(Token = "0x40040C1")]
		[FieldOffset(Offset = "0x341")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted;
	}
}
