using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	[RequireComponent(typeof(LandVehicle))]
	public class DeliveryVehicle : MonoBehaviour
	{
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000793")]
		public LandVehicle Vehicle
		{
			[Token(Token = "0x6003414")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003415")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000794")]
		public DeliveryInstance ActiveDelivery
		{
			[Token(Token = "0x6003416")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003417")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003418")]
		[Address(RVA = "0x7A1C80", Offset = "0x7A0680", VA = "0x1807A1C80")]
		private void Awake()
		{
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003419")]
		[Address(RVA = "0x7A1A30", Offset = "0x7A0430", VA = "0x1807A1A30")]
		public void Activate(DeliveryInstance instance)
		{
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341A")]
		[Address(RVA = "0x7A1D20", Offset = "0x7A0720", VA = "0x1807A1D20")]
		public void Deactivate()
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x7A1F10", Offset = "0x7A0910", VA = "0x1807A1F10")]
		public DeliveryVehicle()
		{
		}

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[FieldOffset(Offset = "0x30")]
		public string GUID;
	}
}
