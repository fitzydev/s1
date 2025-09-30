using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000D05 RID: 3333
	[Token(Token = "0x2000D05")]
	public class ParkingSpot : MonoBehaviour
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06005E35 RID: 24117 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005E36 RID: 24118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1D")]
		public LandVehicle OccupantVehicle
		{
			[Token(Token = "0x6005E35")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E36")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0xA633A0", Offset = "0xA61DA0", VA = "0x180A633A0")]
		private void Awake()
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0xA635A0", Offset = "0xA61FA0", VA = "0x180A635A0")]
		private void Init()
		{
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0xA63720", Offset = "0xA62120", VA = "0x180A63720")]
		public void SetOccupant(LandVehicle vehicle)
		{
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ParkingSpot()
		{
		}

		// Token: 0x0400447A RID: 17530
		[Token(Token = "0x400447A")]
		[FieldOffset(Offset = "0x20")]
		private ParkingLot ParentLot;

		// Token: 0x0400447B RID: 17531
		[Token(Token = "0x400447B")]
		[FieldOffset(Offset = "0x28")]
		public Transform AlignmentPoint;

		// Token: 0x0400447C RID: 17532
		[Token(Token = "0x400447C")]
		[FieldOffset(Offset = "0x30")]
		public EParkingAlignment Alignment;

		// Token: 0x0400447D RID: 17533
		[Token(Token = "0x400447D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LandVehicle OccupantVehicle_Readonly;
	}
}
