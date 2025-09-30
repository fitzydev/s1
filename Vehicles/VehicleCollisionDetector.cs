using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000872 RID: 2162
	[Token(Token = "0x2000872")]
	public class VehicleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06003BA5 RID: 15269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x8380E0", Offset = "0x836AE0", VA = "0x1808380E0")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleCollisionDetector()
		{
		}

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<Collision> onCollisionEnter;
	}
}
