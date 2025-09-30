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
using ScheduleOne.Misc;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB6 RID: 3254
	[Token(Token = "0x2000CB6")]
	public class MixingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06005ABF RID: 23231 RVA: 0x000162C0 File Offset: 0x000144C0
		// (set) Token: 0x06005AC0 RID: 23232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA8")]
		public bool IsOpen
		{
			[Token(Token = "0x6005ABF")]
			[Address(RVA = "0x69DDB0", Offset = "0x69C7B0", VA = "0x18069DDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AC0")]
			[Address(RVA = "0x69DDC0", Offset = "0x69C7C0", VA = "0x18069DDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AC2 RID: 23234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA9")]
		public MixOperation CurrentMixOperation
		{
			[Token(Token = "0x6005AC1")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AC2")]
			[Address(RVA = "0x8A6D70", Offset = "0x8A5770", VA = "0x1808A6D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06005AC3 RID: 23235 RVA: 0x000162D8 File Offset: 0x000144D8
		[Token(Token = "0x17000CAA")]
		public bool IsMixingDone
		{
			[Token(Token = "0x6005AC3")]
			[Address(RVA = "0xA3BF60", Offset = "0xA3A960", VA = "0x180A3BF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x000162F0 File Offset: 0x000144F0
		// (set) Token: 0x06005AC5 RID: 23237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAB")]
		public int CurrentMixTime
		{
			[Token(Token = "0x6005AC4")]
			[Address(RVA = "0xA3BF10", Offset = "0xA3A910", VA = "0x180A3BF10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005AC5")]
			[Address(RVA = "0xA3BFA0", Offset = "0xA3A9A0", VA = "0x180A3BFA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AC7 RID: 23239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAC")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6005AC6")]
			[Address(RVA = "0x9DC5F0", Offset = "0x9DAFF0", VA = "0x1809DC5F0", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AC7")]
			[Address(RVA = "0x9DC610", Offset = "0x9DB010", VA = "0x1809DC610", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AC9 RID: 23241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAD")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6005AC8")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AC9")]
			[Address(RVA = "0xA37280", Offset = "0xA35C80", VA = "0x180A37280", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06005ACA RID: 23242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005ACB RID: 23243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAE")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005ACA")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005ACB")]
			[Address(RVA = "0xA3C000", Offset = "0xA3AA00", VA = "0x180A3C000", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAF")]
		public string Name
		{
			[Token(Token = "0x6005ACC")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06005ACD RID: 23245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005ACE RID: 23246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB0")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6005ACD")]
			[Address(RVA = "0xA3BF50", Offset = "0xA3A950", VA = "0x180A3BF50", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005ACE")]
			[Address(RVA = "0xA3BFE0", Offset = "0xA3A9E0", VA = "0x180A3BFE0", Slot = "89")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06005ACF RID: 23247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AD0 RID: 23248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB1")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6005ACF")]
			[Address(RVA = "0x716B70", Offset = "0x715570", VA = "0x180716B70", Slot = "90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AD0")]
			[Address(RVA = "0x716E80", Offset = "0x715880", VA = "0x180716E80", Slot = "91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06005AD1 RID: 23249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB2")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6005AD1")]
			[Address(RVA = "0x9EBA20", Offset = "0x9EA420", VA = "0x1809EBA20", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06005AD2 RID: 23250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB3")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6005AD2")]
			[Address(RVA = "0xA3BEF0", Offset = "0xA3A8F0", VA = "0x180A3BEF0", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06005AD3 RID: 23251 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x17000CB4")]
		public bool Selectable
		{
			[Token(Token = "0x6005AD3")]
			[Address(RVA = "0x81C3B0", Offset = "0x81ADB0", VA = "0x18081C3B0", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06005AD4 RID: 23252 RVA: 0x00016320 File Offset: 0x00014520
		// (set) Token: 0x06005AD5 RID: 23253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB5")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005AD4")]
			[Address(RVA = "0x81C3C0", Offset = "0x81ADC0", VA = "0x18081C3C0", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005AD5")]
			[Address(RVA = "0x81C630", Offset = "0x81B030", VA = "0x18081C630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB6")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6005AD6")]
			[Address(RVA = "0x62FE00", Offset = "0x62E800", VA = "0x18062FE00", Slot = "109")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AD8 RID: 23256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB7")]
		protected MixingStationConfiguration stationConfiguration
		{
			[Token(Token = "0x6005AD7")]
			[Address(RVA = "0x62FE00", Offset = "0x62E800", VA = "0x18062FE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AD8")]
			[Address(RVA = "0x630520", Offset = "0x62EF20", VA = "0x180630520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06005AD9 RID: 23257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB8")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6005AD9")]
			[Address(RVA = "0xA1CD60", Offset = "0xA1B760", VA = "0x180A1CD60", Slot = "110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x00016338 File Offset: 0x00014538
		[Token(Token = "0x17000CB9")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6005ADA")]
			[Address(RVA = "0xA3BF00", Offset = "0xA3A900", VA = "0x180A3BF00", Slot = "111")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06005ADB RID: 23259 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005ADC RID: 23260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CBA")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6005ADB")]
			[Address(RVA = "0x62FC80", Offset = "0x62E680", VA = "0x18062FC80", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005ADC")]
			[Address(RVA = "0x630250", Offset = "0x62EC50", VA = "0x180630250", Slot = "113")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06005ADD RID: 23261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005ADE RID: 23262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CBB")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6005ADD")]
			[Address(RVA = "0x8C8800", Offset = "0x8C7200", VA = "0x1808C8800", Slot = "114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005ADE")]
			[Address(RVA = "0xA370A0", Offset = "0xA35AA0", VA = "0x180A370A0", Slot = "115")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0xA3A320", Offset = "0xA38D20", VA = "0x180A3A320", Slot = "129")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBC")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6005AE0")]
			[Address(RVA = "0xA3BF90", Offset = "0xA3A990", VA = "0x180A3BF90", Slot = "117")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06005AE1 RID: 23265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBD")]
		public Transform Transform
		{
			[Token(Token = "0x6005AE1")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "118")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBE")]
		public Transform UIPoint
		{
			[Token(Token = "0x6005AE2")]
			[Address(RVA = "0x9EBA20", Offset = "0x9EA420", VA = "0x1809EBA20", Slot = "119")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06005AE3 RID: 23267 RVA: 0x00016350 File Offset: 0x00014550
		[Token(Token = "0x17000CBF")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6005AE3")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06005AE4 RID: 23268 RVA: 0x00016368 File Offset: 0x00014568
		// (set) Token: 0x06005AE5 RID: 23269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC0")]
		public Vector3 DiscoveryBoxOffset
		{
			[Token(Token = "0x6005AE4")]
			[Address(RVA = "0xA3BF20", Offset = "0xA3A920", VA = "0x180A3BF20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6005AE5")]
			[Address(RVA = "0xA3BFB0", Offset = "0xA3A9B0", VA = "0x180A3BFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06005AE6 RID: 23270 RVA: 0x00016380 File Offset: 0x00014580
		// (set) Token: 0x06005AE7 RID: 23271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC1")]
		public Quaternion DiscoveryBoxRotation
		{
			[Token(Token = "0x6005AE6")]
			[Address(RVA = "0xA3BF40", Offset = "0xA3A940", VA = "0x180A3BF40")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6005AE7")]
			[Address(RVA = "0xA3BFD0", Offset = "0xA3A9D0", VA = "0x180A3BFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0xA34000", Offset = "0xA32A00", VA = "0x180A34000", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0xA3BAD0", Offset = "0xA3A4D0", VA = "0x180A3BAD0", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0xA356E0", Offset = "0xA340E0", VA = "0x180A356E0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0xA367B0", Offset = "0xA351B0", VA = "0x180A367B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0xA3A0A0", Offset = "0xA38AA0", VA = "0x180A3A0A0", Slot = "130")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00016398 File Offset: 0x00014598
		[Token(Token = "0x6005AED")]
		[Address(RVA = "0xA34050", Offset = "0xA32A50", VA = "0x180A34050", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0xA34790", Offset = "0xA33190", VA = "0x180A34790", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0xA3BDA0", Offset = "0xA3A7A0", VA = "0x180A3BDA0")]
		private void TimeSkipped(int minsPassed)
		{
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0xA358B0", Offset = "0xA342B0", VA = "0x180A358B0", Slot = "131")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0xA3A1B0", Offset = "0xA38BB0", VA = "0x180A3A1B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixingOperation(MixOperation operation, int mixTime)
		{
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF2")]
		[Address(RVA = "0xA3A770", Offset = "0xA39170", VA = "0x180A3A770", Slot = "132")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void SetMixOperation(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF3")]
		[Address(RVA = "0xA35F00", Offset = "0xA34900", VA = "0x180A35F00", Slot = "133")]
		public virtual void MixingStart()
		{
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF4")]
		[Address(RVA = "0xA35D00", Offset = "0xA34700", VA = "0x180A35D00")]
		[ObserversRpc]
		public void MixingDone_Networked()
		{
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF5")]
		[Address(RVA = "0xA35E20", Offset = "0xA34820", VA = "0x180A35E20", Slot = "134")]
		public virtual void MixingDone()
		{
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x000163B0 File Offset: 0x000145B0
		[Token(Token = "0x6005AF6")]
		[Address(RVA = "0xA34B00", Offset = "0xA33500", VA = "0x180A34B00")]
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0xA34FA0", Offset = "0xA339A0", VA = "0x180A34FA0")]
		public List<ItemInstance> GetIngredients()
		{
			return null;
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x000163C8 File Offset: 0x000145C8
		[Token(Token = "0x6005AF8")]
		[Address(RVA = "0xA35070", Offset = "0xA33A70", VA = "0x180A35070")]
		public int GetMixQuantity()
		{
			return 0;
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x000163E0 File Offset: 0x000145E0
		[Token(Token = "0x6005AF9")]
		[Address(RVA = "0xA34170", Offset = "0xA32B70", VA = "0x180A34170")]
		public bool CanStartMix()
		{
			return default(bool);
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0xA35450", Offset = "0xA33E50", VA = "0x180A35450")]
		public ProductDefinition GetProduct()
		{
			return null;
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0xA35310", Offset = "0xA33D10", VA = "0x180A35310")]
		public PropertyItemDefinition GetMixer()
		{
			return null;
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x000163F8 File Offset: 0x000145F8
		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0xA352F0", Offset = "0xA33CF0", VA = "0x180A352F0")]
		public int GetMixTimeForCurrentOperation()
		{
			return 0;
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0xA399B0", Offset = "0xA383B0", VA = "0x180A399B0")]
		[ServerRpc(RequireOwnership = false)]
		public void TryCreateOutputItems()
		{
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0xA3B610", Offset = "0xA3A010", VA = "0x180A3B610")]
		public void SetStartButtonClickable(bool clickable)
		{
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0xA36DB0", Offset = "0xA357B0", VA = "0x180A36DB0")]
		private void OutputChanged()
		{
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B00")]
		[Address(RVA = "0xA3BA90", Offset = "0xA3A490", VA = "0x180A3BA90")]
		private void StartButtonClicked(RaycastHit hit)
		{
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B01")]
		[Address(RVA = "0xA36930", Offset = "0xA35330", VA = "0x180A36930")]
		public void Open()
		{
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B02")]
		[Address(RVA = "0xA341B0", Offset = "0xA32BB0", VA = "0x180A341B0")]
		public void Close()
		{
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B03")]
		[Address(RVA = "0xA355A0", Offset = "0xA33FA0", VA = "0x180A355A0")]
		public void Hovered()
		{
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B04")]
		[Address(RVA = "0xA35800", Offset = "0xA34200", VA = "0x180A35800")]
		public void Interacted()
		{
		}

		// Token: 0x06005B05 RID: 23301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B05")]
		[Address(RVA = "0xA34560", Offset = "0xA32F60", VA = "0x180A34560", Slot = "123")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06005B06 RID: 23302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B06")]
		[Address(RVA = "0xA34A70", Offset = "0xA33470", VA = "0x180A34A70", Slot = "124")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06005B07 RID: 23303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B07")]
		[Address(RVA = "0xA3B8F0", Offset = "0xA3A2F0", VA = "0x180A3B8F0", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B08")]
		[Address(RVA = "0xA3B630", Offset = "0xA3A030", VA = "0x180A3B630")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B09")]
		[Address(RVA = "0xA3A600", Offset = "0xA39000", VA = "0x180A3A600", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0A")]
		[Address(RVA = "0xA3A450", Offset = "0xA38E50", VA = "0x180A3A450")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0B")]
		[Address(RVA = "0xA3B420", Offset = "0xA39E20", VA = "0x180A3B420", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0xA3B0F0", Offset = "0xA39AF0", VA = "0x180A3B0F0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0xA3AF50", Offset = "0xA39950", VA = "0x180A3AF50", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0E")]
		[Address(RVA = "0xA3AC90", Offset = "0xA39690", VA = "0x180A3AC90")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0xA3AB60", Offset = "0xA39560", VA = "0x180A3AB60", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B10")]
		[Address(RVA = "0xA3AA30", Offset = "0xA39430", VA = "0x180A3AA30", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B11")]
		[Address(RVA = "0xA34C20", Offset = "0xA33620", VA = "0x180A34C20", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B12")]
		[Address(RVA = "0xA354F0", Offset = "0xA33EF0", VA = "0x180A354F0", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B13")]
		[Address(RVA = "0xA3BDE0", Offset = "0xA3A7E0", VA = "0x180A3BDE0")]
		public MixingStation()
		{
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B17")]
		[Address(RVA = "0xA36000", Offset = "0xA34A00", VA = "0x180A36000", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B18")]
		[Address(RVA = "0xA35F70", Offset = "0xA34970", VA = "0x180A35F70", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B19")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1A")]
		[Address(RVA = "0xA39030", Offset = "0xA37A30", VA = "0x180A39030")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1B")]
		[Address(RVA = "0xA370A0", Offset = "0xA35AA0", VA = "0x180A370A0", Slot = "135")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1C")]
		[Address(RVA = "0xA37EC0", Offset = "0xA368C0", VA = "0x180A37EC0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1D")]
		[Address(RVA = "0xA38EC0", Offset = "0xA378C0", VA = "0x180A38EC0")]
		private void RpcWriter___Server_SendMixingOperation_2669582547(MixOperation operation, int mixTime)
		{
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1E")]
		[Address(RVA = "0xA37070", Offset = "0xA35A70", VA = "0x180A37070")]
		public void RpcLogic___SendMixingOperation_2669582547(MixOperation operation, int mixTime)
		{
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1F")]
		[Address(RVA = "0xA37E10", Offset = "0xA36810", VA = "0x180A37E10")]
		private void RpcReader___Server_SendMixingOperation_2669582547(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B20")]
		[Address(RVA = "0xA388A0", Offset = "0xA372A0", VA = "0x180A388A0")]
		private void RpcWriter___Observers_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B21")]
		[Address(RVA = "0xA371D0", Offset = "0xA35BD0", VA = "0x180A371D0", Slot = "136")]
		public virtual void RpcLogic___SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B22")]
		[Address(RVA = "0xA37B70", Offset = "0xA36570", VA = "0x180A37B70")]
		private void RpcReader___Observers_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B23")]
		[Address(RVA = "0xA39AC0", Offset = "0xA384C0", VA = "0x180A39AC0")]
		private void RpcWriter___Target_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B24")]
		[Address(RVA = "0xA38450", Offset = "0xA36E50", VA = "0x180A38450")]
		private void RpcReader___Target_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B25")]
		[Address(RVA = "0xA35D00", Offset = "0xA34700", VA = "0x180A35D00")]
		private void RpcWriter___Observers_MixingDone_Networked_2166136261()
		{
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B26")]
		[Address(RVA = "0xA37050", Offset = "0xA35A50", VA = "0x180A37050")]
		public void RpcLogic___MixingDone_Networked_2166136261()
		{
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B27")]
		[Address(RVA = "0xA37A90", Offset = "0xA36490", VA = "0x180A37A90")]
		private void RpcReader___Observers_MixingDone_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B28")]
		[Address(RVA = "0xA399B0", Offset = "0xA383B0", VA = "0x180A399B0")]
		private void RpcWriter___Server_TryCreateOutputItems_2166136261()
		{
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B29")]
		[Address(RVA = "0xA37870", Offset = "0xA36270", VA = "0x180A37870")]
		public void RpcLogic___TryCreateOutputItems_2166136261()
		{
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2A")]
		[Address(RVA = "0xA38420", Offset = "0xA36E20", VA = "0x180A38420")]
		private void RpcReader___Server_TryCreateOutputItems_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2B")]
		[Address(RVA = "0xA39840", Offset = "0xA38240", VA = "0x180A39840")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2C")]
		[Address(RVA = "0xA37730", Offset = "0xA36130", VA = "0x180A37730", Slot = "137")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2D")]
		[Address(RVA = "0xA38330", Offset = "0xA36D30", VA = "0x180A38330")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2E")]
		[Address(RVA = "0xA38D40", Offset = "0xA37740", VA = "0x180A38D40")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0xA377B0", Offset = "0xA361B0", VA = "0x180A377B0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B30")]
		[Address(RVA = "0xA37D80", Offset = "0xA36780", VA = "0x180A37D80")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B31")]
		[Address(RVA = "0xA39F30", Offset = "0xA38930", VA = "0x180A39F30")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B32")]
		[Address(RVA = "0xA38680", Offset = "0xA37080", VA = "0x180A38680")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B33")]
		[Address(RVA = "0xA39160", Offset = "0xA37B60", VA = "0x180A39160")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B34")]
		[Address(RVA = "0xA37140", Offset = "0xA35B40", VA = "0x180A37140", Slot = "138")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B35")]
		[Address(RVA = "0xA37F40", Offset = "0xA36940", VA = "0x180A37F40")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B36")]
		[Address(RVA = "0xA38720", Offset = "0xA37120", VA = "0x180A38720")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B37")]
		[Address(RVA = "0xA37150", Offset = "0xA35B50", VA = "0x180A37150")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B38")]
		[Address(RVA = "0xA37AD0", Offset = "0xA364D0", VA = "0x180A37AD0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B39")]
		[Address(RVA = "0xA396B0", Offset = "0xA380B0", VA = "0x180A396B0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3A")]
		[Address(RVA = "0xA37600", Offset = "0xA36000", VA = "0x180A37600", Slot = "139")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3B")]
		[Address(RVA = "0xA381E0", Offset = "0xA36BE0", VA = "0x180A381E0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3C")]
		[Address(RVA = "0xA39DA0", Offset = "0xA387A0", VA = "0x180A39DA0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3D")]
		[Address(RVA = "0xA37680", Offset = "0xA36080", VA = "0x180A37680")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3E")]
		[Address(RVA = "0xA38580", Offset = "0xA36F80", VA = "0x180A38580")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3F")]
		[Address(RVA = "0xA38BA0", Offset = "0xA375A0", VA = "0x180A38BA0")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B40")]
		[Address(RVA = "0xA37C90", Offset = "0xA36690", VA = "0x180A37C90")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B41")]
		[Address(RVA = "0xA39540", Offset = "0xA37F40", VA = "0x180A39540")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B42")]
		[Address(RVA = "0xA37500", Offset = "0xA35F00", VA = "0x180A37500", Slot = "140")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B43")]
		[Address(RVA = "0xA380F0", Offset = "0xA36AF0", VA = "0x180A380F0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B44")]
		[Address(RVA = "0xA38A20", Offset = "0xA37420", VA = "0x180A38A20")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B45")]
		[Address(RVA = "0xA37580", Offset = "0xA35F80", VA = "0x180A37580")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B46")]
		[Address(RVA = "0xA37C00", Offset = "0xA36600", VA = "0x180A37C00")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B47")]
		[Address(RVA = "0xA39C30", Offset = "0xA38630", VA = "0x180A39C30")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0xA384E0", Offset = "0xA36EE0", VA = "0x180A384E0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0xA39410", Offset = "0xA37E10", VA = "0x180A39410")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0xA37320", Offset = "0xA35D20", VA = "0x180A37320", Slot = "141")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0xA38070", Offset = "0xA36A70", VA = "0x180A38070")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0xA392E0", Offset = "0xA37CE0", VA = "0x180A392E0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0xA37280", Offset = "0xA35C80", VA = "0x180A37280", Slot = "142")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0xA37FF0", Offset = "0xA369F0", VA = "0x180A37FF0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B50 RID: 23376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC2")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B50")]
			[Address(RVA = "0xA3C160", Offset = "0xA3AB60", VA = "0x180A3C160")]
			set
			{
			}
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x00016410 File Offset: 0x00014610
		[Token(Token = "0x6005B51")]
		[Address(RVA = "0xA36EB0", Offset = "0xA358B0", VA = "0x180A36EB0", Slot = "143")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.MixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06005B52 RID: 23378 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B53 RID: 23379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC3")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005B52")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B53")]
			[Address(RVA = "0xA3C220", Offset = "0xA3AC20", VA = "0x180A3C220")]
			set
			{
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06005B54 RID: 23380 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B55 RID: 23381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC4")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6005B54")]
			[Address(RVA = "0x8C8800", Offset = "0x8C7200", VA = "0x1808C8800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B55")]
			[Address(RVA = "0xA3C0A0", Offset = "0xA3AAA0", VA = "0x180A3C0A0")]
			set
			{
			}
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B56")]
		[Address(RVA = "0xA33980", Offset = "0xA32380", VA = "0x180A33980", Slot = "144")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.MixingStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04004278 RID: 17016
		[Token(Token = "0x4004278")]
		[FieldOffset(Offset = "0x230")]
		public ItemSlot ProductSlot;

		// Token: 0x04004279 RID: 17017
		[Token(Token = "0x4004279")]
		[FieldOffset(Offset = "0x238")]
		public ItemSlot MixerSlot;

		// Token: 0x0400427A RID: 17018
		[Token(Token = "0x400427A")]
		[FieldOffset(Offset = "0x240")]
		public ItemSlot OutputSlot;

		// Token: 0x0400427E RID: 17022
		[Token(Token = "0x400427E")]
		[FieldOffset(Offset = "0x260")]
		public bool RequiresIngredientInsertion;

		// Token: 0x04004286 RID: 17030
		[Token(Token = "0x4004286")]
		[FieldOffset(Offset = "0x298")]
		[Header("Settings")]
		public int MixTimePerItem;

		// Token: 0x04004287 RID: 17031
		[Token(Token = "0x4004287")]
		[FieldOffset(Offset = "0x29C")]
		public int MaxMixQuantity;

		// Token: 0x04004288 RID: 17032
		[Token(Token = "0x4004288")]
		[FieldOffset(Offset = "0x2A0")]
		[Header("Prefabs")]
		public GameObject JugPrefab;

		// Token: 0x04004289 RID: 17033
		[Token(Token = "0x4004289")]
		[FieldOffset(Offset = "0x2A8")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x0400428A RID: 17034
		[Token(Token = "0x400428A")]
		[FieldOffset(Offset = "0x2B0")]
		public Transform CameraPosition;

		// Token: 0x0400428B RID: 17035
		[Token(Token = "0x400428B")]
		[FieldOffset(Offset = "0x2B8")]
		public Transform CameraPosition_CombineIngredients;

		// Token: 0x0400428C RID: 17036
		[Token(Token = "0x400428C")]
		[FieldOffset(Offset = "0x2C0")]
		public Transform CameraPosition_StartMachine;

		// Token: 0x0400428D RID: 17037
		[Token(Token = "0x400428D")]
		[FieldOffset(Offset = "0x2C8")]
		public StorageVisualizer InputVisuals;

		// Token: 0x0400428E RID: 17038
		[Token(Token = "0x400428E")]
		[FieldOffset(Offset = "0x2D0")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x0400428F RID: 17039
		[Token(Token = "0x400428F")]
		[FieldOffset(Offset = "0x2D8")]
		public DigitalAlarm Clock;

		// Token: 0x04004290 RID: 17040
		[Token(Token = "0x4004290")]
		[FieldOffset(Offset = "0x2E0")]
		public ToggleableLight Light;

		// Token: 0x04004291 RID: 17041
		[Token(Token = "0x4004291")]
		[FieldOffset(Offset = "0x2E8")]
		public NewMixDiscoveryBox DiscoveryBox;

		// Token: 0x04004292 RID: 17042
		[Token(Token = "0x4004292")]
		[FieldOffset(Offset = "0x2F0")]
		public Transform ItemContainer;

		// Token: 0x04004293 RID: 17043
		[Token(Token = "0x4004293")]
		[FieldOffset(Offset = "0x2F8")]
		public Transform[] IngredientTransforms;

		// Token: 0x04004294 RID: 17044
		[Token(Token = "0x4004294")]
		[FieldOffset(Offset = "0x300")]
		public Fillable BowlFillable;

		// Token: 0x04004295 RID: 17045
		[Token(Token = "0x4004295")]
		[FieldOffset(Offset = "0x308")]
		public Clickable StartButton;

		// Token: 0x04004296 RID: 17046
		[Token(Token = "0x4004296")]
		[FieldOffset(Offset = "0x310")]
		public Transform JugAlignment;

		// Token: 0x04004297 RID: 17047
		[Token(Token = "0x4004297")]
		[FieldOffset(Offset = "0x318")]
		public Rigidbody Anchor;

		// Token: 0x04004298 RID: 17048
		[Token(Token = "0x4004298")]
		[FieldOffset(Offset = "0x320")]
		public BoxCollider TrashSpawnVolume;

		// Token: 0x04004299 RID: 17049
		[Token(Token = "0x4004299")]
		[FieldOffset(Offset = "0x328")]
		public Transform uiPoint;

		// Token: 0x0400429A RID: 17050
		[Token(Token = "0x400429A")]
		[FieldOffset(Offset = "0x330")]
		public Transform[] accessPoints;

		// Token: 0x0400429B RID: 17051
		[Token(Token = "0x400429B")]
		[FieldOffset(Offset = "0x338")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x0400429C RID: 17052
		[Token(Token = "0x400429C")]
		[FieldOffset(Offset = "0x340")]
		[Header("Sounds")]
		public StartLoopStopAudio MachineSound;

		// Token: 0x0400429D RID: 17053
		[Token(Token = "0x400429D")]
		[FieldOffset(Offset = "0x348")]
		public AudioSourceController StartSound;

		// Token: 0x0400429E RID: 17054
		[Token(Token = "0x400429E")]
		[FieldOffset(Offset = "0x350")]
		public AudioSourceController StopSound;

		// Token: 0x0400429F RID: 17055
		[Token(Token = "0x400429F")]
		[FieldOffset(Offset = "0x358")]
		[Header("UI")]
		[Header("Mix Timing")]
		public MixingStationUIElement WorldspaceUIPrefab;

		// Token: 0x040042A0 RID: 17056
		[Token(Token = "0x40042A0")]
		[FieldOffset(Offset = "0x360")]
		public Sprite typeIcon;

		// Token: 0x040042A1 RID: 17057
		[Token(Token = "0x40042A1")]
		[FieldOffset(Offset = "0x368")]
		public UnityEvent onMixStart;

		// Token: 0x040042A2 RID: 17058
		[Token(Token = "0x40042A2")]
		[FieldOffset(Offset = "0x370")]
		public UnityEvent onMixDone;

		// Token: 0x040042A3 RID: 17059
		[Token(Token = "0x40042A3")]
		[FieldOffset(Offset = "0x378")]
		public UnityEvent onOutputCollected;

		// Token: 0x040042A4 RID: 17060
		[Token(Token = "0x40042A4")]
		[FieldOffset(Offset = "0x380")]
		public UnityEvent onStartButtonClicked;

		// Token: 0x040042A7 RID: 17063
		[Token(Token = "0x40042A7")]
		[FieldOffset(Offset = "0x3A8")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x040042A8 RID: 17064
		[Token(Token = "0x40042A8")]
		[FieldOffset(Offset = "0x3B0")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x040042A9 RID: 17065
		[Token(Token = "0x40042A9")]
		[FieldOffset(Offset = "0x3B8")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x040042AA RID: 17066
		[Token(Token = "0x40042AA")]
		[FieldOffset(Offset = "0x3C0")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x040042AB RID: 17067
		[Token(Token = "0x40042AB")]
		[FieldOffset(Offset = "0x3C1")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted;
	}
}
