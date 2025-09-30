using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	[Serializable]
	public class SentryInstance
	{
		// Token: 0x06001B86 RID: 7046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x64D650", Offset = "0x64C050", VA = "0x18064D650")]
		public void Evaluate()
		{
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x64D7F0", Offset = "0x64C1F0", VA = "0x18064D7F0")]
		public void StartEntry()
		{
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x64D750", Offset = "0x64C150", VA = "0x18064D750")]
		private void MinPass()
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x64D4B0", Offset = "0x64BEB0", VA = "0x18064D4B0")]
		public void EndSentry()
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x64DA90", Offset = "0x64C490", VA = "0x18064DA90")]
		public SentryInstance()
		{
		}

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[FieldOffset(Offset = "0x10")]
		public SentryLocation Location;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[FieldOffset(Offset = "0x18")]
		public int Members;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x1C")]
		[Header("Timing")]
		public int StartTime;

		// Token: 0x0400178B RID: 6027
		[Token(Token = "0x400178B")]
		[FieldOffset(Offset = "0x20")]
		public int EndTime;

		// Token: 0x0400178C RID: 6028
		[Token(Token = "0x400178C")]
		[FieldOffset(Offset = "0x24")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x0400178D RID: 6029
		[Token(Token = "0x400178D")]
		[FieldOffset(Offset = "0x28")]
		public bool OnlyIfCurfewEnabled;

		// Token: 0x0400178E RID: 6030
		[Token(Token = "0x400178E")]
		[FieldOffset(Offset = "0x30")]
		private List<PoliceOfficer> officers;
	}
}
