using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	public class MixingStationConfiguration : EntityConfiguration
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000464")]
		public MixingStation station
		{
			[Token(Token = "0x6001906")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001907")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000465")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001908")]
			[Address(RVA = "0x486240", Offset = "0x484C40", VA = "0x180486240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001909")]
			[Address(RVA = "0x4BEDE0", Offset = "0x4BD7E0", VA = "0x1804BEDE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190A")]
		[Address(RVA = "0x60CD20", Offset = "0x60B720", VA = "0x18060CD20")]
		public MixingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, MixingStation station)
		{
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x600D10", Offset = "0x5FF710", VA = "0x180600D10", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x60C9B0", Offset = "0x60B3B0", VA = "0x18060C9B0")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x60CAF0", Offset = "0x60B4F0", VA = "0x18060CAF0")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x600D50", Offset = "0x5FF750", VA = "0x180600D50", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x6009F0", Offset = "0x5FF3F0", VA = "0x1806009F0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x60CCB0", Offset = "0x60B6B0", VA = "0x18060CCB0", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x60CC00", Offset = "0x60B600", VA = "0x18060CC00", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x40")]
		public NPCField AssignedChemist;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x48")]
		public ObjectField Destination;

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x50")]
		public NumberField StartThrehold;
	}
}
