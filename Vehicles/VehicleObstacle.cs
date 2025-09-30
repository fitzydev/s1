using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000879 RID: 2169
	[Token(Token = "0x2000879")]
	public class VehicleObstacle : MonoBehaviour
	{
		// Token: 0x06003BE6 RID: 15334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x83BAD0", Offset = "0x83A4D0", VA = "0x18083BAD0")]
		public VehicleObstacle()
		{
		}

		// Token: 0x040029BE RID: 10686
		[Token(Token = "0x40029BE")]
		[FieldOffset(Offset = "0x20")]
		public Collider col;

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public bool twoSided;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0x2C")]
		public VehicleObstacle.EObstacleType type;

		// Token: 0x0200087A RID: 2170
		[Token(Token = "0x200087A")]
		public enum EObstacleType
		{
			// Token: 0x040029C2 RID: 10690
			[Token(Token = "0x40029C2")]
			Generic,
			// Token: 0x040029C3 RID: 10691
			[Token(Token = "0x40029C3")]
			TrafficLight
		}
	}
}
