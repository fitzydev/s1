using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200087C RID: 2172
	[Token(Token = "0x200087C")]
	public class VehicleSeat : MonoBehaviour
	{
		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[Token(Token = "0x1700087D")]
		public bool isOccupied
		{
			[Token(Token = "0x6003BEB")]
			[Address(RVA = "0x83C790", Offset = "0x83B190", VA = "0x18083C790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BEC")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleSeat()
		{
		}

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x20")]
		public bool isDriverSeat;

		// Token: 0x040029C6 RID: 10694
		[Token(Token = "0x40029C6")]
		[FieldOffset(Offset = "0x28")]
		public Player Occupant;
	}
}
