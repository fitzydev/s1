using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C1 RID: 2497
	[Token(Token = "0x20009C1")]
	public class Equippable_Seed : Equippable_Viewmodel
	{
		// Token: 0x0600443F RID: 17471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443F")]
		[Address(RVA = "0x893640", Offset = "0x892040", VA = "0x180893640", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004440")]
		[Address(RVA = "0x8935E0", Offset = "0x891FE0", VA = "0x1808935E0", Slot = "11")]
		protected virtual void StartSowSeedTask(Pot pot)
		{
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004441")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public Equippable_Seed()
		{
		}

		// Token: 0x04002FC2 RID: 12226
		[Token(Token = "0x4002FC2")]
		[FieldOffset(Offset = "0x68")]
		public SeedDefinition Seed;
	}
}
