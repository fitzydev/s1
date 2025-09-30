using System;
using Il2CppDummyDll;

namespace ScheduleOne.Law
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	[Serializable]
	public class LawActivitySettings
	{
		// Token: 0x06001B4F RID: 6991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x638AE0", Offset = "0x6374E0", VA = "0x180638AE0")]
		public void Evaluate()
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x638A70", Offset = "0x637470", VA = "0x180638A70")]
		public void End()
		{
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B51")]
		[Address(RVA = "0x638DF0", Offset = "0x6377F0", VA = "0x180638DF0")]
		public void OnLoaded()
		{
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public LawActivitySettings()
		{
		}

		// Token: 0x04001757 RID: 5975
		[Token(Token = "0x4001757")]
		[FieldOffset(Offset = "0x10")]
		public PatrolInstance[] Patrols;

		// Token: 0x04001758 RID: 5976
		[Token(Token = "0x4001758")]
		[FieldOffset(Offset = "0x18")]
		public CheckpointInstance[] Checkpoints;

		// Token: 0x04001759 RID: 5977
		[Token(Token = "0x4001759")]
		[FieldOffset(Offset = "0x20")]
		public CurfewInstance[] Curfews;

		// Token: 0x0400175A RID: 5978
		[Token(Token = "0x400175A")]
		[FieldOffset(Offset = "0x28")]
		public VehiclePatrolInstance[] VehiclePatrols;

		// Token: 0x0400175B RID: 5979
		[Token(Token = "0x400175B")]
		[FieldOffset(Offset = "0x30")]
		public SentryInstance[] Sentries;
	}
}
