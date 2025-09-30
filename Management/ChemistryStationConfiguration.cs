using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	public class ChemistryStationConfiguration : EntityConfiguration
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000458")]
		public ChemistryStation Station
		{
			[Token(Token = "0x60018BC")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018BD")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000459")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x60018BE")]
			[Address(RVA = "0x486240", Offset = "0x484C40", VA = "0x180486240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018BF")]
			[Address(RVA = "0x4BEDE0", Offset = "0x4BD7E0", VA = "0x1804BEDE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x600DE0", Offset = "0x5FF7E0", VA = "0x180600DE0")]
		public ChemistryStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, ChemistryStation station)
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x600D10", Offset = "0x5FF710", VA = "0x180600D10", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x600A10", Offset = "0x5FF410", VA = "0x180600A10")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x600B50", Offset = "0x5FF550", VA = "0x180600B50")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x600D50", Offset = "0x5FF750", VA = "0x180600D50", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x6009F0", Offset = "0x5FF3F0", VA = "0x1806009F0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x600D70", Offset = "0x5FF770", VA = "0x180600D70", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x600C60", Offset = "0x5FF660", VA = "0x180600C60", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		[FieldOffset(Offset = "0x40")]
		public NPCField AssignedChemist;

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[FieldOffset(Offset = "0x48")]
		public StationRecipeField Recipe;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;
	}
}
