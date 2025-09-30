using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200086F RID: 2159
	[Token(Token = "0x200086F")]
	public class VehicleAudio : MonoBehaviour
	{
		// Token: 0x06003B8C RID: 15244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x820F20", Offset = "0x81F920", VA = "0x180820F20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		protected virtual void EngineStart()
		{
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "6")]
		protected virtual void EngineStop()
		{
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8F")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "7")]
		protected virtual void HeadlightsToggledOn()
		{
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "8")]
		protected virtual void HeadlightsToggledOff()
		{
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VehicleAudio()
		{
		}

		// Token: 0x0400296F RID: 10607
		[Token(Token = "0x400296F")]
		[FieldOffset(Offset = "0x20")]
		[Header("Refererences")]
		public LandVehicle Vehicle;

		// Token: 0x04002970 RID: 10608
		[Token(Token = "0x4002970")]
		[FieldOffset(Offset = "0x28")]
		public VehicleLights Lights;

		// Token: 0x04002971 RID: 10609
		[Token(Token = "0x4002971")]
		[FieldOffset(Offset = "0x30")]
		[Header("Sounds")]
		public AudioSource EngineStartSound;

		// Token: 0x04002972 RID: 10610
		[Token(Token = "0x4002972")]
		[FieldOffset(Offset = "0x38")]
		public AudioSource EngineStopSound;

		// Token: 0x04002973 RID: 10611
		[Token(Token = "0x4002973")]
		[FieldOffset(Offset = "0x40")]
		public AudioSource HeadlightsOnSound;

		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		[FieldOffset(Offset = "0x48")]
		public AudioSource HeadlightsOffSound;

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[FieldOffset(Offset = "0x50")]
		public AudioSource HornSound;
	}
}
