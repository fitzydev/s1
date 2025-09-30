using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	public class ChemistConfiguration : EntityConfiguration
	{
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x17000455")]
		public int TotalStations
		{
			[Token(Token = "0x60018AF")]
			[Address(RVA = "0x600950", Offset = "0x5FF350", VA = "0x180600950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000456")]
		public Chemist chemist
		{
			[Token(Token = "0x60018B0")]
			[Address(RVA = "0x4573D0", Offset = "0x455DD0", VA = "0x1804573D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018B1")]
			[Address(RVA = "0x5FD1C0", Offset = "0x5FBBC0", VA = "0x1805FD1C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000457")]
		public EmployeeHome assignedHome
		{
			[Token(Token = "0x60018B2")]
			[Address(RVA = "0x4573C0", Offset = "0x455DC0", VA = "0x1804573C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018B3")]
			[Address(RVA = "0x6009E0", Offset = "0x5FF3E0", VA = "0x1806009E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x600250", Offset = "0x5FEC50", VA = "0x180600250")]
		public ChemistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist)
		{
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x5FFAD0", Offset = "0x5FE4D0", VA = "0x1805FFAD0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x5FF680", Offset = "0x5FE080", VA = "0x1805FF680")]
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x5FE170", Offset = "0x5FCB70", VA = "0x1805FE170")]
		public void AssignedStationsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x600180", Offset = "0x5FEB80", VA = "0x180600180", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x5FF490", Offset = "0x5FDE90", VA = "0x1805FF490", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x5FF540", Offset = "0x5FDF40", VA = "0x1805FF540")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x38")]
		public ObjectField Home;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x40")]
		public ObjectListField Stations;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x48")]
		public List<ChemistryStation> ChemStations;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x50")]
		public List<LabOven> LabOvens;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x58")]
		public List<Cauldron> Cauldrons;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x60")]
		public List<MixingStation> MixStations;
	}
}
