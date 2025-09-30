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
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C9F RID: 3231
	[Token(Token = "0x2000C9F")]
	public class ChemistryStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600589F RID: 22687 RVA: 0x00015D38 File Offset: 0x00013F38
		[Token(Token = "0x17000C47")]
		public bool isOpen
		{
			[Token(Token = "0x600589F")]
			[Address(RVA = "0xA1CDA0", Offset = "0xA1B7A0", VA = "0x180A1CDA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058A1 RID: 22689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C48")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060058A2 RID: 22690 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058A3 RID: 22691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C49")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60058A2")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A3")]
			[Address(RVA = "0xA188D0", Offset = "0xA172D0", VA = "0x180A188D0", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060058A4 RID: 22692 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058A5 RID: 22693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C4A")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60058A4")]
			[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A5")]
			[Address(RVA = "0xA18970", Offset = "0xA17370", VA = "0x180A18970", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060058A6 RID: 22694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058A7 RID: 22695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C4B")]
		public ChemistryCookOperation CurrentCookOperation
		{
			[Token(Token = "0x60058A6")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A7")]
			[Address(RVA = "0x630500", Offset = "0x62EF00", VA = "0x180630500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060058A8 RID: 22696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4C")]
		public string Name
		{
			[Token(Token = "0x60058A8")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060058A9 RID: 22697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058AA RID: 22698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C4D")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60058A9")]
			[Address(RVA = "0x6DFEC0", Offset = "0x6DE8C0", VA = "0x1806DFEC0", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058AA")]
			[Address(RVA = "0x6DFF30", Offset = "0x6DE930", VA = "0x1806DFF30", Slot = "89")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060058AB RID: 22699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058AC RID: 22700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C4E")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60058AB")]
			[Address(RVA = "0x9EBA20", Offset = "0x9EA420", VA = "0x1809EBA20", Slot = "90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058AC")]
			[Address(RVA = "0xA1CE60", Offset = "0xA1B860", VA = "0x180A1CE60", Slot = "91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060058AD RID: 22701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4F")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x60058AD")]
			[Address(RVA = "0xA1CD80", Offset = "0xA1B780", VA = "0x180A1CD80", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C50")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x60058AE")]
			[Address(RVA = "0x62FC60", Offset = "0x62E660", VA = "0x18062FC60", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060058AF RID: 22703 RVA: 0x00015D50 File Offset: 0x00013F50
		[Token(Token = "0x17000C51")]
		public bool Selectable
		{
			[Token(Token = "0x60058AF")]
			[Address(RVA = "0xA1CD90", Offset = "0xA1B790", VA = "0x180A1CD90", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060058B0 RID: 22704 RVA: 0x00015D68 File Offset: 0x00013F68
		// (set) Token: 0x060058B1 RID: 22705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C52")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x60058B0")]
			[Address(RVA = "0xA1CD70", Offset = "0xA1B770", VA = "0x180A1CD70", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058B1")]
			[Address(RVA = "0xA1CE50", Offset = "0xA1B850", VA = "0x180A1CE50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060058B2 RID: 22706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C53")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60058B2")]
			[Address(RVA = "0xA1CD60", Offset = "0xA1B760", VA = "0x180A1CD60", Slot = "109")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060058B3 RID: 22707 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058B4 RID: 22708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C54")]
		protected ChemistryStationConfiguration stationConfiguration
		{
			[Token(Token = "0x60058B3")]
			[Address(RVA = "0xA1CD60", Offset = "0xA1B760", VA = "0x180A1CD60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058B4")]
			[Address(RVA = "0xA1CEA0", Offset = "0xA1B8A0", VA = "0x180A1CEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060058B5 RID: 22709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C55")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60058B5")]
			[Address(RVA = "0x62FC40", Offset = "0x62E640", VA = "0x18062FC40", Slot = "110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x00015D80 File Offset: 0x00013F80
		[Token(Token = "0x17000C56")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60058B6")]
			[Address(RVA = "0x6AABD0", Offset = "0x6A95D0", VA = "0x1806AABD0", Slot = "111")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060058B7 RID: 22711 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058B8 RID: 22712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C57")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60058B7")]
			[Address(RVA = "0xA14720", Offset = "0xA13120", VA = "0x180A14720", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058B8")]
			[Address(RVA = "0xA1CE80", Offset = "0xA1B880", VA = "0x180A1CE80", Slot = "113")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060058B9 RID: 22713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058BA RID: 22714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C58")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60058B9")]
			[Address(RVA = "0xA14740", Offset = "0xA13140", VA = "0x180A14740", Slot = "114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058BA")]
			[Address(RVA = "0xA18600", Offset = "0xA17000", VA = "0x180A18600", Slot = "115")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BB")]
		[Address(RVA = "0xA1B350", Offset = "0xA19D50", VA = "0x180A1B350", Slot = "129")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060058BC RID: 22716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C59")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60058BC")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0", Slot = "117")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060058BD RID: 22717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5A")]
		public Transform Transform
		{
			[Token(Token = "0x60058BD")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "118")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5B")]
		public Transform UIPoint
		{
			[Token(Token = "0x60058BE")]
			[Address(RVA = "0xA1CD80", Offset = "0xA1B780", VA = "0x180A1CD80", Slot = "119")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060058BF RID: 22719 RVA: 0x00015D98 File Offset: 0x00013F98
		[Token(Token = "0x17000C5C")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60058BF")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C0")]
		[Address(RVA = "0xA15270", Offset = "0xA13C70", VA = "0x180A15270", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C1")]
		[Address(RVA = "0xA16D20", Offset = "0xA15720", VA = "0x180A16D20", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C2")]
		[Address(RVA = "0xA17BE0", Offset = "0xA165E0", VA = "0x180A17BE0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C3")]
		[Address(RVA = "0xA1B110", Offset = "0xA19B10", VA = "0x180A1B110", Slot = "130")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x00015DB0 File Offset: 0x00013FB0
		[Token(Token = "0x60058C4")]
		[Address(RVA = "0xA152C0", Offset = "0xA13CC0", VA = "0x180A152C0", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0xA160D0", Offset = "0xA14AD0", VA = "0x180A160D0", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0xA170C0", Offset = "0xA15AC0", VA = "0x180A170C0", Slot = "131")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0xA1CA40", Offset = "0xA1B440", VA = "0x180A1CA40")]
		private void TimeSkipped(int minsSkippped)
		{
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C8")]
		[Address(RVA = "0xA1CAA0", Offset = "0xA1B4A0", VA = "0x180A1CAA0")]
		private void UpdateClock()
		{
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C9")]
		[Address(RVA = "0xA1CBF0", Offset = "0xA1B5F0", VA = "0x180A1CBF0", Slot = "132")]
		protected virtual void Update()
		{
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CA")]
		[Address(RVA = "0xA15720", Offset = "0xA14120", VA = "0x180A15720")]
		public Beaker CreateBeaker()
		{
			return null;
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CB")]
		[Address(RVA = "0xA15890", Offset = "0xA14290", VA = "0x180A15890")]
		public StirringRod CreateStirringRod()
		{
			return null;
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CC")]
		[Address(RVA = "0xA1B220", Offset = "0xA19C20", VA = "0x180A1B220")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(ChemistryCookOperation op)
		{
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CD")]
		[Address(RVA = "0xA1B480", Offset = "0xA19E80", VA = "0x180A1B480")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetCookOperation(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CE")]
		[Address(RVA = "0xA16600", Offset = "0xA15000", VA = "0x180A16600")]
		[ObserversRpc]
		public void FinalizeOperation()
		{
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CF")]
		[Address(RVA = "0xA182E0", Offset = "0xA16CE0", VA = "0x180A182E0")]
		public void ResetStation()
		{
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x60058D0")]
		[Address(RVA = "0xA164A0", Offset = "0xA14EA0", VA = "0x180A164A0")]
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D1")]
		[Address(RVA = "0xA16A20", Offset = "0xA15420", VA = "0x180A16A20")]
		public List<ItemInstance> GetIngredients()
		{
			return null;
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x60058D2")]
		[Address(RVA = "0xA16BB0", Offset = "0xA155B0", VA = "0x180A16BB0")]
		public bool HasIngredientsForRecipe(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D3")]
		[Address(RVA = "0xA15A10", Offset = "0xA14410", VA = "0x180A15A10")]
		public void CreateTrash(List<StationItem> mixerItems)
		{
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0xA16BE0", Offset = "0xA155E0", VA = "0x180A16BE0")]
		public void Hovered()
		{
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0xA17010", Offset = "0xA15A10", VA = "0x180A17010")]
		public void Interacted()
		{
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D6")]
		[Address(RVA = "0xA16510", Offset = "0xA14F10", VA = "0x180A16510")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D7")]
		[Address(RVA = "0xA17D50", Offset = "0xA16750", VA = "0x180A17D50")]
		public void Open()
		{
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D8")]
		[Address(RVA = "0xA153C0", Offset = "0xA13DC0", VA = "0x180A153C0")]
		public void Close()
		{
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058D9")]
		[Address(RVA = "0xA1BB30", Offset = "0xA1A530", VA = "0x180A1BB30", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DA")]
		[Address(RVA = "0xA1BA00", Offset = "0xA1A400", VA = "0x180A1BA00", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DB")]
		[Address(RVA = "0xA1C8A0", Offset = "0xA1B2A0", VA = "0x180A1C8A0", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DC")]
		[Address(RVA = "0xA1C5E0", Offset = "0xA1AFE0", VA = "0x180A1C5E0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DD")]
		[Address(RVA = "0xA1B890", Offset = "0xA1A290", VA = "0x180A1B890", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DE")]
		[Address(RVA = "0xA1B6E0", Offset = "0xA1A0E0", VA = "0x180A1B6E0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058DF")]
		[Address(RVA = "0xA1C3F0", Offset = "0xA1ADF0", VA = "0x180A1C3F0", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E0")]
		[Address(RVA = "0xA1C0C0", Offset = "0xA1AAC0", VA = "0x180A1C0C0")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E1")]
		[Address(RVA = "0xA1BF20", Offset = "0xA1A920", VA = "0x180A1BF20", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E2")]
		[Address(RVA = "0xA1BC60", Offset = "0xA1A660", VA = "0x180A1BC60")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E3")]
		[Address(RVA = "0xA15EB0", Offset = "0xA148B0", VA = "0x180A15EB0", Slot = "123")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E4")]
		[Address(RVA = "0xA16410", Offset = "0xA14E10", VA = "0x180A16410", Slot = "124")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E5")]
		[Address(RVA = "0xA16720", Offset = "0xA15120", VA = "0x180A16720", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E6")]
		[Address(RVA = "0xA16B00", Offset = "0xA15500", VA = "0x180A16B00", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E7")]
		[Address(RVA = "0xA1CC70", Offset = "0xA1B670", VA = "0x180A1CC70")]
		public ChemistryStation()
		{
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EA")]
		[Address(RVA = "0xA17480", Offset = "0xA15E80", VA = "0x180A17480", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0xA173F0", Offset = "0xA15DF0", VA = "0x180A173F0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058ED")]
		[Address(RVA = "0xA1A1C0", Offset = "0xA18BC0", VA = "0x180A1A1C0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EE")]
		[Address(RVA = "0xA18600", Offset = "0xA17000", VA = "0x180A18600", Slot = "133")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EF")]
		[Address(RVA = "0xA19130", Offset = "0xA17B30", VA = "0x180A19130")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F0")]
		[Address(RVA = "0xA1A090", Offset = "0xA18A90", VA = "0x180A1A090")]
		private void RpcWriter___Server_SendCookOperation_3552222198(ChemistryCookOperation op)
		{
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F1")]
		[Address(RVA = "0xA185F0", Offset = "0xA16FF0", VA = "0x180A185F0")]
		public void RpcLogic___SendCookOperation_3552222198(ChemistryCookOperation op)
		{
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F2")]
		[Address(RVA = "0xA190C0", Offset = "0xA17AC0", VA = "0x180A190C0")]
		private void RpcReader___Server_SendCookOperation_3552222198(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F3")]
		[Address(RVA = "0xA19930", Offset = "0xA18330", VA = "0x180A19930")]
		private void RpcWriter___Observers_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F4")]
		[Address(RVA = "0xA186A0", Offset = "0xA170A0", VA = "0x180A186A0")]
		public void RpcLogic___SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F5")]
		[Address(RVA = "0xA18DB0", Offset = "0xA177B0", VA = "0x180A18DB0")]
		private void RpcReader___Observers_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F6")]
		[Address(RVA = "0xA1AB40", Offset = "0xA19540", VA = "0x180A1AB40")]
		private void RpcWriter___Target_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F7")]
		[Address(RVA = "0xA19690", Offset = "0xA18090", VA = "0x180A19690")]
		private void RpcReader___Target_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F8")]
		[Address(RVA = "0xA16600", Offset = "0xA15000", VA = "0x180A16600")]
		private void RpcWriter___Observers_FinalizeOperation_2166136261()
		{
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F9")]
		[Address(RVA = "0xA18390", Offset = "0xA16D90", VA = "0x180A18390")]
		public void RpcLogic___FinalizeOperation_2166136261()
		{
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FA")]
		[Address(RVA = "0xA18D80", Offset = "0xA17780", VA = "0x180A18D80")]
		private void RpcReader___Observers_FinalizeOperation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FB")]
		[Address(RVA = "0xA1A5A0", Offset = "0xA18FA0", VA = "0x180A1A5A0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FC")]
		[Address(RVA = "0xA18970", Offset = "0xA17370", VA = "0x180A18970", Slot = "134")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FD")]
		[Address(RVA = "0xA192E0", Offset = "0xA17CE0", VA = "0x180A192E0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FE")]
		[Address(RVA = "0xA1A470", Offset = "0xA18E70", VA = "0x180A1A470")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FF")]
		[Address(RVA = "0xA188D0", Offset = "0xA172D0", VA = "0x180A188D0", Slot = "135")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005900")]
		[Address(RVA = "0xA19260", Offset = "0xA17C60", VA = "0x180A19260")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005901")]
		[Address(RVA = "0xA1A9D0", Offset = "0xA193D0", VA = "0x180A1A9D0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005902")]
		[Address(RVA = "0xA18C40", Offset = "0xA17640", VA = "0x180A18C40", Slot = "136")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005903")]
		[Address(RVA = "0xA195A0", Offset = "0xA17FA0", VA = "0x180A195A0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005904")]
		[Address(RVA = "0xA19F10", Offset = "0xA18910", VA = "0x180A19F10")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005905")]
		[Address(RVA = "0xA18CC0", Offset = "0xA176C0", VA = "0x180A18CC0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005906")]
		[Address(RVA = "0xA19030", Offset = "0xA17A30", VA = "0x180A19030")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005907")]
		[Address(RVA = "0xA1AFA0", Offset = "0xA199A0", VA = "0x180A1AFA0")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005908")]
		[Address(RVA = "0xA19890", Offset = "0xA18290", VA = "0x180A19890")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005909")]
		[Address(RVA = "0xA1A2F0", Offset = "0xA18CF0", VA = "0x180A1A2F0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590A")]
		[Address(RVA = "0xA18840", Offset = "0xA17240", VA = "0x180A18840", Slot = "137")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590B")]
		[Address(RVA = "0xA191B0", Offset = "0xA17BB0", VA = "0x180A191B0")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590C")]
		[Address(RVA = "0xA19A70", Offset = "0xA18470", VA = "0x180A19A70")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590D")]
		[Address(RVA = "0xA18850", Offset = "0xA17250", VA = "0x180A18850")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590E")]
		[Address(RVA = "0xA18E10", Offset = "0xA17810", VA = "0x180A18E10")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590F")]
		[Address(RVA = "0xA1A840", Offset = "0xA19240", VA = "0x180A1A840")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005910")]
		[Address(RVA = "0xA18B10", Offset = "0xA17510", VA = "0x180A18B10", Slot = "138")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005911")]
		[Address(RVA = "0xA19450", Offset = "0xA17E50", VA = "0x180A19450")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005912")]
		[Address(RVA = "0xA1AE10", Offset = "0xA19810", VA = "0x180A1AE10")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005913")]
		[Address(RVA = "0xA18B90", Offset = "0xA17590", VA = "0x180A18B90")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005914")]
		[Address(RVA = "0xA19790", Offset = "0xA18190", VA = "0x180A19790")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005915")]
		[Address(RVA = "0xA19D70", Offset = "0xA18770", VA = "0x180A19D70")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005916")]
		[Address(RVA = "0xA18F40", Offset = "0xA17940", VA = "0x180A18F40")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005917")]
		[Address(RVA = "0xA1A6D0", Offset = "0xA190D0", VA = "0x180A1A6D0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005918")]
		[Address(RVA = "0xA18A10", Offset = "0xA17410", VA = "0x180A18A10", Slot = "139")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005919")]
		[Address(RVA = "0xA19360", Offset = "0xA17D60", VA = "0x180A19360")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591A")]
		[Address(RVA = "0xA19BF0", Offset = "0xA185F0", VA = "0x180A19BF0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591B")]
		[Address(RVA = "0xA18A90", Offset = "0xA17490", VA = "0x180A18A90")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591C")]
		[Address(RVA = "0xA18EB0", Offset = "0xA178B0", VA = "0x180A18EB0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591D")]
		[Address(RVA = "0xA1ACA0", Offset = "0xA196A0", VA = "0x180A1ACA0")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591E")]
		[Address(RVA = "0xA196F0", Offset = "0xA180F0", VA = "0x180A196F0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600591F RID: 22815 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005920 RID: 22816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C5D")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x600591F")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005920")]
			[Address(RVA = "0xA1CF80", Offset = "0xA1B980", VA = "0x180A1CF80")]
			set
			{
			}
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x00015DF8 File Offset: 0x00013FF8
		[Token(Token = "0x6005921")]
		[Address(RVA = "0xA18140", Offset = "0xA16B40", VA = "0x180A18140", Slot = "140")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.ChemistryStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005923 RID: 22819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C5E")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005922")]
			[Address(RVA = "0xA0B190", Offset = "0xA09B90", VA = "0x180A0B190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005923")]
			[Address(RVA = "0xA1D040", Offset = "0xA1BA40", VA = "0x180A1D040")]
			set
			{
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06005924 RID: 22820 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005925 RID: 22821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C5F")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6005924")]
			[Address(RVA = "0xA14740", Offset = "0xA13140", VA = "0x180A14740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005925")]
			[Address(RVA = "0xA1CEC0", Offset = "0xA1B8C0", VA = "0x180A1CEC0")]
			set
			{
			}
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005926")]
		[Address(RVA = "0xA14DF0", Offset = "0xA137F0", VA = "0x180A14DF0", Slot = "141")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.ChemistryStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04004150 RID: 16720
		[Token(Token = "0x4004150")]
		public const float FOV_OVERRIDE = 65f;

		// Token: 0x04004151 RID: 16721
		[Token(Token = "0x4004151")]
		public const int INPUT_SLOT_COUNT = 3;

		// Token: 0x04004156 RID: 16726
		[Token(Token = "0x4004156")]
		[FieldOffset(Offset = "0x238")]
		public ItemSlot[] IngredientSlots;

		// Token: 0x04004157 RID: 16727
		[Token(Token = "0x4004157")]
		[FieldOffset(Offset = "0x240")]
		public ItemSlot OutputSlot;

		// Token: 0x04004158 RID: 16728
		[Token(Token = "0x4004158")]
		[FieldOffset(Offset = "0x248")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04004159 RID: 16729
		[Token(Token = "0x4004159")]
		[FieldOffset(Offset = "0x250")]
		public Transform CameraPosition_Default;

		// Token: 0x0400415A RID: 16730
		[Token(Token = "0x400415A")]
		[FieldOffset(Offset = "0x258")]
		public Transform CameraPosition_Stirring;

		// Token: 0x0400415B RID: 16731
		[Token(Token = "0x400415B")]
		[FieldOffset(Offset = "0x260")]
		public Transform StaticBeaker;

		// Token: 0x0400415C RID: 16732
		[Token(Token = "0x400415C")]
		[FieldOffset(Offset = "0x268")]
		public Transform StaticFunnel;

		// Token: 0x0400415D RID: 16733
		[Token(Token = "0x400415D")]
		[FieldOffset(Offset = "0x270")]
		public Transform StaticStirringRod;

		// Token: 0x0400415E RID: 16734
		[Token(Token = "0x400415E")]
		[FieldOffset(Offset = "0x278")]
		public Transform ItemContainer;

		// Token: 0x0400415F RID: 16735
		[Token(Token = "0x400415F")]
		[FieldOffset(Offset = "0x280")]
		public LabStand LabStand;

		// Token: 0x04004160 RID: 16736
		[Token(Token = "0x4004160")]
		[FieldOffset(Offset = "0x288")]
		public StorageVisualizer InputVisuals;

		// Token: 0x04004161 RID: 16737
		[Token(Token = "0x4004161")]
		[FieldOffset(Offset = "0x290")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x04004162 RID: 16738
		[Token(Token = "0x4004162")]
		[FieldOffset(Offset = "0x298")]
		public Rigidbody AnchorRb;

		// Token: 0x04004163 RID: 16739
		[Token(Token = "0x4004163")]
		[FieldOffset(Offset = "0x2A0")]
		public BunsenBurner Burner;

		// Token: 0x04004164 RID: 16740
		[Token(Token = "0x4004164")]
		[FieldOffset(Offset = "0x2A8")]
		public BoilingFlask BoilingFlask;

		// Token: 0x04004165 RID: 16741
		[Token(Token = "0x4004165")]
		[FieldOffset(Offset = "0x2B0")]
		public DigitalAlarm Alarm;

		// Token: 0x04004166 RID: 16742
		[Token(Token = "0x4004166")]
		[FieldOffset(Offset = "0x2B8")]
		public Transform uiPoint;

		// Token: 0x04004167 RID: 16743
		[Token(Token = "0x4004167")]
		[FieldOffset(Offset = "0x2C0")]
		public Transform[] accessPoints;

		// Token: 0x04004168 RID: 16744
		[Token(Token = "0x4004168")]
		[FieldOffset(Offset = "0x2C8")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x04004169 RID: 16745
		[Token(Token = "0x4004169")]
		[FieldOffset(Offset = "0x2D0")]
		public BoxCollider TrashSpawnVolume;

		// Token: 0x0400416A RID: 16746
		[Token(Token = "0x400416A")]
		[FieldOffset(Offset = "0x2D8")]
		public Transform ExplosionPoint;

		// Token: 0x0400416B RID: 16747
		[Token(Token = "0x400416B")]
		[FieldOffset(Offset = "0x2E0")]
		[Header("Slot Display Points")]
		public Transform InputSlotsPosition;

		// Token: 0x0400416C RID: 16748
		[Token(Token = "0x400416C")]
		[FieldOffset(Offset = "0x2E8")]
		public Transform OutputSlotPosition;

		// Token: 0x0400416D RID: 16749
		[Token(Token = "0x400416D")]
		[FieldOffset(Offset = "0x2F0")]
		[Header("Transforms")]
		public Transform[] IngredientTransforms;

		// Token: 0x0400416E RID: 16750
		[Token(Token = "0x400416E")]
		[FieldOffset(Offset = "0x2F8")]
		public Transform BeakerAlignmentTransform;

		// Token: 0x0400416F RID: 16751
		[Token(Token = "0x400416F")]
		[FieldOffset(Offset = "0x300")]
		[Header("Prefabs")]
		public GameObject BeakerPrefab;

		// Token: 0x04004170 RID: 16752
		[Token(Token = "0x4004170")]
		[FieldOffset(Offset = "0x308")]
		public StirringRod StirringRodPrefab;

		// Token: 0x04004171 RID: 16753
		[Token(Token = "0x4004171")]
		[FieldOffset(Offset = "0x310")]
		[Header("UI")]
		public ChemistryStationUIElement WorldspaceUIPrefab;

		// Token: 0x04004172 RID: 16754
		[Token(Token = "0x4004172")]
		[FieldOffset(Offset = "0x318")]
		public Sprite typeIcon;

		// Token: 0x0400417A RID: 16762
		[Token(Token = "0x400417A")]
		[FieldOffset(Offset = "0x350")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x0400417B RID: 16763
		[Token(Token = "0x400417B")]
		[FieldOffset(Offset = "0x358")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x0400417C RID: 16764
		[Token(Token = "0x400417C")]
		[FieldOffset(Offset = "0x360")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x0400417D RID: 16765
		[Token(Token = "0x400417D")]
		[FieldOffset(Offset = "0x368")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted;

		// Token: 0x0400417E RID: 16766
		[Token(Token = "0x400417E")]
		[FieldOffset(Offset = "0x369")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted;

		// Token: 0x02000CA0 RID: 3232
		[Token(Token = "0x2000CA0")]
		public enum EStep
		{
			// Token: 0x04004180 RID: 16768
			[Token(Token = "0x4004180")]
			CombineIngredients,
			// Token: 0x04004181 RID: 16769
			[Token(Token = "0x4004181")]
			Stir,
			// Token: 0x04004182 RID: 16770
			[Token(Token = "0x4004182")]
			LowerBoilingFlask,
			// Token: 0x04004183 RID: 16771
			[Token(Token = "0x4004183")]
			PourIntoBoilingFlask,
			// Token: 0x04004184 RID: 16772
			[Token(Token = "0x4004184")]
			RaiseBoilingFlask,
			// Token: 0x04004185 RID: 16773
			[Token(Token = "0x4004185")]
			StartHeat,
			// Token: 0x04004186 RID: 16774
			[Token(Token = "0x4004186")]
			Cook,
			// Token: 0x04004187 RID: 16775
			[Token(Token = "0x4004187")]
			LowerBoilingFlaskAgain,
			// Token: 0x04004188 RID: 16776
			[Token(Token = "0x4004188")]
			PourThroughFilter
		}
	}
}
