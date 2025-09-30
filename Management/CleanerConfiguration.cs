using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class CleanerConfiguration : EntityConfiguration
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045A")]
		public Cleaner cleaner
		{
			[Token(Token = "0x60018CB")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018CC")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045B")]
		public List<TrashContainerItem> binItems
		{
			[Token(Token = "0x60018CD")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018CE")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045C")]
		public EmployeeHome assignedHome
		{
			[Token(Token = "0x60018CF")]
			[Address(RVA = "0x486240", Offset = "0x484C40", VA = "0x180486240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018D0")]
			[Address(RVA = "0x4BEDE0", Offset = "0x4BD7E0", VA = "0x1804BEDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x6017D0", Offset = "0x6001D0", VA = "0x1806017D0")]
		public CleanerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cleaner _cleaner)
		{
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x601700", Offset = "0x600100", VA = "0x180601700", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x6015C0", Offset = "0x5FFFC0", VA = "0x1806015C0")]
		private bool IsObjValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x601190", Offset = "0x5FFB90", VA = "0x180601190")]
		public void AssignedBinsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x601730", Offset = "0x600130", VA = "0x180601730", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x6013D0", Offset = "0x5FFDD0", VA = "0x1806013D0", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x601480", Offset = "0x5FFE80", VA = "0x180601480")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x38")]
		public ObjectField Home;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x40")]
		public ObjectListField Bins;
	}
}
