using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CEE RID: 3310
	[Token(Token = "0x2000CEE")]
	public class Dealership : MonoBehaviour
	{
		// Token: 0x06005DC2 RID: 24002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC2")]
		[Address(RVA = "0xA58620", Offset = "0xA57020", VA = "0x180A58620")]
		public void SpawnVehicle(string vehicleCode)
		{
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC3")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public Dealership()
		{
		}

		// Token: 0x04004415 RID: 17429
		[Token(Token = "0x4004415")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] SpawnPoints;
	}
}
