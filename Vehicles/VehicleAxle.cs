using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000870 RID: 2160
	[Token(Token = "0x2000870")]
	public class VehicleAxle : MonoBehaviour
	{
		// Token: 0x06003B92 RID: 15250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x821110", Offset = "0x81FB10", VA = "0x180821110", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x821180", Offset = "0x81FB80", VA = "0x180821180", Slot = "5")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleAxle()
		{
		}

		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		protected Wheel wheel;

		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		[FieldOffset(Offset = "0x28")]
		private Transform model;
	}
}
