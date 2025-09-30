using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	public class PackagerConfiguration : EntityConfiguration
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x17000466")]
		public int AssignedStationCount
		{
			[Token(Token = "0x6001915")]
			[Address(RVA = "0x60E920", Offset = "0x60D320", VA = "0x18060E920")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000467")]
		public Packager packager
		{
			[Token(Token = "0x6001916")]
			[Address(RVA = "0x4E9B20", Offset = "0x4E8520", VA = "0x1804E9B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001917")]
			[Address(RVA = "0x5FD1D0", Offset = "0x5FBBD0", VA = "0x1805FD1D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000468")]
		public EmployeeHome assignedHome
		{
			[Token(Token = "0x6001918")]
			[Address(RVA = "0x4573D0", Offset = "0x455DD0", VA = "0x1804573D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001919")]
			[Address(RVA = "0x5FD1C0", Offset = "0x5FBBC0", VA = "0x1805FD1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x60E2D0", Offset = "0x60CCD0", VA = "0x18060E2D0")]
		public PackagerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Packager _botanist)
		{
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x60DEC0", Offset = "0x60C8C0", VA = "0x18060DEC0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x60DBF0", Offset = "0x60C5F0", VA = "0x18060DBF0")]
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x60D100", Offset = "0x60BB00", VA = "0x18060D100")]
		public void AssignedStationsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x60E230", Offset = "0x60CC30", VA = "0x18060E230", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x60D9D0", Offset = "0x60C3D0", VA = "0x18060D9D0", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x60DAB0", Offset = "0x60C4B0", VA = "0x18060DAB0")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x0400161B RID: 5659
		[Token(Token = "0x400161B")]
		[FieldOffset(Offset = "0x38")]
		public ObjectField Home;

		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x40")]
		public ObjectListField Stations;

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x48")]
		public RouteListField Routes;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x50")]
		public List<PackagingStation> AssignedStations;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x58")]
		public List<BrickPress> AssignedBrickPresses;
	}
}
