using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	public class DryingRackConfiguration : EntityConfiguration
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045D")]
		public DryingRack Rack
		{
			[Token(Token = "0x60018D9")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018DA")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045E")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x60018DB")]
			[Address(RVA = "0x486240", Offset = "0x484C40", VA = "0x180486240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018DC")]
			[Address(RVA = "0x4BEDE0", Offset = "0x4BD7E0", VA = "0x1804BEDE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x606BA0", Offset = "0x6055A0", VA = "0x180606BA0")]
		public DryingRackConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, DryingRack rack)
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x600D10", Offset = "0x5FF710", VA = "0x180600D10", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x606830", Offset = "0x605230", VA = "0x180606830")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x606970", Offset = "0x605370", VA = "0x180606970")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x600D50", Offset = "0x5FF750", VA = "0x180600D50", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x6009F0", Offset = "0x5FF3F0", VA = "0x1806009F0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x606B30", Offset = "0x605530", VA = "0x180606B30", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x606A80", Offset = "0x605480", VA = "0x180606A80", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x40")]
		public NPCField AssignedBotanist;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x48")]
		public QualityField TargetQuality;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;
	}
}
