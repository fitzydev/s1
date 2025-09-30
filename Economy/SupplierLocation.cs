using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	public class SupplierLocation : MonoBehaviour
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x17000635")]
		public bool IsOccupied
		{
			[Token(Token = "0x60025A3")]
			[Address(RVA = "0x6FEC20", Offset = "0x6FD620", VA = "0x1806FEC20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000636")]
		public Supplier ActiveSupplier
		{
			[Token(Token = "0x60025A4")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025A5")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x6FE600", Offset = "0x6FD000", VA = "0x1806FE600")]
		public void Awake()
		{
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x6FE830", Offset = "0x6FD230", VA = "0x1806FE830")]
		private void OnDestroy()
		{
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x6FE8B0", Offset = "0x6FD2B0", VA = "0x1806FE8B0")]
		public void SetActiveSupplier(Supplier supplier)
		{
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SupplierLocation()
		{
		}

		// Token: 0x04001D02 RID: 7426
		[Token(Token = "0x4001D02")]
		[FieldOffset(Offset = "0x0")]
		public static List<SupplierLocation> AllLocations;

		// Token: 0x04001D04 RID: 7428
		[Token(Token = "0x4001D04")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public string LocationName;

		// Token: 0x04001D05 RID: 7429
		[Token(Token = "0x4001D05")]
		[FieldOffset(Offset = "0x30")]
		public string LocationDescription;

		// Token: 0x04001D06 RID: 7430
		[Token(Token = "0x4001D06")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform GenericContainer;

		// Token: 0x04001D07 RID: 7431
		[Token(Token = "0x4001D07")]
		[FieldOffset(Offset = "0x40")]
		public Transform SupplierStandPoint;

		// Token: 0x04001D08 RID: 7432
		[Token(Token = "0x4001D08")]
		[FieldOffset(Offset = "0x48")]
		public WorldStorageEntity[] DeliveryBays;

		// Token: 0x04001D09 RID: 7433
		[Token(Token = "0x4001D09")]
		[FieldOffset(Offset = "0x50")]
		public POI PoI;

		// Token: 0x04001D0A RID: 7434
		[Token(Token = "0x4001D0A")]
		[FieldOffset(Offset = "0x58")]
		private SupplierLocationConfiguration[] configs;
	}
}
