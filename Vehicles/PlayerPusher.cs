using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(BoxCollider))]
	public class PlayerPusher : MonoBehaviour
	{
		// Token: 0x06003B7C RID: 15228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7C")]
		[Address(RVA = "0x81EC50", Offset = "0x81D650", VA = "0x18081EC50")]
		private void Awake()
		{
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7D")]
		[Address(RVA = "0x81ED00", Offset = "0x81D700", VA = "0x18081ED00")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7E")]
		[Address(RVA = "0x81ED50", Offset = "0x81D750", VA = "0x18081ED50")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7F")]
		[Address(RVA = "0x81F190", Offset = "0x81DB90", VA = "0x18081F190")]
		public PlayerPusher()
		{
		}

		// Token: 0x04002961 RID: 10593
		[Token(Token = "0x4002961")]
		[FieldOffset(Offset = "0x20")]
		private LandVehicle veh;

		// Token: 0x04002962 RID: 10594
		[Token(Token = "0x4002962")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float MinSpeedToPush;

		// Token: 0x04002963 RID: 10595
		[Token(Token = "0x4002963")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxPushSpeed;

		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		[FieldOffset(Offset = "0x30")]
		public float MinPushForce;

		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		[FieldOffset(Offset = "0x34")]
		public float MaxPushForce;

		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		[FieldOffset(Offset = "0x38")]
		private Collider collider;
	}
}
