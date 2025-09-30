using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000873 RID: 2163
	[Token(Token = "0x2000873")]
	public class VehicleFX : MonoBehaviour
	{
		// Token: 0x06003BA7 RID: 15271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x8383D0", Offset = "0x836DD0", VA = "0x1808383D0", Slot = "4")]
		public virtual void OnVehicleStart()
		{
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA8")]
		[Address(RVA = "0x838430", Offset = "0x836E30", VA = "0x180838430", Slot = "5")]
		public virtual void OnVehicleStop()
		{
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleFX()
		{
		}

		// Token: 0x0400298F RID: 10639
		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0x20")]
		public ParticleSystem[] exhaustFX;
	}
}
