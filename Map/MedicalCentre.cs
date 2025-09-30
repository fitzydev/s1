using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CFA RID: 3322
	[Token(Token = "0x2000CFA")]
	public class MedicalCentre : NPCEnterableBuilding
	{
		// Token: 0x06005DFF RID: 24063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFF")]
		[Address(RVA = "0xA5F3C0", Offset = "0xA5DDC0", VA = "0x180A5F3C0")]
		public MedicalCentre()
		{
		}

		// Token: 0x04004454 RID: 17492
		[Token(Token = "0x4004454")]
		[FieldOffset(Offset = "0x50")]
		public Transform RespawnPoint;
	}
}
