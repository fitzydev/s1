using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000D0D RID: 3341
	[Token(Token = "0x2000D0D")]
	public class PoliceStation : NPCEnterableBuilding
	{
		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06005E62 RID: 24162 RVA: 0x00016AD0 File Offset: 0x00014CD0
		// (set) Token: 0x06005E63 RID: 24163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D24")]
		public float TimeSinceLastDispatch
		{
			[Token(Token = "0x6005E62")]
			[Address(RVA = "0x7BAA30", Offset = "0x7B9430", VA = "0x1807BAA30")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005E63")]
			[Address(RVA = "0x7F35A0", Offset = "0x7F1FA0", VA = "0x1807F35A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06005E64 RID: 24164 RVA: 0x00016AE8 File Offset: 0x00014CE8
		[Token(Token = "0x17000D25")]
		private int deployedVehicleCount
		{
			[Token(Token = "0x6005E64")]
			[Address(RVA = "0xA64A70", Offset = "0xA63470", VA = "0x180A64A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E65")]
		[Address(RVA = "0xA63750", Offset = "0xA62150", VA = "0x180A63750", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E66")]
		[Address(RVA = "0xA645E0", Offset = "0xA62FE0", VA = "0x180A645E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E67")]
		[Address(RVA = "0xA648D0", Offset = "0xA632D0", VA = "0x180A648D0")]
		private void Update()
		{
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E68")]
		[Address(RVA = "0xA638B0", Offset = "0xA622B0", VA = "0x180A638B0")]
		private void CleanVehicleList()
		{
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E69")]
		[Address(RVA = "0xA63D50", Offset = "0xA62750", VA = "0x180A63D50")]
		public void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E6A")]
		[Address(RVA = "0xA646B0", Offset = "0xA630B0", VA = "0x180A646B0")]
		public PoliceOfficer PullOfficer()
		{
			return null;
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E6B")]
		[Address(RVA = "0xA639B0", Offset = "0xA623B0", VA = "0x180A639B0")]
		public LandVehicle CreateVehicle()
		{
			return null;
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0xA643E0", Offset = "0xA62DE0", VA = "0x180A643E0", Slot = "8")]
		public override void NPCEnteredBuilding(NPC npc)
		{
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0xA64520", Offset = "0xA62F20", VA = "0x180A64520", Slot = "9")]
		public override void NPCExitedBuilding(NPC npc)
		{
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E6E")]
		[Address(RVA = "0xA64360", Offset = "0xA62D60", VA = "0x180A64360")]
		public static PoliceStation GetClosestPoliceStation(Vector3 point)
		{
			return null;
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0xA649A0", Offset = "0xA633A0", VA = "0x180A649A0")]
		public PoliceStation()
		{
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x00016B00 File Offset: 0x00014D00
		[Token(Token = "0x6005E71")]
		[Address(RVA = "0xA64770", Offset = "0xA63170", VA = "0x180A64770")]
		[CompilerGenerated]
		internal static bool <CreateVehicle>g__IsSpawnPointAvailable|21_0(Transform spawnPoint)
		{
			return default(bool);
		}

		// Token: 0x040044A9 RID: 17577
		[Token(Token = "0x40044A9")]
		[FieldOffset(Offset = "0x0")]
		public static List<PoliceStation> PoliceStations;

		// Token: 0x040044AA RID: 17578
		[Token(Token = "0x40044AA")]
		[FieldOffset(Offset = "0x50")]
		public int VehicleLimit;

		// Token: 0x040044AB RID: 17579
		[Token(Token = "0x40044AB")]
		[FieldOffset(Offset = "0x58")]
		[Header("References")]
		public Transform SpawnPoint;

		// Token: 0x040044AC RID: 17580
		[Token(Token = "0x40044AC")]
		[FieldOffset(Offset = "0x60")]
		public Transform[] VehicleSpawnPoints;

		// Token: 0x040044AD RID: 17581
		[Token(Token = "0x40044AD")]
		[FieldOffset(Offset = "0x68")]
		public Transform[] PossessedVehicleSpawnPoints;

		// Token: 0x040044AE RID: 17582
		[Token(Token = "0x40044AE")]
		[FieldOffset(Offset = "0x70")]
		[Header("Prefabs")]
		public LandVehicle[] PoliceVehiclePrefabs;

		// Token: 0x040044AF RID: 17583
		[Token(Token = "0x40044AF")]
		[FieldOffset(Offset = "0x78")]
		public List<PoliceOfficer> OfficerPool;

		// Token: 0x040044B1 RID: 17585
		[Token(Token = "0x40044B1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<LandVehicle> deployedVehicles;

		// Token: 0x02000D0E RID: 3342
		[Token(Token = "0x2000D0E")]
		public enum EDispatchType
		{
			// Token: 0x040044B3 RID: 17587
			[Token(Token = "0x40044B3")]
			Auto,
			// Token: 0x040044B4 RID: 17588
			[Token(Token = "0x40044B4")]
			UseVehicle,
			// Token: 0x040044B5 RID: 17589
			[Token(Token = "0x40044B5")]
			OnFoot
		}
	}
}
