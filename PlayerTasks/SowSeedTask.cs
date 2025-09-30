using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	public class SowSeedTask : Task
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A1")]
		public override string TaskName
		{
			[Token(Token = "0x6001329")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600132A")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132B")]
		[Address(RVA = "0x5B7190", Offset = "0x5B5B90", VA = "0x1805B7190")]
		public SowSeedTask(Pot _pot, SeedDefinition def)
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132C")]
		[Address(RVA = "0x5B6D40", Offset = "0x5B5740", VA = "0x1805B6D40", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132D")]
		[Address(RVA = "0x5B6990", Offset = "0x5B5390", VA = "0x1805B6990", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132E")]
		[Address(RVA = "0x5B65F0", Offset = "0x5B4FF0", VA = "0x1805B65F0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x5B6420", Offset = "0x5B4E20", VA = "0x1805B6420")]
		private void OnSeedExitVial()
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x5B6430", Offset = "0x5B4E30", VA = "0x1805B6430")]
		private void OnSeedReachedDestination()
		{
		}

		// Token: 0x0400123F RID: 4671
		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0xA0")]
		protected Pot pot;

		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0xA8")]
		protected SeedDefinition definition;

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0xB0")]
		protected FunctionalSeed seed;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0xB8")]
		private bool seedExitedVial;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0xB9")]
		private bool seedReachedDestination;

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0xBA")]
		private bool successfullyPlanted;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0xBC")]
		private float weedSeedStationaryTime;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0xC0")]
		private bool capRemoved;
	}
}
