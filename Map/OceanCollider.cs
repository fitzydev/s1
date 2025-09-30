using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000D00 RID: 3328
	[Token(Token = "0x2000D00")]
	public class OceanCollider : MonoBehaviour
	{
		// Token: 0x06005E1A RID: 24090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0xA617E0", Offset = "0xA601E0", VA = "0x180A617E0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0xA61CC0", Offset = "0xA606C0", VA = "0x180A61CC0")]
		private IEnumerator WarpPlayer()
		{
			return null;
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0xA61D30", Offset = "0xA60730", VA = "0x180A61D30")]
		private IEnumerator WarpVehicle(LandVehicle veh)
		{
			return null;
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0xA61DC0", Offset = "0xA607C0", VA = "0x180A61DC0")]
		public OceanCollider()
		{
		}

		// Token: 0x04004464 RID: 17508
		[Token(Token = "0x4004464")]
		[FieldOffset(Offset = "0x20")]
		private bool localPlayerBeingWarped;

		// Token: 0x04004465 RID: 17509
		[Token(Token = "0x4004465")]
		[FieldOffset(Offset = "0x28")]
		private List<LandVehicle> warpedVehicles;

		// Token: 0x04004466 RID: 17510
		[Token(Token = "0x4004466")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController SplashSound;
	}
}
