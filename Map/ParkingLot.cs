using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000D03 RID: 3331
	[Token(Token = "0x2000D03")]
	public class ParkingLot : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06005E2A RID: 24106 RVA: 0x00016A28 File Offset: 0x00014C28
		// (set) Token: 0x06005E2B RID: 24107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1C")]
		public Guid GUID
		{
			[Token(Token = "0x6005E2A")]
			[Address(RVA = "0x4FCCE0", Offset = "0x4FB6E0", VA = "0x1804FCCE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6005E2B")]
			[Address(RVA = "0x51AE50", Offset = "0x519850", VA = "0x18051AE50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0xA62CD0", Offset = "0xA616D0", VA = "0x180A62CD0")]
		private void Awake()
		{
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0xA63290", Offset = "0xA61C90", VA = "0x180A63290", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0xA63180", Offset = "0xA61B80", VA = "0x180A63180")]
		public ParkingSpot GetRandomFreeSpot()
		{
			return null;
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00016A40 File Offset: 0x00014C40
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0xA630C0", Offset = "0xA61AC0", VA = "0x180A630C0")]
		public int GetRandomFreeSpotIndex()
		{
			return 0;
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0xA62F30", Offset = "0xA61930", VA = "0x180A62F30")]
		public List<ParkingSpot> GetFreeParkingSpots()
		{
			return null;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0xA632F0", Offset = "0xA61CF0", VA = "0x180A632F0")]
		public ParkingLot()
		{
		}

		// Token: 0x0400446F RID: 17519
		[Token(Token = "0x400446F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04004471 RID: 17521
		[Token(Token = "0x4004471")]
		[FieldOffset(Offset = "0x38")]
		[Header("READONLY")]
		public List<ParkingSpot> ParkingSpots;

		// Token: 0x04004472 RID: 17522
		[Token(Token = "0x4004472")]
		[FieldOffset(Offset = "0x40")]
		[Header("Entry")]
		public Transform EntryPoint;

		// Token: 0x04004473 RID: 17523
		[Token(Token = "0x4004473")]
		[FieldOffset(Offset = "0x48")]
		public Transform HiddenVehicleAccessPoint;

		// Token: 0x04004474 RID: 17524
		[Token(Token = "0x4004474")]
		[FieldOffset(Offset = "0x50")]
		[Header("Exit")]
		public bool UseExitPoint;

		// Token: 0x04004475 RID: 17525
		[Token(Token = "0x4004475")]
		[FieldOffset(Offset = "0x54")]
		public EParkingAlignment ExitAlignment;

		// Token: 0x04004476 RID: 17526
		[Token(Token = "0x4004476")]
		[FieldOffset(Offset = "0x58")]
		public Transform ExitPoint;

		// Token: 0x04004477 RID: 17527
		[Token(Token = "0x4004477")]
		[FieldOffset(Offset = "0x60")]
		public VehicleDetector ExitPointVehicleDetector;
	}
}
