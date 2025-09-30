using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000869 RID: 2153
	[Token(Token = "0x2000869")]
	[RequireComponent(typeof(Rigidbody))]
	public class ObstructionDetector : MonoBehaviour
	{
		// Token: 0x06003B76 RID: 15222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x81DB80", Offset = "0x81C580", VA = "0x18081DB80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x81DC40", Offset = "0x81C640", VA = "0x18081DC40", Slot = "5")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x81E5C0", Offset = "0x81CFC0", VA = "0x18081E5C0")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x81EAB0", Offset = "0x81D4B0", VA = "0x18081EAB0")]
		public ObstructionDetector()
		{
		}

		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		[FieldOffset(Offset = "0x20")]
		private LandVehicle vehicle;

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x28")]
		public List<LandVehicle> vehicles;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0x30")]
		public List<NPC> npcs;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0x38")]
		public List<PlayerMovement> players;

		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		[FieldOffset(Offset = "0x40")]
		public List<VehicleObstacle> vehicleObstacles;

		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		[FieldOffset(Offset = "0x48")]
		public float closestObstructionDistance;

		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		[FieldOffset(Offset = "0x4C")]
		public float range;
	}
}
