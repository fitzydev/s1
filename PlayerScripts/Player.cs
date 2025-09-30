using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts.Health;
using ScheduleOne.Product;
using ScheduleOne.Property;
using ScheduleOne.Skating;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	public class Player : NetworkBehaviour, ISaveable, ICombatTargetable, IDamageable, ISightable
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x170004DA")]
		public bool IsLocalPlayer
		{
			[Token(Token = "0x6001BA9")]
			[Address(RVA = "0x62FD80", Offset = "0x62E780", VA = "0x18062FD80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DB")]
		public Transform CenterPointTransform
		{
			[Token(Token = "0x6001BAA")]
			[Address(RVA = "0x62FC10", Offset = "0x62E610", VA = "0x18062FC10", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x170004DC")]
		public Vector3 LookAtPoint
		{
			[Token(Token = "0x6001BAB")]
			[Address(RVA = "0x62FE40", Offset = "0x62E840", VA = "0x18062FE40", Slot = "45")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x170004DD")]
		public bool IsCurrentlyTargetable
		{
			[Token(Token = "0x6001BAC")]
			[Address(RVA = "0x62FD30", Offset = "0x62E730", VA = "0x18062FD30", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x170004DE")]
		public float RangedHitChanceMultiplier
		{
			[Token(Token = "0x6001BAD")]
			[Address(RVA = "0x62FFE0", Offset = "0x62E9E0", VA = "0x18062FFE0", Slot = "47")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x170004DF")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6001BAE")]
			[Address(RVA = "0x630150", Offset = "0x62EB50", VA = "0x180630150", Slot = "48")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x621120", Offset = "0x61FB20", VA = "0x180621120", Slot = "49")]
		public void RecordLastKnownPosition(bool resetTimeSinceLastSeen)
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x619120", Offset = "0x617B20", VA = "0x180619120", Slot = "50")]
		public float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E0")]
		public VisionEvent HighestProgressionEvent
		{
			[Token(Token = "0x6001BB1")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10", Slot = "57")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BB2")]
			[Address(RVA = "0x630490", Offset = "0x62EE90", VA = "0x180630490", Slot = "58")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E1")]
		public EntityVisibility VisibilityComponent
		{
			[Token(Token = "0x6001BB3")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180", Slot = "59")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x619670", Offset = "0x618070", VA = "0x180619670", Slot = "60")]
		public bool IsCurrentlySightable()
		{
			return default(bool);
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x00009888 File Offset: 0x00007A88
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E2")]
		public Vector3 EyePosition
		{
			[Token(Token = "0x6001BB5")]
			[Address(RVA = "0x62FCE0", Offset = "0x62E6E0", VA = "0x18062FCE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001BB6")]
			[Address(RVA = "0x630460", Offset = "0x62EE60", VA = "0x180630460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E3")]
		public string PlayerName
		{
			[Token(Token = "0x6001BB7")]
			[Address(RVA = "0x62FFD0", Offset = "0x62E9D0", VA = "0x18062FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BB8")]
			[Address(RVA = "0x630640", Offset = "0x62F040", VA = "0x180630640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E4")]
		public string PlayerCode
		{
			[Token(Token = "0x6001BB9")]
			[Address(RVA = "0x62FFB0", Offset = "0x62E9B0", VA = "0x18062FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BBA")]
			[Address(RVA = "0x630590", Offset = "0x62EF90", VA = "0x180630590")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E5")]
		public NetworkObject CurrentVehicle
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x62FCC0", Offset = "0x62E6C0", VA = "0x18062FCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x6302C0", Offset = "0x62ECC0", VA = "0x1806302C0")]
			[ServerRpc(RunLocally = true)]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E6")]
		public VehicleSeat CurrentVehicleSeat
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BBE")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E7")]
		public LandVehicle LastDrivenVehicle
		{
			[Token(Token = "0x6001BBF")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC0")]
			[Address(RVA = "0x630500", Offset = "0x62EF00", VA = "0x180630500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x000098A0 File Offset: 0x00007AA0
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E8")]
		public float TimeSinceVehicleExit
		{
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0x630140", Offset = "0x62EB40", VA = "0x180630140")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x630740", Offset = "0x62F140", VA = "0x180630740")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x000098B8 File Offset: 0x00007AB8
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E9")]
		public bool Crouched
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x62FC50", Offset = "0x62E650", VA = "0x18062FC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BC4")]
			[Address(RVA = "0x62DC40", Offset = "0x62C640", VA = "0x18062DC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EA")]
		public NetworkObject CurrentBed
		{
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x62FC70", Offset = "0x62E670", VA = "0x18062FC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC6")]
			[Address(RVA = "0x62B8F0", Offset = "0x62A2F0", VA = "0x18062B8F0")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x000098D0 File Offset: 0x00007AD0
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EB")]
		public bool IsReadyToSleep
		{
			[Token(Token = "0x6001BC7")]
			[Address(RVA = "0x62FDA0", Offset = "0x62E7A0", VA = "0x18062FDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BC8")]
			[Address(RVA = "0x624420", Offset = "0x622E20", VA = "0x180624420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x000098E8 File Offset: 0x00007AE8
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EC")]
		public bool IsSkating
		{
			[Token(Token = "0x6001BC9")]
			[Address(RVA = "0x62FDB0", Offset = "0x62E7B0", VA = "0x18062FDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BCA")]
			[Address(RVA = "0x62BC50", Offset = "0x62A650", VA = "0x18062BC50")]
			[ServerRpc]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004ED")]
		public Skateboard ActiveSkateboard
		{
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BCC")]
			[Address(RVA = "0x6301C0", Offset = "0x62EBC0", VA = "0x1806301C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00009900 File Offset: 0x00007B00
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EE")]
		public bool IsSleeping
		{
			[Token(Token = "0x6001BCD")]
			[Address(RVA = "0x62FDC0", Offset = "0x62E7C0", VA = "0x18062FDC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BCE")]
			[Address(RVA = "0x6304D0", Offset = "0x62EED0", VA = "0x1806304D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00009918 File Offset: 0x00007B18
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EF")]
		public bool IsRagdolled
		{
			[Token(Token = "0x6001BCF")]
			[Address(RVA = "0x62FD90", Offset = "0x62E790", VA = "0x18062FD90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BD0")]
			[Address(RVA = "0x6304C0", Offset = "0x62EEC0", VA = "0x1806304C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00009930 File Offset: 0x00007B30
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F0")]
		public bool IsArrested
		{
			[Token(Token = "0x6001BD1")]
			[Address(RVA = "0x62FD20", Offset = "0x62E720", VA = "0x18062FD20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BD2")]
			[Address(RVA = "0x6304B0", Offset = "0x62EEB0", VA = "0x1806304B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00009948 File Offset: 0x00007B48
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F1")]
		public bool IsTased
		{
			[Token(Token = "0x6001BD3")]
			[Address(RVA = "0x62FDD0", Offset = "0x62E7D0", VA = "0x18062FDD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BD4")]
			[Address(RVA = "0x6304E0", Offset = "0x62EEE0", VA = "0x1806304E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00009960 File Offset: 0x00007B60
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F2")]
		public bool IsUnconscious
		{
			[Token(Token = "0x6001BD5")]
			[Address(RVA = "0x62FDE0", Offset = "0x62E7E0", VA = "0x18062FDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BD6")]
			[Address(RVA = "0x6304F0", Offset = "0x62EEF0", VA = "0x1806304F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00009978 File Offset: 0x00007B78
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F3")]
		public float Scale
		{
			[Token(Token = "0x6001BD7")]
			[Address(RVA = "0x6300E0", Offset = "0x62EAE0", VA = "0x1806300E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001BD8")]
			[Address(RVA = "0x6306E0", Offset = "0x62F0E0", VA = "0x1806306E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F4")]
		public Property CurrentProperty
		{
			[Token(Token = "0x6001BD9")]
			[Address(RVA = "0x62FC90", Offset = "0x62E690", VA = "0x18062FC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BDA")]
			[Address(RVA = "0x630270", Offset = "0x62EC70", VA = "0x180630270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F5")]
		public Property LastVisitedProperty
		{
			[Token(Token = "0x6001BDB")]
			[Address(RVA = "0x62FE00", Offset = "0x62E800", VA = "0x18062FE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BDC")]
			[Address(RVA = "0x630520", Offset = "0x62EF20", VA = "0x180630520")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F6")]
		public Business CurrentBusiness
		{
			[Token(Token = "0x6001BDD")]
			[Address(RVA = "0x62FC80", Offset = "0x62E680", VA = "0x18062FC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BDE")]
			[Address(RVA = "0x630250", Offset = "0x62EC50", VA = "0x180630250")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00009990 File Offset: 0x00007B90
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F7")]
		public EMapRegion CurrentRegion
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x62FCA0", Offset = "0x62E6A0", VA = "0x18062FCA0")]
			[CompilerGenerated]
			get
			{
				return EMapRegion.Northtown;
			}
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x630290", Offset = "0x62EC90", VA = "0x180630290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x170004F8")]
		public Vector3 PlayerBasePosition
		{
			[Token(Token = "0x6001BE1")]
			[Address(RVA = "0x62FEB0", Offset = "0x62E8B0", VA = "0x18062FEB0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x000099C0 File Offset: 0x00007BC0
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F9")]
		public Vector3 CameraPosition
		{
			[Token(Token = "0x6001BE2")]
			[Address(RVA = "0x62FBE0", Offset = "0x62E5E0", VA = "0x18062FBE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001BE3")]
			[Address(RVA = "0x6301E0", Offset = "0x62EBE0", VA = "0x1806301E0")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000099D8 File Offset: 0x00007BD8
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FA")]
		public Quaternion CameraRotation
		{
			[Token(Token = "0x6001BE4")]
			[Address(RVA = "0x62FC00", Offset = "0x62E600", VA = "0x18062FC00")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6001BE5")]
			[Address(RVA = "0x62B730", Offset = "0x62A130", VA = "0x18062B730")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FB")]
		public BasicAvatarSettings CurrentAvatarSettings
		{
			[Token(Token = "0x6001BE6")]
			[Address(RVA = "0x62FC60", Offset = "0x62E660", VA = "0x18062FC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BE7")]
			[Address(RVA = "0x630230", Offset = "0x62EC30", VA = "0x180630230")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FC")]
		public ProductItemInstance ConsumedProduct
		{
			[Token(Token = "0x6001BE8")]
			[Address(RVA = "0x62FC40", Offset = "0x62E640", VA = "0x18062FC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BE9")]
			[Address(RVA = "0x630210", Offset = "0x62EC10", VA = "0x180630210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000099F0 File Offset: 0x00007BF0
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FD")]
		public int TimeSinceProductConsumed
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x630130", Offset = "0x62EB30", VA = "0x180630130")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BEB")]
			[Address(RVA = "0x630730", Offset = "0x62F130", VA = "0x180630730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x61A4E0", Offset = "0x618EE0", VA = "0x18061A4E0")]
		[Button]
		public void LoadDebugAvatarSettings()
		{
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004FE")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001BED")]
			[Address(RVA = "0x630060", Offset = "0x62EA60", VA = "0x180630060", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004FF")]
		public string SaveFileName
		{
			[Token(Token = "0x6001BEE")]
			[Address(RVA = "0x630030", Offset = "0x62EA30", VA = "0x180630030", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000500")]
		public Loader Loader
		{
			[Token(Token = "0x6001BEF")]
			[Address(RVA = "0x62FE10", Offset = "0x62E810", VA = "0x18062FE10", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00009A08 File Offset: 0x00007C08
		[Token(Token = "0x17000501")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000502")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0x62FE20", Offset = "0x62E820", VA = "0x18062FE20", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x630540", Offset = "0x62EF40", VA = "0x180630540", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000503")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x62FE30", Offset = "0x62E830", VA = "0x18062FE30", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x630560", Offset = "0x62EF60", VA = "0x180630560", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x00009A20 File Offset: 0x00007C20
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000504")]
		public bool HasChanged
		{
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0x62FD00", Offset = "0x62E700", VA = "0x18062FD00", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0x630480", Offset = "0x62EE80", VA = "0x180630480", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00009A38 File Offset: 0x00007C38
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000505")]
		public bool avatarVisibleToLocalPlayer
		{
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0x630190", Offset = "0x62EB90", VA = "0x180630190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BF8")]
			[Address(RVA = "0x630750", Offset = "0x62F150", VA = "0x180630750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x00009A50 File Offset: 0x00007C50
		// (set) Token: 0x06001BFA RID: 7162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000506")]
		public bool playerDataRetrieveReturned
		{
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x6301A0", Offset = "0x62EBA0", VA = "0x1806301A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BFA")]
			[Address(RVA = "0x630760", Offset = "0x62F160", VA = "0x180630760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x00009A68 File Offset: 0x00007C68
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000507")]
		public bool playerSaveRequestReturned
		{
			[Token(Token = "0x6001BFB")]
			[Address(RVA = "0x6301B0", Offset = "0x62EBB0", VA = "0x1806301B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BFC")]
			[Address(RVA = "0x630770", Offset = "0x62F170", VA = "0x180630770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00009A80 File Offset: 0x00007C80
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000508")]
		public bool PlayerInitializedOverNetwork
		{
			[Token(Token = "0x6001BFD")]
			[Address(RVA = "0x62FFC0", Offset = "0x62E9C0", VA = "0x18062FFC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BFE")]
			[Address(RVA = "0x630630", Offset = "0x62F030", VA = "0x180630630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000509")]
		public bool Paranoid
		{
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0x62FEA0", Offset = "0x62E8A0", VA = "0x18062FEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x630580", Offset = "0x62EF80", VA = "0x180630580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x00009AB0 File Offset: 0x00007CB0
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050A")]
		public bool Sneaky
		{
			[Token(Token = "0x6001C01")]
			[Address(RVA = "0x630120", Offset = "0x62EB20", VA = "0x180630120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C02")]
			[Address(RVA = "0x630720", Offset = "0x62F120", VA = "0x180630720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x00009AC8 File Offset: 0x00007CC8
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050B")]
		public bool Disoriented
		{
			[Token(Token = "0x6001C03")]
			[Address(RVA = "0x62FCD0", Offset = "0x62E6D0", VA = "0x18062FCD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C04")]
			[Address(RVA = "0x630450", Offset = "0x62EE50", VA = "0x180630450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00009AE0 File Offset: 0x00007CE0
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050C")]
		public bool Seizure
		{
			[Token(Token = "0x6001C05")]
			[Address(RVA = "0x630100", Offset = "0x62EB00", VA = "0x180630100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x630700", Offset = "0x62F100", VA = "0x180630700")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00009AF8 File Offset: 0x00007CF8
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050D")]
		public bool Slippery
		{
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x630110", Offset = "0x62EB10", VA = "0x180630110")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C08")]
			[Address(RVA = "0x630710", Offset = "0x62F110", VA = "0x180630710")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00009B10 File Offset: 0x00007D10
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050E")]
		public bool Schizophrenic
		{
			[Token(Token = "0x6001C09")]
			[Address(RVA = "0x6300F0", Offset = "0x62EAF0", VA = "0x1806300F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x6306F0", Offset = "0x62F0F0", VA = "0x1806306F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x618C20", Offset = "0x617620", VA = "0x180618C20")]
		public static Player GetPlayer(NetworkConnection conn)
		{
			return null;
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x618D70", Offset = "0x617770", VA = "0x180618D70")]
		public static Player GetRandomPlayer(bool excludeArrestedOrDead = true, bool excludeSleeping = true)
		{
			return null;
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x618B10", Offset = "0x617510", VA = "0x180618B10")]
		public static Player GetPlayer(string playerCode)
		{
			return null;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x6162F0", Offset = "0x614CF0", VA = "0x1806162F0", Slot = "61")]
		public virtual void Awake()
		{
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x6195E0", Offset = "0x617FE0", VA = "0x1806195E0", Slot = "62")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x62E840", Offset = "0x62D240", VA = "0x18062E840", Slot = "63")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x61D2C0", Offset = "0x61BCC0", VA = "0x18061D2C0", Slot = "64")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x61DF80", Offset = "0x61C980", VA = "0x18061DF80", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x61ED90", Offset = "0x61D790", VA = "0x18061ED90")]
		private void PlayerLoaded()
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x61DD20", Offset = "0x61C720", VA = "0x18061DD20", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x621280", Offset = "0x61FC80", VA = "0x180621280")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void RequestSavePlayer()
		{
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x621630", Offset = "0x620030", VA = "0x180621630")]
		[ObserversRpc]
		[TargetRpc]
		private void ReturnSaveRequest(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x6194C0", Offset = "0x617EC0", VA = "0x1806194C0")]
		[ObserversRpc(RunLocally = true)]
		public void HostExitedGame()
		{
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x6163A0", Offset = "0x614DA0", VA = "0x1806163A0")]
		private void ClientConnectionStateChanged(ClientConnectionStateArgs args)
		{
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x62D5E0", Offset = "0x62BFE0", VA = "0x18062D5E0")]
		[ServerRpc(RunLocally = true)]
		public void SendPlayerNameData(string playerName, ulong id)
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x621150", Offset = "0x61FB50", VA = "0x180621150")]
		[ServerRpc(RequireOwnership = false)]
		public void RequestPlayerData(string playerCode)
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x61B240", Offset = "0x619C40", VA = "0x18061B240")]
		[ServerRpc(RunLocally = true)]
		public void MarkPlayerInitialized()
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x6208C0", Offset = "0x61F2C0", VA = "0x1806208C0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ReceivePlayerData(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x62DC50", Offset = "0x62C650", VA = "0x18062DC50")]
		public void SetGravityMultiplier(float multiplier)
		{
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x620BF0", Offset = "0x61F5F0", VA = "0x180620BF0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerNameData(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x62CEE0", Offset = "0x62B8E0", VA = "0x18062CEE0")]
		public void SendFlashlightOn(bool on)
		{
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x62CEE0", Offset = "0x62B8E0", VA = "0x18062CEE0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendFlashlightOnNetworked(bool on)
		{
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x623630", Offset = "0x622030", VA = "0x180623630")]
		[ObserversRpc(RunLocally = true)]
		private void SetFlashlightOn(bool on)
		{
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x61E9A0", Offset = "0x61D3A0", VA = "0x18061E9A0", Slot = "12")]
		public override void OnStopClient()
		{
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x61E8F0", Offset = "0x61D2F0", VA = "0x18061E8F0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x62EE20", Offset = "0x62D820", VA = "0x18062EE20", Slot = "65")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "66")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x62EB50", Offset = "0x62D550", VA = "0x18062EB50", Slot = "67")]
		protected virtual void Tick()
		{
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x619AC0", Offset = "0x6184C0", VA = "0x180619AC0", Slot = "68")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x61FB80", Offset = "0x61E580", VA = "0x18061FB80")]
		private void RecalculateCurrentProperty()
		{
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x61FE90", Offset = "0x61E890", VA = "0x18061FE90")]
		private void RecalculateCurrentRegion()
		{
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x617FE0", Offset = "0x6169E0", VA = "0x180617FE0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0x614FB0", Offset = "0x6139B0", VA = "0x180614FB0")]
		private void ApplyMovementVisuals()
		{
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2C")]
		[Address(RVA = "0x62E660", Offset = "0x62D060", VA = "0x18062E660")]
		public void SetVisible(bool vis, bool network = false)
		{
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2D")]
		[Address(RVA = "0x61EC70", Offset = "0x61D670", VA = "0x18061EC70")]
		[ObserversRpc]
		public void PlayJumpAnimation()
		{
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00009B28 File Offset: 0x00007D28
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x618710", Offset = "0x617110", VA = "0x180618710")]
		public bool GetIsGrounded()
		{
			return default(bool);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x62CBB0", Offset = "0x62B5B0", VA = "0x18062CBB0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendCrouched(bool crouched)
		{
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x62DC40", Offset = "0x62C640", VA = "0x18062DC40")]
		public void SetCrouchedLocal(bool crouched)
		{
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x620190", Offset = "0x61EB90", VA = "0x180620190")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveCrouched(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x62CA20", Offset = "0x62B420", VA = "0x18062CA20")]
		[ServerRpc(RunLocally = true)]
		public void SendAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x623360", Offset = "0x621D60", VA = "0x180623360")]
		[ObserversRpc(BufferLast = true, RunLocally = true)]
		public void SetAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x628B30", Offset = "0x627530", VA = "0x180628B30")]
		[ObserversRpc]
		private void SetVisible_Networked(bool vis)
		{
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x6174F0", Offset = "0x615EF0", VA = "0x1806174F0")]
		public void EnterVehicle(LandVehicle vehicle, VehicleSeat seat)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x617B70", Offset = "0x616570", VA = "0x180617B70")]
		public void ExitVehicle(Transform exitPoint)
		{
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x61F3A0", Offset = "0x61DDA0", VA = "0x18061F3A0")]
		private void PreDestroyClientObjects(NetworkConnection conn)
		{
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x616B00", Offset = "0x615500", VA = "0x180616B00")]
		private void CurrentVehicleChanged(NetworkObject oldVeh, NetworkObject newVeh, bool asServer)
		{
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x6001C39")]
		[Address(RVA = "0x615770", Offset = "0x614170", VA = "0x180615770")]
		public static bool AreAllPlayersReadyToSleep()
		{
			return default(bool);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x62E7E0", Offset = "0x62D1E0", VA = "0x18062E7E0")]
		private void SleepStart()
		{
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x62E210", Offset = "0x62CC10", VA = "0x18062E210")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetReadyToSleep(bool ready)
		{
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x62E7D0", Offset = "0x62D1D0", VA = "0x18062E7D0")]
		private void SleepEnd()
		{
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x614C00", Offset = "0x613600", VA = "0x180614C00")]
		public static void Activate()
		{
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x616FB0", Offset = "0x6159B0", VA = "0x180616FB0")]
		public static void Deactivate(bool freeMouse)
		{
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3F")]
		[Address(RVA = "0x617880", Offset = "0x616280", VA = "0x180617880")]
		public void ExitAll()
		{
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x62E5D0", Offset = "0x62CFD0", VA = "0x18062E5D0")]
		public void SetVisibleToLocalPlayer(bool vis)
		{
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x62DF40", Offset = "0x62C940", VA = "0x18062DF40")]
		[ObserversRpc(RunLocally = true)]
		public void SetPlayerCode(string code)
		{
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x62ADE0", Offset = "0x6297E0", VA = "0x18062ADE0")]
		[ServerRpc]
		public void SendPunch()
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x61F5C0", Offset = "0x61DFC0", VA = "0x18061F5C0")]
		[ObserversRpc]
		private void Punch()
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x61B0B0", Offset = "0x619AB0", VA = "0x18061B0B0")]
		[ServerRpc(RunLocally = true)]
		private void MarkIntroCompleted(BasicAvatarSettings appearance)
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x6196B0", Offset = "0x6180B0", VA = "0x1806196B0")]
		public bool IsPointVisibleToPlayer(Vector3 point, float maxDistance_Visible = 30f, float minDistance_Invisible = 5f)
		{
			return default(bool);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x618340", Offset = "0x616D40", VA = "0x180618340")]
		public static Player GetClosestPlayer(Vector3 point, out float distance, [Optional] List<Player> exclude)
		{
			return null;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x62DBA0", Offset = "0x62C5A0", VA = "0x18062DBA0")]
		public void SetCapsuleColliderHeight(float normalizedHeight)
		{
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x62E340", Offset = "0x62CD40", VA = "0x18062E340")]
		public void SetScale(float scale)
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x62E360", Offset = "0x62CD60", VA = "0x18062E360")]
		public void SetScale(float scale, float lerpTime)
		{
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x615650", Offset = "0x614050", VA = "0x180615650", Slot = "69")]
		protected virtual void ApplyScale()
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x619000", Offset = "0x617A00", VA = "0x180619000", Slot = "70")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x618A00", Offset = "0x617400", VA = "0x180618A00")]
		public PlayerData GetPlayerData()
		{
			return null;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x62F240", Offset = "0x62DC40", VA = "0x18062F240", Slot = "71")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x618680", Offset = "0x617080", VA = "0x180618680")]
		public string GetInventoryString()
		{
			return null;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x618290", Offset = "0x616C90", VA = "0x180618290")]
		public string GetAppearanceString()
		{
			return null;
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x6185E0", Offset = "0x616FE0", VA = "0x1806185E0")]
		public string GetClothingString()
		{
			return null;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x619250", Offset = "0x617C50", VA = "0x180619250")]
		public string GetVariablesString()
		{
			return null;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x61A980", Offset = "0x619380", VA = "0x18061A980", Slot = "72")]
		public virtual void Load(PlayerData data, string containerPath)
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x61AF80", Offset = "0x619980", VA = "0x18061AF80", Slot = "73")]
		public virtual void Load(PlayerData data)
		{
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x61A500", Offset = "0x618F00", VA = "0x18061A500", Slot = "74")]
		public virtual void LoadInventory(string contentsString)
		{
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x61A330", Offset = "0x618D30", VA = "0x18061A330", Slot = "75")]
		public virtual void LoadAppearance(string appearanceString)
		{
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x61A400", Offset = "0x618E00", VA = "0x18061A400", Slot = "76")]
		public virtual void LoadClothing(string contentsString)
		{
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C57")]
		[Address(RVA = "0x62E080", Offset = "0x62CA80", VA = "0x18062E080")]
		public void SetRagdolled(bool ragdolled)
		{
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x62D010", Offset = "0x62BA10", VA = "0x18062D010", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void SendImpact(Impact impact)
		{
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x620780", Offset = "0x61F180", VA = "0x180620780", Slot = "78")]
		[ObserversRpc(RunLocally = true)]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0x61F570", Offset = "0x61DF70", VA = "0x18061F570", Slot = "79")]
		public virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5B")]
		[Address(RVA = "0x61D620", Offset = "0x61C020", VA = "0x18061D620", Slot = "80")]
		public virtual void OnDied()
		{
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5C")]
		[Address(RVA = "0x61DBB0", Offset = "0x61C5B0", VA = "0x18061DBB0", Slot = "81")]
		public virtual void OnRevived()
		{
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5D")]
		[Address(RVA = "0x615A40", Offset = "0x614440", VA = "0x180615A40")]
		[ServerRpc(RunLocally = true)]
		public void Arrest_Server()
		{
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5E")]
		[Address(RVA = "0x615920", Offset = "0x614320", VA = "0x180615920")]
		[ObserversRpc(RunLocally = true)]
		private void Arrest_Client()
		{
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0x618110", Offset = "0x616B10", VA = "0x180618110")]
		[ServerRpc(RunLocally = true)]
		public void Free_Server()
		{
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C60")]
		[Address(RVA = "0x617FF0", Offset = "0x6169F0", VA = "0x180617FF0")]
		[ObserversRpc(RunLocally = true)]
		private void Free_Client()
		{
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C61")]
		[Address(RVA = "0x62D460", Offset = "0x62BE60", VA = "0x18062D460")]
		[ServerRpc(RunLocally = true)]
		public void SendPassOut()
		{
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C62")]
		[Address(RVA = "0x61EB50", Offset = "0x61D550", VA = "0x18061EB50")]
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOut()
		{
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x62D2E0", Offset = "0x62BCE0", VA = "0x18062D2E0")]
		[ServerRpc(RunLocally = true)]
		public void SendPassOutRecovery()
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x61EA30", Offset = "0x61D430", VA = "0x18061EA30")]
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOutRecovery()
		{
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x62CDB0", Offset = "0x62B7B0", VA = "0x18062CDB0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEquippable_Networked(string assetPath)
		{
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x6234E0", Offset = "0x621EE0", VA = "0x1806234E0")]
		[ObserversRpc(RunLocally = true)]
		private void SetEquippable_Networked(string assetPath)
		{
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x62CD70", Offset = "0x62B770", VA = "0x18062CD70")]
		[ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked(string message, int receipt)
		{
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x620610", Offset = "0x61F010", VA = "0x180620610")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked(string message, int receipt)
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x62CCE0", Offset = "0x62B6E0", VA = "0x18062CCE0")]
		[ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x620410", Offset = "0x61EE10", VA = "0x180620410")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x62C6E0", Offset = "0x62B0E0", VA = "0x18062C6E0")]
		[ServerRpc(RunLocally = true)]
		public void SendAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x62D7A0", Offset = "0x62C1A0", VA = "0x18062D7A0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0x62DA10", Offset = "0x62C410", VA = "0x18062DA10")]
		public void SetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x621390", Offset = "0x61FD90", VA = "0x180621390")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0x621600", Offset = "0x620000", VA = "0x180621600")]
		public void ResetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x62C690", Offset = "0x62B090", VA = "0x18062C690")]
		[ServerRpc(RunLocally = true)]
		public void SendAnimationBool(string name, bool val)
		{
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x6231D0", Offset = "0x621BD0", VA = "0x1806231D0")]
		[ObserversRpc(RunLocally = true)]
		public void SetAnimationBool(string name, bool val)
		{
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x628DE0", Offset = "0x6277E0", VA = "0x180628DE0")]
		[ObserversRpc]
		public void Taze()
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x62DEC0", Offset = "0x62C8C0", VA = "0x18062DEC0")]
		[ServerRpc(RunLocally = true)]
		public void SetInventoryItem(int index, ItemInstance item)
		{
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x618940", Offset = "0x617340", VA = "0x180618940")]
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x62C880", Offset = "0x62B280", VA = "0x18062C880")]
		[ServerRpc(RunLocally = true)]
		public void SendAppearance(BasicAvatarSettings settings)
		{
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x62DA40", Offset = "0x62C440", VA = "0x18062DA40")]
		[ObserversRpc(RunLocally = true)]
		public void SetAppearance(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x61B3C0", Offset = "0x619DC0", VA = "0x18061B3C0")]
		public void MountSkateboard(Skateboard board)
		{
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x62D150", Offset = "0x62BB50", VA = "0x18062D150")]
		[ServerRpc(RunLocally = true)]
		private void SendMountedSkateboard(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x6237C0", Offset = "0x6221C0", VA = "0x1806237C0")]
		[ObserversRpc(RunLocally = true)]
		private void SetMountedSkateboard(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x6171A0", Offset = "0x615BA0", VA = "0x1806171A0")]
		public void DismountSkateboard()
		{
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x616610", Offset = "0x615010", VA = "0x180616610")]
		public void ConsumeProduct(ProductItemInstance product)
		{
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x629D30", Offset = "0x628730", VA = "0x180629D30")]
		[ServerRpc(RequireOwnership = false)]
		private void SendConsumeProduct(ProductItemInstance product)
		{
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x620050", Offset = "0x61EA50", VA = "0x180620050")]
		[ObserversRpc]
		private void ReceiveConsumeProduct(ProductItemInstance product)
		{
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x616570", Offset = "0x614F70", VA = "0x180616570")]
		private void ConsumeProductInternal(ProductItemInstance product)
		{
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x616340", Offset = "0x614D40", VA = "0x180616340")]
		public void ClearProduct()
		{
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C80")]
		[Address(RVA = "0x6167B0", Offset = "0x6151B0", VA = "0x1806167B0")]
		private void CreatePlayerVariables()
		{
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x619150", Offset = "0x617B50", VA = "0x180619150")]
		public BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C82")]
		public T GetValue<T>(string variableName)
		{
			return null;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x62E4A0", Offset = "0x62CEA0", VA = "0x18062E4A0")]
		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x614DF0", Offset = "0x6137F0", VA = "0x180614DF0")]
		public void AddVariable(BaseVariable variable)
		{
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x62D620", Offset = "0x62C020", VA = "0x18062D620")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(string variableName, string value, bool sendToOwner)
		{
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x620E90", Offset = "0x61F890", VA = "0x180620E90")]
		[TargetRpc]
		private void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x620FF0", Offset = "0x61F9F0", VA = "0x180620FF0")]
		private void ReceiveValue(string variableName, string value)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x61A7E0", Offset = "0x6191E0", VA = "0x18061A7E0")]
		public void LoadVariable(VariableData data)
		{
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x62B0C0", Offset = "0x629AC0", VA = "0x18062B0C0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x623C60", Offset = "0x622660", VA = "0x180623C60")]
		[ObserversRpc(RunLocally = true)]
		private void ShowWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x62F590", Offset = "0x62DF90", VA = "0x18062F590")]
		public Player()
		{
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "42")]
		private NetworkObject ScheduleOne.Combat.ICombatTargetable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x62C680", Offset = "0x62B080", VA = "0x18062C680", Slot = "53")]
		private GameObject ScheduleOne.Combat.IDamageable.get_gameObject()
		{
			return null;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0", Slot = "56")]
		private NetworkObject ScheduleOne.Vision.ISightable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x62EDB0", Offset = "0x62D7B0", VA = "0x18062EDB0")]
		[CompilerGenerated]
		private IEnumerator <Taze>g__Tase|357_0()
		{
			return null;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x61BBD0", Offset = "0x61A5D0", VA = "0x18061BBD0", Slot = "82")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x61BAB0", Offset = "0x61A4B0", VA = "0x18061BAB0", Slot = "83")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x61BA70", Offset = "0x61A470", VA = "0x18061BA70", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x62BAA0", Offset = "0x62A4A0", VA = "0x18062BAA0")]
		private void RpcWriter___Server_set_CurrentVehicle_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x624800", Offset = "0x623200", VA = "0x180624800")]
		public void RpcLogic___set_CurrentVehicle_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x626B00", Offset = "0x625500", VA = "0x180626B00")]
		private void RpcReader___Server_set_CurrentVehicle_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x62B8F0", Offset = "0x62A2F0", VA = "0x18062B8F0")]
		private void RpcWriter___Server_set_CurrentBed_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x624760", Offset = "0x623160", VA = "0x180624760")]
		public void RpcLogic___set_CurrentBed_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x626A00", Offset = "0x625400", VA = "0x180626A00")]
		private void RpcReader___Server_set_CurrentBed_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x62BC50", Offset = "0x62A650", VA = "0x18062BC50")]
		private void RpcWriter___Server_set_IsSkating_1140765316(bool value)
		{
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x6248A0", Offset = "0x6232A0", VA = "0x1806248A0")]
		public void RpcLogic___set_IsSkating_1140765316(bool value)
		{
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x626BA0", Offset = "0x6255A0", VA = "0x180626BA0")]
		private void RpcReader___Server_set_IsSkating_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x62B540", Offset = "0x629F40", VA = "0x18062B540")]
		private void RpcWriter___Server_set_CameraPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x624610", Offset = "0x623010", VA = "0x180624610")]
		public void RpcLogic___set_CameraPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x6267B0", Offset = "0x6251B0", VA = "0x1806267B0")]
		private void RpcReader___Server_set_CameraPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x62B730", Offset = "0x62A130", VA = "0x18062B730")]
		private void RpcWriter___Server_set_CameraRotation_3429297120(Quaternion value)
		{
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x6246C0", Offset = "0x6230C0", VA = "0x1806246C0")]
		public void RpcLogic___set_CameraRotation_3429297120(Quaternion value)
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x626910", Offset = "0x625310", VA = "0x180626910")]
		private void RpcReader___Server_set_CameraRotation_3429297120(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x629530", Offset = "0x627F30", VA = "0x180629530")]
		private void RpcWriter___Server_RequestSavePlayer_2166136261()
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x622FE0", Offset = "0x6219E0", VA = "0x180622FE0")]
		public void RpcLogic___RequestSavePlayer_2166136261()
		{
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x625860", Offset = "0x624260", VA = "0x180625860")]
		private void RpcReader___Server_RequestSavePlayer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x627F90", Offset = "0x626990", VA = "0x180627F90")]
		private void RpcWriter___Observers_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x623120", Offset = "0x621B20", VA = "0x180623120")]
		private void RpcLogic___ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x625000", Offset = "0x623A00", VA = "0x180625000")]
		private void RpcReader___Observers_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x62C3C0", Offset = "0x62ADC0", VA = "0x18062C3C0")]
		private void RpcWriter___Target_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x626EF0", Offset = "0x6258F0", VA = "0x180626EF0")]
		private void RpcReader___Target_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x627220", Offset = "0x625C20", VA = "0x180627220")]
		private void RpcWriter___Observers_HostExitedGame_2166136261()
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x621E00", Offset = "0x620800", VA = "0x180621E00")]
		public void RpcLogic___HostExitedGame_2166136261()
		{
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x624930", Offset = "0x623330", VA = "0x180624930")]
		private void RpcReader___Observers_HostExitedGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x62ABE0", Offset = "0x6295E0", VA = "0x18062ABE0")]
		private void RpcWriter___Server_SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x623900", Offset = "0x622300", VA = "0x180623900")]
		public void RpcLogic___SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x6261D0", Offset = "0x624BD0", VA = "0x1806261D0")]
		private void RpcReader___Server_SendPlayerNameData_586648380(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x621150", Offset = "0x61FB50", VA = "0x180621150")]
		private void RpcWriter___Server_RequestPlayerData_3615296227(string playerCode)
		{
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x622D70", Offset = "0x621770", VA = "0x180622D70")]
		public void RpcLogic___RequestPlayerData_3615296227(string playerCode)
		{
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x625810", Offset = "0x624210", VA = "0x180625810")]
		private void RpcReader___Server_RequestPlayerData_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x6293B0", Offset = "0x627DB0", VA = "0x1806293B0")]
		private void RpcWriter___Server_MarkPlayerInitialized_2166136261()
		{
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x622010", Offset = "0x620A10", VA = "0x180622010")]
		public void RpcLogic___MarkPlayerInitialized_2166136261()
		{
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x6257B0", Offset = "0x6241B0", VA = "0x1806257B0")]
		private void RpcReader___Server_MarkPlayerInitialized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x627B40", Offset = "0x626540", VA = "0x180627B40")]
		private void RpcWriter___Observers_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x622AD0", Offset = "0x6214D0", VA = "0x180622AD0")]
		public void RpcLogic___ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x624E40", Offset = "0x623840", VA = "0x180624E40")]
		private void RpcReader___Observers_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x62BF60", Offset = "0x62A960", VA = "0x18062BF60")]
		private void RpcWriter___Target_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBD")]
		[Address(RVA = "0x626CB0", Offset = "0x6256B0", VA = "0x180626CB0")]
		private void RpcReader___Target_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBE")]
		[Address(RVA = "0x627CE0", Offset = "0x6266E0", VA = "0x180627CE0")]
		private void RpcWriter___Observers_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0x622C60", Offset = "0x621660", VA = "0x180622C60")]
		private void RpcLogic___ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0x624F10", Offset = "0x623910", VA = "0x180624F10")]
		private void RpcReader___Observers_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x62C100", Offset = "0x62AB00", VA = "0x18062C100")]
		private void RpcWriter___Target_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC2")]
		[Address(RVA = "0x626D80", Offset = "0x625780", VA = "0x180626D80")]
		private void RpcReader___Target_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x62A4D0", Offset = "0x628ED0", VA = "0x18062A4D0")]
		private void RpcWriter___Server_SendFlashlightOnNetworked_1140765316(bool on)
		{
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x623630", Offset = "0x622030", VA = "0x180623630")]
		private void RpcLogic___SendFlashlightOnNetworked_1140765316(bool on)
		{
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x625F60", Offset = "0x624960", VA = "0x180625F60")]
		private void RpcReader___Server_SendFlashlightOnNetworked_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x628770", Offset = "0x627170", VA = "0x180628770")]
		private void RpcWriter___Observers_SetFlashlightOn_1140765316(bool on)
		{
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x623FB0", Offset = "0x6229B0", VA = "0x180623FB0")]
		private void RpcLogic___SetFlashlightOn_1140765316(bool on)
		{
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x625310", Offset = "0x623D10", VA = "0x180625310")]
		private void RpcReader___Observers_SetFlashlightOn_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x61EC70", Offset = "0x61D670", VA = "0x18061EC70")]
		private void RpcWriter___Observers_PlayJumpAnimation_2166136261()
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x6224E0", Offset = "0x620EE0", VA = "0x1806224E0")]
		public void RpcLogic___PlayJumpAnimation_2166136261()
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x6249F0", Offset = "0x6233F0", VA = "0x1806249F0")]
		private void RpcReader___Observers_PlayJumpAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x629E60", Offset = "0x628860", VA = "0x180629E60")]
		private void RpcWriter___Server_SendCrouched_1140765316(bool crouched)
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x6234A0", Offset = "0x621EA0", VA = "0x1806234A0")]
		public void RpcLogic___SendCrouched_1140765316(bool crouched)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x625C70", Offset = "0x624670", VA = "0x180625C70")]
		private void RpcReader___Server_SendCrouched_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x62BE00", Offset = "0x62A800", VA = "0x18062BE00")]
		private void RpcWriter___Target_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x622650", Offset = "0x621050", VA = "0x180622650")]
		private void RpcLogic___ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x626C20", Offset = "0x625620", VA = "0x180626C20")]
		private void RpcReader___Target_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x627580", Offset = "0x625F80", VA = "0x180627580")]
		private void RpcWriter___Observers_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x624BA0", Offset = "0x6235A0", VA = "0x180624BA0")]
		private void RpcReader___Observers_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x629B80", Offset = "0x628580", VA = "0x180629B80")]
		private void RpcWriter___Server_SendAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x623360", Offset = "0x621D60", VA = "0x180623360")]
		public void RpcLogic___SendAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x625A90", Offset = "0x624490", VA = "0x180625A90")]
		private void RpcReader___Server_SendAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x6284F0", Offset = "0x626EF0", VA = "0x1806284F0")]
		private void RpcWriter___Observers_SetAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x623EE0", Offset = "0x6228E0", VA = "0x180623EE0")]
		public void RpcLogic___SetAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x625230", Offset = "0x623C30", VA = "0x180625230")]
		private void RpcReader___Observers_SetAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x628B30", Offset = "0x627530", VA = "0x180628B30")]
		private void RpcWriter___Observers_SetVisible_Networked_1140765316(bool vis)
		{
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x6244B0", Offset = "0x622EB0", VA = "0x1806244B0")]
		private void RpcLogic___SetVisible_Networked_1140765316(bool vis)
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x625460", Offset = "0x623E60", VA = "0x180625460")]
		private void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x62B410", Offset = "0x629E10", VA = "0x18062B410")]
		private void RpcWriter___Server_SetReadyToSleep_1140765316(bool ready)
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x624420", Offset = "0x622E20", VA = "0x180624420")]
		public void RpcLogic___SetReadyToSleep_1140765316(bool ready)
		{
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x626720", Offset = "0x625120", VA = "0x180626720")]
		private void RpcReader___Server_SetReadyToSleep_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x6289F0", Offset = "0x6273F0", VA = "0x1806289F0")]
		private void RpcWriter___Observers_SetPlayerCode_3615296227(string code)
		{
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x624410", Offset = "0x622E10", VA = "0x180624410")]
		public void RpcLogic___SetPlayerCode_3615296227(string code)
		{
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x625400", Offset = "0x623E00", VA = "0x180625400")]
		private void RpcReader___Observers_SetPlayerCode_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x62ADE0", Offset = "0x6297E0", VA = "0x18062ADE0")]
		private void RpcWriter___Server_SendPunch_2166136261()
		{
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x61F5C0", Offset = "0x61DFC0", VA = "0x18061F5C0")]
		public void RpcLogic___SendPunch_2166136261()
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x626270", Offset = "0x624C70", VA = "0x180626270")]
		private void RpcReader___Server_SendPunch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x61F5C0", Offset = "0x61DFC0", VA = "0x18061F5C0")]
		private void RpcWriter___Observers_Punch_2166136261()
		{
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x622510", Offset = "0x620F10", VA = "0x180622510")]
		private void RpcLogic___Punch_2166136261()
		{
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x624A30", Offset = "0x623430", VA = "0x180624A30")]
		private void RpcReader___Observers_Punch_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x629200", Offset = "0x627C00", VA = "0x180629200")]
		private void RpcWriter___Server_MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x621F70", Offset = "0x620970", VA = "0x180621F70")]
		private void RpcLogic___MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x625730", Offset = "0x624130", VA = "0x180625730")]
		private void RpcReader___Server_MarkIntroCompleted_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x62A600", Offset = "0x629000", VA = "0x18062A600")]
		private void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x6237A0", Offset = "0x6221A0", VA = "0x1806237A0", Slot = "84")]
		public virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x625FF0", Offset = "0x6249F0", VA = "0x180625FF0")]
		private void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x627A00", Offset = "0x626400", VA = "0x180627A00")]
		private void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x6228F0", Offset = "0x6212F0", VA = "0x1806228F0", Slot = "85")]
		public virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x624DE0", Offset = "0x6237E0", VA = "0x180624DE0")]
		private void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x628F00", Offset = "0x627900", VA = "0x180628F00")]
		private void RpcWriter___Server_Arrest_Server_2166136261()
		{
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x615920", Offset = "0x614320", VA = "0x180615920")]
		public void RpcLogic___Arrest_Server_2166136261()
		{
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x625670", Offset = "0x624070", VA = "0x180625670")]
		private void RpcReader___Server_Arrest_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x626FE0", Offset = "0x6259E0", VA = "0x180626FE0")]
		private void RpcWriter___Observers_Arrest_Client_2166136261()
		{
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x621830", Offset = "0x620230", VA = "0x180621830")]
		private void RpcLogic___Arrest_Client_2166136261()
		{
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x6248B0", Offset = "0x6232B0", VA = "0x1806248B0")]
		private void RpcReader___Observers_Arrest_Client_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x629080", Offset = "0x627A80", VA = "0x180629080")]
		private void RpcWriter___Server_Free_Server_2166136261()
		{
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x617FF0", Offset = "0x6169F0", VA = "0x180617FF0")]
		public void RpcLogic___Free_Server_2166136261()
		{
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x6256D0", Offset = "0x6240D0", VA = "0x1806256D0")]
		private void RpcReader___Server_Free_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x627100", Offset = "0x625B00", VA = "0x180627100")]
		private void RpcWriter___Observers_Free_Client_2166136261()
		{
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x6219E0", Offset = "0x6203E0", VA = "0x1806219E0")]
		private void RpcLogic___Free_Client_2166136261()
		{
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x6248F0", Offset = "0x6232F0", VA = "0x1806248F0")]
		private void RpcReader___Observers_Free_Client_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x62AA60", Offset = "0x629460", VA = "0x18062AA60")]
		private void RpcWriter___Server_SendPassOut_2166136261()
		{
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x61EB50", Offset = "0x61D550", VA = "0x18061EB50")]
		public void RpcLogic___SendPassOut_2166136261()
		{
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x626170", Offset = "0x624B70", VA = "0x180626170")]
		private void RpcReader___Server_SendPassOut_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x627460", Offset = "0x625E60", VA = "0x180627460")]
		private void RpcWriter___Observers_PassOut_2166136261()
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x622250", Offset = "0x620C50", VA = "0x180622250")]
		public void RpcLogic___PassOut_2166136261()
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x6249B0", Offset = "0x6233B0", VA = "0x1806249B0")]
		private void RpcReader___Observers_PassOut_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x62A8E0", Offset = "0x6292E0", VA = "0x18062A8E0")]
		private void RpcWriter___Server_SendPassOutRecovery_2166136261()
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x61EA30", Offset = "0x61D430", VA = "0x18061EA30")]
		public void RpcLogic___SendPassOutRecovery_2166136261()
		{
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x626110", Offset = "0x624B10", VA = "0x180626110")]
		private void RpcReader___Server_SendPassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x627340", Offset = "0x625D40", VA = "0x180627340")]
		private void RpcWriter___Observers_PassOutRecovery_2166136261()
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x6220A0", Offset = "0x620AA0", VA = "0x1806220A0")]
		public void RpcLogic___PassOutRecovery_2166136261()
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x624970", Offset = "0x623370", VA = "0x180624970")]
		private void RpcReader___Observers_PassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x62A3A0", Offset = "0x628DA0", VA = "0x18062A3A0")]
		private void RpcWriter___Server_SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x6234E0", Offset = "0x621EE0", VA = "0x1806234E0")]
		public void RpcLogic___SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x625EF0", Offset = "0x6248F0", VA = "0x180625EF0")]
		private void RpcReader___Server_SendEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x628630", Offset = "0x627030", VA = "0x180628630")]
		private void RpcWriter___Observers_SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x623F80", Offset = "0x622980", VA = "0x180623F80")]
		private void RpcLogic___SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x625290", Offset = "0x623C90", VA = "0x180625290")]
		private void RpcReader___Observers_SetEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x629F90", Offset = "0x628990", VA = "0x180629F90")]
		private void RpcWriter___Server_SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x620610", Offset = "0x61F010", VA = "0x180620610")]
		public void RpcLogic___SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x625D00", Offset = "0x624700", VA = "0x180625D00")]
		private void RpcReader___Server_SendEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x6276C0", Offset = "0x6260C0", VA = "0x1806276C0")]
		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x6226A0", Offset = "0x6210A0", VA = "0x1806226A0")]
		private void RpcLogic___ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x624C30", Offset = "0x623630", VA = "0x180624C30")]
		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x62A180", Offset = "0x628B80", VA = "0x18062A180")]
		private void RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x6234B0", Offset = "0x621EB0", VA = "0x1806234B0")]
		public void RpcLogic___SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x625DB0", Offset = "0x6247B0", VA = "0x180625DB0")]
		private void RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x627840", Offset = "0x626240", VA = "0x180627840")]
		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x6227A0", Offset = "0x6211A0", VA = "0x1806227A0")]
		private void RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x624CC0", Offset = "0x6236C0", VA = "0x180624CC0")]
		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x629820", Offset = "0x628220", VA = "0x180629820")]
		private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x623340", Offset = "0x621D40", VA = "0x180623340")]
		public void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x625980", Offset = "0x624380", VA = "0x180625980")]
		private void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x628240", Offset = "0x626C40", VA = "0x180628240")]
		private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x623E00", Offset = "0x622800", VA = "0x180623E00")]
		public void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x625120", Offset = "0x623B20", VA = "0x180625120")]
		private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x62C520", Offset = "0x62AF20", VA = "0x18062C520")]
		private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x626F70", Offset = "0x625970", VA = "0x180626F70")]
		private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x627E50", Offset = "0x626850", VA = "0x180627E50")]
		private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x6230E0", Offset = "0x621AE0", VA = "0x1806230E0")]
		public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x624F90", Offset = "0x623990", VA = "0x180624F90")]
		private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x62C260", Offset = "0x62AC60", VA = "0x18062C260")]
		private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x626E80", Offset = "0x625880", VA = "0x180626E80")]
		private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x629640", Offset = "0x628040", VA = "0x180629640")]
		private void RpcWriter___Server_SendAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0x6231D0", Offset = "0x621BD0", VA = "0x1806231D0")]
		public void RpcLogic___SendAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x6258B0", Offset = "0x6242B0", VA = "0x1806258B0")]
		private void RpcReader___Server_SendAnimationBool_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x6280D0", Offset = "0x626AD0", VA = "0x1806280D0")]
		private void RpcWriter___Observers_SetAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x623DD0", Offset = "0x6227D0", VA = "0x180623DD0")]
		public void RpcLogic___SetAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x625070", Offset = "0x623A70", VA = "0x180625070")]
		private void RpcReader___Observers_SetAnimationBool_310431262(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x628DE0", Offset = "0x6277E0", VA = "0x180628DE0")]
		private void RpcWriter___Observers_Taze_2166136261()
		{
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x624510", Offset = "0x622F10", VA = "0x180624510")]
		public void RpcLogic___Taze_2166136261()
		{
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x625560", Offset = "0x623F60", VA = "0x180625560")]
		private void RpcReader___Observers_Taze_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x62B220", Offset = "0x629C20", VA = "0x18062B220")]
		private void RpcWriter___Server_SetInventoryItem_2317364410(int index, ItemInstance item)
		{
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x624020", Offset = "0x622A20", VA = "0x180624020")]
		public void RpcLogic___SetInventoryItem_2317364410(int index, ItemInstance item)
		{
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x626640", Offset = "0x625040", VA = "0x180626640")]
		private void RpcReader___Server_SetInventoryItem_2317364410(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D35")]
		[Address(RVA = "0x6299D0", Offset = "0x6283D0", VA = "0x1806299D0")]
		private void RpcWriter___Server_SendAppearance_3281254764(BasicAvatarSettings settings)
		{
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D36")]
		[Address(RVA = "0x623350", Offset = "0x621D50", VA = "0x180623350")]
		public void RpcLogic___SendAppearance_3281254764(BasicAvatarSettings settings)
		{
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D37")]
		[Address(RVA = "0x625A10", Offset = "0x624410", VA = "0x180625A10")]
		private void RpcReader___Server_SendAppearance_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D38")]
		[Address(RVA = "0x628380", Offset = "0x626D80", VA = "0x180628380")]
		private void RpcWriter___Observers_SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x623E40", Offset = "0x622840", VA = "0x180623E40")]
		public void RpcLogic___SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3A")]
		[Address(RVA = "0x625190", Offset = "0x623B90", VA = "0x180625190")]
		private void RpcReader___Observers_SetAppearance_2139595489(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x62A730", Offset = "0x629130", VA = "0x18062A730")]
		private void RpcWriter___Server_SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x6237C0", Offset = "0x6221C0", VA = "0x1806237C0")]
		private void RpcLogic___SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x626070", Offset = "0x624A70", VA = "0x180626070")]
		private void RpcReader___Server_SendMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x6288B0", Offset = "0x6272B0", VA = "0x1806288B0")]
		private void RpcWriter___Observers_SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x624070", Offset = "0x622A70", VA = "0x180624070")]
		private void RpcLogic___SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x625390", Offset = "0x623D90", VA = "0x180625390")]
		private void RpcReader___Observers_SetMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x629D30", Offset = "0x628730", VA = "0x180629D30")]
		private void RpcWriter___Server_SendConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x620050", Offset = "0x61EA50", VA = "0x180620050")]
		private void RpcLogic___SendConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x625B10", Offset = "0x624510", VA = "0x180625B10")]
		private void RpcReader___Server_SendConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x620050", Offset = "0x61EA50", VA = "0x180620050")]
		private void RpcWriter___Observers_ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x6225A0", Offset = "0x620FA0", VA = "0x1806225A0")]
		private void RpcLogic___ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x624AD0", Offset = "0x6234D0", VA = "0x180624AD0")]
		private void RpcReader___Observers_ReceiveConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x62AF60", Offset = "0x629960", VA = "0x18062AF60")]
		private void RpcWriter___Server_SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x623AD0", Offset = "0x6224D0", VA = "0x180623AD0")]
		public void RpcLogic___SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x6263C0", Offset = "0x624DC0", VA = "0x1806263C0")]
		private void RpcReader___Server_SendValue_3589193952(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4A")]
		[Address(RVA = "0x620E90", Offset = "0x61F890", VA = "0x180620E90")]
		private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4B")]
		[Address(RVA = "0x622D50", Offset = "0x621750", VA = "0x180622D50")]
		private void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4C")]
		[Address(RVA = "0x626E00", Offset = "0x625800", VA = "0x180626E00")]
		private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x62B0C0", Offset = "0x629AC0", VA = "0x18062B0C0")]
		private void RpcWriter___Server_SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x623C60", Offset = "0x622660", VA = "0x180623C60")]
		public void RpcLogic___SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0x626490", Offset = "0x624E90", VA = "0x180626490")]
		private void RpcReader___Server_SendWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x628C70", Offset = "0x627670", VA = "0x180628C70")]
		private void RpcWriter___Observers_ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D51")]
		[Address(RVA = "0x6244E0", Offset = "0x622EE0", VA = "0x1806244E0")]
		private void RpcLogic___ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D52")]
		[Address(RVA = "0x6254D0", Offset = "0x623ED0", VA = "0x1806254D0")]
		private void RpcReader___Observers_ShowWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050F")]
		public string SyncAccessor_<PlayerName>k__BackingField
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0x62FFD0", Offset = "0x62E9D0", VA = "0x18062FFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D54")]
			[Address(RVA = "0x630C20", Offset = "0x62F620", VA = "0x180630C20")]
			set
			{
			}
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x61F6E0", Offset = "0x61E0E0", VA = "0x18061F6E0", Slot = "86")]
		public virtual bool ReadSyncVar___ScheduleOne.PlayerScripts.Player(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000510")]
		public string SyncAccessor_<PlayerCode>k__BackingField
		{
			[Token(Token = "0x6001D56")]
			[Address(RVA = "0x62FFB0", Offset = "0x62E9B0", VA = "0x18062FFB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D57")]
			[Address(RVA = "0x630B60", Offset = "0x62F560", VA = "0x180630B60")]
			set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000511")]
		public NetworkObject SyncAccessor_<CurrentVehicle>k__BackingField
		{
			[Token(Token = "0x6001D58")]
			[Address(RVA = "0x62FCC0", Offset = "0x62E6C0", VA = "0x18062FCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D59")]
			[Address(RVA = "0x6309E0", Offset = "0x62F3E0", VA = "0x1806309E0")]
			set
			{
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000512")]
		public NetworkObject SyncAccessor_<CurrentBed>k__BackingField
		{
			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0x62FC70", Offset = "0x62E670", VA = "0x18062FC70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D5B")]
			[Address(RVA = "0x630920", Offset = "0x62F320", VA = "0x180630920")]
			set
			{
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00009BB8 File Offset: 0x00007DB8
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000513")]
		public bool SyncAccessor_<IsReadyToSleep>k__BackingField
		{
			[Token(Token = "0x6001D5C")]
			[Address(RVA = "0x62FDA0", Offset = "0x62E7A0", VA = "0x18062FDA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D5D")]
			[Address(RVA = "0x630AA0", Offset = "0x62F4A0", VA = "0x180630AA0")]
			set
			{
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00009BD0 File Offset: 0x00007DD0
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000514")]
		public Vector3 SyncAccessor_<CameraPosition>k__BackingField
		{
			[Token(Token = "0x6001D5E")]
			[Address(RVA = "0x62FBE0", Offset = "0x62E5E0", VA = "0x18062FBE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001D5F")]
			[Address(RVA = "0x630780", Offset = "0x62F180", VA = "0x180630780")]
			set
			{
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00009BE8 File Offset: 0x00007DE8
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000515")]
		public Quaternion SyncAccessor_<CameraRotation>k__BackingField
		{
			[Token(Token = "0x6001D60")]
			[Address(RVA = "0x62FC00", Offset = "0x62E600", VA = "0x18062FC00")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6001D61")]
			[Address(RVA = "0x630860", Offset = "0x62F260", VA = "0x180630860")]
			set
			{
			}
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x615BC0", Offset = "0x6145C0", VA = "0x180615BC0", Slot = "87")]
		protected virtual void Awake_UserLogic_ScheduleOne.PlayerScripts.Player_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040017AE RID: 6062
		[Token(Token = "0x40017AE")]
		public const string OWNER_PLAYER_CODE = "Local";

		// Token: 0x040017AF RID: 6063
		[Token(Token = "0x40017AF")]
		public const float CapColDefaultHeight = 2f;

		// Token: 0x040017B0 RID: 6064
		[Token(Token = "0x40017B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<NetworkObject> objectsTemporarilyOwnedByPlayer;

		// Token: 0x040017B1 RID: 6065
		[Token(Token = "0x40017B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action onLocalPlayerSpawned;

		// Token: 0x040017B2 RID: 6066
		[Token(Token = "0x40017B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Player> onPlayerSpawned;

		// Token: 0x040017B3 RID: 6067
		[Token(Token = "0x40017B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Player> onPlayerDespawned;

		// Token: 0x040017B4 RID: 6068
		[Token(Token = "0x40017B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Player Local;

		// Token: 0x040017B5 RID: 6069
		[Token(Token = "0x40017B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<Player> PlayerList;

		// Token: 0x040017B7 RID: 6071
		[Token(Token = "0x40017B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("References")]
		public GameObject LocalGameObject;

		// Token: 0x040017B8 RID: 6072
		[Token(Token = "0x40017B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x040017B9 RID: 6073
		[Token(Token = "0x40017B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AvatarAnimation Anim;

		// Token: 0x040017BA RID: 6074
		[Token(Token = "0x40017BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x040017BC RID: 6076
		[Token(Token = "0x40017BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public PlayerVisibility VisualState;

		// Token: 0x040017BD RID: 6077
		[Token(Token = "0x40017BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public EntityVisibility Visibility;

		// Token: 0x040017BE RID: 6078
		[Token(Token = "0x40017BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public CapsuleCollider CapCol;

		// Token: 0x040017BF RID: 6079
		[Token(Token = "0x40017BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public POI PoI;

		// Token: 0x040017C0 RID: 6080
		[Token(Token = "0x40017C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public PlayerHealth Health;

		// Token: 0x040017C1 RID: 6081
		[Token(Token = "0x40017C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public PlayerCrimeData CrimeData;

		// Token: 0x040017C2 RID: 6082
		[Token(Token = "0x40017C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public PlayerEnergy Energy;

		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public Transform MimicCamera;

		// Token: 0x040017C4 RID: 6084
		[Token(Token = "0x40017C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AvatarFootstepDetector FootstepDetector;

		// Token: 0x040017C5 RID: 6085
		[Token(Token = "0x40017C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public LocalPlayerFootstepGenerator LocalFootstepDetector;

		// Token: 0x040017C6 RID: 6086
		[Token(Token = "0x40017C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public CharacterController CharacterController;

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public AudioSourceController PunchSound;

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public OptimizedLight ThirdPersonFlashlight;

		// Token: 0x040017C9 RID: 6089
		[Token(Token = "0x40017C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public WorldspaceDialogueRenderer NameLabel;

		// Token: 0x040017CA RID: 6090
		[Token(Token = "0x40017CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public PlayerClothing Clothing;

		// Token: 0x040017CB RID: 6091
		[Token(Token = "0x40017CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public WorldspaceDialogueRenderer WorldspaceDialogue;

		// Token: 0x040017CC RID: 6092
		[Token(Token = "0x40017CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[Header("Settings")]
		public LayerMask GroundDetectionMask;

		// Token: 0x040017CD RID: 6093
		[Token(Token = "0x40017CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public float AvatarOffset_Standing;

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public float AvatarOffset_Crouched;

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[Header("Movement mapping")]
		public AnimationCurve WalkingMapCurve;

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public AnimationCurve CrouchWalkMapCurve;

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public NetworkConnection Connection;

		// Token: 0x040017D6 RID: 6102
		[Token(Token = "0x40017D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public Player.VehicleEvent onEnterVehicle;

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public Player.VehicleTransformEvent onExitVehicle;

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public Action<Skateboard> onSkateboardMounted;

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public Action onSkateboardDismounted;

		// Token: 0x040017EB RID: 6123
		[Token(Token = "0x40017EB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		public bool HasCompletedIntro;

		// Token: 0x040017EE RID: 6126
		[Token(Token = "0x40017EE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public ItemSlot[] Inventory;

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		[Header("Appearance debugging")]
		public BasicAvatarSettings DebugAvatarSettings;

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private PlayerLoader loader;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public UnityEvent onRagdoll;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public UnityEvent onRagdollEnd;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public UnityEvent onArrested;

		// Token: 0x040017FA RID: 6138
		[Token(Token = "0x40017FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public UnityEvent onFreed;

		// Token: 0x040017FB RID: 6139
		[Token(Token = "0x40017FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public UnityEvent onTased;

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public UnityEvent onTasedEnd;

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public UnityEvent onPassedOut;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public UnityEvent onPassOutRecovery;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public List<BaseVariable> PlayerVariables;

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public Dictionary<string, BaseVariable> VariableDict;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private float standingScale;

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x354")]
		private float timeAirborne;

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private Coroutine taseCoroutine;

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private List<ConstantForce> ragdollForceComponents;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private List<int> impactHistory;

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private List<Quaternion> seizureRotations;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private List<int> equippableMessageIDHistory;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private Coroutine lerpScaleRoutine;

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public SyncVar<string> syncVar___<PlayerName>k__BackingField;

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public SyncVar<string> syncVar___<PlayerCode>k__BackingField;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public SyncVar<NetworkObject> syncVar___<CurrentVehicle>k__BackingField;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		public SyncVar<NetworkObject> syncVar___<CurrentBed>k__BackingField;

		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		public SyncVar<bool> syncVar___<IsReadyToSleep>k__BackingField;

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public SyncVar<Vector3> syncVar___<CameraPosition>k__BackingField;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		public SyncVar<Quaternion> syncVar___<CameraRotation>k__BackingField;

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E1")]
		private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted;

		// Token: 0x0200054C RID: 1356
		// (Invoke) Token: 0x06001D64 RID: 7524
		[Token(Token = "0x200054C")]
		public delegate void VehicleEvent(LandVehicle vehicle);

		// Token: 0x0200054D RID: 1357
		// (Invoke) Token: 0x06001D68 RID: 7528
		[Token(Token = "0x200054D")]
		public delegate void VehicleTransformEvent(LandVehicle vehicle, Transform exitPoint);
	}
}
