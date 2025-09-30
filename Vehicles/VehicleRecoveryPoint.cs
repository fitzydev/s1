using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200087B RID: 2171
	[Token(Token = "0x200087B")]
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		// Token: 0x06003BE7 RID: 15335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x83C3E0", Offset = "0x83ADE0", VA = "0x18083C3E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x83C4B0", Offset = "0x83AEB0", VA = "0x18083C4B0")]
		public static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleRecoveryPoint()
		{
		}

		// Token: 0x040029C4 RID: 10692
		[Token(Token = "0x40029C4")]
		[FieldOffset(Offset = "0x0")]
		public static List<VehicleRecoveryPoint> recoveryPoints;
	}
}
