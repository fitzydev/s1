using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CE9 RID: 3305
	[Token(Token = "0x2000CE9")]
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		// Token: 0x06005D95 RID: 23957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D95")]
		[Address(RVA = "0xA54CF0", Offset = "0xA536F0", VA = "0x180A54CF0", Slot = "5")]
		public override void SetIsOpen(bool open)
		{
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D96")]
		[Address(RVA = "0xA54BA0", Offset = "0xA535A0", VA = "0x180A54BA0", Slot = "7")]
		protected override void MinPass()
		{
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D97")]
		[Address(RVA = "0xA54D80", Offset = "0xA53780", VA = "0x180A54D80")]
		public AutoshopAccessZone()
		{
		}

		// Token: 0x040043FD RID: 17405
		[Token(Token = "0x40043FD")]
		[FieldOffset(Offset = "0x60")]
		public Animation RollerDoorAnim;

		// Token: 0x040043FE RID: 17406
		[Token(Token = "0x40043FE")]
		[FieldOffset(Offset = "0x68")]
		public VehicleDetector VehicleDetection;

		// Token: 0x040043FF RID: 17407
		[Token(Token = "0x40043FF")]
		[FieldOffset(Offset = "0x70")]
		private bool rollerDoorOpen;
	}
}
