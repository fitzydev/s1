using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200086C RID: 2156
	[Token(Token = "0x200086C")]
	[RequireComponent(typeof(BoxCollider))]
	public class SpeedZone : MonoBehaviour
	{
		// Token: 0x06003B80 RID: 15232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x81FCB0", Offset = "0x81E6B0", VA = "0x18081FCB0", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x81FD80", Offset = "0x81E780", VA = "0x18081FD80")]
		public static List<SpeedZone> GetSpeedZones(Vector3 point)
		{
			return null;
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x81FFF0", Offset = "0x81E9F0", VA = "0x18081FFF0")]
		public SpeedZone()
		{
		}

		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		[FieldOffset(Offset = "0x0")]
		public static List<SpeedZone> speedZones;

		// Token: 0x04002968 RID: 10600
		[Token(Token = "0x4002968")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider col;

		// Token: 0x04002969 RID: 10601
		[Token(Token = "0x4002969")]
		[FieldOffset(Offset = "0x28")]
		public float speed;
	}
}
