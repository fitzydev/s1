using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs.Behaviour;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	[Serializable]
	public class PatrolInstance
	{
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D7")]
		public PatrolGroup ActiveGroup
		{
			[Token(Token = "0x6001B7E")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B7F")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x642490", Offset = "0x640E90", VA = "0x180642490")]
		public void Evaluate()
		{
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x642940", Offset = "0x641340", VA = "0x180642940")]
		public void StartPatrol()
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x642790", Offset = "0x641190", VA = "0x180642790")]
		private void MinPass()
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x642360", Offset = "0x640D60", VA = "0x180642360")]
		public void EndPatrol()
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x642B40", Offset = "0x641540", VA = "0x180642B40")]
		public PatrolInstance()
		{
		}

		// Token: 0x04001773 RID: 6003
		[Token(Token = "0x4001773")]
		[FieldOffset(Offset = "0x10")]
		public FootPatrolRoute Route;

		// Token: 0x04001774 RID: 6004
		[Token(Token = "0x4001774")]
		[FieldOffset(Offset = "0x18")]
		public int Members;

		// Token: 0x04001775 RID: 6005
		[Token(Token = "0x4001775")]
		[FieldOffset(Offset = "0x1C")]
		public int StartTime;

		// Token: 0x04001776 RID: 6006
		[Token(Token = "0x4001776")]
		[FieldOffset(Offset = "0x20")]
		public int EndTime;

		// Token: 0x04001777 RID: 6007
		[Token(Token = "0x4001777")]
		[FieldOffset(Offset = "0x24")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001778 RID: 6008
		[Token(Token = "0x4001778")]
		[FieldOffset(Offset = "0x28")]
		public bool OnlyIfCurfewEnabled;
	}
}
