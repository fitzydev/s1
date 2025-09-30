using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EPOOutline;
using FishNet.Component.Ownership;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using Pathfinding;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles.AI;
using ScheduleOne.Vehicles.Modification;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000862 RID: 2146
	[Token(Token = "0x2000862")]
	[RequireComponent(typeof(VehicleCamera))]
	[RequireComponent(typeof(NetworkTransform))]
	[RequireComponent(typeof(PredictedOwner))]
	[RequireComponent(typeof(PhysicsDamageable))]
	[RequireComponent(typeof(VehicleCollisionDetector))]
	public class LandVehicle : NetworkBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000843")]
		public string VehicleName
		{
			[Token(Token = "0x6003AA0")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000844")]
		public string VehicleCode
		{
			[Token(Token = "0x6003AA1")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x17000845")]
		public float VehiclePrice
		{
			[Token(Token = "0x6003AA2")]
			[Address(RVA = "0x716D70", Offset = "0x715770", VA = "0x180716D70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x0000FC00 File Offset: 0x0000DE00
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000846")]
		public bool IsPlayerOwned
		{
			[Token(Token = "0x6003AA3")]
			[Address(RVA = "0x81BD30", Offset = "0x81A730", VA = "0x18081BD30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003AA4")]
			[Address(RVA = "0x81C470", Offset = "0x81AE70", VA = "0x18081C470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x0000FC18 File Offset: 0x0000DE18
		// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000847")]
		public bool IsVisible
		{
			[Token(Token = "0x6003AA5")]
			[Address(RVA = "0x81BD40", Offset = "0x81A740", VA = "0x18081BD40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003AA6")]
			[Address(RVA = "0x81C480", Offset = "0x81AE80", VA = "0x18081C480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x0000FC30 File Offset: 0x0000DE30
		// (set) Token: 0x06003AA8 RID: 15016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000848")]
		public Guid GUID
		{
			[Token(Token = "0x6003AA7")]
			[Address(RVA = "0x81BD20", Offset = "0x81A720", VA = "0x18081BD20", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6003AA8")]
			[Address(RVA = "0x81C460", Offset = "0x81AE60", VA = "0x18081C460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x0000FC48 File Offset: 0x0000DE48
		// (set) Token: 0x06003AAA RID: 15018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000849")]
		public float DistanceToLocalCamera
		{
			[Token(Token = "0x6003AA9")]
			[Address(RVA = "0x659810", Offset = "0x658210", VA = "0x180659810")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003AAA")]
			[Address(RVA = "0x659880", Offset = "0x658280", VA = "0x180659880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06003AAB RID: 15019 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x1700084A")]
		public Vector3 boundingBoxDimensions
		{
			[Token(Token = "0x6003AAB")]
			[Address(RVA = "0x81C120", Offset = "0x81AB20", VA = "0x18081C120")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084B")]
		public Transform driverEntryPoint
		{
			[Token(Token = "0x6003AAC")]
			[Address(RVA = "0x81C2C0", Offset = "0x81ACC0", VA = "0x18081C2C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084C")]
		public Rigidbody Rb
		{
			[Token(Token = "0x6003AAD")]
			[Address(RVA = "0x81BF90", Offset = "0x81A990", VA = "0x18081BF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x1700084D")]
		public float ActualMaxSteeringAngle
		{
			[Token(Token = "0x6003AAE")]
			[Address(RVA = "0x81BAF0", Offset = "0x81A4F0", VA = "0x18081BAF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x0000FC90 File Offset: 0x0000DE90
		// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084E")]
		public bool MaxSteerAngleOverridden
		{
			[Token(Token = "0x6003AAF")]
			[Address(RVA = "0x81BD50", Offset = "0x81A750", VA = "0x18081BD50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003AB0")]
			[Address(RVA = "0x81C490", Offset = "0x81AE90", VA = "0x18081C490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084F")]
		public float OverriddenMaxSteerAngle
		{
			[Token(Token = "0x6003AB1")]
			[Address(RVA = "0x81BF70", Offset = "0x81A970", VA = "0x18081BF70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003AB2")]
			[Address(RVA = "0x81C4A0", Offset = "0x81AEA0", VA = "0x18081C4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		// (set) Token: 0x06003AB4 RID: 15028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000850")]
		public EVehicleColor OwnedColor
		{
			[Token(Token = "0x6003AB3")]
			[Address(RVA = "0x81BF80", Offset = "0x81A980", VA = "0x18081BF80")]
			[CompilerGenerated]
			get
			{
				return EVehicleColor.Black;
			}
			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x81C4B0", Offset = "0x81AEB0", VA = "0x18081C4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x17000851")]
		public int Capacity
		{
			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x81BB10", Offset = "0x81A510", VA = "0x18081BB10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x17000852")]
		public int CurrentPlayerOccupancy
		{
			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x81BB50", Offset = "0x81A550", VA = "0x18081BB50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x0000FD08 File Offset: 0x0000DF08
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000853")]
		public bool localPlayerIsDriver
		{
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x81C3B0", Offset = "0x81ADB0", VA = "0x18081C3B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x81C620", Offset = "0x81B020", VA = "0x18081C620")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x0000FD20 File Offset: 0x0000DF20
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000854")]
		public bool localPlayerIsInVehicle
		{
			[Token(Token = "0x6003AB9")]
			[Address(RVA = "0x81C3C0", Offset = "0x81ADC0", VA = "0x18081C3C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003ABA")]
			[Address(RVA = "0x81C630", Offset = "0x81B030", VA = "0x18081C630")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x0000FD38 File Offset: 0x0000DF38
		// (set) Token: 0x06003ABC RID: 15036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000855")]
		public bool isOccupied
		{
			[Token(Token = "0x6003ABB")]
			[Address(RVA = "0x81C320", Offset = "0x81AD20", VA = "0x18081C320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003ABC")]
			[Address(RVA = "0x81C570", Offset = "0x81AF70", VA = "0x18081C570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000856")]
		public Player DriverPlayer
		{
			[Token(Token = "0x6003ABD")]
			[Address(RVA = "0x81BC70", Offset = "0x81A670", VA = "0x18081BC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000857")]
		public List<Player> OccupantPlayers
		{
			[Token(Token = "0x6003ABE")]
			[Address(RVA = "0x81BD60", Offset = "0x81A760", VA = "0x18081BD60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000858")]
		public NPC[] OccupantNPCs
		{
			[Token(Token = "0x6003ABF")]
			[Address(RVA = "0x62FE00", Offset = "0x62E800", VA = "0x18062FE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AC0")]
			[Address(RVA = "0x630520", Offset = "0x62EF20", VA = "0x180630520")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x0000FD50 File Offset: 0x0000DF50
		// (set) Token: 0x06003AC2 RID: 15042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000859")]
		public float speed_Kmh
		{
			[Token(Token = "0x6003AC1")]
			[Address(RVA = "0x81C3D0", Offset = "0x81ADD0", VA = "0x18081C3D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003AC2")]
			[Address(RVA = "0x81C640", Offset = "0x81B040", VA = "0x18081C640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[Token(Token = "0x1700085A")]
		public float speed_Ms
		{
			[Token(Token = "0x6003AC3")]
			[Address(RVA = "0x81C400", Offset = "0x81AE00", VA = "0x18081C400")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x1700085B")]
		public float speed_Mph
		{
			[Token(Token = "0x6003AC4")]
			[Address(RVA = "0x81C3E0", Offset = "0x81ADE0", VA = "0x18081C3E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x0000FD98 File Offset: 0x0000DF98
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085C")]
		public float currentThrottle
		{
			[Token(Token = "0x6003AC5")]
			[Address(RVA = "0x81C2B0", Offset = "0x81ACB0", VA = "0x18081C2B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003AC6")]
			[Address(RVA = "0x81C550", Offset = "0x81AF50", VA = "0x18081C550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		// (set) Token: 0x06003AC8 RID: 15048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085D")]
		public bool brakesApplied
		{
			[Token(Token = "0x6003AC7")]
			[Address(RVA = "0x81C2A0", Offset = "0x81ACA0", VA = "0x18081C2A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003AC8")]
			[Address(RVA = "0x81C4C0", Offset = "0x81AEC0", VA = "0x18081C4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		// (set) Token: 0x06003ACA RID: 15050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085E")]
		public bool isReversing
		{
			[Token(Token = "0x6003AC9")]
			[Address(RVA = "0x81C390", Offset = "0x81AD90", VA = "0x18081C390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003ACA")]
			[Address(RVA = "0x81C580", Offset = "0x81AF80", VA = "0x18081C580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		// (set) Token: 0x06003ACC RID: 15052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085F")]
		public bool isStatic
		{
			[Token(Token = "0x6003ACB")]
			[Address(RVA = "0x81C3A0", Offset = "0x81ADA0", VA = "0x18081C3A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003ACC")]
			[Address(RVA = "0x81C610", Offset = "0x81B010", VA = "0x18081C610")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		// (set) Token: 0x06003ACE RID: 15054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000860")]
		public bool handbrakeApplied
		{
			[Token(Token = "0x6003ACD")]
			[Address(RVA = "0x81C310", Offset = "0x81AD10", VA = "0x18081C310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003ACE")]
			[Address(RVA = "0x81C560", Offset = "0x81AF60", VA = "0x18081C560")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x17000861")]
		public float boundingBaseOffset
		{
			[Token(Token = "0x6003ACF")]
			[Address(RVA = "0x81C060", Offset = "0x81AA60", VA = "0x18081C060")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x17000862")]
		public bool isParked
		{
			[Token(Token = "0x6003AD0")]
			[Address(RVA = "0x81C330", Offset = "0x81AD30", VA = "0x18081C330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003AD2 RID: 15058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000863")]
		public ParkingLot CurrentParkingLot
		{
			[Token(Token = "0x6003AD1")]
			[Address(RVA = "0x81BB30", Offset = "0x81A530", VA = "0x18081BB30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AD2")]
			[Address(RVA = "0x81C420", Offset = "0x81AE20", VA = "0x18081C420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000864")]
		public ParkingSpot CurrentParkingSpot
		{
			[Token(Token = "0x6003AD3")]
			[Address(RVA = "0x81BB40", Offset = "0x81A540", VA = "0x18081BB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AD4")]
			[Address(RVA = "0x81C440", Offset = "0x81AE40", VA = "0x18081C440")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000865")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003AD5")]
			[Address(RVA = "0x81BFD0", Offset = "0x81A9D0", VA = "0x18081BFD0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000866")]
		public string SaveFileName
		{
			[Token(Token = "0x6003AD6")]
			[Address(RVA = "0x81BFA0", Offset = "0x81A9A0", VA = "0x18081BFA0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000867")]
		public Loader Loader
		{
			[Token(Token = "0x6003AD7")]
			[Address(RVA = "0x62FE10", Offset = "0x62E810", VA = "0x18062FE10", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x0000FE40 File Offset: 0x0000E040
		[Token(Token = "0x17000868")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003AD8")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003ADA RID: 15066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000869")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003AD9")]
			[Address(RVA = "0x62FE20", Offset = "0x62E820", VA = "0x18062FE20", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003ADA")]
			[Address(RVA = "0x630540", Offset = "0x62EF40", VA = "0x180630540", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003ADC RID: 15068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086A")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003ADB")]
			[Address(RVA = "0x62FE30", Offset = "0x62E830", VA = "0x18062FE30", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003ADC")]
			[Address(RVA = "0x630560", Offset = "0x62EF60", VA = "0x180630560", Slot = "29")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x0000FE58 File Offset: 0x0000E058
		// (set) Token: 0x06003ADE RID: 15070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086B")]
		public bool HasChanged
		{
			[Token(Token = "0x6003ADD")]
			[Address(RVA = "0x62FD00", Offset = "0x62E700", VA = "0x18062FD00", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003ADE")]
			[Address(RVA = "0x630480", Offset = "0x62EE80", VA = "0x180630480", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADF")]
		[Address(RVA = "0x811410", Offset = "0x80FE10", VA = "0x180811410", Slot = "45")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE0")]
		[Address(RVA = "0x813E90", Offset = "0x812890", VA = "0x180813E90", Slot = "46")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE1")]
		[Address(RVA = "0x815500", Offset = "0x813F00", VA = "0x180815500", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE2")]
		[Address(RVA = "0x815270", Offset = "0x813C70", VA = "0x180815270", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE3")]
		[Address(RVA = "0x815480", Offset = "0x813E80", VA = "0x180815480", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE4")]
		[Address(RVA = "0x818F40", Offset = "0x817940", VA = "0x180818F40")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE5")]
		[Address(RVA = "0x815ED0", Offset = "0x8148D0", VA = "0x180815ED0")]
		private void RefreshPoI()
		{
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x818ED0", Offset = "0x8178D0", VA = "0x180818ED0", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE7")]
		[Address(RVA = "0x81A0D0", Offset = "0x818AD0", VA = "0x18081A0D0", Slot = "47")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x8124C0", Offset = "0x810EC0", VA = "0x1808124C0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x814BC0", Offset = "0x8135C0", VA = "0x180814BC0", Slot = "48")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEA")]
		[Address(RVA = "0x813870", Offset = "0x812270", VA = "0x180813870")]
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEB")]
		[Address(RVA = "0x81B0D0", Offset = "0x819AD0", VA = "0x18081B0D0", Slot = "49")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEC")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AED")]
		[Address(RVA = "0x812510", Offset = "0x810F10", VA = "0x180812510", Slot = "50")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x814F20", Offset = "0x813920", VA = "0x180814F20", Slot = "51")]
		protected virtual void OnMinPass()
		{
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEF")]
		[Address(RVA = "0x813F70", Offset = "0x812970", VA = "0x180813F70", Slot = "52")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x814B60", Offset = "0x813560", VA = "0x180814B60")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x818020", Offset = "0x816A20", VA = "0x180818020", Slot = "53")]
		[ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(NetworkConnection conn)
		{
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x815150", Offset = "0x813B50", VA = "0x180815150", Slot = "54")]
		[ObserversRpc]
		protected virtual void OnOwnerChanged()
		{
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF3")]
		[Address(RVA = "0x8199F0", Offset = "0x8183F0", VA = "0x1808199F0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF4")]
		[Address(RVA = "0x819A80", Offset = "0x818480", VA = "0x180819A80")]
		[ObserversRpc(RunLocally = true)]
		public void SetTransform(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x811560", Offset = "0x80FF60", VA = "0x180811560")]
		public void DestroyVehicle()
		{
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x81B000", Offset = "0x819A00", VA = "0x18081B000", Slot = "55")]
		protected virtual void UpdateThrottle()
		{
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x810950", Offset = "0x80F350", VA = "0x180810950", Slot = "56")]
		protected virtual void ApplyThrottle()
		{
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x810800", Offset = "0x80F200", VA = "0x180810800")]
		public void ApplyHandbrake()
		{
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x8182C0", Offset = "0x816CC0", VA = "0x1808182C0")]
		[ServerRpc(RequireOwnership = false)]
		private void SetSteeringAngle(float sa)
		{
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x81AA00", Offset = "0x819400", VA = "0x18081AA00", Slot = "57")]
		protected virtual void UpdateSteerAngle()
		{
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x8108C0", Offset = "0x80F2C0", VA = "0x1808108C0", Slot = "58")]
		protected virtual void ApplySteerAngle()
		{
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFC")]
		[Address(RVA = "0x811480", Offset = "0x80FE80", VA = "0x180811480")]
		private void DelaySetStatic(bool stat)
		{
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFD")]
		[Address(RVA = "0x8191A0", Offset = "0x817BA0", VA = "0x1808191A0", Slot = "59")]
		public virtual void SetIsStatic(bool stat)
		{
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFE")]
		[Address(RVA = "0x810440", Offset = "0x80EE40", VA = "0x180810440")]
		public void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFF")]
		[Address(RVA = "0x812FE0", Offset = "0x8119E0", VA = "0x180812FE0")]
		public Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
		{
			return null;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x0000FE70 File Offset: 0x0000E070
		[Token(Token = "0x6003B00")]
		[Address(RVA = "0x716D70", Offset = "0x715770", VA = "0x180716D70")]
		public float GetVehicleValue()
		{
			return 0f;
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x8155A0", Offset = "0x813FA0", VA = "0x1808155A0")]
		public void OverrideMaxSteerAngle(float maxAngle)
		{
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B02")]
		[Address(RVA = "0x8162F0", Offset = "0x814CF0", VA = "0x1808162F0")]
		public void ResetMaxSteerAngle()
		{
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x8192F0", Offset = "0x817CF0", VA = "0x1808192F0")]
		public void SetObstaclesActive(bool active)
		{
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x8137B0", Offset = "0x8121B0", VA = "0x1808137B0")]
		public VehicleSeat GetFirstFreeSeat()
		{
			return null;
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B05")]
		[Address(RVA = "0x819730", Offset = "0x818130", VA = "0x180819730")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B06")]
		[Address(RVA = "0x8195C0", Offset = "0x817FC0", VA = "0x1808195C0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B07")]
		[Address(RVA = "0x813DA0", Offset = "0x8127A0", VA = "0x180813DA0")]
		private void Hovered()
		{
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B08")]
		[Address(RVA = "0x813F20", Offset = "0x812920", VA = "0x180813F20")]
		private void Interacted()
		{
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B09")]
		[Address(RVA = "0x811720", Offset = "0x810120", VA = "0x180811720")]
		private void EnterVehicle()
		{
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0A")]
		[Address(RVA = "0x8120A0", Offset = "0x810AA0", VA = "0x1808120A0")]
		public void ExitVehicle()
		{
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x811710", Offset = "0x810110", VA = "0x180811710")]
		private void EndJustExited()
		{
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B0C")]
		[Address(RVA = "0x813750", Offset = "0x812150", VA = "0x180813750")]
		public Transform GetExitPoint(int seatIndex = 0)
		{
			return null;
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B0D")]
		[Address(RVA = "0x8133C0", Offset = "0x811DC0", VA = "0x1808133C0")]
		private Transform GetClosestExitPoint(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B0E")]
		[Address(RVA = "0x8138F0", Offset = "0x8122F0", VA = "0x1808138F0")]
		private Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			return null;
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x8101C0", Offset = "0x80EBC0", VA = "0x1808101C0")]
		public void AddNPCOccupant(NPC npc)
		{
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B10")]
		[Address(RVA = "0x8160B0", Offset = "0x814AB0", VA = "0x1808160B0")]
		public void RemoveNPCOccupant(NPC npc)
		{
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x0000FE88 File Offset: 0x0000E088
		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x811460", Offset = "0x80FE60", VA = "0x180811460", Slot = "60")]
		public virtual bool CanBeRecovered()
		{
			return default(bool);
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x815D00", Offset = "0x814700", VA = "0x180815D00", Slot = "61")]
		public virtual void RecoverVehicle()
		{
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x818D90", Offset = "0x817790", VA = "0x180818D90")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendOwnedColor(EVehicleColor col)
		{
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x819340", Offset = "0x817D40", VA = "0x180819340", Slot = "62")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x8105F0", Offset = "0x80EFF0", VA = "0x1808105F0", Slot = "63")]
		public virtual void ApplyColor(EVehicleColor col)
		{
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x8108A0", Offset = "0x80F2A0", VA = "0x1808108A0")]
		public void ApplyOwnedColor()
		{
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x819C20", Offset = "0x818620", VA = "0x180819C20")]
		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B18")]
		[Address(RVA = "0x813D20", Offset = "0x812720", VA = "0x180813D20")]
		public void HideOutline()
		{
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x8155B0", Offset = "0x813FB0", VA = "0x1808155B0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x815820", Offset = "0x814220", VA = "0x180815820")]
		public void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x811C90", Offset = "0x810690", VA = "0x180811C90")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1C")]
		[Address(RVA = "0x811EF0", Offset = "0x8108F0", VA = "0x180811EF0")]
		public void ExitPark(bool moveToExitPoint = true)
		{
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1D")]
		[Address(RVA = "0x819B80", Offset = "0x818580", VA = "0x180819B80")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B1E")]
		[Address(RVA = "0x813670", Offset = "0x812070", VA = "0x180813670")]
		public List<ItemInstance> GetContents()
		{
			return null;
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x813B10", Offset = "0x812510", VA = "0x180813B10", Slot = "64")]
		public virtual VehicleData GetVehicleData()
		{
			return null;
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B20")]
		[Address(RVA = "0x8138B0", Offset = "0x8122B0", VA = "0x1808138B0", Slot = "33")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B21")]
		[Address(RVA = "0x8135A0", Offset = "0x811FA0", VA = "0x1808135A0")]
		private ItemSet GetContentsSet()
		{
			return null;
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B22")]
		[Address(RVA = "0x814090", Offset = "0x812A90", VA = "0x180814090", Slot = "65")]
		public virtual void Load(VehicleData data, string containerPath)
		{
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B23")]
		[Address(RVA = "0x81B480", Offset = "0x819E80", VA = "0x18081B480")]
		public LandVehicle()
		{
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x814420", Offset = "0x812E20", VA = "0x180814420", Slot = "66")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x814390", Offset = "0x812D90", VA = "0x180814390", Slot = "67")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B27")]
		[Address(RVA = "0x80E9E0", Offset = "0x80D3E0", VA = "0x18080E9E0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x817830", Offset = "0x816230", VA = "0x180817830")]
		private void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B29")]
		[Address(RVA = "0x816590", Offset = "0x814F90", VA = "0x180816590")]
		public void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2A")]
		[Address(RVA = "0x816D00", Offset = "0x815700", VA = "0x180816D00")]
		private void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2B")]
		[Address(RVA = "0x818960", Offset = "0x817360", VA = "0x180818960")]
		private void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2C")]
		[Address(RVA = "0x817430", Offset = "0x815E30", VA = "0x180817430")]
		private void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2D")]
		[Address(RVA = "0x818020", Offset = "0x816A20", VA = "0x180818020")]
		private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2E")]
		[Address(RVA = "0x816770", Offset = "0x815170", VA = "0x180816770", Slot = "68")]
		protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2F")]
		[Address(RVA = "0x817090", Offset = "0x815A90", VA = "0x180817090")]
		private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B30")]
		[Address(RVA = "0x815150", Offset = "0x813B50", VA = "0x180815150")]
		private void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x816310", Offset = "0x814D10", VA = "0x180816310", Slot = "69")]
		protected virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B32")]
		[Address(RVA = "0x816C70", Offset = "0x815670", VA = "0x180816C70")]
		private void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B33")]
		[Address(RVA = "0x818400", Offset = "0x816E00", VA = "0x180818400")]
		private void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B34")]
		[Address(RVA = "0x816BB0", Offset = "0x8155B0", VA = "0x180816BB0")]
		public void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B35")]
		[Address(RVA = "0x817260", Offset = "0x815C60", VA = "0x180817260")]
		private void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B36")]
		[Address(RVA = "0x817C30", Offset = "0x816630", VA = "0x180817C30")]
		private void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x816AD0", Offset = "0x8154D0", VA = "0x180816AD0")]
		public void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x816E80", Offset = "0x815880", VA = "0x180816E80")]
		private void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x8182C0", Offset = "0x816CC0", VA = "0x1808182C0")]
		private void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x816A40", Offset = "0x815440", VA = "0x180816A40")]
		private void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x8171A0", Offset = "0x815BA0", VA = "0x1808171A0")]
		private void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x817AB0", Offset = "0x8164B0", VA = "0x180817AB0")]
		private void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x8167B0", Offset = "0x8151B0", VA = "0x1808167B0")]
		private void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x816DF0", Offset = "0x8157F0", VA = "0x180816DF0")]
		private void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x818C20", Offset = "0x817620", VA = "0x180818C20")]
		private void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x817520", Offset = "0x815F20", VA = "0x180817520")]
		private void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B41")]
		[Address(RVA = "0x818150", Offset = "0x816B50", VA = "0x180818150")]
		private void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x816A20", Offset = "0x815420", VA = "0x180816A20")]
		private void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x817100", Offset = "0x815B00", VA = "0x180817100")]
		private void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x817EF0", Offset = "0x8168F0", VA = "0x180817EF0")]
		private void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x816570", Offset = "0x814F70", VA = "0x180816570")]
		public void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x817010", Offset = "0x815A10", VA = "0x180817010")]
		private void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x818AC0", Offset = "0x8174C0", VA = "0x180818AC0")]
		private void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x816730", Offset = "0x815130", VA = "0x180816730", Slot = "70")]
		protected virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B49")]
		[Address(RVA = "0x8174B0", Offset = "0x815EB0", VA = "0x1808174B0")]
		private void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x817970", Offset = "0x816370", VA = "0x180817970")]
		private void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4B")]
		[Address(RVA = "0x816D80", Offset = "0x815780", VA = "0x180816D80")]
		private void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4C")]
		[Address(RVA = "0x8176F0", Offset = "0x8160F0", VA = "0x1808176F0")]
		private void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x816550", Offset = "0x814F50", VA = "0x180816550")]
		private void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x816CA0", Offset = "0x8156A0", VA = "0x180816CA0")]
		private void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x818800", Offset = "0x817200", VA = "0x180818800")]
		private void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x8173D0", Offset = "0x815DD0", VA = "0x1808173D0")]
		private void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x8175B0", Offset = "0x815FB0", VA = "0x1808175B0")]
		private void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x816300", Offset = "0x814D00", VA = "0x180816300")]
		public void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x816BF0", Offset = "0x8155F0", VA = "0x180816BF0")]
		private void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B54")]
		[Address(RVA = "0x8186A0", Offset = "0x8170A0", VA = "0x1808186A0")]
		private void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x817360", Offset = "0x815D60", VA = "0x180817360")]
		private void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086C")]
		public float SyncAccessor_currentSteerAngle
		{
			[Token(Token = "0x6003B56")]
			[Address(RVA = "0x81C650", Offset = "0x81B050", VA = "0x18081C650")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003B57")]
			[Address(RVA = "0x81C7E0", Offset = "0x81B1E0", VA = "0x18081C7E0")]
			set
			{
			}
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x815AE0", Offset = "0x8144E0", VA = "0x180815AE0", Slot = "71")]
		public virtual bool ReadSyncVar___ScheduleOne.Vehicles.LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		// (set) Token: 0x06003B5A RID: 15194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086D")]
		public bool SyncAccessor_<brakesApplied>k__BackingField
		{
			[Token(Token = "0x6003B59")]
			[Address(RVA = "0x81C2A0", Offset = "0x81ACA0", VA = "0x18081C2A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B5A")]
			[Address(RVA = "0x81C660", Offset = "0x81B060", VA = "0x18081C660")]
			set
			{
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06003B5B RID: 15195 RVA: 0x0000FF00 File Offset: 0x0000E100
		// (set) Token: 0x06003B5C RID: 15196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086E")]
		public bool SyncAccessor_<isReversing>k__BackingField
		{
			[Token(Token = "0x6003B5B")]
			[Address(RVA = "0x81C390", Offset = "0x81AD90", VA = "0x18081C390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B5C")]
			[Address(RVA = "0x81C720", Offset = "0x81B120", VA = "0x18081C720")]
			set
			{
			}
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x8110A0", Offset = "0x80FAA0", VA = "0x1808110A0", Slot = "72")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.LandVehicle_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040028E8 RID: 10472
		[Token(Token = "0x40028E8")]
		public const float KINEMATIC_THRESHOLD_DISTANCE = 30f;

		// Token: 0x040028E9 RID: 10473
		[Token(Token = "0x40028E9")]
		public const float MAX_TURNOVER_SPEED = 5f;

		// Token: 0x040028EA RID: 10474
		[Token(Token = "0x40028EA")]
		public const float TURNOVER_FORCE = 8f;

		// Token: 0x040028EB RID: 10475
		[Token(Token = "0x40028EB")]
		public const bool USE_WHEEL = false;

		// Token: 0x040028EC RID: 10476
		[Token(Token = "0x40028EC")]
		public const float SPEED_DISPLAY_MULTIPLIER = 1.4f;

		// Token: 0x040028ED RID: 10477
		[Token(Token = "0x40028ED")]
		[FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x040028EE RID: 10478
		[Token(Token = "0x40028EE")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		[SerializeField]
		protected string vehicleName;

		// Token: 0x040028EF RID: 10479
		[Token(Token = "0x40028EF")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected string vehicleCode;

		// Token: 0x040028F0 RID: 10480
		[Token(Token = "0x40028F0")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected float vehiclePrice;

		// Token: 0x040028F3 RID: 10483
		[Token(Token = "0x40028F3")]
		[FieldOffset(Offset = "0x136")]
		public bool UseHumanoidCollider;

		// Token: 0x040028F5 RID: 10485
		[Token(Token = "0x40028F5")]
		[FieldOffset(Offset = "0x148")]
		public bool SpawnAsPlayerOwned;

		// Token: 0x040028F7 RID: 10487
		[Token(Token = "0x40028F7")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Header("References")]
		protected GameObject vehicleModel;

		// Token: 0x040028F8 RID: 10488
		[Token(Token = "0x40028F8")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		protected WheelCollider[] driveWheels;

		// Token: 0x040028F9 RID: 10489
		[Token(Token = "0x40028F9")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		protected WheelCollider[] steerWheels;

		// Token: 0x040028FA RID: 10490
		[Token(Token = "0x40028FA")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		protected WheelCollider[] handbrakeWheels;

		// Token: 0x040028FB RID: 10491
		[Token(Token = "0x40028FB")]
		[FieldOffset(Offset = "0x170")]
		[HideInInspector]
		public List<Wheel> wheels;

		// Token: 0x040028FC RID: 10492
		[Token(Token = "0x40028FC")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x040028FD RID: 10493
		[Token(Token = "0x40028FD")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		protected List<Transform> exitPoints;

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		protected Rigidbody rb;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0x190")]
		public VehicleSeat[] Seats;

		// Token: 0x04002900 RID: 10496
		[Token(Token = "0x4002900")]
		[FieldOffset(Offset = "0x198")]
		public BoxCollider boundingBox;

		// Token: 0x04002901 RID: 10497
		[Token(Token = "0x4002901")]
		[FieldOffset(Offset = "0x1A0")]
		public VehicleAgent Agent;

		// Token: 0x04002902 RID: 10498
		[Token(Token = "0x4002902")]
		[FieldOffset(Offset = "0x1A8")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04002903 RID: 10499
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0x1B0")]
		public StorageDoorAnimation Trunk;

		// Token: 0x04002904 RID: 10500
		[Token(Token = "0x4002904")]
		[FieldOffset(Offset = "0x1B8")]
		public NavMeshObstacle NavMeshObstacle;

		// Token: 0x04002905 RID: 10501
		[Token(Token = "0x4002905")]
		[FieldOffset(Offset = "0x1C0")]
		public NavmeshCut NavmeshCut;

		// Token: 0x04002906 RID: 10502
		[Token(Token = "0x4002906")]
		[FieldOffset(Offset = "0x1C8")]
		public VehicleHumanoidCollider HumanoidColliderContainer;

		// Token: 0x04002907 RID: 10503
		[Token(Token = "0x4002907")]
		[FieldOffset(Offset = "0x1D0")]
		public POI POI;

		// Token: 0x04002908 RID: 10504
		[Token(Token = "0x4002908")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		protected Transform centerOfMass;

		// Token: 0x04002909 RID: 10505
		[Token(Token = "0x4002909")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		protected Transform cameraOrigin;

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		protected VehicleLights lights;

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x1F0")]
		[Header("Steer settings")]
		[SerializeField]
		protected float maxSteeringAngle;

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x1F4")]
		[SerializeField]
		protected float steerRate;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		protected bool flipSteer;

		// Token: 0x04002910 RID: 10512
		[Token(Token = "0x4002910")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Header("Drive settings")]
		protected AnimationCurve motorTorque;

		// Token: 0x04002911 RID: 10513
		[Token(Token = "0x4002911")]
		[FieldOffset(Offset = "0x208")]
		public float TopSpeed;

		// Token: 0x04002912 RID: 10514
		[Token(Token = "0x4002912")]
		[FieldOffset(Offset = "0x20C")]
		[SerializeField]
		[Range(2f, 16f)]
		protected float diffGearing;

		// Token: 0x04002913 RID: 10515
		[Token(Token = "0x4002913")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		protected float handBrakeForce;

		// Token: 0x04002914 RID: 10516
		[Token(Token = "0x4002914")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		protected AnimationCurve brakeForce;

		// Token: 0x04002915 RID: 10517
		[Token(Token = "0x4002915")]
		[FieldOffset(Offset = "0x220")]
		[Range(0.1f, 3f)]
		[SerializeField]
		protected float BrakeForceMultiplier;

		// Token: 0x04002916 RID: 10518
		[Token(Token = "0x4002916")]
		[FieldOffset(Offset = "0x224")]
		[Range(0.5f, 10f)]
		[SerializeField]
		protected float downforce;

		// Token: 0x04002917 RID: 10519
		[Token(Token = "0x4002917")]
		[FieldOffset(Offset = "0x228")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float reverseMultiplier;

		// Token: 0x04002918 RID: 10520
		[Token(Token = "0x4002918")]
		[FieldOffset(Offset = "0x230")]
		[Header("Color Settings")]
		[SerializeField]
		protected LandVehicle.BodyMesh[] BodyMeshes;

		// Token: 0x04002919 RID: 10521
		[Token(Token = "0x4002919")]
		[FieldOffset(Offset = "0x238")]
		public EVehicleColor DefaultColor;

		// Token: 0x0400291B RID: 10523
		[Token(Token = "0x400291B")]
		[FieldOffset(Offset = "0x240")]
		private EVehicleColor DisplayedColor;

		// Token: 0x0400291C RID: 10524
		[Token(Token = "0x400291C")]
		[FieldOffset(Offset = "0x248")]
		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> outlineRenderers;

		// Token: 0x0400291D RID: 10525
		[Token(Token = "0x400291D")]
		[FieldOffset(Offset = "0x250")]
		protected Outlinable outlineEffect;

		// Token: 0x0400291E RID: 10526
		[Token(Token = "0x400291E")]
		[FieldOffset(Offset = "0x258")]
		[Header("Control overrides")]
		public bool overrideControls;

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0x25C")]
		public float throttleOverride;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0x260")]
		public float steerOverride;

		// Token: 0x04002921 RID: 10529
		[Token(Token = "0x4002921")]
		[FieldOffset(Offset = "0x268")]
		[Header("Storage settings")]
		public StorageEntity Storage;

		// Token: 0x04002922 RID: 10530
		[Token(Token = "0x4002922")]
		[FieldOffset(Offset = "0x270")]
		private VehicleSeat localPlayerSeat;

		// Token: 0x04002928 RID: 10536
		[Token(Token = "0x4002928")]
		[FieldOffset(Offset = "0x290")]
		private CircularQueue<float> previousSpeeds;

		// Token: 0x04002929 RID: 10537
		[Token(Token = "0x4002929")]
		private const int previousSpeedsSampleSize = 20;

		// Token: 0x0400292B RID: 10539
		[Token(Token = "0x400292B")]
		[FieldOffset(Offset = "0x29C")]
		[SyncVar(/*Failed to decode CustomAttribute blob!*/)]
		public float currentSteerAngle;

		// Token: 0x0400292C RID: 10540
		[Token(Token = "0x400292C")]
		[FieldOffset(Offset = "0x2A0")]
		private float lastFrameSteerAngle;

		// Token: 0x0400292D RID: 10541
		[Token(Token = "0x400292D")]
		[FieldOffset(Offset = "0x2A4")]
		private float lastReplicatedSteerAngle;

		// Token: 0x0400292E RID: 10542
		[Token(Token = "0x400292E")]
		[FieldOffset(Offset = "0x2A8")]
		private bool justExitedVehicle;

		// Token: 0x04002933 RID: 10547
		[Token(Token = "0x4002933")]
		[FieldOffset(Offset = "0x2B0")]
		private Vector3 lastFramePosition;

		// Token: 0x04002934 RID: 10548
		[Token(Token = "0x4002934")]
		[FieldOffset(Offset = "0x2C0")]
		private Transform closestExitPoint;

		// Token: 0x04002935 RID: 10549
		[Token(Token = "0x4002935")]
		[FieldOffset(Offset = "0x2C8")]
		[HideInInspector]
		public ParkData CurrentParkData;

		// Token: 0x04002938 RID: 10552
		[Token(Token = "0x4002938")]
		[FieldOffset(Offset = "0x2E0")]
		private VehicleLoader loader;

		// Token: 0x0400293C RID: 10556
		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0x300")]
		public LandVehicle.VehiclePlayerEvent onPlayerEnterVehicle;

		// Token: 0x0400293D RID: 10557
		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x308")]
		public LandVehicle.VehiclePlayerEvent onPlayerExitVehicle;

		// Token: 0x0400293E RID: 10558
		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x310")]
		public UnityEvent onVehicleStart;

		// Token: 0x0400293F RID: 10559
		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x318")]
		public UnityEvent onVehicleStop;

		// Token: 0x04002940 RID: 10560
		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x320")]
		public UnityEvent onHandbrakeApplied;

		// Token: 0x04002941 RID: 10561
		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x328")]
		public UnityEvent<Collision> onCollision;

		// Token: 0x04002942 RID: 10562
		[Token(Token = "0x4002942")]
		[FieldOffset(Offset = "0x330")]
		public SyncVar<float> syncVar___currentSteerAngle;

		// Token: 0x04002943 RID: 10563
		[Token(Token = "0x4002943")]
		[FieldOffset(Offset = "0x338")]
		public SyncVar<bool> syncVar___<brakesApplied>k__BackingField;

		// Token: 0x04002944 RID: 10564
		[Token(Token = "0x4002944")]
		[FieldOffset(Offset = "0x340")]
		public SyncVar<bool> syncVar___<isReversing>k__BackingField;

		// Token: 0x04002945 RID: 10565
		[Token(Token = "0x4002945")]
		[FieldOffset(Offset = "0x348")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted;

		// Token: 0x04002946 RID: 10566
		[Token(Token = "0x4002946")]
		[FieldOffset(Offset = "0x349")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted;

		// Token: 0x02000863 RID: 2147
		[Token(Token = "0x2000863")]
		[Serializable]
		public class BodyMesh
		{
			// Token: 0x06003B5E RID: 15198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B5E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public BodyMesh()
			{
			}

			// Token: 0x04002947 RID: 10567
			[Token(Token = "0x4002947")]
			[FieldOffset(Offset = "0x10")]
			public MeshRenderer Renderer;

			// Token: 0x04002948 RID: 10568
			[Token(Token = "0x4002948")]
			[FieldOffset(Offset = "0x18")]
			public int MaterialIndex;
		}

		// Token: 0x02000864 RID: 2148
		// (Invoke) Token: 0x06003B60 RID: 15200
		[Token(Token = "0x2000864")]
		public delegate void VehiclePlayerEvent(Player player);
	}
}
