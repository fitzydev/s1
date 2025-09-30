using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200076F RID: 1903
	[Token(Token = "0x200076F")]
	[RequireComponent(typeof(Rigidbody))]
	public class VehicleDetector : MonoBehaviour
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000778")]
		public bool IgnoreNewDetections
		{
			[Token(Token = "0x6003372")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003373")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x78E0B0", Offset = "0x78CAB0", VA = "0x18078E0B0")]
		private void Awake()
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x78EA60", Offset = "0x78D460", VA = "0x18078EA60")]
		private void Start()
		{
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x78E480", Offset = "0x78CE80", VA = "0x18078E480")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x78E5F0", Offset = "0x78CFF0", VA = "0x18078E5F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x78E210", Offset = "0x78CC10", VA = "0x18078E210")]
		private void MinPass()
		{
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x78E730", Offset = "0x78D130", VA = "0x18078E730")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x78E950", Offset = "0x78D350", VA = "0x18078E950")]
		private void SortVehicles()
		{
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x78E870", Offset = "0x78D270", VA = "0x18078E870")]
		public void SetIgnoreNewCollisions(bool ignore)
		{
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x0000E310 File Offset: 0x0000C510
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x78E010", Offset = "0x78CA10", VA = "0x18078E010")]
		public bool AreAnyVehiclesOccupied()
		{
			return default(bool);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337D")]
		[Address(RVA = "0x78E1A0", Offset = "0x78CBA0", VA = "0x18078E1A0")]
		public void Clear()
		{
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337E")]
		[Address(RVA = "0x78ECF0", Offset = "0x78D6F0", VA = "0x18078ECF0")]
		public VehicleDetector()
		{
		}

		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		[FieldOffset(Offset = "0x20")]
		public List<LandVehicle> vehicles;

		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		[FieldOffset(Offset = "0x28")]
		public LandVehicle closestVehicle;

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[FieldOffset(Offset = "0x31")]
		private bool ignoreExit;

		// Token: 0x040023B6 RID: 9142
		[Token(Token = "0x40023B6")]
		[FieldOffset(Offset = "0x38")]
		private Collider[] detectionColliders;

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[FieldOffset(Offset = "0x40")]
		private bool collidersEnabled;
	}
}
