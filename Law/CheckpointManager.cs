using System;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x2000524")]
	public class CheckpointManager : NetworkSingleton<CheckpointManager>
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x631B20", Offset = "0x630520", VA = "0x180631B20", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x631BE0", Offset = "0x6305E0", VA = "0x180631BE0")]
		public void SetCheckpointEnabled(CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)
		{
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x631A40", Offset = "0x630440", VA = "0x180631A40")]
		public RoadCheckpoint GetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			return null;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x631DB0", Offset = "0x6307B0", VA = "0x180631DB0")]
		public CheckpointManager()
		{
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x631AD0", Offset = "0x6304D0", VA = "0x180631AD0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x631A80", Offset = "0x630480", VA = "0x180631A80", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x6319D0", Offset = "0x6303D0", VA = "0x1806319D0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04001727 RID: 5927
		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public RoadCheckpoint WesternCheckpoint;

		// Token: 0x04001728 RID: 5928
		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x128")]
		public RoadCheckpoint DocksCheckpoint;

		// Token: 0x04001729 RID: 5929
		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x130")]
		public RoadCheckpoint NorthResidentialCheckpoint;

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x138")]
		public RoadCheckpoint WestResidentialCheckpoint;

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000525 RID: 1317
		[Token(Token = "0x2000525")]
		public enum ECheckpointLocation
		{
			// Token: 0x0400172E RID: 5934
			[Token(Token = "0x400172E")]
			Western,
			// Token: 0x0400172F RID: 5935
			[Token(Token = "0x400172F")]
			Docks,
			// Token: 0x04001730 RID: 5936
			[Token(Token = "0x4001730")]
			NorthResidential,
			// Token: 0x04001731 RID: 5937
			[Token(Token = "0x4001731")]
			WestResidential
		}
	}
}
