using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000875 RID: 2165
	[Token(Token = "0x2000875")]
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleInitializer : NetworkBehaviour
	{
		// Token: 0x06003BAD RID: 15277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x838620", Offset = "0x837020", VA = "0x180838620", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x606820", Offset = "0x605220", VA = "0x180606820")]
		public VehicleInitializer()
		{
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x838600", Offset = "0x837000", VA = "0x180838600", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x601B40", Offset = "0x600540", VA = "0x180601B40", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04002991 RID: 10641
		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0x118")]
		public ParkingLot InitialParkingLot;

		// Token: 0x04002992 RID: 10642
		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0x120")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x121")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted;
	}
}
