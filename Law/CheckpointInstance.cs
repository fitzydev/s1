using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	[Serializable]
	public class CheckpointInstance
	{
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B5")]
		public RoadCheckpoint activeCheckpoint
		{
			[Token(Token = "0x6001AEB")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AEC")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x631700", Offset = "0x630100", VA = "0x180631700")]
		public void Evaluate()
		{
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x631470", Offset = "0x62FE70", VA = "0x180631470")]
		public void EnableCheckpoint()
		{
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x631280", Offset = "0x62FC80", VA = "0x180631280")]
		private bool DistanceRequirementsMet()
		{
			return default(bool);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x6318F0", Offset = "0x6302F0", VA = "0x1806318F0")]
		private void MinPass()
		{
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x631060", Offset = "0x62FA60", VA = "0x180631060")]
		public void DisableCheckpoint()
		{
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x6319A0", Offset = "0x6303A0", VA = "0x1806319A0")]
		public CheckpointInstance()
		{
		}

		// Token: 0x0400171E RID: 5918
		[Token(Token = "0x400171E")]
		public const float MIN_ACTIVATION_DISTANCE = 50f;

		// Token: 0x0400171F RID: 5919
		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x10")]
		public CheckpointManager.ECheckpointLocation Location;

		// Token: 0x04001720 RID: 5920
		[Token(Token = "0x4001720")]
		[FieldOffset(Offset = "0x14")]
		public int Members;

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x18")]
		public int StartTime;

		// Token: 0x04001722 RID: 5922
		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x1C")]
		public int EndTime;

		// Token: 0x04001723 RID: 5923
		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001724 RID: 5924
		[Token(Token = "0x4001724")]
		[FieldOffset(Offset = "0x24")]
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001725 RID: 5925
		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x28")]
		private RoadCheckpoint checkPoint;
	}
}
