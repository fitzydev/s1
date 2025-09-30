using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200085F RID: 2143
	[Token(Token = "0x200085F")]
	public class ForkliftCamera : VehicleCamera
	{
		// Token: 0x06003A9C RID: 15004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x80E170", Offset = "0x80CB70", VA = "0x18080E170", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9D")]
		[Address(RVA = "0x80E010", Offset = "0x80CA10", VA = "0x18080E010", Slot = "6")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x80E1C0", Offset = "0x80CBC0", VA = "0x18080E1C0")]
		public ForkliftCamera()
		{
		}

		// Token: 0x040028E1 RID: 10465
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x80")]
		[Header("Forklift References")]
		[SerializeField]
		protected Transform forkCamPos;

		// Token: 0x040028E2 RID: 10466
		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected Light guidanceLight;

		// Token: 0x040028E3 RID: 10467
		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0x90")]
		protected bool forkliftCamActive;
	}
}
