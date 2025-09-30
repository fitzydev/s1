using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	public class SensorRollerDoors : RollerDoor
	{
		// Token: 0x06002635 RID: 9781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x6FD900", Offset = "0x6FC300", VA = "0x1806FD900", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x6E8690", Offset = "0x6E7090", VA = "0x1806E8690")]
		public SensorRollerDoors()
		{
		}

		// Token: 0x04001D73 RID: 7539
		[Token(Token = "0x4001D73")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public VehicleDetector Detector;

		// Token: 0x04001D74 RID: 7540
		[Token(Token = "0x4001D74")]
		[FieldOffset(Offset = "0x70")]
		public VehicleDetector ClipDetector;

		// Token: 0x04001D75 RID: 7541
		[Token(Token = "0x4001D75")]
		[FieldOffset(Offset = "0x78")]
		[Header("Settings")]
		public bool DetectPlayerOccupiedVehiclesOnly;
	}
}
