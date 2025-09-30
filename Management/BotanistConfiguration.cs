using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	public class BotanistConfiguration : EntityConfiguration
	{
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044F")]
		public Botanist botanist
		{
			[Token(Token = "0x6001886")]
			[Address(RVA = "0x4E9B20", Offset = "0x4E8520", VA = "0x1804E9B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001887")]
			[Address(RVA = "0x5FD1D0", Offset = "0x5FBBD0", VA = "0x1805FD1D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000450")]
		public EmployeeHome assignedHome
		{
			[Token(Token = "0x6001888")]
			[Address(RVA = "0x4573D0", Offset = "0x455DD0", VA = "0x1804573D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001889")]
			[Address(RVA = "0x5FD1C0", Offset = "0x5FBBC0", VA = "0x1805FD1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x5FCB60", Offset = "0x5FB560", VA = "0x1805FCB60")]
		public BotanistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist)
		{
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x5FC700", Offset = "0x5FB100", VA = "0x1805FC700", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x5FC370", Offset = "0x5FAD70", VA = "0x1805FC370")]
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x5FBA30", Offset = "0x5FA430", VA = "0x1805FBA30")]
		public void AssignedPotsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x5FCA70", Offset = "0x5FB470", VA = "0x1805FCA70", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x5FC150", Offset = "0x5FAB50", VA = "0x1805FC150", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x5FC230", Offset = "0x5FAC30", VA = "0x1805FC230")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x040015E7 RID: 5607
		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0x38")]
		public ObjectField Home;

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0x40")]
		public ObjectField Supplies;

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x48")]
		public ObjectListField AssignedStations;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0x50")]
		public List<Pot> AssignedPots;

		// Token: 0x040015EB RID: 5611
		[Token(Token = "0x40015EB")]
		[FieldOffset(Offset = "0x58")]
		public List<DryingRack> AssignedRacks;
	}
}
