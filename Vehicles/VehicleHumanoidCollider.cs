using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000874 RID: 2164
	[Token(Token = "0x2000874")]
	public class VehicleHumanoidCollider : MonoBehaviour
	{
		// Token: 0x06003BAA RID: 15274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x838530", Offset = "0x836F30", VA = "0x180838530")]
		private void Start()
		{
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x838490", Offset = "0x836E90", VA = "0x180838490")]
		private void OnCollisionStay(Collision collision)
		{
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleHumanoidCollider()
		{
		}

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x20")]
		public LandVehicle vehicle;
	}
}
