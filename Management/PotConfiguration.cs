using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	public class PotConfiguration : EntityConfiguration
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046B")]
		public Pot Pot
		{
			[Token(Token = "0x6001931")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001932")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046C")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001933")]
			[Address(RVA = "0x4573C0", Offset = "0x455DC0", VA = "0x1804573C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001934")]
			[Address(RVA = "0x6009E0", Offset = "0x5FF3E0", VA = "0x1806009E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x60FFD0", Offset = "0x60E9D0", VA = "0x18060FFD0")]
		public PotConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Pot pot)
		{
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x60FC70", Offset = "0x60E670", VA = "0x18060FC70", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x60F8F0", Offset = "0x60E2F0", VA = "0x18060F8F0")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x60FA30", Offset = "0x60E430", VA = "0x18060FA30")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x60FE10", Offset = "0x60E810", VA = "0x18060FE10", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x60F8D0", Offset = "0x60E2D0", VA = "0x18060F8D0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x60FE30", Offset = "0x60E830", VA = "0x18060FE30", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x60FB40", Offset = "0x60E540", VA = "0x18060FB40", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x40")]
		public ItemField Seed;

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x48")]
		public ItemField Additive1;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x50")]
		public ItemField Additive2;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x58")]
		public ItemField Additive3;

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x60")]
		public NPCField AssignedBotanist;

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x68")]
		public ObjectField Destination;
	}
}
