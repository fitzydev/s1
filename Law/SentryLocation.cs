using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x02000541 RID: 1345
	[Token(Token = "0x2000541")]
	public class SentryLocation : MonoBehaviour
	{
		// Token: 0x06001B8B RID: 7051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x64DB30", Offset = "0x64C530", VA = "0x18064DB30")]
		public SentryLocation()
		{
		}

		// Token: 0x0400178F RID: 6031
		[Token(Token = "0x400178F")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public List<Transform> StandPoints;

		// Token: 0x04001790 RID: 6032
		[Token(Token = "0x4001790")]
		[FieldOffset(Offset = "0x28")]
		[Header("Info")]
		public List<PoliceOfficer> AssignedOfficers;
	}
}
