using System;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	[Serializable]
	public class VehiclePatrolInstance
	{
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D8")]
		private PoliceStation nearestStation
		{
			[Token(Token = "0x6001B8C")]
			[Address(RVA = "0x650140", Offset = "0x64EB40", VA = "0x180650140")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x64FD00", Offset = "0x64E700", VA = "0x18064FD00")]
		public void Evaluate()
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x64FC60", Offset = "0x64E660", VA = "0x18064FC60")]
		private void CheckEnd()
		{
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x650000", Offset = "0x64EA00", VA = "0x180650000")]
		public void StartPatrol()
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x650120", Offset = "0x64EB20", VA = "0x180650120")]
		public VehiclePatrolInstance()
		{
		}

		// Token: 0x04001791 RID: 6033
		[Token(Token = "0x4001791")]
		[FieldOffset(Offset = "0x10")]
		public VehiclePatrolRoute Route;

		// Token: 0x04001792 RID: 6034
		[Token(Token = "0x4001792")]
		[FieldOffset(Offset = "0x18")]
		public int StartTime;

		// Token: 0x04001793 RID: 6035
		[Token(Token = "0x4001793")]
		[FieldOffset(Offset = "0x1C")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001794 RID: 6036
		[Token(Token = "0x4001794")]
		[FieldOffset(Offset = "0x20")]
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001795 RID: 6037
		[Token(Token = "0x4001795")]
		[FieldOffset(Offset = "0x28")]
		private PoliceOfficer activeOfficer;

		// Token: 0x04001796 RID: 6038
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0x30")]
		private int latestStartTime;

		// Token: 0x04001797 RID: 6039
		[Token(Token = "0x4001797")]
		[FieldOffset(Offset = "0x34")]
		private bool startedThisCycle;
	}
}
